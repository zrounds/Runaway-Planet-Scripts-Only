using UnityEngine;
using System.Collections;

public class BaseBrazil : BaseCountry {

	public BaseBrazil(){
		CountryName = "Brazil";
		Population = 204259812;
        IniitalPopulation = 204259812;
        GrowthRate = 0.9;
		GDP = 2346076315119;
        TotalScore = 0;
        EnergyDemand = 502887657144;
		EnergyPerCapita = 2462;
		EnergyProduction = 22432589911591;
		PerCoal = 0;
		PerGas = 20;
		PerNuclear = 3;
		PerWind = 0;
        PerChangeGDP = 0;
        PerChangePop = 0;
        PerChangeCO2 = 0;
        PerHydro = 72;
		PerSolar = 5;
        InitialGDP = 2346076315119;
        InitialCO2Emissions = 264794291364200;
        CO2Emissions = 264794291364200;
        Industry = "Agriculture: 5.9%, Industry: 22.2%, Services: 71.9%";
        Exports = "Oils, ores, slag, ash, oil, meat, machines";
        WorldHappRank = 17;

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
            new int[] { 40,0,0,0,0,0,0 },
            new int[] { 50,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 30,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 25,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 25,0,0,0,0,0,0 },
            new int[] { 5,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 10,0,0,0,0,0,0 },
            new int[] { 15,0,0,0,0,0,0 },
            new int[] { 20,0,0,0,0,0,0 },
            new int[] { 35,0,0,0,0,0,0 },
            new int[] { 100,0,0,0,0,0,0 },
            new int[] { 0,-1,-1,-1,-1,5,-1 },
            new int[] { 0,-2,-2,-2,-2,10,-2 },
            new int[] { 0,-3,-3,-3,-3,15,-3 },
            new int[] { 0,-1,-1,-1,-1,-1,5 },
            new int[] { 0,-2,-2,-2,-2,-2,10 },
            new int[] { 0,-3,-3,-3,-3,-3,15 },
            new int[] { 0,-1,5,-1,-1,-1,-1 },
            new int[] { 0,-2,10,-2,-2,-2,-2 },
            new int[] { 0,-3,15,-3,-3,-3,-3 },
            new int[] { 0,-1,-1,5,-1,-1,-1 },
            new int[] { 0,-2,-2,10,-2,-2,-2 },
            new int[] { 0,-3,-3,15,-3,-3,-3 },
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
            new double[] { 0,-0.01,-0.05 },
            new double[] { 0,0,-0.05 },
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
