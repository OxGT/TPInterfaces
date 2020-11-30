using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterfaces
{
    class Eleve : IComparable
    {
        string nom;
        List<double> listeNotes = new List<double>();
        double moyenne;

        public Eleve(string UnNom)
        {
            nom = UnNom;
        }

        public double getMoyenneEleve()
        {
            return moyenne;
        }

        public string getNomEleve()
        {
            return nom;
        }

        public List<double> getListeNotes()
        {
            return listeNotes;
        }

        public void ajouterNote(int note)
        {
            if(note < 0)
            {
                listeNotes.Add(0);
            }
            else if (note > 20)
            {
                listeNotes.Add(20);
            }
            else
                listeNotes.Add(note);

            double s=0;
            foreach(double n in listeNotes)
            {
                s = s + n;
            }

            moyenne = s / listeNotes.Count;
        }

        public string toString()
        {
            return nom + " " + moyenne;
        }

        public int CompareTo(object obj)
        {
            int res;

            Eleve eleve = (Eleve)obj;
            if (this.moyenne < eleve.moyenne)
                res = -1;
            else if (this.moyenne > eleve.moyenne)
                res = 1;
            else res = 0;

            return res;
        }
    }
}
