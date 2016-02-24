using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //FoodMenu summerMenu = new FoodMenu();
            //summerMenu.Name = "Summer Menu";

            //summerMenu.AddMenuItem("Salmon", "Fresh Norwegian salmon with Sandefjord butter", 25.50);
            //summerMenu.AddMenuItem("Taco", "All Norwegians eat taco on Fridays", 10);
            //summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask for Dr.Jones";

            //DrinkMenu outsideDrinks = new DrinkMenu();
            //outsideDrinks.AddMenuItem("Virgin Cuba Libre","A classic",10);
            //outsideDrinks.AddMenuItem("Screwdriver", "Gets you hammered", 15);
            //outsideDrinks.Disclaimer = "Do not drink and code";

            List<Menu> menusFromDatabase = Menu.GetAllMenus();
            Menu firstMenu = menusFromDatabase[0];

            firstMenu.SaveNewMenuItem("Smorgas", "A classic Nordic dish", 10);
            menusFromDatabase = Menu.GetAllMenus();

            Order hungryguestOrder = new Order();


            foreach (Menu currentMenu in menusFromDatabase)
            {
                foreach (MenuItem currentItem in currentMenu.items)
                {
                    hungryguestOrder.items.Add(currentItem);
                }
            }
           
            Console.WriteLine("The total price for the order is " + hungryguestOrder.Total);
            Console.ReadKey();
        }
    }
}
