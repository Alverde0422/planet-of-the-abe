using System;
using System.Collections.Generic;
using System.Text;

namespace planet_of_the_abe
{
    public class planter
    {
       List<string> planit = new List<string> { };

        public List<string> GetPlanetNames()
        {

            planit.Add("Merkur");
            planit.Add("Jorden");
            planit.Add("Mars");
            planit.Add("Jupiter");
            planit.Add("Saturn");
            planit.Add("Uranus");
            planit.Add("Neptun");
            planit.Add("Pluto");
            planit.Insert(1, "Venus");
            planit.Remove("Pluto");
            planit.Add("Pluto");

            return planit;
        }
        List<double> planitMeanTemperature = new List<double> { };

        public List<double> GetPlanetMeanTemperature()
        {

            planitMeanTemperature.Add(167);
            planitMeanTemperature.Add(464);
            planitMeanTemperature.Add(15);
            planitMeanTemperature.Add(-65);
            planitMeanTemperature.Add(-110);
            planitMeanTemperature.Add(-140);
            planitMeanTemperature.Add(-195);
            planitMeanTemperature.Add(-200);
            planitMeanTemperature.Add(-225);
            
            return planitMeanTemperature;
        }


    }      
}
