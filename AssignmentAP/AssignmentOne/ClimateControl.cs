﻿using System;

namespace AssignmentAP.AssignmentOne
{
    public class ClimateControl : Clothing
    {
        public ClimateControl()
        {
            materials = new []
            {
                "Heated Clothing",
                "Wind Resistant Upper Clothing"
            };
            regionsWithMaximumSales = new[]
            {
                "Hanoi",
                "TpHCM"
            };
            regionsWithAvgSales = new[]
            {
                "Bangkok",
                "Phuket"
            };
            regionsWithLowSales = new[]
            {
                "Moscow",
                "Saint Petersburg"
            };
        }

        public override void Sales()
        {
            Console.WriteLine("Regions with maximum sales: " + string.Join(", ", regionsWithMaximumSales));
            Console.WriteLine("Regions with average sales: " + string.Join(", ", regionsWithAvgSales));
            Console.WriteLine("Regions with low sales: " + string.Join(", ", regionsWithLowSales));
        }

        public override void Materials()
        {
            Console.WriteLine("Using materials: " + string.Join(", ", materials));
        }

        public override void CommonWear()
        {
            Console.WriteLine("Common wear: skirts, trousers, jackets, blouses, tops, dresses, shirts.");
        }
    }
}