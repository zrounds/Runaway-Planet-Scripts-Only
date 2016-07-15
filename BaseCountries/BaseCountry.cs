using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;


public class BaseCountry
{

    public enum PlayerStates
    {
        DECIDING, READY, WAITING
    }
    string countryName;
    double population;
    double initialPopulation;
    long gdp;
    double initialGDP;
    double growthRate;
    int energyPerCapita;
    long energyDemand;
    long energyProduction;
    //do we need energyProd?
    int happiness = 0; 
    int perCoal;
    int perGas;
    int perNuclear;
    int perWind;
    int perHydro;
    int perSolar;
    double co2Emissions;
    double initialco2Emissions;
    string industry;
    string exports;
    int world_happ_rank;
    //Decision State Matrix, note default of bool is false, so array starts as all false 
    protected bool[] decisionState = new bool[83]; //We started numbering from 1, 0 is a dummy entry 
    protected int[][] decisionEffectsInt;
    protected double[][] decisionEffectsDouble;
    double perChangeGDP;
    double perChangePop;
    double perChangeCO2;
    double totalScore;

    public double InitialGDP
    {
        get { return initialGDP; }
        set { initialGDP = value; }
    }

    public int Happiness
    {
        get { return happiness; }
        set { happiness = value; }
    }

    public string Industry
    {
        get { return industry; }
        set { industry = value; }
    }

    public bool[] DecisionState
    {
        get { return decisionState; }
    }

    public int[][] DecisionEffectsInt
    {
        get { return decisionEffectsInt; }
    }

    public double[][] DecisionEffectsDouble
    {
        get { return decisionEffectsDouble; }
    }

    public string CountryName
    {
        get { return countryName; }
        set { countryName = value; }
    }

    public string Exports
    {
        get { return exports; }
        set { exports = value; }
    }

    public void IterateYear()
    {
        Population =  Math.Round(Population * Math.Exp(GrowthRate / 100.0));
        EnergyDemand = (long)Population * EnergyPerCapita;
        CO2Emissions = (((double)PerCoal / 100.0) * (double) EnergyDemand * 820.0) + (((double)PerGas / 100.0) * (double) EnergyDemand * 490.0) + (((double)PerNuclear / 100.0) * (double)EnergyDemand * 12.0) + (((double)PerWind / 100.0) * (double)EnergyDemand * 11.5) + (((double)PerHydro / 100.0) * (double)EnergyDemand * 24.0) + (((double)PerSolar / 100.0) * (double)EnergyDemand * 48.0);
       // PerChangeCO2 = (CO2Emissions - InitialCO2Emissions) / InitialCO2Emissions * 100.0;
        //TODO Add year +1
        //Complete Dummy Line: Population = Population + 300000000;
        //Population = Population * (long)(Math.Exp(growthRate / 100));
        //energyDemand = Population * energyPerCapita;
        //co2Emissions = ((perCoal / 100) * energyProduction * 820) + ((perGas / 100) * energyProduction * 490) + ((perNuclear / 100) * energyProduction * 12) + ((perWind / 100) * energyProduction * 11) + ((perHydro / 100) * energyProduction * 24) + ((perSolar / 100) * energyProduction * 48);
        //ppm = ppm + (co2Emissions/(2.13*Math.Pow(10,15)));
        //temp = temp + (0.01*(co2Emissions/(2.13*Math.Pow(10,15))));
        //seaLevelRise = seaLevelRise + 3.2 * (0.01*(co2Emissions/(2.13*Math.Pow(10,15))));
        //TODO Push to GUI - update labels

    }

    public void Iterate5Years()
    {
        //TODO push to GUI
    }

    public double Population
    {
        get { return population; }
        set { population = value; }
    }

    public double IniitalPopulation
    {
        get { return initialPopulation; }
        set { initialPopulation = value; }
    }

    public long GDP
    {
        get { return gdp; }
        set { gdp = value; }
    }

    public double GrowthRate
    {
        get { return growthRate; }
        set { growthRate = value; }
    }

    public double TotalScore
    {
        get { return totalScore; }
        set { totalScore = value; }
    }

    public double PerChangeGDP
    {
        get { return perChangeGDP; }
        set { perChangeGDP = value; }
    }

    public double PerChangePop
    {
        get { return perChangePop; }
        set { perChangePop = value; }
    }

    public double PerChangeCO2
    {
        get { return perChangeCO2; }
        set { perChangeCO2 = value; }
    }

    public long EnergyDemand
    {
        get { return energyDemand; }
        set { energyDemand = value; }
    }

    public int EnergyPerCapita
    {
        get { return energyPerCapita; }
        set { energyPerCapita = value; }
    }

    public int WorldHappRank
    {
        get { return world_happ_rank; }
        set { world_happ_rank = value; }
    }

    public long EnergyProduction
    {
        get { return energyProduction; }
        set { energyProduction = value; }
    }

    public double CO2Emissions
    {
        get { return co2Emissions; }
        set { co2Emissions = value; }
    }

    public double InitialCO2Emissions
    {
        get { return initialco2Emissions; }
        set { initialco2Emissions = value; }
    }

    public int PerCoal
    {
        get { return perCoal; }
        set { perCoal = value; }
    }

    public int PerGas
    {
        get { return perGas; }
        set { perGas = value; }
    }

    public int PerNuclear
    {
        get { return perNuclear; }
        set { perNuclear = value; }
    }

    public int PerWind
    {
        get { return perWind; }
        set { perWind = value; }
    }

    public int PerHydro
    {
        get { return perHydro; }
        set { perHydro = value; }
    }

    public int PerSolar
    {
        get { return perSolar; }
        set { perSolar = value; }
    }
}
