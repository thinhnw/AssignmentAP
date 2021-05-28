﻿using System;
using System.Security.Permissions;

namespace AssignmentAP.AssignmentOne
{
    public class TrendSetting : Clothing
    {
        public TrendSetting()
        {
            materials = new []
            {
                "Cotton Polyester",
                "Rayon",
                "Linen",
                "Satin",
                "Georgette",
                "Moss Crepe",
                "Net",
                "Lace",
                "Jacquard Velvet"
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