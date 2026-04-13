using System;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        float USDwallet; 
        float SOMwallet;
        float SomToUSD = 84.80f;
        float USDToSom = 0.012f;
        float amount;
        string Chosen;

     Console.WriteLine("Amount of dollars");
        string input = Console.ReadLine();
        if (float.TryParse(input, out USDwallet))
        {

        }
        else 
        { 
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        /*Try to make it easier to read and handle errors*/

     Console.WriteLine("Amount of soms");
        string somInput = Console.ReadLine();
        if (float.TryParse(somInput, out SOMwallet))
        {

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Choose (USD/SOM)");
        Console.Write("1 - USD / 2 - SOM ");
        Chosen = Console.ReadLine();

        switch (Chosen)
        {
            case "1":
                Console.WriteLine("You chose: " + Chosen);
                Console.WriteLine("You have " + USDwallet);
                Console.WriteLine("Choose the option below : ");
                Console.WriteLine("1 - Exchange USD to SOM");
                Console.WriteLine("2 - Exit "); /*System of Back */
                Console.WriteLine("3 - Cash out");

                String option = Console.ReadLine();
                  switch (option)
                 {
                    case "1":
                        Console.WriteLine("Write the amount to exchange:");
                        string amountInput = Console.ReadLine();
                        if (float.TryParse(amountInput, out amount))
                        {
                            if (amount <= USDwallet)
                            {
                                float convertedToSOM = amount * SomToUSD;
                                USDwallet -= amount;
                                SOMwallet += convertedToSOM;
                                Console.WriteLine("You have " + USDwallet + " USD and " + SOMwallet + " SOM.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Exiting...");
                        break; /*System of Back*/
                    case "3":
                        Console.WriteLine("Cashing out..."); /*Add cash out functionality*/
                        break; 
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                 }
                break;


            case "2":
                Console.WriteLine("You chose: " + Chosen);
                Console.WriteLine("You have " + SOMwallet);
                Console.WriteLine("Choose the option below : ");
                Console.WriteLine("1 - Exchange SOM to USD");
                Console.WriteLine("2 - Exit "); /*System of Back */
                Console.WriteLine("3 - Cash out");

                string option2 = Console.ReadLine();
                switch(option2)
                {
                    case "1":
                        Console.WriteLine("Write the amount to exchange:");
                        string amountInput2 = Console.ReadLine();
                        if (float.TryParse(amountInput2, out amount))
                        {
                            if (amount <= SOMwallet)
                            {
                                float convertedToUSD = amount * USDToSom;
                                SOMwallet -= amount; /**/
                                USDwallet += convertedToUSD;
                                Console.WriteLine("You have " + USDwallet + " USD and " + SOMwallet + " SOM.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Exiting...");
                        break; /*System of Back*/
                    case "3":
                        Console.WriteLine("Cashing out..."); /*Add cash out functionality*/
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                break;
        }
    }
}