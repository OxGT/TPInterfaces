using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPInterfaces
{
    class GroupeEleves
    {
        List<Eleve> listeEleves = new List<Eleve>();

        public GroupeEleves()
        {

        }

        public int nombre()
        {
            return listeEleves.Count();
        }

        public List<Eleve> getListe()
        {
            return listeEleves;
        }

        public void ajouterEleve(Eleve eleve)
        {
            listeEleves.Add(eleve);
        }

        public Eleve chercher(String nom)
        {
            Eleve resultat = null;
            foreach(Eleve e in listeEleves)
            {
                if(e.Equals(nom))
                {
                    resultat = e;
                }
            }

            return resultat;
        }

        public void lister()
        {
            foreach(Eleve e in listeEleves)
            {
                Console.WriteLine(e.toString());
            }
        }

        public Eleve meilleurEleve()
        {
            return listeEleves.Max();
        }

        public void trierEleves()
        {
            listeEleves.Sort();

            foreach(Eleve e in listeEleves)
            {
                Console.WriteLine(e.getNomEleve() + " " + e.getMoyenneEleve());
            }
        }
    }

}
