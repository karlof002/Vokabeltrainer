/***********************************************************************************************
 * Übungsnr:        05                                     
 * Programmname:    Vocabulary                                  
 * Autor:           Michael Bucek                               
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Der Benutzer wird aufgefordert, ein vorgegebenes deutsches Wort ins
 * Englische zu übersetzen und einzugeben. 
 * ************************************************
*/

using System;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 0;
            string english;
            Console.WriteLine("Gebe die Übersetzung des Wortes 'Fisch' ein!");
            do
            {
                //Rateversuche
                tries = tries + 1;
                Console.Write($"Versuch Nr. {tries}: ");
                english = Console.ReadLine();
                if (english != "fish")
                {
                    Console.WriteLine("Leider falsch!");
                }
            } while ((english != "fish") && (tries<5));

            //Auswertung
            if (tries == 1)
            {
                Console.WriteLine("Richtig!! Meister-Übersetzer!!");
            }
            else if (tries < 5)
            {
                Console.WriteLine("Richtig, aber es könnte besser sein!");
            }
            else if (english=="fish") //Beim 5. Versuch richtig
            {
                Console.WriteLine("Zumindest beim letzten Versuch geschafft!");
            }
            else //Auch beim 5. Versuch falsch
            {
                Console.WriteLine("Das war wohl nichts!!");
            }

        }
    }
}

