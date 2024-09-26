namespace Topic_5__Assignment_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/26/24
            double earthWeight, marsWeight, jupiterWeight, saturnWeight, uranusWeight, neptuneWeight, venusWeight;
            string choise;
            Console.WriteLine("What is your weight on Earth in lbs?");
            double.TryParse(Console.ReadLine(), out earthWeight);

            venusWeight = (earthWeight * 0.78);
            marsWeight = (earthWeight * 0.39);
            jupiterWeight = (earthWeight * 2.65);
            saturnWeight = (earthWeight * 1.17);
            uranusWeight = (earthWeight * 1.05);
            neptuneWeight = (earthWeight * 1.23);

            Console.WriteLine();
            Console.WriteLine("What planet do you wish to go to?");
            Console.WriteLine();
            Console.WriteLine("1. Venus\t2. Mars  \t3. Jupiter");
            Console.WriteLine("4. Saturn\t5. Uranus\t6. Neptune");
            Console.WriteLine();
            Console.WriteLine("Please input your choise as a number:");
            choise = Console.ReadLine();

            if (choise == "1")
                Console.WriteLine("You weigh " + venusWeight + "lbs on Venus");
            else if (choise == "2")
                Console.WriteLine("You weigh " + marsWeight + "lbs on Mars");
            else if (choise == "3")
                Console.WriteLine("You weigh " + jupiterWeight + "lbs on Jupiter");
            else if (choise == "4")
                Console.WriteLine("You weigh " + saturnWeight + "lbs on Saturn");
            else if (choise == "5")
                Console.WriteLine("You weigh " + uranusWeight + "lbs on Uranus");
            else if (choise == "6")
                Console.WriteLine("You weigh " + neptuneWeight + "lbs on Neptune");
            else
                Console.WriteLine("Invalid option. Please input one of the Valid Number Options.");




        }
    }
}
