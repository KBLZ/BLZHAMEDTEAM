
namespace DepartTP2
{
    public class Personnage
    {
        private string nom;
        private ClassePersonnage classPersonnage;
        private Arme arme;
        private int nbPotions;
        private List<Sort> sorts;
        private Dictionary<int, int> degatsDernierCombat;


        public Personnage(string pNom, ClassePersonnage pClassPersonnage, Arme pArme, List<Sort> pSorts)
        {
            this.Nom = pNom;
            this.ClassPersonnage = pClassPersonnage;
            this.Arme = pArme;
            this.Sorts = pSorts;
            this.nbPotions = 0;
        }

        public string Nom
        {
            get { return nom; }
            private set
            {
                if (value == "")
                {
                    throw new ArgumentException("Le nom du personnage ne doit pas être vide!");
                }
                nom = value;
            }
        }

        public ClassePersonnage ClassPersonnage
        {
            get { return classPersonnage; }
            private set { classPersonnage = value; }
        }

        public Arme Arme
        {
            get { return arme; }
            private set { arme = value; }
        }

        public int NbPotions
        {
            get { return nbPotions; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Le nombre de portion ne doit pas être négatif !");
                }
                nbPotions = value;
            }
        }

        public List<Sort> Sorts
        {
            get { return sorts; }
            private set
            {
                if (this.ClassPersonnage == ClassePersonnage.Marge)
                {
                    sorts = value;
                }

            }
        }

        public Dictionary<int, int> DegatsDernierCombat
        {
            get { return degatsDernierCombat; }
            private set
            {
                degatsDernierCombat = value;
            }
        }

        public bool EstMort()
        {
            return false;
        }

        public void Attaquer(Personnage character)
        {

        }

        public void BoirePotion()
        {
            if (nbPotions > 0)
            {
                nbPotions--;
                GenererNombre generateur = new GenererNombre((int)PotionMagique.NbPotionMin, (int)PotionMagique.NbPotionMax);
                int NbPotion=generateur.ValeurSuivant();

            }
        }
    }
}
