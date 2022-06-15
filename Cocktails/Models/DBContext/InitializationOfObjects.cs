using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cocktails.Models.DBContext
{
    public class InitializationOfObjects
    {
        private void InitializationOfUnits()
        {
            using (var con = new Context())
            {
                var mLUnit = new Unit() { UnitType = "mL" };
                con.Units.Add(mLUnit);

                var tspUnit = new Unit() { UnitType = "tsp" };
                con.Units.Add(tspUnit);

                var stkUnit = new Unit() { UnitType = "stk" };
                con.Units.Add(stkUnit);
                con.SaveChanges();
            }
        }

        private void InitializationOfLiquids()
        {
            using (var con = new Context())
            {
                var limeJuice60mL = new Liquid()
                {
                    LiquidName = "Lime Juice",
                    Amount = 60,
                    //I am selecting unittype with "ml". The reason why i use first is the unittype cannot be null.
                    UnitType = con.Units.First(x => x.UnitType == "mL")
                };
                var limeJuice10mL = new Liquid()
                {
                    LiquidName = "Lime Juice",
                    Amount = 10,
                    UnitType = con.Units.First(x => x.UnitType == "mL")
                };
                var tripleSec = new Liquid()
                {
                    LiquidName = "Triple Sec",
                    Amount = 30,
                    UnitType = con.Units.First(x => x.UnitType == "mL")
                };
                var tequila = new Liquid()
                {
                    LiquidName = "Tequila",
                    Amount = 60,
                    UnitType = con.Units.First(x => x.UnitType == "mL")
                };

                var darkRum = new Liquid()
                {
                    LiquidName = "Dark Rum",
                    Amount = 50,
                    UnitType = con.Units.First(x => x.UnitType == "mL")
                };

                var orangeCuracao = new Liquid()
                {
                    LiquidName = "Orange Curacao",
                    Amount = 15,
                    UnitType = con.Units.First(x => x.UnitType == "mL")
                };

                var almondSyrup = new Liquid()
                {
                    LiquidName = "Almond Syrup",
                    Amount = 60,
                    UnitType = con.Units.First(x => x.UnitType == "mL")
                };

                con.Liquids.Add(limeJuice60mL);
                con.Liquids.Add(limeJuice10mL);
                con.Liquids.Add(tripleSec);
                con.Liquids.Add(tequila);
                con.Liquids.Add(darkRum);
                con.Liquids.Add(orangeCuracao);
                con.Liquids.Add(almondSyrup);
                con.SaveChanges();
            }
        }

        private void InitializationOfAdditions()
        {
            using (var con = new Context())
            {
                var saltRim = new Addition()
                {
                    AdditionName = "Salt Rim",
                    Amount = 0,
                    UnitType = null
                };
                var crushedIce = new Addition()
                {
                    AdditionName = "Crushed Ice",
                    Amount = 1,
                    //I am selecting unittype with "stk". The reason why i use first is the unittype cannot be null.
                    UnitType = con.Units.First(x => x.UnitType == "stk")
                };
                var limeSegment = new Addition()
                {
                    AdditionName = "Lime Segment",
                    Amount = 1,
                    UnitType = con.Units.First(x => x.UnitType == "stk")
                };

                var limeSection = new Addition()
                {
                    AdditionName = "Lime Section",
                    Amount = 1,
                    UnitType = con.Units.First(x => x.UnitType == "stk")
                };

                var maraschinoCherry = new Addition()
                {
                    AdditionName = "Maraschino Cherry",
                    Amount = 1,
                    UnitType = con.Units.First(x => x.UnitType == "stk")
                };

                con.Additions.Add(saltRim);
                con.Additions.Add(crushedIce);
                con.Additions.Add(limeSegment);
                con.Additions.Add(limeSection);
                con.Additions.Add(maraschinoCherry);
                con.SaveChanges();
            }
        }

        private void InitializationOfCocktail()
        {
            using (var con = new Context())
            {
                var margarita = new Cocktail()
                {
                    CocktailName = "Margarita",
                    Liquids = new List<Liquid>()
                    {
                        //Gets addition name, amount and unittype
                        con.Liquids.First(x => x.LiquidName == "Lime Juice" && x.Amount == 60 && x.UnitType.UnitType == "mL"),
                        con.Liquids.First(x => x.LiquidName == "Triple Sec" && x.Amount == 30 && x.UnitType.UnitType == "mL"),
                        con.Liquids.First(x => x.LiquidName == "Tequila" && x.Amount == 60 && x.UnitType.UnitType == "mL"),
                    },
                    Additions = new List<Addition>()
                    {
                        //Gets addidtion name.
                        con.Additions.First(x => x.AdditionName == "Lime Section"),
                        con.Additions.First(x => x.AdditionName == "Salt Rim"),
                        con.Additions.First(x => x.AdditionName == "Crushed Ice"),
                    }
                };

                var maitai = new Cocktail()
                {
                    CocktailName = "Mai tai",
                    Liquids = new List<Liquid>()
                    {
                        //Gets addition name, amount and unittype
                        con.Liquids.First(x => x.LiquidName == "Dark Rum" && x.Amount == 50 && x.UnitType.UnitType == "mL"),
                        con.Liquids.First(x => x.LiquidName == "Orange Curacao" && x.Amount == 15 && x.UnitType.UnitType == "mL"),
                        con.Liquids.First(x => x.LiquidName == "Lime Juice" && x.Amount == 10 && x.UnitType.UnitType == "mL"),
                        con.Liquids.First(x => x.LiquidName == "Almond Syrup" && x.Amount == 60 && x.UnitType.UnitType == "mL"),
                    },
                    Additions = new List<Addition>()
                    {
                        //Gets addition name.
                        con.Additions.First(x => x.AdditionName == "Lime Section"),
                        con.Additions.First(x => x.AdditionName == "Maraschino Cherry"),
                        con.Additions.First(x => x.AdditionName == "Lime Segment"),
                    }

                };
                con.Cocktails.Add(margarita);
                con.Cocktails.Add(maitai);
                con.SaveChanges();
            }
        }

        public void RunInInitializationOfObjects()
        {
            InitializationOfUnits();
            InitializationOfLiquids();
            InitializationOfAdditions();
            InitializationOfCocktail();
        }
    }
}
