using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace HelloWorld{

    public class Program 
    {
        public static void Main(string[] args)
        {    
           
            var ime = "Ivan";
            var prezime = "Posavac";

            Console.WriteLine("Ime: {0} Prezime: {1} ", ime, prezime);

            string[] myGuacamoleArray = new string[2];

            myGuacamoleArray[0] = "Guacamole";
            myGuacamoleArray[1] = "Siracha";

            Console.WriteLine( myGuacamoleArray[0]);
            Console.WriteLine( myGuacamoleArray[1]);

            string[] mySecondroceryArayy = {"Apples", "eggs" };

            Console.WriteLine(mySecondroceryArayy[0]);
            Console.WriteLine(mySecondroceryArayy[1]);

            List<string> myGroceryList = new List<string>() {"Milk", "Chease" };

            Console.WriteLine(myGroceryList[0]);
            Console.WriteLine(myGroceryList[1]);   
            
            myGroceryList.Add("Oranges");

            // Console.WriteLine(myGroceryList[2]);

            IEnumerable<string> myGroceryIEnumberable = myGroceryList;
            Console.WriteLine(myGroceryIEnumberable.First());
            string[,] myTwoDimensionalArray = new string[,] {
                {"apples", "Eggs"}, 
                {"Milk", "Chease" }
            };

            Console.WriteLine(myTwoDimensionalArray[1,1]);
            

            Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string> {
                {"Cheese", "Dairy"}
            };

            Console.WriteLine(myGroceryDictionary["Cheese"]);
            System.Console.WriteLine();
        }
    }
}

