using System;
using System.Collections.Generic;

namespace Individuellt_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> JohnDoeKonto = new List<double>();
            JohnDoeKonto.Add(100);
            JohnDoeKonto.Add(150);
            JohnDoeKonto.Add(200);
            List<string> JohnDoeKontoNamn = new List<string>();
            JohnDoeKontoNamn.Add("Inkomstkonto");
            JohnDoeKontoNamn.Add("TEST");
            JohnDoeKontoNamn.Add("TEST2");

            List<double> JaneDoeKonto = new List<double>();
            JaneDoeKonto.Add(100);
            JaneDoeKonto.Add(50);
            JaneDoeKonto.Add(150);
            List<string> JaneDoeKontoNamn = new List<string>();
            JaneDoeKontoNamn.Add("Inkomstkonto");
            JaneDoeKontoNamn.Add("TEST3");
            JaneDoeKontoNamn.Add("TEST4");

            List<double> BabyDoeKonto = new List<double>();
            BabyDoeKonto.Add(100);
            List<string> BabyDoeKontoNamn = new List<string>();
            BabyDoeKontoNamn.Add("Sparkonto");

            List<double> JohnRoeKonto = new List<double>();
            JohnRoeKonto.Add(100);
            List<string> JohnRoeKontoNamn = new List<string>();
            JohnRoeKontoNamn.Add("Inkomstkonto");

            List<double> JanieDoeKonto = new List<double>();
            JanieDoeKonto.Add(100);
            List<string> JanieDoeKontoNamn = new List<string>();
            JanieDoeKontoNamn.Add("Inkomstkonto");

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
                    if (svarPin == pin[0] && svarAnvändarnamn == användare[0])
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[1] && svarAnvändarnamn == användare[1])
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[2] && svarAnvändarnamn == användare[2])
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[3] && svarAnvändarnamn == användare[3])
                    {
                        huvudmeny = true;
                        break;
                    }
                    if (svarPin == pin[4] && svarAnvändarnamn == användare[4])
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
                    bool fel = false;
                    int huvudmenySvar = 0;
                    Console.Clear();
                    Console.WriteLine("Värmt välkommen {0}!", svarAnvändarnamn);
                    Console.WriteLine("");
                    Console.WriteLine("Välj ett alternativ nedan.");
                    Console.WriteLine("");
                    Console.WriteLine("(1) --- Se dina konton och saldo.");
                    Console.WriteLine("(2) --- Överföring mellan konton.");
                    Console.WriteLine("(3) --- Ta ut pengar.");
                    Console.WriteLine("(4) --- Logga ut.");

                    try
                    {
                        huvudmenySvar = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ett fel har uppstått: Endast siffror är acceptabla att inmata! Tryck på enter för att återgå till menyn.");
                        Console.ReadKey();
                        fel = true;
                    }

                    switch (huvudmenySvar)
                    {
                        case 1:
                            if (svarAnvändarnamn == användare[0])
                            {
                                KontonOchSaldo(JohnDoeKontoNamn, JohnDoeKonto);
                            }
                            if (svarAnvändarnamn == användare[1])
                            {
                                KontonOchSaldo(JaneDoeKontoNamn, JaneDoeKonto);
                            }
                            if (svarAnvändarnamn == användare[2])
                            {
                                KontonOchSaldo(BabyDoeKontoNamn, BabyDoeKonto);
                            }
                            if (svarAnvändarnamn == användare[3])
                            {
                                KontonOchSaldo(JohnRoeKontoNamn, JohnRoeKonto);
                            }
                            if (svarAnvändarnamn == användare[4])
                            {
                                KontonOchSaldo(JanieDoeKontoNamn, JanieDoeKonto);
                            }
                            break;

                        case 2:
                            if (svarAnvändarnamn == användare[0])
                            {
                                ÖverföringMellanKonton(JohnDoeKontoNamn, JohnDoeKonto);
                            }
                            if (svarAnvändarnamn == användare[1])
                            {
                                ÖverföringMellanKonton(JaneDoeKontoNamn, JaneDoeKonto);
                            }
                            if (svarAnvändarnamn == användare[2])
                            {
                                ÖverföringMellanKonton(BabyDoeKontoNamn, BabyDoeKonto);
                            }
                            if (svarAnvändarnamn == användare[3])
                            {
                                ÖverföringMellanKonton(JohnRoeKontoNamn, JohnRoeKonto);
                            }
                            if (svarAnvändarnamn == användare[4])
                            {
                                ÖverföringMellanKonton(JanieDoeKontoNamn, JanieDoeKonto);
                            }
                            break;

                        case 3:

                            break;

                        case 4:
                            huvudmeny = false;
                            break;

                        default:
                            if (fel == false)
                            {
                                Console.WriteLine("Var vänlig och mata in en siffra som representerar ett val i menyn. Tryck på enter för att återgå till menyn.");
                                Console.ReadKey();
                            }
                            break;
                    }













                }










            }
        }

        public static void KontonOchSaldo(List<string> KontoNamn, List<double> Konto)
        {
            Console.Clear();
            for (int i = 0; i < KontoNamn.Count; i++)
            {
                Console.Write(KontoNamn[0 + i] + ": --- " + Konto[0 + i]);
                Console.WriteLine(""); Console.WriteLine("");
            }
            Console.WriteLine("Tryck på enter för att återgå till menyn.");
            Console.ReadKey();
        }

        public static void ÖverföringMellanKonton(List<string> KontoNamn, List<double> Konto)
        {
            Console.Clear();
            for (int i = 0; i < KontoNamn.Count; i++)
            {
                Console.Write(KontoNamn[0 + i] + ": --- " + Konto[0 + i]);
                Console.WriteLine(""); Console.WriteLine("");
            }
            Console.WriteLine();            
            Console.ReadKey();
        }



    }
}
