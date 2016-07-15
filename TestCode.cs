using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Collections.Generic;

public class TestCode : MonoBehaviour {

    [SerializeField]
    public Text year_text;

    public Text US_population_text;
    public Text US_GDP_text;
    public Text US_energy_use_per_person_text;
    public Text US_energy_demand_text;
    public Text US_energy_production_text;
    public Text US_per_coal_text;
    public Text US_per_gas_text;
    public Text US_per_nuclear_text;
    public Text US_per_wind_text;
    public Text US_per_hydro_text;
    public Text US_per_solar_text;
    public Text US_co2_emissions_text;
    public Text US_growth_rate_text;
    public Text ppm_text;
    public Text temp_text;
    public Text slr_text;

    public List<Text> Texts;

    int year = 2015;

    double US_population = 321368864.0;
    double US_growth_rate = 0.7;
    long US_GDP = 17419000000000;
    int US_energy_use_per_person = 12954;
    long US_energy_demand = 4163012264256;
    double US_energy_production = 4255499969482.00;
    int US_per_coal = 39;
    int US_per_gas = 31;
    int US_per_nuclear = 20;
    int US_per_wind = 4;
    int US_per_hydro = 6;
    int US_per_solar = 0;
    double US_co2_emissions = 4255499969482.00;
    double ppm = 400.0;
    double temp = 12.4;
    double slr = 0.0;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(430, 350, 150, 40), "Run 1 Iteration"))
        {
            year = year + 1;
            year_text.text = "Year = " + year.ToString();

            US_population = US_population * Math.Exp(US_growth_rate/100.0);
            US_population_text.text = "US population = " + Math.Round(US_population).ToString();

            // US_GDP

            // US_energy_use_per_person

            US_energy_demand = (long)US_population * US_energy_use_per_person;
            US_energy_demand_text.text = "US energy demand = " + US_energy_demand.ToString() + "kWh";

            // US_energy_production

            // US_per_coal, etc.....

            US_co2_emissions = ((US_per_coal / 100.0) * US_energy_production * 820.0) + ((US_per_gas / 100.0) * US_energy_production * 490.0) + ((US_per_nuclear / 100.0) * US_energy_production * 12.0) + ((US_per_wind / 100.0) * US_energy_production * 11.5) + ((US_per_hydro / 100.0) * US_energy_production * 24.0) + ((US_per_solar / 100.0) * US_energy_production * 48.0);
            US_co2_emissions_text.text = "US C02 emissions = " + US_co2_emissions.ToString() + " kg";
            ppm = ppm + (US_co2_emissions / (2.13 * Math.Pow(10,15)));
            ppm_text.text = "PPM CO2 = " + Math.Round(ppm).ToString();
            temp = temp + (0.01 * (US_co2_emissions / (2.13 * Math.Pow(10, 15))));
            temp_text.text = "Temperature = " + ((1.8 * temp) + 32).ToString() + " F";
            slr = slr + 3.2 * (0.01 * (US_co2_emissions / (2.13 * Math.Pow(10, 15))));
            slr_text.text = "Sea Level Rise = " + (slr/0.3048).ToString() + " ft";

            if (slr > 1 )
            {
				UnityEngine.SceneManagement.SceneManager.LoadScene ("mainmenu");
            }
        }

        if (GUI.Button(new Rect(430, 100, 300, 40), "Decrease Population Growth Rate"))
        {
            if (US_growth_rate > 0.01)
            {
                US_growth_rate = (0.9 * US_growth_rate);
                US_growth_rate_text.text = "US growth rate = " + US_growth_rate.ToString();
            }
            
         
        }

        if (GUI.Button(new Rect(430, 150, 300, 40), "Increase Energy Use Per Person by 10%"))
        {
            US_energy_use_per_person = (int) ((1.10 * US_energy_use_per_person));
            US_energy_demand = (long)US_population * US_energy_use_per_person;
            US_energy_demand_text.text = "US energy demand = " + US_energy_demand.ToString() + "kWh";
            US_energy_use_per_person_text.text = "US energy use per person = " + US_energy_use_per_person.ToString() + " kWh";
        }

        if (GUI.Button(new Rect(15, 15, 150, 40), "Back to Main Menu"))
		UnityEngine.SceneManagement.SceneManager.LoadScene ("mainmenu");


    }

    // Use this for initialization
    void Start () {
        year_text.text = "Year = 2015";
        US_population_text.text = "US population = 321368864";
        // US_GDP
        // US_energy_use_per_person
        US_energy_demand_text.text = "US energy demand = 4163012264256 kWh";
        // US_energy_production
        // US_per_coal, etc.....
        // US_co2_emissions
        US_growth_rate_text.text = "US growth rate = 0.7";
        ppm_text.text = "PPM CO2 = 400";
        temp_text.text = "Temperature = " + ((1.8 * temp) + 32).ToString() + " F";
        slr_text.text = "Sea Level Rise = 0 ft";
    }

    // Update is called once per frame
    //void Update () {
    //  test.text = "hello there";
    //}
}
