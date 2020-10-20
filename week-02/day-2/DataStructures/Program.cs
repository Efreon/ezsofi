using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            TelephoneBook();
        }

        //// STRINGS ////
        // Exercise 1 - SimpleReplace //
        public static void SimpleReplace()
        {
            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away
            string example = "In a dishwasher far far away";
            Console.WriteLine(example.Replace("dishwasher", "galaxy"));
        }

        // Exercise 2 - UrlFixer //
        public static void UrlFixer()
        {
            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!
            string url = "https//www.reddit.com/r/nevertellmethebots";
            string urlReplace = url.Replace("bots", "odds");
            StringBuilder urlCorrect = new StringBuilder();
            urlCorrect.Append(urlReplace.Substring(0, 5));
            urlCorrect.Append(":");
            urlCorrect.Append(urlReplace.Substring(5, (urlReplace.Length) - 5));
            Console.WriteLine(urlCorrect);
        }

        // Exercise 3 - TakesLonger //
        public static void TakesLonger()
        {
            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            StringBuilder quoteBuilder = new StringBuilder();
            quoteBuilder.Append(quote.Substring(0, 21));
            quoteBuilder.Append("always takes longer than");
            quoteBuilder.Append(" ");
            quoteBuilder.Append(quote.Substring(21, (quote.Length) - 21));
            Console.WriteLine(quoteBuilder);
        }

        // Exercise 4 - ToDoPrint //
        public static void ToDoPrint()
        {
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation
            // Expected output:
            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo
            string todoText = " - Buy milk\n";
            var indentAmount = 4;
            var indent = new string(' ', indentAmount);
            StringBuilder myToDo = new StringBuilder();
            myToDo.Append("My todo:");
            myToDo.Append("\n");
            myToDo.Append(todoText);
            myToDo.Append(" - Download games");
            myToDo.Append("\n");
            myToDo.Append(indent);
            myToDo.Append(" - Diablo");
            Console.WriteLine(myToDo);
        }

        // Exercise 5 - Reverse //
        public static void Reverse()
        {
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            string reversedString = "";
            int length = toBeReversed.Length - 1;

            for (int i = toBeReversed.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + toBeReversed[i];
            }
            Console.WriteLine(reversedString);

        }

        //// DATA STRUCTURES ////
        // Exercise 6 - List Introduction 1 //
        public static void ListIntro1()
        {
            // Create an empty list which will contain names(strings)
            List<string> names = new List<string>();
            // Print out the number of elements in the list
            Console.WriteLine(names.Count);
            // Add William to the list
            names.Add("William");
            // Print out whether the list is empty or not
            names.Any();
            Console.WriteLine(names.Count);
            // Add John to the list
            // Add Amanda to the list
            var namesAdd = new string[] { "John", "Amanda" };
            names.AddRange(namesAdd);
            // Print out the number of elements in the list
            Console.WriteLine(names.Count);
            // Print out the 3rd element
            Console.WriteLine(names[2]);
            //Iterate through the list and print out each name
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            // Iterate through the list and print
            for (int i = 0; i <= (names.Count) - 1; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }
            //Remove the 2nd element
            names.RemoveAt(1);
            //Iterate through the list in a reversed order and print out each name
            for (int i = (names.Count) - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            //Remove all elements
            names.RemoveRange(0, names.Count);
        }

        // Exercise 7 - Map Introduction 1 //
        public static void MapIntro1()
        {
            //Create an empty map where the keys are integers and the values are characters
            Dictionary<int, char> map = new Dictionary<int, char>();
            // Print out whether the map is empty or not
            Console.WriteLine(map.Count);
            // Add the following key-value pairs to the map
            int[] keys = new int[] { 97, 98, 99, 65, 66, 67 };
            char[] values = new char[] { 'a', 'b', 'c', 'A', 'B', 'C' };
            for (int i = 0; i <= (keys.Length) - 1; i++)
            {
                map.Add(keys[i], values[i]);
            }
            //Print all the keys
            foreach (KeyValuePair<int, char> kvp in map)
            {
                Console.WriteLine(kvp.Key);
            }
            // Print all the values
            foreach (KeyValuePair<int, char> kvp in map)
            {
                Console.WriteLine(kvp.Value);
            }
            foreach (KeyValuePair<int, char> kvp in map)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            // Add value D with the key 68
            map.Add(68, 'D');
            // Print how many key-value pairs are in the map
            Console.WriteLine(map.Count);
            // Print the value that is associated with key 99
            Console.WriteLine(map[99]);
            // Remove the key-value pair where with key 97
            map.Remove(97);
            // Print whether there is an associated value with key 100 or not
            if (!map.ContainsKey(100))
            {
                Console.WriteLine(false);
            }
            // Remove all the key-value pairs
            map.Clear();
        }

        // Exercise 8 - List Introduction 2 // 
        public static void ListIntro2()
        {
            // Create a list('List A') which contains the following values
            string[] listElements = { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> listA = new List<string>(listElements);
            // Create a new list ('List B') with the values of List A
            List<string> listB = new List<string>(listA);
            // Print out whether List A contains Durian or not
            Console.WriteLine(listA.Contains("Durian"));
            // Remove Durian from List B
            // listB.Remove("Durian");
            List<string> listBRemoved = new List<string>();
            for (int i = 0; i <= (listB.Count) - 1; i++)
            {
                if (listB[i] != "Durian")
                {
                    listBRemoved.Add(listB[i]);
                }
            }
            // Add Kiwifruit to List A after the 4th element
            listB.Add("Kiwifruit");
            // Compare the size of List A and List B
            int listASize = listA.Count;
            int listBSize = listB.Count;
            Console.WriteLine($"List A has {listASize} and List B has {listBSize} items");
            if (listA.Count > listB.Count)
            {
                Console.WriteLine("List A has more item");
            }
            else if (listA.Count == listB.Count)
            {
                Console.WriteLine("List A has the same amount of items as List B");
            }
            else
            {
                Console.WriteLine("List B has more item");
            }
            // Get the index of Avocado from List A
            for (int i = 0; i <= (listA.Count - 1); i++)
            {
                if (listA[i].Equals("Avocado"))
                {
                    Console.WriteLine(i);
                }
            }
            // Get the index of Durian from List B
            for (int i = 0; i <= (listB.Count - 1); i++)
            {
                if (listB[i].Equals("Durian"))
                {
                    Console.WriteLine(i);
                }
            }
            // Add Passion Fruit and Pomelo to List B in a single statement
            listB.AddRange(new string[] { "Passion Fruit", "Pomelo" });
            // Print out the 3rd element from List A
            Console.WriteLine(listA[2]);
        }

        // Exercise 9 - Map Introduction 2 //
        public static void MapIntro2()
        {
            // Create a map where the keys are strings and the values are strings 
            // with the following initial values
            Dictionary<string, string> mapTwo = new Dictionary<string, string>();
            string[] key = new string[] { "978-1-60309-452-8", "978-1-60309-459-7", "978-1-60309-444-3", "978-1-60309-461-0" };
            string[] value = new string[] { "A Letter to Jo", "Lupus", "Red Panda and Moon Bear", "The Lab" };
            for (int i = 0; i <= (key.Length) - 1; i++)
            {
                mapTwo.Add(key[i], value[i]);
            }
            // Print all the key-value pairs in the following format
            foreach (KeyValuePair<string, string> kvp in mapTwo)
            {
                Console.WriteLine($"{kvp.Value} (ISBN: {kvp.Key})");
            }
            // Remove the key-value pair with key 978-1-60309-444-3
            mapTwo.Remove("978-1-60309-444-3");
            // Remove the key-value pair with value The Lab
            foreach (var item in mapTwo.Where(kvp => kvp.Value == "The Lab").ToList())
            {
                mapTwo.Remove(item.Key);
            }
            // Add the following key-value pairs to the map
            mapTwo.Add("978-1-60309-450-4", "They Called Us Enemy");
            mapTwo.Add("978-1-60309-453-5", "Why Did We Trust Him?");
            // Print whether there is an associated value with key 478-0-61159-424-8 or not
            if (!mapTwo.ContainsKey("478 - 0 - 61159 - 424 - 8"))
            {
                Console.WriteLine(false);
            }
            // Print the value associated with key 978-1-60309-453-5
            Console.WriteLine(mapTwo["978-1-60309-453-5"]);
        }

        // Exercise 10 - Personal Finance //
        public static void PersonalFinance()
        {
            // Create a list with the following items.
            // 500, 1000, 1250, 175, 800 and 120
            int[] spend = { 500, 1000, 1250, 175, 800, 120 };
            List<int> myExpenses = new List<int>(spend);
            // How much did we spend?
            int totalSpend = 0;
            for (int i = 0; i <= myExpenses.Count - 1; i++)
            {
                totalSpend += myExpenses[i];
            }
            Console.WriteLine($"I spent {totalSpend} money.");
            // Which was our greatest expense?
            int highestExpense = 0;
            for (int i = 0; i <= myExpenses.Count - 1; i++)
            {
                if (highestExpense <= myExpenses[i])
                {
                    highestExpense = myExpenses[i];
                }
            }
            Console.WriteLine($"My greatest expense was {highestExpense}");
            // Which was our cheapest spending?
            int cheapestExpense = 0;
            for (int i = 0; i <= myExpenses.Count - 1; i++)
            {
                if (i == 0)
                {
                    cheapestExpense = myExpenses[i];
                }
                else if (i > 0 && myExpenses[i] <= cheapestExpense)
                {
                    cheapestExpense = myExpenses[i];
                }
            }
            Console.WriteLine($"My cheapest expense was {cheapestExpense}");
            // What was the average amount of our spendings?
            int avgSpending = 0;
            int totalSpending = 0;

            for (int i = 0; i <= myExpenses.Count - 1; i++)
            {
                totalSpending += myExpenses[i];
                avgSpending = totalSpending / myExpenses.Count;
            }
            Console.WriteLine($"My average spending was {avgSpending}.");
        }

        // Exercise 11 - Telephone Book //
        public static void TelephoneBook()
        {
            // Create a map with the following key-value pairs.
            Dictionary<string, string> telephoneBook = new Dictionary<string, string>();
            string[] name = new string[] { "William A. Lathan", "John K. Miller", "Hortensia E. Foster", "Amanda D. Newland", "Brooke P. Askew" };
            string[] phoneNumber = new string[] { "405-709-1865", "402-247-8568", "606-481-6467", "319-243-5613", "307-687-2982" };
            for (int i = 0; i <= name.Length - 1; i++)
            {
                telephoneBook.Add(name[i], phoneNumber[i]);
            }
            // Create an application which solves the following problems.
            //What is John K. Miller's phone number?
            Console.WriteLine($"John K. Miller's phone number is: {telephoneBook["John K. Miller"]}");
            // Whose phone number is 307 - 687 - 2982 ?
            foreach(KeyValuePair<string, string> kvp in telephoneBook)
            {   
                if (kvp.Value == "307-687-2982")
                {
                    Console.WriteLine($"307-687-2982 is {kvp.Key}'s phone number");
                }
            }
            // Do we know Chris E.Myers' phone number?
            Console.WriteLine(telephoneBook.ContainsKey("Chris E.Myers"));
        }

    }
}
