
using System.Collections.Generic;
using GuitarApp.model;
using static GuitarApp.model.SeperateEnums;


namespace GuitarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

         
            GuitarSpecs searchSpecs = new GuitarSpecs(
                Builder.Gibson,     
                "Les Paul",       
                GuitarType.Electric, 
                TopWood.Spruce,    
                BackWood.Mahogany,  
                6                    
            );

            List<Guitar> matchingGuitars = inventory.Search(searchSpecs);

      
            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Matching guitars found:");
                foreach (Guitar guitar in matchingGuitars)
                {
                    Console.WriteLine($"Serial Number: {guitar.SerialNumber}, Price: {guitar.Price}");
                }
            }
            else
            {
                Console.WriteLine("No matching guitars found.");
            }
        }

        static void InitializeInventory(Inventory inventory)
        {     
            
            inventory.AddGuitar(new Guitar("1", 15000, new GuitarSpecs(Builder.Gibson, "Les Paul", GuitarType.Electric, TopWood.Spruce, BackWood.Mahogany, 6)));
            inventory.AddGuitar(new Guitar("2", 12000, new GuitarSpecs(Builder.Fender, "Stratocaster", GuitarType.Electric, TopWood.Cedar, BackWood.Maple, 6)));
            inventory.AddGuitar(new Guitar("3", 8000, new GuitarSpecs(Builder.Martin, "D-28", GuitarType.Acoustic, TopWood.Spruce, BackWood.Rosewood, 6)));

        
        }
    }
}