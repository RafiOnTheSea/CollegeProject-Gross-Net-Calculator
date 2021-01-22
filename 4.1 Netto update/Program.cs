using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Netto_update
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            double RV = 0, AV = 0, KV = 0, PV = 0, MG = 0, JG = 0, LS = 0, soli = 0, Kir = 0;
            double x = 0, y = 0, erg = 0, erg2 = 0, loop4nn = 0;

            while (i < 1)
            {
                

                
                x -= x;

                while (loop4nn == 0)
                {

                    Console.WriteLine("1.monat 2.jahr oder 3.beenden?");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*jahr und monat*/
                    do
                    {

                        if (x == 1)
                        {
                            Console.WriteLine("wie viel verdienen sie in monat?");
                            MG = Convert.ToDouble(Console.ReadLine());
                            JG = MG * 12;

                            loop4nn += 1;
                        }

                        if (x == 2)
                        {
                            Console.WriteLine("wie viel verdienen sie in jahre?");
                            JG = Convert.ToDouble(Console.ReadLine());
                            MG = JG / 12;

                            loop4nn += 1;
                            
                        }
                        
                        if (x == 3)
                        {
                            i = 1;
                            loop4nn += 1;
                        }

                    } while (MG < 0);

               

                }

                loop4nn -= loop4nn;
                
                /*jahr und monat ende*/

                /*versicherung MAX*/
                
                x -= x;
                do
                {
                    if (JG >= 62550) {
                        Console.WriteLine("sind sie peivat versichert? 1.ja 2. nein");
                        x = Convert.ToDouble(Console.ReadLine());
                    }
                } while (x < 0 || x > 2);


                

                if (JG > 5400)
                {
                    RV = (9.3 * MG) / 100;
                    if (RV > 641.70)
                    {
                        RV = 641.70;
                    }
                    AV = (1.3 * MG) / 100;
                    if (AV > 82.80)
                    {
                        AV = 82.80;
                    }
                    if (x == 2 || x == 0)
                    {
                        KV = (7.3 * MG) / 100;
                        if (KV > 363.28)
                        {
                            KV = 363.28;
                        }
                    }
                    
                    PV = (1.525 * MG) / 100;
                    if (PV > 71.48)
                    {
                        PV = 71.48;
                    }
                    /*Jahres Gehat*/
                    /*steuerklasse*/

                    x -= x;
                    do
                    {
                        if (MG >= 450)
                        {
                            Console.WriteLine("steuerklasse? 1.klasse 3 2.klasse 1 3.klasse 4");
                            x = Convert.ToDouble(Console.ReadLine());
                        }
                        if (x == 1)
                        {
                            JG /= 2;
                        }
                    } while (x<0 || x> 3);

                    /*zone 2*/
                    if (JG > 9408 && JG <= 14532)
                    {
                        LS = 0.14 * (JG - 9408) + ((JG - 9408) * (JG - 9408)) * 972.87 *
                       0.00000001;
                    }
                    /*zone 3*/
                    if (JG > 14532 && JG <= 57051)
                    {
                        LS = 0.2397 * (JG - 14532) + ((JG - 14532) * (JG - 14532)) *
                       212.02 * 0.00000001 + 972.87;
                    }
                    /*zone 4*/
                    if (JG > 57051 && JG <= 270500)
                    {
                        LS = 0.42 * (JG - 57051) + 14997.68;
                    }
                    /*zone 5*/
                    if (JG > 270500)
                    {
                        LS = 0.45 * (JG - 270500) + 104646.26;
                    }
                    /*Jahres Gehat ende*/

                    if (x == 1)
                    {
                        LS *= 2;
                    }

                    x -= x;
                    /*steuerklasse ende */
                    /*kirche*/
                    if (JG > 9408)
                    {
                        soli = 0.055 * LS;
                        x = -x;

                        do { 
                            Console.WriteLine("Kirche? 1.ja 2.nein");
                        x = Convert.ToDouble(Console.ReadLine());

                        }while (x < 0 || x > 2);

                        if (x == 1)
                        {
                            do {
                            Console.WriteLine("wohnen sie in byarn oder baden wuttenberg? 1.ja 2.nein");
                            y = Convert.ToDouble(Console.ReadLine());
                            } while (y < 0 || y > 2);

                            if (y == 1)
                            {
                                Kir = 0.08 * LS;
                            }
                            if (y == 2)
                            {
                                Kir = 0.09 * LS;
                            }
                        }
                    }
                }
                /*versicherung MAX ende*/
                Console.Clear();
                erg = JG - 12 * (RV + AV + KV + PV) - LS - soli - Kir;
                erg2 = MG - RV - AV - KV - PV - LS / 12 - soli / 12 - Kir / 12;
                Console.WriteLine("Renteversicherung jahr: " + Math.Round((RV * 12), 2) +
                Environment.NewLine + "krankenversicherung jahr: " + Math.Round((KV * 12), 2) +
                Environment.NewLine + "arbeitslosenversicherung jahr: " + Math.Round((AV * 12), 2) +
                Environment.NewLine + "Pflegeversicherung jahr: " + Math.Round((PV * 12), 2) +
                Environment.NewLine + "lohnsteuer jahr: " + Math.Round(LS, 2) +
                Environment.NewLine + "Kirschensteuer jahr: " + Math.Round((Kir * 12), 2) +
                Environment.NewLine + "solidaritätsseuter jahr: " + Math.Round((soli * 12), 2) +
                Environment.NewLine + "ihre netto für das jahr: " + Math.Round(erg, 2) +
                Environment.NewLine + "--------------------------------------------------------- - " +
                Environment.NewLine + "Renteversicherung monat: " + Math.Round(RV, 2) +
                Environment.NewLine + "krankenversicherung monat: " + Math.Round(KV, 2) +
                Environment.NewLine + "arbeitslosenversicherung monat: " + Math.Round(AV, 2) +
                Environment.NewLine + "Pflegeversicherung monat: " + Math.Round(PV, 2) +
                Environment.NewLine + "lohnsteuer monat: " + Math.Round((LS / 12), 2) +
                Environment.NewLine + "Kirschensteuer monat: " + Math.Round(Kir / 12, 2) +
                Environment.NewLine + "solidaritätsseuter monat: " + Math.Round(soli / 12, 2) +
                Environment.NewLine + "ihre netto für das monat: " + Math.Round(erg2, 2));
                Console.ReadLine();
                Console.Clear();
            }

                
        }
    }
}
