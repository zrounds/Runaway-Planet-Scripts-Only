using UnityEngine;
using System.Collections;

public class BaseUSA : BaseCountry {

	public BaseUSA(){
		CountryName = "United States of America";
        TotalScore = 0;
		Population = 321368864;
        IniitalPopulation = 321368864;
        GrowthRate = 0.7;
		GDP = 17419000000000;
		EnergyDemand = 4163012264256;
		EnergyPerCapita = 12954;
		EnergyProduction = 4255499969482;
		PerCoal = 39;
		PerGas = 31;
		PerNuclear = 20;
		PerWind = 4;
		PerHydro = 6;
		PerSolar = 0;
        //co2Emissions = 0;
        InitialGDP = 17419000000000;
        InitialCO2Emissions = 2025617985473430;
        CO2Emissions = 2025617985473430;
        Industry = "Agriculture: 1.6%, Industry: 20.8%, Services: 77.6%";
        Exports = "Machines, engines, electronics, aircraft, vehicles";
        WorldHappRank = 13;
        PerChangeGDP = 0;
        PerChangePop = 0;
        PerChangeCO2 = 0;

        decisionEffectsInt = new int[][]
        {
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 10,1,2,3,4,5,6 }, //all 0 other than initial 10
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 25,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 22,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 30,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 25,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 100,0,0,0,0,0,0 },
            new int[] { 0,-1,-1,-1,-1,5,-1 },
            new int[] { 0,-2,-2,-2,-2,10,-2 },
            new int[] { 0,-3,-3,-3,-3,15,-3 },
            new int[] { 0,-1,-1,-1,5,-1,-1 },
            new int[] { 0,-2,-2,-2,10,-2,-2 },
            new int[] { 0,-3,-3,-3,15,-3,-3 },
            new int[] { 0,5,-1,-1,-1,-1,-1 },
            new int[] { 0,10,-2,-2,-2,-2,-2 },
            new int[] { 0,15,-3,-3,-3,-3,-3 },
            new int[] { 0,-1,5,-1,-1,-1,-1 },
            new int[] { 0,-2,10,-2,-2,-2,-2 },
            new int[] { 0,-3,15,-3,-3,-3,-3 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { -5,0,0,0,0,0,0 },
            new int[] { -10,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 37,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 100,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 50,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 8,0,0,0,0,0,0 },
            new int[] { 25,0,0,0,0,0,0 },
            new int[] { 35,0,0,0,0,0,0 },
            new int[] { 12,0,0,0,0,0,0 },
            new int[] { 14,0,0,0,0,0,0 },
            new int[] { 16,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 8,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { -5,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 30,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 8,0,0,0,0,0,0 },
            new int[] { 50,0,0,0,0,0,0 },
            new int[] { 80,0,0,0,0,0,0 },
            new int[] { 6,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 }
        };

        decisionEffectsDouble = new double[][]{
            new double[] { 0, 0, 0 },
            new double[] { 0,-0.05, 0 }, 
            new double[] { 0,0,-0.02 },
            new double[] { 0,0, 0 },
            new double[] { 0,0.01,-0.02 },
            new double[] { 0,0.02, 0 },
            new double[] { 0,0,-0.02 },
            new double[] { - 0.02,0, 0 },
            new double[] { 0,-0.05, 0 },
            new double[] { 0,0.01,-0.05 },
            new double[] { 0,-0.01,-0.01 },
            new double[] { 0,0,-0.01 },
            new double[] { 0,0.01,-0.01 },
            new double[] { 0,0.02,-0.05 },
            new double[] { 0,-0.03, 0 },
            new double[] { 0,0, 0 },
            new double[] { 0,-0.07, 0 },
            new double[] { 0,-0.02, 0 },
            new double[] { 0,0.01,-0.01 },
            new double[] { - 0.1,0, 0 },
            new double[] { 0.05,-0.04, 0 },
            new double[] { 0,0, 0 },
            new double[] { 0,-0.05,-0.01 },
            new double[] { 0,-0.02, 0 },
            new double[] { 0,0.04, 0 },
            new double[] { 0,0.01, 0.05 },
            new double[] { 0,0.15,-0.05 },
            new double[] { 0,-0.05, 0 },
            new double[] { 0,-0.1, 0 },
            new double[] { 0,-0.15, 0 },
            new double[] { 0,-0.05, 0 },
            new double[] { 0,-0.1, 0 },
            new double[] { 0,-0.15, 0 },
            new double[] { 0,-0.02, 0 },
            new double[] { 0,-0.07, 0 },
            new double[] { 0,-0.13, 0 },
            new double[] { 0,-0.02, 0 },
            new double[] { 0,-0.07, 0 },
            new double[] { 0,-0.13, 0 },
            new double[] { 0,0,-0.02 },
            new double[] { 0,0,-0.05 },
            new double[] { 0,0,-0.08 },
            new double[] { 0,-0.05,-0.08 },
            new double[] { 0,-0.1,-0.1 },
            new double[] { 0.001,0,-0.02 },
            new double[] { 0,0,-0.05 },
            new double[] { 0,0,-0.08 },
            new double[] { 0,0,-0.09 },
            new double[] { 0,0,-0.06 },
            new double[] { 0,0.1, 0 },
            new double[] { 0,0.05,-0.05 },
            new double[] { 0,0, 0 },
            new double[] { 0,0, 0 },
            new double[] { 0,0.1, 0.02 },
            new double[] { 0,0.15, 0.1 },
            new double[] { 0,-0.05, 0 },
            new double[] { 0,-0.05,-0.01 },
            new double[] { 0,0.05, 0 },
            new double[] { 0,0.02, 0.03 },
            new double[] { 0.01,0.06, 0.01 },
            new double[] { 0.02,0.05, 0 },
            new double[] { 0,0.06, 0 },
            new double[] { 0,0.08, 0 },
            new double[] { 0,0.1, 0 },
            new double[] { 0,0.03, 0 },
            new double[] { 0,0.06, 0.06 },
            new double[] { 0,0.08, 0.08 },
            new double[] { 0,0.01, 0 },
            new double[] { 0,0.09, 0.03 },
            new double[] { 0,-0.02, 0 },
            new double[] { 0,0.04, 0 },
            new double[] { 0,0.1, 0.05 },
            new double[] { 0,-0.06, 0 },
            new double[] { 0,-0.09, 0 },
            new double[] { 0,0.07, 0 },
            new double[] { 0,0.08,-0.01 },
            new double[] { 0,0.01, 0 },
            new double[] { 0,-0.02, 0 },
            new double[] { 0,0.05, 0 },
            new double[] { 0,0.2, 0 },
            new double[] { 0,0.25, 0 },
            new double[] { 0,0.02, 0 },
            new double[] { 0,0,-0.01 }
        };
    }
}
