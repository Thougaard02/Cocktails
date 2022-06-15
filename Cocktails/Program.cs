using Cocktails.Business_Logic;
using Cocktails.Models;
using Cocktails.Models.DBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncomment the below to initializate objects
            //InitializationOfObjects initializationOfObjects = new InitializationOfObjects();
            //initializationOfObjects.RunInInitializationOfObjects();
            
            CocktailManager cocktailManager = new CocktailManager();
            //Search for cocktail by cocktail name

            CocktailController cocktailController = new CocktailController(cocktailManager);
            //Console.WriteLine(cocktailController.GetCocktail("Mai tai"));
            
            Console.WriteLine("Insert cocktail");
            string cocktailName = Console.ReadLine();
            
            Console.WriteLine("Insert liquid name");
            string liquidName = Console.ReadLine();

            Console.WriteLine("Insert liquid amount");
            int liquidAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert liquid unit");
            string liquidUnit = Console.ReadLine();
            Unit liquidUnitType = new Unit() { UnitType = liquidUnit };

            //Adds inserted infomation into liquids
            List<Liquid> liquids = new List<Liquid>();
            liquids.Add(new Liquid(liquidName, liquidAmount, liquidUnitType));

            Console.WriteLine("Insert addition name");
            string additionName = Console.ReadLine();

            Console.WriteLine("Insert liquid amount");
            int additionAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert addition unit");
            string additionUnit = Console.ReadLine();
            Unit additionUnitType = new Unit() { UnitType = additionUnit };

            //Adds inserted infomation into additions
            List<Addition> additions = new List<Addition>();
            additions.Add(new Addition(additionName, additionAmount, additionUnitType));

            cocktailController.CreateCocktail(cocktailName, liquids, additions);
        }
    }
}
