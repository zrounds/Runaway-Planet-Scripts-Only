using UnityEngine;
using System.Collections;

public class BaseIndia : BaseCountry {

	public BaseIndia(){
		CountryName = "India";
        TotalScore = 0; 
        Population = 1251695584;
        IniitalPopulation = 1251695584;
		GrowthRate = 1.2;
		GDP = 2048517438874;
		EnergyDemand = 931261514496;
		EnergyPerCapita = 744;
		EnergyProduction = 1118060017109;
		PerCoal = 72;
		PerGas = 8;
		PerNuclear = 3;
        PerChangeGDP = 0;
        PerChangePop = 0;
        PerChangeCO2 = 0;
        PerWind = 3;
		PerHydro = 12;
		PerSolar = 3;
        InitialGDP = 2048517438874;
        InitialCO2Emissions = 709548838357799;
        CO2Emissions = 709548838357799;
        Industry = "Agriculture: 16.1%, Industry: 29.5%, Services: 54.4%";
        Exports = "Gems, precious metals, oil, vehciles, machines, engines";
        WorldHappRank = 118;

        decisionEffectsInt = new int[][]{
            new int[] { 0,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 22,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 30,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 25,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 40,0,0,0,0,0,0 },
            new int[] { -20,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 100,0,0,0,0,0,0 },
            new int[] { 0,-1,-1,-1,-1,5,-1 },
            new int[] { 0,-2,-2,-2,-2,10,-2 },
            new int[] { 0,-3,-3,-3,-3,15,-3 },
            new int[] { 0,-1,-1,-1,-1,-1,5 },
            new int[] { 0,-2,-2,-2,-2,-2,10 },
            new int[] { 0,-3,-3,-3,-3,-3,15 },
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
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { 37,0,0,0,0,0, 0 },
            new int[] { 5,0,0,0,0,0, 0 },
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { 100,0,0,0,0,0, 0 },
            new int[] { 20,0,0,0,0,0, 0 },
            new int[] { 50,0,0,0,0,0, 0 },
            new int[] { 5,0,0,0,0,0, 0 },
            new int[] { 10,0,0,0,0,0, 0 },
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { 8,0,0,0,0,0, 0 },
            new int[] { 25,0,0,0,0,0, 0 },
            new int[] { 35,0,0,0,0,0, 0 },
            new int[] { 12,0,0,0,0,0, 0 },
            new int[] { 14,0,0,0,0,0, 0 },
            new int[] { 16,0,0,0,0,0, 0 },
            new int[] { 5,0,0,0,0,0, 0 },
            new int[] { 8,0,0,0,0,0, 0 },
            new int[] { 10,0,0,0,0,0, 0 },
            new int[] { 20,0,0,0,0,0, 0 },
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { -5,0,0,0,0,0, 0 },
            new int[] { 10,0,0,0,0,0, 0 },
            new int[] { 30,0,0,0,0,0, 0 },
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { 15,0,0,0,0,0, 0 },
            new int[] { 5,0,0,0,0,0, 0 },
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { 0,0,0,0,0,0, 0 },
            new int[] { 8,0,0,0,0,0, 0 },
            new int[] { 50,0,0,0,0,0, 0 },
            new int[] { 80,0,0,0,0,0, 0 },
            new int[] { 6,0,0,0,0,0, 0 },
            new int[] { 15,0,0,0,0,0,0 }
        };

        decisionEffectsDouble = new double[][]{
            new double[] { 0,0,0 },
            new double[] { 0,-0.05,0 },
            new double[] { 0,0,-0.02 },
            new double[] { 0,0,0 },
            new double[] { 0,0.01,-0.02 },
            new double[] { 0,0.02,0 },
            new double[] { 0,0,-0.02 },
            new double[] { -0.02,0,0 },
            new double[] { 0,-0.05,0 },
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
            new double[] { -0.1,0, 0 },
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