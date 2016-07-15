using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using WPMF;

public class TestGUI : MonoBehaviour
{

    private BaseCountry country;
    public GlobeKeeper gk;
    private GUIStyle guiStyle = new GUIStyle();
    public Texture socialTreeTexture;
    public Texture envTreeTexture;
    public Texture econTreeTexture;
    public Texture blackboxTexture;
    public Texture blackboxTextureCHANGEME;
    public Texture treeTexture;
    public Texture coinTexture;
    public Texture familyTexture;
    private bool showSocialTree = false;
    private bool showEconTree = false;
    private bool showEnvTree = false;
    private bool showSocialScore = false;
    private bool showEconScore = false;
    private bool showEnvScore = false;
    public AudioSource FailureSound; 

    public int socialScoreLabel = 0;
    public double econScoreLabel = 0;
    public double envScoreLabel = 0;
    public System.String socialScoreStatus = "DANGER";
    public System.String econScoreStatus = "Neutral";
    public System.String envScoreStatus = "Neutral";
    public System.String yearLabel = "2016";
    public System.String ppmLabel = "405 ppm";
    public System.String sea_level_riseLabel = "0 ft";
    public System.String tempLabel = "54.2 F";
    public System.String globalpopLabel = "7125000000";
    public string worldRankLabel = "World Rankings:\n \n 1 United States | 0\n2 China | 0\n3 Germany | 0\n4 Brazil | 0\n5 India | 0\n6 Russia | 0";

    public WorldMap2D map;
    private BaseCountry country1;
    private BaseCountry country2;
    private BaseCountry country3;
    private BaseCountry country4;
    private BaseCountry country5;
    private BaseCountry country6;
    private int decisionTokens = 2;

    string[] buttonLabelArray = new string[] {"Hello this is index zero what are you doing here", "Education for minors\n \n  Invest into educational improvements for children ages 4-18 to improve on textbooks, test scores, and experiential learning.",
"Education for adults\n \n   Invest into colleges, continuing educational programs and training for adults of all ages.",
"Decrease in dropouts\n \n  As a result in improved education for children and adults, a higher percentage of the population finishes school in your country.",
"Voter education\n \n  Invest into improving education on how and why citizens exercise their right to vote, as well as providing materials on current candidates and bills",
"Economic education\n \n  Invest to improve the methods of teaching practical economic knowledge in schools including how to do taxes, financial planning, the specifics of mortgages and loans, and retirement planning. ",
"Outdoor education\n \n  Invest to support education about the environment and the inclusion of outdoor activities and exercise in schools. Students will enjoy nature walks, field trips to national parks, and improved education about geology, geography, biology, chemistry and astronomy.",
"Health education \n \n Invest to improve sex ed, provide accessible classes for CPR and first aid, and educate the populace on the health care system on your country.",
"Living wage\n \n  Make the minimum wage in your country a living wage.",
"Affordable higher education\n \n  Invest in higher education, making colleges and graduate schools more accessible to the public. ",
"Wildlife reserve\n \n  Preserve the endangered wildlife of your country in a reserve made just for them.",
"New national park\n \n  Establish a new national park to preserve natural wonders for future generations.",
"Visit a national park day\n \n  Declare a holiday in honor of the new national park.",
"Require the playing of runaway planet in schools\n \n  Require that children and young adults play Runaway Planet for improved education in global politics and environmental issues.",
"Hospital renovation\n \n  Renovate hospitals throughout the country.",
"Drug education\n \n  Due to better health education and more accessible doctor and hospital care, your populace is now more educated about drugs.",
"Universal healthcare\n \n  Your country’s healthcare is now not only available to everyone, but more optimized in efficiency and cost to the country as a whole.",
"Government programs for health\n \n  Invest in improvement and expansion of government programs encouraging citizen health.",
"Fitness program\n \n   Combat heart disease and obesity as well as supporting physical fitness with programs that encourage people to get outdoors and play! ",
"Birth control\n \n  Invest to provide accessible birth control to the population.",
"Provide tax breaks to families with dependants\n \n  Encourage family growth by providing monetary incentive and assistance to families with multiple children.",
"Civic devlopment\n \n  Invest in civic development throughout your country.",
"Sanitation\n \n  Invest in improved sanitation systems throughout your country, with more environmentally friendly methods of disposal.",
"Prison reform\n \n  Invest in renovation and study of prisons in order to provide better programs for rehabilitation of prisoners.",
"Resources for homeless\n \n   Invest in resources for the health and welfare of the homeless. Support affordable housing, food kitchens, and programs that help with job searches and procuring of clothing.",
"Rural economic development\n \n  Invest to help rural economies develop with better infrastructure, internet, and more economic opportunity.",
"Quality of life\n \n  Your population has longer lifespans, higher happiness, and your advances in medicine and health have lead to a widespread eradication of major diseases.",
"Common renewable energy 1\n \n  Invest 5% of your GDP into the development of your country's most common renewable energy source.",
"Common renewable energy 2\n \n  Invest 10% of your GDP into the development of your country's most common renewable energy source.",
"Common renewable energy 3\n \n  Invest 15% of your GDP into the development of your country's most common renewable energy source.",
"2nd common renewable energy 1\n \n  Invest 5% of your GDP into the development of your country's second most common renewable energy source.",
"2nd common renewable energy 2\n \n  Invest 10% of your GDP into the development of your country's second most common renewable energy source.",
"2nd common renewable energy 3\n \n  Invest 15% of your GDP into the development of your country's second most common renewable energy source.",
"Common non-renewable energy 1\n \n  Invest 5% of your GDP into the development of your country's most common non-renewable energy source.",
"Common non-renewable energy 2\n \n  Invest 10% of your GDP into the development of your country's most common non-renewable energy source.",
"Common non-renewable energy 3\n \n  Invest 15% of your GDP into the development of your country's most common non-renewable energy source.",
"2nd common non-renewable energy 1\n \n  Invest 5% of your GDP into the development of your country's second most common non-renewable energy source.",
"2nd common non-renewable energy 2\n \n  Invest 10% of your GDP into the development of your country's second most common non-renewable energy source.",
"2nd common nonrenewable energy 3\n \n  Invest 15% of your GDP into the development of your country's second most common non-renewable energy source.",
"Arbor day\n \n  Promote the country-wide celebration of Arbor Day to plant trees and seeds of cooperation across the nation. ",
"Vehicle emissions\n \n  Set tighter restrictions on vehicular emissions.",
"Industrial emissions\n \n  Tighten standards for industrial emissions and ensure regular inspections to enforce them.",
"Energy efficiency research 1\n \n  Invest into scientific research in energy efficiency. ",
"Energy efficiency research 2\n \n  Invest further into scientific research to spark inventions and advances in energy efficiency.",
"Carpooling initiative\n \n  Use social media to promote carpooling in cities.",
"Bikeshare / bike lanes\n \n  Establish a large network of bike sharing programs and bike lanes throughout cities in your country.",
"Improved bus routes\n \n  Improve the efficiency of bus routes and schedules, and increase inspections on buses to make sure they meet emission standards.",
"Hybrid bus initiative\n \n  Initiate a program so that all city bus transportation must be on newly invented hybrid buses.",
"Light rail\n \n  Implement an improved light rail system in your country to make transportation quick and accessible to the populace.",
"Bull Market\n \n  Your country receives an unprecidented increase in stock value, foreign investment, and a surge of economic growth.",
"International summit\n \n  Attend an international summit to show concern about climate change and the state of the world.",
"International invention conference\n \n  Promote and attend an international invention conference to foster the exchange of ideas and cooperation among nations.",
"All renewable energy\n \n  Your country has now reached a state of complete reliance on renewable energies.",
"Energy costs dramatically decrease\n \n  Due to your investment in non-renewables, your country now has cheaper energy costs.",
"Cheap and universal access to energy\n \n  Everyone in your country has cheap and easy access to energy sources, promoting business, creativity, and the economy.",
"Infrastructure\n \n  Invest to improve your country's infrastructure over a period of years.",
"Electric smart grid\n \n  Implement an electric smart grid in your country where the grid used by consumers provides digital feedback to providers, improving efficient provision of energy, lower utility operation costs, and integration of renewable technologies.",
"Other countries invest in your domestic energy\n \n  Foreign nations see the marked improvement in your energy systems and invest in your domestic energy producers and providers.",
"Roads & bridges\n \n  Improve roads and bridges in your country to facilitate travel and the interconnectivity of your economic centers.",
"Internet\n \n  Invest to create faster internet speeds, greater accessibility to the internet, and improved wifi.",
"Cultural/social boost\n \n  The improved infrastructure in your country has led to a creative boom that promotes culture and social dynamics. ",
"Tax breaks for domestic companies 1\n \n  Implement a tax code revision that allows domestic companies greater tax breaks to promote your country's economy and products over imports.",
"Tax breaks for domestic companies 2\n \n  Increase tax breaks for domestic companies to grow them further and encourage entrepreneurs to begin their company in your country.",
"Tax breaks for domestic companies 3\n \n  Add one more layer of tax breaks for domestic companies to ensure that the new businesses stay and grow in your country and that consumers choose products that will enhance your GDP.",
"Jobs\n \n  Invest for the creation of jobs in various sectors, to decrease unemployment and increase GDP.",
"Manufacturing 1\n \n  Invest in your country's manufacturing sector.",
"Manufacturing 2\n \n  Invest further into your country's manufacturing sector to produce more exportable products.",
"Cheap products!\n \n  As your country produces more products, they become cheaper for consumption throughout the nation leading to greater consumption and happiness.",
"Increased exports\n \n  Your exports and sales to other countries increase.",
"Heighten quality standards 1\n \n  Tighten standards of quality for exports leaving your country to make sure you do not export shoddy or faulty products.",
"Heighten quality standards 2\n \n  Establish exemplary levels of quality for your products such that your country becomes known for their quality.",
"Quality of exports increase\n \n  Increased standards lead to a cycle of increasing quality and increase in sales overseas. Other countries buy your products and your product quality keeps getting better.",
"Research money 1\n \n  Invest in technological research to further the computer and technology based industries in your country.",
"Research money 2\n \n  Invest further in research for futuristic technologies in modern times.",
"Technology jobs!\n \n  Investment in new technologies has led to openings in the technological sector for new employees.",
"Technology exports increase\n \n  Increase in new technology and technology workers has led to other countries buying your products. Your technology exports increase.",
"Discover a new raw material\n \n  Scientists in your country have found a new raw material never before used in modern times.",
"Integrate new raw material\n \n  Through study and science, the new raw material has been implemented into regular manufacturing processes, improving their efficiency and cost.",
"Bonus increased quality of materials at decreased price\n \n  Due to this unprecidented find and quick integration your country is enjoying higher quality products for less money.",
"Good international reputation\n \n  Due to years of improved standards and volume of production, your country has established a consistent reputation for quality of goods and services. Other countries will buy from your for years to come because of their newfound respect for you.",
"Economic stimulus & stable economic growth\n \n ",
"Tourism Jobs\n \n  Invest in jobs in the tourism industry, promoting your country's natural beauty to both your own citizens and the world",
"Beautify\n \n  Due to your increased care for the aesthetic value of your nation, your population develops increased national pride, and makes efforts to beautify the country, which becomes known worldwide for its beauty."};

    int[,] buttonInstantiationArray = new int[,] {
            {0,0,0 },
             {1,240,95},
             {2,240,150},
             {3,289,150},
             {4,170,215},
             {5,220,215},
             {6,270,215},
             {7,319,215},
             {8,170,305},
             {9,170,370},
             {10,270,275},
             {11,270,329},
             {12,220,329},
             {13,270,377},
             {14,368,275},
             {15,423,331},
             {16,368,330},
             {17,405,90},
             {18,405,144},
             {19,370,199},
             {20,439,199},
             {21,524,88},
             {22,523,143},
             {23,523,197},
             {24,523,253},
             {25,522,317},
             {26,368,450},
             {27,190,113},
             {28,190,167},
             {29,190,227},
             {30,246,114},
             {31,246,167},
             {32,245,227},
             {33,467,114},
             {34,467,167},
             {35,467,227},
             {36,519,115},
             {37,519,167},
             {38,519,227},
             {39,218,276},
             {40,316,114},
             {41,316,167},
             {42,316,227},
             {43,316,276},
             {44,368,114},
             {45,368,167},
             {46,419,227},
             {47,368,227},
             {48,368,276},
             {49,494,278},
             {50,264,366},
             {51,368,366},
             {52,316,433},
             {53,494,366},
             {54,494, 426},
             {55,218,80},
             {56,219, 131},
             {57,173, 131},
             {58,219, 176},
             {59,219, 228},
             {60,173,228},
             {61,306, 80 },
             {62,306, 124 },
             {63,306, 175 },
             {64,426, 80 },
             {65,376, 175 },
             {66,376, 236 },
             {67,376, 279 },
             {68,376, 326 },
             {69,319,279 },
             {70,319, 326 },
             {71,351, 373},
             {72,426, 150 },
             {73,426, 201 },
             {74,426, 253 },
             {75,426, 304 },
             {76,474,201},
             {77,474,253 },
             {78,474,304 },
             {79,351, 420 },
             {80,351, 467 },
             {81,474, 150 },
             {82,526, 150 }
         };

    private int[][][] dependencies = {
        new int[][] { new int[] {}}, //Dummy first entry, need to offset our numbering to match our diagram
        //Ones
        new int[][] { new int[] {}}, //1    
        new int[][] { new int[] {1}}, //2
        new int[][] { new int[] {2}}, //3
        new int[][] { new int[] {2}}, //4
        new int[][] { new int[] {2}}, //5
        new int[][] { new int[] {2}}, //6
        new int[][] { new int[] {2}}, //7
        new int[][] { new int[] {4,5}}, //8
        new int[][] { new int[] {8}}, //9
        //Teens
        new int[][] { new int[] {6}}, //10
        new int[][] { new int[] {10}}, //11
        new int[][] { new int[] {11}}, //12
        new int[][] { new int[] {11}}, //13
        new int[][] { new int[] {7}, new int[] {18,19}, new int[] {18,20}}, //14
        new int[][] { new int[] {16}}, //15
        new int[][] { new int[] {14}}, //16
        new int[][] { new int[] {}}, //17
        new int[][] { new int[] {17}}, //18
        new int[][] { new int[] {18}}, //19
        //Twenties
        new int[][] { new int[] {18}}, //20
        new int[][] { new int[] {}}, //21
        new int[][] { new int[] {21}}, //22
        new int[][] { new int[] {22}}, //23
        new int[][] { new int[] {23}}, //24
        new int[][] { new int[] {24}}, //25
        new int[][] { new int[] {9,13,16}, new int[] {16,25}}, //26
        new int[][] { new int[] {}}, //27
        new int[][] { new int[] {27}}, //28
        new int[][] { new int[] {28}}, //29
        //Thirties
        new int[][] { new int[] {}}, //30
        new int[][] { new int[] {30}}, //31
        new int[][] { new int[] {31}}, //32
        new int[][] { new int[] {}}, //33
        new int[][] { new int[] {33}}, //34
        new int[][] { new int[] {34}}, //35
        new int[][] { new int[] {}}, //36
        new int[][] { new int[] {36}}, //37
        new int[][] { new int[] {37}}, //38
        new int[][] { new int[] {29,32}}, //39
        //Forties
        new int[][] { new int[] {}}, //40
        new int[][] { new int[] {40}}, //41
        new int[][] { new int[] {41}}, //42
        new int[][] { new int[] {42}}, //43
        new int[][] { new int[] {}}, //44
        new int[][] { new int[] {44}}, //45
        new int[][] { new int[] {45}}, //46
        new int[][] { new int[] {42}, new int[] {46}}, //47
        new int[][] { new int[] {46}}, //48
        new int[][] { new int[] {35,38}}, //49
        //Fifties
        new int[][] { new int[] {39,43,48}}, //50
        new int[][] { new int[] {39,43,48}}, //51
        new int[][] { new int[] {50,51}}, //52
        new int[][] { new int[] {43,48,49}}, //53
        new int[][] { new int[] {53}}, //54
        new int[][] { new int[] {}}, //55
        new int[][] { new int[] {55}}, //56
        new int[][] { new int[] {56}}, //57
        new int[][] { new int[] {56}}, //58
        new int[][] { new int[] {58}}, //59
        //Sixties
        new int[][] { new int[] {59}}, //60
        new int[][] { new int[] {}}, //61
        new int[][] { new int[] {61}}, //62
        new int[][] { new int[] {62}}, //63
        new int[][] { new int[] {}}, //64
        new int[][] { new int[] {63}, new int[] {64}}, //65
        new int[][] { new int[] {65}}, //66
        new int[][] { new int[] {66}}, //67
        new int[][] { new int[] {67}}, //68
        new int[][] { new int[] {67}}, //69
        //Seventies
        new int[][] { new int[] {69}}, //70
        new int[][] { new int[] {70,68}}, //71
        new int[][] { new int[] {64}}, //72
        new int[][] { new int[] {72}}, //73
        new int[][] { new int[] {73}}, //74
        new int[][] { new int[] {74}}, //75
        new int[][] { new int[] {73}}, //76
        new int[][] { new int[] {76}}, //77
        new int[][] { new int[] {77}}, //78
        new int[][] { new int[] {59,71}, new int[] {71,75,78}}, //79
        //Eighties
        new int[][] { new int[] {79}}, //80
        new int[][] { new int[] {64}}, //81
        new int[][] { new int[] {81}} //82
    };

    // NOTE THAT THIS NEEDS TO BE HARD CODED TO BE THE STARTING COUNTRY AT PRESENT
    // Use this for initialization

    void DecideEconStatus()
    {
        econScoreLabel = System.Math.Round((country.GDP - country.InitialGDP) / country.InitialGDP * 100.00);
        if (econScoreLabel < -10)
        {
            econScoreStatus = "DANGER";
            
        } else if (econScoreLabel > 10)
        {
            econScoreStatus = "Excellent!";
        }
        else
        {
            econScoreStatus = "Neutral";
        }
    }

    void DecideEnvStatus()
    {
        envScoreLabel = System.Math.Round((country.CO2Emissions - country.InitialCO2Emissions) / country.InitialCO2Emissions * 100.00);
        if (envScoreLabel > 10)
        {
            envScoreStatus= "DANGER";
        }
        else if (envScoreLabel < -10 )
        {
            envScoreStatus = "Excellent!";
        }
        else
        {
            envScoreStatus = "Neutral";
        }
    }

    void DecideSocialStatus()
    {
        socialScoreLabel = country.Happiness;
        if (country.Happiness > 225)
        {
            socialScoreStatus = "Excellent!";
        } else if (country.Happiness > 90)
        {
            socialScoreStatus = "Neutral";
        } else
        {
            socialScoreStatus = "DANGER";
        }
    }

    IEnumerator Wait()
    {
        //waitActive = true;
        yield return new WaitForSeconds(5.0f);
        //canSwitch = true;
        //waitActive = false;
    }

    void Start()
    {
        

        gk = gameObject.GetComponent<GlobeKeeper>();


        map = WorldMap2D.instance;
        map.showLatitudeLines = false;
        map.showLongitudeLines = false;
        map.earthStyle = EARTH_STYLE.NaturalScenic;
        map.isDirty = true;
        //map.RestyleEarth();
        map.Redraw();
        map.allowScrollOnScreenEdges = false;
        map.invertZoomDirection = true;
        country1 = new BaseUSA();
        country2 = new BaseChina();
        country3 = new BaseIndia();
        country4 = new BaseGermany();
        country5 = new BaseBrazil();
        country6 = new BaseRussia();
        Time.timeScale = 1;
        StartCoroutine(Wait());
        map.FlyToLocation(0, 0);
        map.SetZoomLevel(1);
        map.FlyToCountry("United States of America");
        map.SetZoomLevel((float)0.25); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        DecideEnvStatus();
        DecideEconStatus();
        DecideSocialStatus();
        country.TotalScore = socialScoreLabel + econScoreLabel;

        if (GUI.Button(new Rect(865, 510, 80, 80), new GUIContent(socialTreeTexture, "Social Tree")))
        {
            if (showSocialTree)
            {
                showSocialTree = false;
            }
            else
            {
                showSocialTree = true;
                showEnvTree = false;
                showEconTree = false;
                showEconScore = false;
                showEnvScore = false;
                showSocialScore = false;
            }

        };

        if (GUI.Button(new Rect(775, 510, 80, 80), new GUIContent(envTreeTexture, "Environment Tree")))
        {
            if (showEnvTree)
            {
                showEnvTree = false;
            }
            else
            {
                showEnvTree = true;
                showEconTree = false;
                showSocialTree = false;
                showEconScore = false;
                showEnvScore = false;
                showSocialScore = false;
            }
        };

        if (GUI.Button(new Rect(685, 510, 80, 80), new GUIContent(econTreeTexture, "Economic Tree")))
        {
            if (showEconTree)
            {
                showEconTree = false;
            }
            else
            {
                showEconTree = true;
                showEnvTree = false;
                showSocialTree = false;
                showEconScore = false;
                showEnvScore = false;
                showSocialScore = false;
            }
        };

        //GUI.Label(new Rect(780, 485, 130, 40), GUI.tooltip);



        if (showSocialTree)
        {
            GUI.DrawTexture(new Rect(150, 72, 440, 440), socialTreeTexture);
            GUI.DrawTexture(new Rect(650, 189, 200, 200), blackboxTexture);
            //Color temp = GUI.color;
            //GUI.color = new Color(1, 1, 1, 1f);
            //GUI.Button(new Rect(250, 130, 30, 30), blackboxTexture);
            //Color tmpColor = GUI.color;
            //GUI.color = new Color(1, 1, 1, 0.1f);
            //GUI.color = tmpColor;
            for (int i = 1; i < 27; i++)
            {
                if (GUI.Button(new Rect(buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2], 40, 40), new GUIContent(country.DecisionState[i] ? blackboxTexture : blackboxTextureCHANGEME, buttonLabelArray[i])))
                {
                    makeDecision(i, buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2]);

                    if(makeDecision(i,1,1) == false)
                    {

                    }

                    //GUI.Button(new Rect(buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2], 40, 40), blackboxTexture);
                    //if (makeDecision(i,1,1)) {
                        //GUI.DrawTexture(new Rect(buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2], 40, 40), blackboxTexture);
                      //  GUI.Button(new Rect(buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2], 40, 40), blackboxTexture);
                    //}
                    //makeDecision(i);
                    //if (makeDecision(i)) {
                    //  GUI.Button(new UnityEngine.Rect(buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2], 40, 40), blackboxTexture);
                    //};
                }

            }
            GUI.Label(new Rect(660, 189, 180, 180), GUI.tooltip);
        }
        if (showEconTree)
        {
            //showEconTree = false;
            //showEconTree = true;
            GUI.DrawTexture(new Rect(150, 72, 440, 440), econTreeTexture);
            GUI.DrawTexture(new Rect(650, 189, 200, 200), blackboxTexture);
            for (int i = 55; i < 83; i++)
            {
                if (GUI.Button(new Rect(buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2], 40, 40), new GUIContent(country.DecisionState[i] ? blackboxTexture : blackboxTextureCHANGEME, buttonLabelArray[i])))
                {
                    makeDecision(i, buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2]);
                    //Validate the decision
                    //If the decision is valid:
                    //Committ the decision
                    //Add a black box
                    //Else:
                    //MAKE A SOUND
                }

            }
            GUI.Label(new Rect(660, 189, 180, 180), GUI.tooltip);
        }
        if (showEnvTree)
        {
            //showEnvTree = false;
            //showEnvTree = true;
            GUI.DrawTexture(new Rect(150, 72, 440, 440), envTreeTexture);
            GUI.DrawTexture(new Rect(650, 189, 200, 200), blackboxTexture);
            for (int i = 27; i < 55; i++)
            {
                if (GUI.Button(new Rect(buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2], 40, 40), new GUIContent(country.DecisionState[i] ? blackboxTexture : blackboxTextureCHANGEME, buttonLabelArray[i])))
                {
                    makeDecision(i, buttonInstantiationArray[i, 1], buttonInstantiationArray[i, 2]);
                    if (makeDecision(i, 1, 1) == false)
                    {
                        //gameObject.GetComponent<AudioSource>().Play();
                        //MAKE A SOUND
                    }
                }
            }
            GUI.Label(new Rect(660, 189, 180, 180), GUI.tooltip);
        }

        if (showEconScore)
        {
            GUI.DrawTexture(new Rect(150, 110, 400, 365), blackboxTexture);
            GUI.DrawTexture(new Rect(130, 166, 440, 500), coinTexture);
            //double perChangeGDP = System.Math.Round((country.GDP - country.InitialGDP) / country.InitialGDP * 100.00);
            GUI.Label(new Rect(160, 118, 400, 350), "Gross Domestric Product:  $" + (System.Math.Round((double)country.GDP)).ToString("N0")  + "\n \nGDP Change: " + System.Math.Round((country.GDP - country.InitialGDP) / country.InitialGDP * 100.00) + "%\n \nInitial GDP: $" + (System.Math.Round((double)country.InitialGDP)).ToString("N0") + "\n \nGDP Sectors: " + country.Industry + "\n \nExports: " + country.Exports);
        }

        if (showEnvScore)
        {
            GUI.DrawTexture(new Rect(150, 110, 400, 365), blackboxTexture);
            GUI.DrawTexture(new Rect(125, 76, 440, 440), treeTexture);
            //double perChangeCO2 = System.Math.Round((country.CO2Emissions - country.InitialCO2Emissions) / country.InitialCO2Emissions * 100.00);
            GUI.Label(new Rect(160, 118, 400, 350), "CO2 Emissions: " + (System.Math.Round(country.CO2Emissions)).ToString("N0") + " kg/year \n \nCO2 Emissions Change: " + System.Math.Round((country.CO2Emissions - country.InitialCO2Emissions) / country.InitialCO2Emissions * 100.00) + "%\n \nInitial CO2 Emissions: " + (System.Math.Round((double)country.InitialCO2Emissions)).ToString("N0") + " kg/year \n \nEnergy Demand: " + (System.Math.Round((double)country.EnergyDemand)).ToString("N0") + " kWh\n \nAverage Energy Use Per Person: " + country.EnergyPerCapita + " kWh\n \n Energy Composition: \n \n        Coal: " + country.PerCoal + "%\n \n        Gas: " + country.PerGas + "%\n \n        Nuclear: " + country.PerNuclear + "%\n \n        Wind: " + country.PerWind + "%\n \n        Hydroelectric: " + country.PerHydro + "%\n \n        Solar: " + country.PerSolar + "%");
        }

        if (showSocialScore)
        {
            GUI.DrawTexture(new Rect(150, 110, 400, 365), blackboxTexture);
            GUI.DrawTexture(new Rect(240, 60, 510, 510), familyTexture);
            //double perChangePopulation = System.Math.Round((country.Population - country.IniitalPopulation) / country.IniitalPopulation * 100.00);
            GUI.Label(new Rect(160, 118, 400, 350), "Population: " + (System.Math.Round(country.Population)).ToString("N0") + "\n \nPopulation Growth Rate: " + country.GrowthRate + "\n \nPopulation Change: "+ System.Math.Round((country.Population - country.IniitalPopulation) / country.IniitalPopulation * 100.00) + "%\n \nInitial Population: " + (System.Math.Round(country.IniitalPopulation)).ToString("N0") + "\n \nQuality of Life Index: " + country.Happiness + "\n \nWorld Happiness Ranking: " + country.WorldHappRank);
        }

        if (GUI.Button(new Rect(547, 540, 120, 20), "Zoom to Country"))
        {
            map.FlyToLocation(0, 0);
            map.SetZoomLevel(1);
            map.FlyToCountry(country.CountryName);
            map.SetZoomLevel((float)0.25);
            map.BlinkCountry(map.GetCountryIndex(country.CountryName), Color.red, Color.blue, 2, 1);
        };

        if (GUI.Button(new Rect(547, 565, 120, 20), "Zoom to Globe"))
        {
            map.FlyToLocation(0, 0);
            map.SetZoomLevel(1);
        };

        if (GUI.Button(new Rect(480, 540, 50, 50), "+"))
        {
            var currentZoom = map.GetZoomLevel();
            map.SetZoomLevel(currentZoom - 0.15f);
        };

        if (GUI.Button(new Rect(420, 540, 50, 50), "-"))
        {
            var currentZoom = map.GetZoomLevel();
            map.SetZoomLevel(currentZoom + 0.15f);
        };

        if (GUI.Button(new Rect(420, 515, 245, 20), "Player:  " + country.CountryName)) ;
        //GUI.Label(new Rect(300, 520, 405, 10), country.CountryName);

        GUI.backgroundColor = Color.blue;
        if (GUI.Button(new Rect(280, 515, 125, 75), "Social Score:\n" + socialScoreLabel + " points \n" + socialScoreStatus))
        {
            if (showSocialScore)
            {
                showSocialScore = false;
            }
            else
            {
                showSocialScore = true;
                showEconScore = false;
                showEnvScore = false;
                showEconTree = false;
                showEnvTree = false;
                showSocialTree = false;
            }
        };

        GUI.backgroundColor = Color.green;
        if (GUI.Button(new Rect(145, 515, 125, 75), "Environment Score:\n" + envScoreLabel + "% Change\n" + envScoreStatus))
        {
            if (showEnvScore)
            {
                showEnvScore = false;
            }
            else
            {
                showEnvScore = true;
                showEconScore = false;
                showSocialScore = false;
                showEconTree = false;
                showEnvTree = false;
                showSocialTree = false;
            }
        };

        GUI.backgroundColor = Color.yellow;
        if (GUI.Button(new Rect(10, 515, 125, 75), "Economic Score:\n" + econScoreLabel + "% Change\n" + econScoreStatus))
        {
            if (showEconScore)
            {
                showEconScore = false;
            }
            else
            {
                showEconScore = true;
                showSocialScore = false;
                showEnvScore = false;
                showEconTree = false;
                showEnvTree = false;
                showSocialTree = false;
            }
        };


        GUI.backgroundColor = Color.gray;
        GUI.Button(new Rect(5, 5, 675, 50), "Year               C02 Concentration               Sea Level Rise               Temperature               Global Pop.     \n");
        GUI.Label(new Rect(30, 30, 100, 80), yearLabel);
        GUI.Label(new Rect(155, 30, 100, 80), ppmLabel);
        GUI.Label(new Rect(320, 30, 100, 80), sea_level_riseLabel);
        GUI.Label(new Rect(455, 30, 100, 80), tempLabel);
        GUI.Label(new Rect(555, 30, 100, 80), globalpopLabel);

        //690, 5, 80, 200
        GUI.Button(new Rect(690, 45, 80, 40), "Decisions\nLeft:  " +decisionTokens);

        GUI.Button(new Rect(780, 5, 170, 150), worldRankLabel);
        // Test Code

        //if (GUI.Button(new Rect(526, 150, 40,40), blackboxTexture))
        //{

        //}



        // End of Test Code



        
    }

    public void SetCountry(BaseCountry newCountry)
    {
        country = newCountry;
    }

    public bool validateDecision(int id)
    {
        bool valid = false;
        for (int i = 0; i < dependencies[id].Length; i++)
        {
            int count = 0;
            for (int q = 0; q < dependencies[id][i].Length; q++)
            {
                if (country.DecisionState[dependencies[id][i][q]])
                {
                    count++;
                }
            }
            if (count == dependencies[id][i].Length)
            {
                valid = true;
            }
        }
        return valid;
    }

    public bool makeDecision(int id, int x, int y)
    {
        if ((decisionTokens > 0) && (!country.DecisionState[id]) && validateDecision(id))
        {
            //Set decision to made
            
            country.DecisionState[id] = true;
            //Update Double-Based Values
            country.GrowthRate += country.DecisionEffectsDouble[id][0];
            country.GDP += (long)(country.GDP * country.DecisionEffectsDouble[id][1]);
            country.EnergyDemand += (long)(country.EnergyDemand * country.DecisionEffectsDouble[id][2]);
            country.PerChangeGDP = System.Math.Round((country.GDP - country.InitialGDP) / country.InitialGDP * 100.00);
            //Update Int-Based Values
            country.Happiness += country.DecisionEffectsInt[id][0];
            country.PerCoal += country.DecisionEffectsInt[id][1];
            country.PerGas += country.DecisionEffectsInt[id][2];
            country.PerNuclear += country.DecisionEffectsInt[id][3];
            country.PerWind += country.DecisionEffectsInt[id][4];
            country.PerHydro += country.DecisionEffectsInt[id][5];
            country.PerSolar += country.DecisionEffectsInt[id][6];
            
            // if (id == a perEnergy-related decision) { do the correct stuff }

            if (id == 52) //Special Behavior For All Renewable Sources Decision
            {
                country.PerCoal = 0;
                country.PerGas = 0;
                country.PerNuclear = 0;
                country.PerSolar = 34;
                country.PerWind = 33;
                country.PerHydro = 33;
            }
            decisionTokens--;
            //GUI.DrawTexture(new Rect(5, 5, 40, 40), blackboxTexture);
            //GUI.DrawTexture(new Rect(x, y, 200, 200), blackboxTexture);
            return true;
        }
        else
        {
            FailureSound.Play(); 
            return false;
        }
    }

    public int DecisionTokens
    {
        get { return decisionTokens; }
        set { decisionTokens = value; }
    }

    void GlobePopulation(long thing)
    {
        globalpopLabel = "" + thing.ToString("N0");
    }

    void Year(int thing)
    {
        yearLabel = "" + thing;
    }

    void PPM(double thing)
    {
        ppmLabel = "" + System.Math.Round(thing);
    }

    void SLR(double thing)
    {
        thing = thing / 0.3048;
        sea_level_riseLabel = "" + System.Math.Round(thing,2) + " ft";
        
    }

    void TEMP(double thing)
    {
        thing = thing * (9.0 / 5.0) + 32;
        tempLabel = "" + System.Math.Round(thing, 1) + " F";
    }

    void WorldRankLabel(string thing)
    {
        worldRankLabel = thing;
    }

    // Don't add this, and I know you already had it, but for reference the function to use is
    //  makeDecision(DecisionIndex), which will return true when the decision goes through and
    //  false in either the case of failing for lacking required other decisions or
    //  failing due to the decision having already been made in the past.
    //  You shouldn't need to call ValidateDecision(DecisionIndex), only exists as a
    //  helper function for makeDecision.
}