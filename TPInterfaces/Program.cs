using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) eleve
            Eleve e1 = new Eleve("Joséphine");
            e1.ajouterNote(21);
            e1.ajouterNote(80);
            e1.ajouterNote(0);
            e1.ajouterNote(12);
            e1.ajouterNote(16);
            e1.ajouterNote(5);
            Console.WriteLine(e1.toString());

            foreach(double d in e1.getListeNotes())
            {
                Console.Write(d + " ");
            }

            //2) groupeEleves
            Console.WriteLine();
            Console.WriteLine();


            GroupeEleves ge1 = new GroupeEleves();

            Eleve e2 = new Eleve("Michelle");
            e2.ajouterNote(90);
            e2.ajouterNote(9);
            e2.ajouterNote(10);
            e2.ajouterNote(18);
            e2.ajouterNote(-50);
            e2.ajouterNote(5);
            e2.ajouterNote(20);
            
            ge1.ajouterEleve(e1);
            ge1.ajouterEleve(e2);
            ge1.lister();

            foreach (double d in e1.getListeNotes())
            {
                Console.Write(d + " ");
            }

            Console.WriteLine();

            foreach (double d in e2.getListeNotes())
            {
                Console.Write(d + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("nombre d'eleve dans le groupe : " + ge1.nombre());
            
            Console.WriteLine();

            //3) compareTo
            Console.WriteLine(e1.CompareTo(e2));
            Console.WriteLine(e2.CompareTo(e1));

            //4) deux nouvelles méthodes

            Console.WriteLine();
            Console.WriteLine(ge1.meilleurEleve());
            Console.WriteLine();
            ge1.trierEleves();

            Console.WriteLine("ajout d'un Console.WriteLine");
            Console.WriteLine("ajout d'un deuxieme Console.WriteLine");
            Console.WriteLine("ajout d'un troisieme Console.WriteLine");

            Console.ReadKey();
        }
    }
}
