using UnityEngine;
using System.Collections;

public class BaseRussia : BaseCountry {

	public BaseRussia(){
		CountryName = "Russia";
        TotalScore = 0;
		Population = 142423773;
        IniitalPopulation = 142423773;
        GrowthRate = 0.2;
		GDP = 1860597922763;
		EnergyDemand = 942418105941;
		EnergyPerCapita = 6617;
		EnergyProduction = 986099982023;
		PerCoal = 14;
        PerChangeGDP = 0;
        PerChangePop = 0;
        PerChangeCO2 = 0;
        PerGas = 52;
		PerNuclear = 17;
		PerWind = 0;
		PerHydro = 17;
		PerSolar = 0;
        InitialGDP = 1860597922763;
        InitialCO2Emissions = 370497485245682;
        CO2Emissions = 370497485245682;
        Industry = "Agriculture: 4.4%, Industry: 35.8%, Services: 59.7%";
        Exports = "Oil, iron, steel, fertilizers, machines, enginers";
        WorldHappRank = 56;

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
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 25,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { -10,0,0,0,0,0,0 },
            new int[] { 30,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 30,0,0,0,0,0,0 },
            new int[] { 30,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 100,0,0,0,0,0,0 },
            new int[] { 0,-1,-1,-1,-1,5,-1 },
            new int[] { 0,-2,-2,-2,-2,10,-2 },
            new int[] { 0,-3,-3,-3,-3,15,-3 },
            new int[] { 0,-1,-1,-1,5,-1,-1 },
            new int[] { 0,-2,-2,-2,10,-2,-2 },
            new int[] { 0,-3,-3,-3,15,-3,-3 },
            new int[] { 0,-1,5,-1,-1,-1,-1 },
            new int[] { 0,-2,10,-2,-2,-2,-2 },
            new int[] { 0,-3,15,-3,-3,-3,-3 },
            new int[] { 0,5,-1,-1,-1,-1,-1 },
            new int[] { 0,10,-2,-2,-2,-2,-2 },
            new int[] { 0,15,-3,-3,-3,-3,-3 },
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
            new double[] { 0,-0.03,0 },
            new double[] { 0,0,0 },
            new double[] { 0,-0.07,0 },
            new double[] { 0,-0.02,0 },
            new double[] { 0,0.01,-0.01 },
            new double[] { -0.1,0,0 },
            new double[] { 0.05,-0.04,0 },
            new double[] { 0,0,0 },
            new double[] { 0,-0.05,-0.01 },
            new double[] { 0,-0.02,0 },
            new double[] { 0,0.04,0 },
            new double[] { 0,0.01,0.05 },
            new double[] { 0,0.15,-0.05 },
            new double[] { 0,-0.05,0 },
            new double[] { 0,-0.1,0 },
            new double[] { 0,-0.15,0 },
            new double[] { 0,-0.05,0 },
            new double[] { 0,-0.1,0 },
            new double[] { 0,-0.15,0 },
            new double[] { 0,-0.02,0 },
            new double[] { 0,-0.07,0 },
            new double[] { 0,-0.13,0 },
            new double[] { 0,-0.02,0 },
            new double[] { 0,-0.07,0 },
            new double[] { 0,-0.13,0 },
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
            new double[] { 0,0.1,0 },
            new double[] { 0,0.05,-0.05 },
            new double[] { 0,0,0 },
            new double[] { 0,0,0 },
            new double[] { 0,0.1,0.02 },
            new double[] { 0,0.15,0.1 },
            new double[] { 0,-0.05,0 },
            new double[] { 0,-0.05,-0.01 },
            new double[] { 0,0.05,0 },
            new double[] { 0,0.02,0.03 },
            new double[] { 0.01,0.06,0.01 },
            new double[] { 0.02,0.05,0 },
            new double[] { 0,0.06,0 },
            new double[] { 0,0.08,0 },
            new double[] { 0,0.1,0 },
            new double[] { 0,0.03,0 },
            new double[] { 0,0.06,0.06 },
            new double[] { 0,0.08,0.08 },
            new double[] { 0,0.01,0 },
            new double[] { 0,0.09,0.03 },
            new double[] { 0,-0.02,0 },
            new double[] { 0,0.04,0 },
            new double[] { 0,0.1,0.05 },
            new double[] { 0,-0.06,0 },
            new double[] { 0,-0.09,0 },
            new double[] { 0,0.07,0 },
            new double[] { 0,0.08,-0.01 },
            new double[] { 0,0.01,0 },
            new double[] { 0,-0.02,0 },
            new double[] { 0,0.05,0 },
            new double[] { 0,0.2,0 },
            new double[] { 0,0.25,0 },
            new double[] { 0,0.02,0 },
            new double[] { 0,0,-0.01 }
        };
    }
}
