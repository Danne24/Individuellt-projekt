﻿using System;
using System.Collections.Generic;

namespace Individuellt_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> JohnDoeKonto = new List<double>();
            JohnDoeKonto.Add(65913.92);
            JohnDoeKonto.Add(12500);
            JohnDoeKonto.Add(98173.19);
            JohnDoeKonto.Add(33738.48);
            List<string> JohnDoeKontoNamn = new List<string>();
            JohnDoeKontoNamn.Add("Inkomstkonto");
            JohnDoeKontoNamn.Add("Sparkonto");
            JohnDoeKontoNamn.Add("Investeringssparkonto");
            JohnDoeKontoNamn.Add("Fondkonto");

            List<double> JaneDoeKonto = new List<double>();
            JaneDoeKonto.Add(53291.27);
            JaneDoeKonto.Add(3000);
            JaneDoeKonto.Add(359300);
            List<string> JaneDoeKontoNamn = new List<string>();
            JaneDoeKontoNamn.Add("Inkomstkonto");
            JaneDoeKontoNamn.Add("Sparkonto");
            JaneDoeKontoNamn.Add("Sparande för ett eget hus");

            List<double> BabyDoeKonto = new List<double>();
            BabyDoeKonto.Add(4000);
            BabyDoeKonto.Add(8750);
            List<string> BabyDoeKontoNamn = new List<string>();
            BabyDoeKontoNamn.Add("Sparkonto");
            BabyDoeKontoNamn.Add("Barnbidrag");

            List<double> JohnRoeKonto = new List<double>();
            JohnRoeKonto.Add(118379.23);
            JohnRoeKonto.Add(7500);
            JohnRoeKonto.Add(258105.11);
            JohnRoeKonto.Add(63871.64);
            JohnRoeKonto.Add(539012);
            List<string> JohnRoeKontoNamn = new List<string>();
            JohnRoeKontoNamn.Add("Inkomstkonto");
            JohnRoeKontoNamn.Add("Sparkonto");
            JohnRoeKontoNamn.Add("Investeringssparkonto");
            JohnRoeKontoNamn.Add("Fondkonto");
            JohnRoeKontoNamn.Add("Pensionssparande");

            List<double> JanieDoeKonto = new List<double>();
            JanieDoeKonto.Add(38168.15);
            JanieDoeKonto.Add(26103.71);
            JanieDoeKonto.Add(85900);
            List<string> JanieDoeKontoNamn = new List<string>();
            JanieDoeKontoNamn.Add("Inkomstkonto");
            JanieDoeKontoNamn.Add("Investeringssparkonto");
            JanieDoeKontoNamn.Add("Sparande för en egen bil");

            bool inloggning = true;
            while (inloggning == true)
            {
                string svarAnvändarnamn = "";
                int svarPin = 0;
                int felPin = 0;
                bool huvudmeny = false;

                string[] användare = { "John Doe", "Jane Doe", "Baby Doe", "John Roe", "Janie Doe" };
                int[] pin = { 1, 2, 3, 4, 5 };
                Console.Clear();
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
                    Console.WriteLine("(111) --- Inmata 111 om du vill logga in med ett annat användarnamn.");
                    try
                    {
                        svarPin = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ett fel har uppstått: en pin kod får bara innehålla siffror! Försök igen.");
                        felPin--;
                    }
                    if (svarPin == 111)
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
                            if (svarAnvändarnamn == användare[0])
                            {
                                TaUtPengar(JohnDoeKontoNamn, JohnDoeKonto, svarPin);
                            }
                            if (svarAnvändarnamn == användare[1])
                            {
                                TaUtPengar(JaneDoeKontoNamn, JaneDoeKonto, svarPin);
                            }
                            if (svarAnvändarnamn == användare[2])
                            {
                                TaUtPengar(BabyDoeKontoNamn, BabyDoeKonto, svarPin);
                            }
                            if (svarAnvändarnamn == användare[3])
                            {
                                TaUtPengar(JohnRoeKontoNamn, JohnRoeKonto, svarPin);
                            }
                            if (svarAnvändarnamn == användare[4])
                            {
                                TaUtPengar(JanieDoeKontoNamn, JanieDoeKonto, svarPin);
                            }
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
            int varv;
            int svar = 0;
            bool loop = true;
            while (loop == true)
            {
                bool fel = false;
                for (varv = 0; varv < KontoNamn.Count; varv++)
                {
                    Console.Write(varv + ": --- " + KontoNamn[0 + varv] + ": --- " + Konto[0 + varv]);
                    Console.WriteLine(""); Console.WriteLine("");
                }
                Console.WriteLine("Mata in numret som representerar det konto som du vill överföra pengar ifrån.");
                Console.WriteLine("(Mata in 111 om du har ångrat dig och vill istället återgå till huvudmenyn.)");
                try
                {
                    svar = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ett fel har uppstått: Det är bara acceptabelt att inmata siffor! Försök igen.");
                    Console.WriteLine("");
                    fel = true;
                }
                if (svar == 111 && fel == false)
                {
                    break;
                }
                else if (svar < KontoNamn.Count && fel == false)
                {
                    loop = false;
                }
                else if (svar >= KontoNamn.Count && fel == false)
                {
                    Console.WriteLine("Det kontot finns inte i systemet. Försök igen.");
                    Console.WriteLine("");
                }
            }

            if (svar != 111)
            {
                Console.Clear();
                int svar2 = 0;
                loop = true;
                while (loop == true)
                {
                    bool fel = false;
                    for (varv = 0; varv < KontoNamn.Count; varv++)
                    {
                        Console.Write(varv + ": --- " + KontoNamn[0 + varv] + ": --- " + Konto[0 + varv]);
                        Console.WriteLine(""); Console.WriteLine("");
                    }
                    Console.WriteLine("Mata nu in det numer som representerar det konto som du vill överföra pengarna till.");
                    Console.WriteLine("(Mata in 111 om du har ångrat dig och vill istället återgå till huvudmenyn.)");
                    try
                    {
                        svar2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ett fel har uppstått: Det är bara acceptabelt att inmata siffor! Försök igen.");
                        Console.WriteLine("");
                        fel = true;
                    }
                    if (svar2 == 111)
                    {
                        break;
                    }
                    else if (svar2 == svar)
                    {
                        Console.WriteLine("Du kan inte överföra pengar till och från samma konto! Försök igen.");
                        Console.WriteLine("");
                    }
                    else if (svar2 < KontoNamn.Count && fel == false && svar2 != svar)
                    {
                        loop = false;
                    }
                    else if (svar2 >= KontoNamn.Count && fel == false && svar2 != svar)
                    {
                        Console.WriteLine("Det kontot finns inte i systemet. Försök igen.");
                        Console.WriteLine("");
                    }
                }

                if (svar2 != 111)
                {
                    double summa = 0;
                    loop = true;
                    while (loop == true)
                    {
                        Console.WriteLine("Vilken summa pengar vill du överföra? Skriv in ett nummer och tryck sedan på enter.");
                        Console.WriteLine("(Mata in 1 om du har ångrat dig och vill istället återgå till huvudmenyn.)");
                        try
                        {
                            summa = Convert.ToDouble(Console.ReadLine());
                            loop = false;
                        }
                        catch
                        {
                            Console.WriteLine("Ett fel har uppstått: Det är bara acceptabelt att inmata siffor! Försök igen.");
                        }
                        if (summa > Konto[svar] && summa > 1)
                        {
                            Console.WriteLine("Det först valda kontot har inte så pass mycket pengar, du får inte ha ett minus belopp på kontot! Försök igen.");
                            loop = true;
                        }
                        else if (summa == 1)
                        {
                            break;
                        }
                    }

                    if (summa != 1)
                    {
                        Konto[svar] = Konto[svar] - summa;
                        Konto[svar2] = Konto[svar2] + summa;

                        Console.Clear();
                        Console.WriteLine("Nedan vissas ditt uppdaterade saldo.");
                        Console.WriteLine("");
                        for (int i = 0; i < KontoNamn.Count; i++)
                        {
                            Console.Write(KontoNamn[0 + i] + ": --- " + Konto[0 + i]);
                            Console.WriteLine(""); Console.WriteLine("");
                        }
                        Console.WriteLine("Tryck på enter för att återgå till menyn.");
                        Console.ReadKey();
                    }
                }
            }
        }

        public static void TaUtPengar(List<string> KontoNamn, List<double> Konto, int pinKod)
        {
            Console.Clear();
            int svarPinKod = 0;
            double summa = 0;
            int varv;
            int svar = 0;
            bool loop = true;
            while (loop == true)
            {
                bool fel = false;
                for (varv = 0; varv < KontoNamn.Count; varv++)
                {
                    Console.Write(varv + ": --- " + KontoNamn[0 + varv] + ": --- " + Konto[0 + varv]);
                    Console.WriteLine(""); Console.WriteLine("");
                }
                Console.WriteLine("Mata in numret som representerar det konto som du vill ta ut pengar ifrån.");
                Console.WriteLine("(Mata in 111 om du har ångrat dig och vill istället återgå till huvudmenyn.)");
                try
                {
                    svar = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ett fel har uppstått: Det är bara acceptabelt att inmata siffor! Försök igen.");
                    Console.WriteLine("");
                    fel = true;
                }
                if (svar == 111)
                {
                    break;
                }
                else if (svar < KontoNamn.Count & fel == false)
                {
                    loop = false;
                }
                else if (svar >= KontoNamn.Count & fel == false)
                {
                    Console.WriteLine("Det kontot finns inte i systemet. Försök igen.");
                    Console.WriteLine("");
                }
            }

            if (svar != 111)
            {
                loop = true;
                while (loop == true)
                {
                    Console.WriteLine("Vilken summa pengar vill du ta ut? Skriv in ett nummer och tryck sedan på enter.");
                    try
                    {
                        summa = Convert.ToDouble(Console.ReadLine());
                        loop = false;
                    }
                    catch
                    {
                        Console.WriteLine("Ett fel har uppstått: Det är bara acceptabelt att inmata siffor! Försök igen.");
                        Console.WriteLine("");
                        summa = 0;
                    }
                    if (summa > Konto[svar])
                    {
                        Console.WriteLine("Det valda kontot har inte så pass mycket pengar, du får inte ha ett minus belopp på kontot! Försök igen.");
                        Console.WriteLine("");
                        loop = true;
                    }
                }
            }

            if (svar != 111)
            {
                Console.Clear();
                Console.WriteLine("Du är tvungen att ange din pinkod för att ta ut pengar, var vänlig och gör det nu.");
                Console.WriteLine("(Mata in 111 om du har ångrat dig och vill istället återgå till huvudmenyn.)");

                loop = true;
                while (loop == true & svarPinKod != pinKod)
                {
                    svarPinKod = Convert.ToInt32(Console.ReadLine());
                    if (svarPinKod == 111)
                    {
                        svar = 111;
                        break;
                    }
                    else if (svarPinKod != pinKod)
                    {
                        Console.WriteLine("Fel pin kod! Försök igen.");
                    }
                }
            }
           
            if (svar != 111)
            {
                Konto[svar] = Konto[svar] - summa;

                Console.Clear();
                Console.WriteLine("Nedan vissas ditt uppdaterade saldo.");
                Console.WriteLine("");
                for (int i = 0; i < KontoNamn.Count; i++)
                {
                    Console.Write(KontoNamn[0 + i] + ": --- " + Konto[0 + i]);
                    Console.WriteLine(""); Console.WriteLine("");
                }
                Console.WriteLine("Tryck på enter för att återgå till menyn.");
                Console.ReadKey();
            }
        }








    }
}
