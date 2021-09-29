using System;

namespace Individuellt_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inloggning = true;
            while (inloggning == true)
            {
                string svarAnvändarnamn = "";
                int svarPin = 0;
                int felPin = 0;
                bool huvudmeny = false;

                string[] användare = { "John Doe", "Jane Doe", "Baby Doe", "John Roe", "Janie Doe" };
                int[] pin = { 1, 2, 3, 4, 5 };
                Console.WriteLine("Välkommen till banken!");

                bool felAnvändarnamn = true;
                while (felAnvändarnamn == true)
                {
                    Console.WriteLine("Var vänlig och skriv in ditt användarnamn.");
                    svarAnvändarnamn = Console.ReadLine();

                    foreach (var item in användare)
                    {
                        if (svarAnvändarnamn == item)
                        {
                            felAnvändarnamn = false;
                        }
                    }
                    if (felAnvändarnamn == true)
                    {
                        Console.WriteLine("Det användarnamnet finns inte i systemet. Försök igen.");
                    }
                }

                while (felPin < 3)
                {
                    Console.WriteLine("Var vänlig och skriv in din pin kod.");
                    Console.WriteLine("(0) --- Inmata 0 om du vill logga in med ett annat användarnamn.");
                    try
                    {
                        svarPin = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ett fel har uppstått: en pin kod får bara innehålla siffror! Försök igen.");
                        felPin--;
                    }
                    if (svarPin == 0)
                    {
                        break;
                    }
                    if (svarPin == pin[0] && svarAnvändarnamn == "John Doe")
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[1] && svarAnvändarnamn == "Jane Doe")
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[2] && svarAnvändarnamn == "Baby Doe")
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[3] && svarAnvändarnamn == "John Roe")
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[4] && svarAnvändarnamn == "Janie Doe")
                    {
                        huvudmeny = true;
                        break;
                    }
                    felPin++;
                    Console.WriteLine("Fel pinkod. Du har {0} fler försök att mata in rätt pin kod.", 3 - felPin);
                }

                if (felPin >= 3)
                {
                    inloggning = false;
                    Console.WriteLine("Du har blivit avstängd från systemet!");
                }

                while (huvudmeny == true)
                {









              









                }










































            }






































        }
    }
}
