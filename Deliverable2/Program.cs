namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There, Welcome Bob's Burger's emporium. The buffet is all you can eat for $9.99! We only charge extra for surge.");

            int totalSurge = 0;
            int totalWater = 0;
            decimal buffet = 9.99m;
            decimal drinkCost = 2.00m;
            decimal buffetCost = 0;
            decimal totalBill = 0;
            decimal totalDrinkCost = 0;

            Console.WriteLine("How many people will be in your group today? Please, parties of 6 or lower.");

            string group = Console.ReadLine();
            int partySize = Convert.ToInt32(group);

            if (partySize < 1 || partySize > 6)
            {
                Console.WriteLine("Sorry, we can only seat parties up to 6. Have a nice day.");
            }
            else
            {
                Console.WriteLine($"A table for {partySize}! Please follow me and take a seat. Can I take everyone's drink order? We have water or surge");

                for (int i = 1; i <= partySize; i++)
                {
                    Console.WriteLine($"Person number {i}, water or surge?");
                    string drink = Console.ReadLine();

                    if (drink == "surge")
                    {
                        Console.WriteLine($"{drink}. Great choice");
                        totalSurge++;
                    }
                    else if (drink == "water")
                    {
                        Console.WriteLine($"{drink}. Fantastic choice");
                        totalWater++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, we do not carry {drink}.");
                    }
                }

                totalDrinkCost = totalSurge * drinkCost;
                buffetCost = partySize * buffet;
                totalBill = buffetCost + totalDrinkCost;
                string water;
                string surge;

                if (totalWater <= 1)
                {
                    water = "water";
                }
                else
                {
                    water = "waters";
                }

                if (totalSurge <= 1)
                {
                    surge = "surge";
                }
                else
                {
                    surge = "surges";
                }

                Console.WriteLine($"Okay, so that's {totalWater} {water} and {totalSurge} {surge} . I will be right back. Feel free to grab your food! Your total bill is ${totalBill}");

            }
        }
    }
}

            
