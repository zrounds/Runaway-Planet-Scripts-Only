using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using WPMF;

public class GlobeKeeper : MonoBehaviour
{

    GlobeKeeper go;
    public TestGUI tg;
    public WorldMap2D map;
    private BaseUSA country1;
    private BaseChina country2;
    private BaseIndia country3;
    private BaseGermany country4;
    private BaseBrazil country5;
    private BaseRussia country6;
    private List<BaseCountry> countries;
    private int curCountry;
    public System.String worldRankLabelGK;
    private Color[] RankingColors = new Color[6] { new Color(1.0f, 0.0f, 0.0f, 1.0f), new Color(1.0f, 0.271f, 0.0f, 1.0f), new Color(1.0f, 0.647f, 0.0f, 1.0f), new Color(1.0f, 1.0f, 0.0f, 1.0f), new Color(0.61f, 0.8f, 0.2f, 1.0f), new Color(0.0f, 1.0f, 0.0f, 1.0f) };
    private int globeYear = 2016;
    private long globePopulation = 7125000000;
    private double globePPM = 405;
    private double globeTemperature = 12.4; //celsius 
    private double globeSLR = 0.0; //= seaLevelRise + 3.2 * (0.01*(co2Emissions/(2.13*Math.Pow(10,15))));

    // Use this for initialization
    void Start()
    {
        map = WorldMap2D.instance;
        country1 = new BaseUSA();
        country2 = new BaseChina();
        country3 = new BaseIndia();
        country4 = new BaseGermany();
        country5 = new BaseBrazil();
        country6 = new BaseRussia();
        countries = new List<BaseCountry>();
        countries.Add(country1); countries.Add(country2); countries.Add(country3); countries.Add(country4); countries.Add(country5); countries.Add(country6);
        curCountry = 0;
        tg = gameObject.GetComponent<TestGUI>();
        tg.SetCountry(country1);
        tg.map.outlineColor = tg.map.frontiersColor; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateGlobalVars()
    {
        long Pop = 0;
        double ppmChange = 0;



        foreach (BaseCountry c in countries)
        {
            c.IterateYear();
            Pop += (long) c.Population;
            ppmChange += (long)(c.CO2Emissions / (2.13 * System.Math.Pow(10, 15)));
        }
        GlobePopulation = Pop + 7125000000;
        globePPM += ppmChange;
        globeTemperature = globeTemperature + (0.01 * ppmChange);
        globeSLR = globeSLR + (3.2 * (0.01 * ppmChange));
        GlobeYear = GlobeYear + 1;
        //Show sea level rise on borders 
        float g = (1.0f - (float)(Math.Sqrt(globeSLR))) / 1.1f;
        if(g < 0.0f) { g = 0.0f; }
        float r = ((float)(Math.Sqrt(globeSLR))) / 1.1f;
        if (r > 1.0f) { r = 1.0f; }
        tg.map.frontiersColor = new Color(r,g,0.0f, 1.0f);
        tg.map.frontiersColorOuter = tg.map.frontiersColor;
        tg.map.outlineColor = tg.map.frontiersColor;
        //tg.map.fillColor = new Color(0.0f,0.0f,1.0f,0.7f);
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(690, 5, 80, 200));
        if (GUILayout.Button("Pass\nTurn"))
        {
            passTurn();
        }
        GUILayout.EndArea();
        double[] totalScoreArray = new double[6] { country1.TotalScore, country2.TotalScore, country3.TotalScore, country4.TotalScore, country5.TotalScore, country6.TotalScore };
        string[] countryNames = new string[6] { "United States", country2.CountryName, country3.CountryName, country4.CountryName, country5.CountryName, country6.CountryName };
        System.Array.Sort(totalScoreArray, countryNames);
        for (int k=0; k < countryNames.Length; k++)
        {
            if (countryNames[k] != "United States")
            {
                tg.map.ToggleCountrySurface(countryNames[k], true, RankingColors[k]);
            } else
            {
                tg.map.ToggleCountrySurface("United States of America", true, RankingColors[k]);
            }
        }
        worldRankLabelGK = "World Rankings:\n \n 1 " + countryNames[5] + " | " + totalScoreArray[5] + "\n2 " + countryNames[4] + " | " + totalScoreArray[4] + "\n3 " + countryNames[3] + " | " + totalScoreArray[3] + "\n4 " + countryNames[2] + " | " + totalScoreArray[2] + "\n5 " + countryNames[1] + " | " + totalScoreArray[1] + "\n 6 " + countryNames[0] + " | " + totalScoreArray[0];
        //worldRankLabelGK = "World Rankings:\n \n 1 United States | " + country1.TotalScore + "\n2 China | " +country2.TotalScore+ "\n3 Germany | " + country4.TotalScore+ "\n4 Brazil | " +  country5.TotalScore+ "\n5 India | " + country3.TotalScore+ "\n6 Russia | " + country6.TotalScore;
        gameObject.SendMessage("WorldRankLabel", worldRankLabelGK);
    }



    void passTurn()
    {
        if (curCountry < countries.Count - 1)
        {
            curCountry++;
        }
        else
        {
            UpdateGlobalVars();
            gameObject.SendMessage("GlobePopulation", GlobePopulation);
            gameObject.SendMessage("Year", GlobeYear);
            gameObject.SendMessage("PPM", GlobePPM);
            gameObject.SendMessage("SLR", GlobeSLR);
            gameObject.SendMessage("TEMP", GlobeTemperature);
            curCountry = 0;
        }

        map.FlyToLocation(0, 0);
        map.SetZoomLevel(1);
        map.FlyToCountry(countries[curCountry].CountryName);
        map.SetZoomLevel((float)0.25);
        // map.BlinkCountry(map.GetCountryIndex("United States of America"), Color.red, Color.blue, 2, 1);


        //map.FlyToCountry(countries[curCountry].CountryName);
        map.BlinkCountry(map.GetCountryIndex(countries[curCountry].CountryName), Color.red, Color.blue, 5, 1);
        tg.SetCountry(countries[curCountry]);
        tg.DecisionTokens = 2;
    }

    public long GlobePopulation
    {
        get { return globePopulation; }
        set { globePopulation = value; }
    }

    public double GlobePPM
    {
        get { return globePPM; }
        set { globePPM = value; }
    }

    public double GlobeTemperature
    {
        get { return globeTemperature; }
        set { globeTemperature = value; }
    }

    public int GlobeYear
    {
        get { return globeYear; }
        set { globeYear = value; }
    }

    public double GlobeSLR
    {
        get { return globeSLR; }
        set { globeSLR = value; }
    }
}