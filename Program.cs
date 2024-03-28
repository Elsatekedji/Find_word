using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Find_word
{
	class Program
	{
        static void Main(string[] args)
        {




            IList<string> motsdictionnaire = File.ReadAllLines("dictionnaire.txt").Select(item => item.ToLower().Trim()).ToList();

            Console.WriteLine("Entrez l'inverse des mots \n\n");
            string motInverser = Console.ReadLine();
            Console.WriteLine("\n");
            
            IList<string> motsInverse = motInverser.Trim().Split(',');

            foreach (var mot in motsInverse)
            {

                
                string motInverserTrier = new string(mot.ToLower().ToCharArray().OrderBy(c => c).ToArray());

                bool correspondanceTrouvee = false;
                foreach (var motdictionnaire in motsdictionnaire)
                {
                   
                    string motdictionTri = new string(motdictionnaire.ToCharArray().OrderBy(c => c).ToArray());
                    if (motInverserTrier.Equals(motdictionTri))
                    {
                        Console.WriteLine($"{mot} : correspond à {motdictionnaire}\n");
                        correspondanceTrouvee = true;
                        break;
                    }
                    

                }
                if (!correspondanceTrouvee)
                {
                    Console.WriteLine($"{mot} : Aucune correspondance trouvée.\n");
                }

            }
            Console.Read();
        }
    }
}
