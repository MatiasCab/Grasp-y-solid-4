//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = ProductManager.GetProduct("Café con leche");
            recipe.AddStep(ProductManager.GetProduct("Café"), 100, EquipmentManager.GetEquipment("Cafetera"), 120);
            recipe.AddStep(ProductManager.GetProduct("Leche"), 200, EquipmentManager.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {
            ProductManager.AddProductToCatalog("Café", 100);
            ProductManager.AddProductToCatalog("Leche", 200);
            ProductManager.AddProductToCatalog("Café con leche", 300);

            EquipmentManager.AddEquipmentToCatalog("Cafetera", 1000);
            EquipmentManager.AddEquipmentToCatalog("Hervidor", 2000);
        }

        

        
    }
}
