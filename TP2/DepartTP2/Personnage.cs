
namespace DepartTP2
{
    public class Personnage
    {
        private string nom;
        private ClassePersonnage classePersonnage;
        private Arme arme;
        private int nbPotions;
        private List<Sort> sorts;
        private Dictionary<int, int> degatsDernierCombat;
        private StatistiquePersonnage statistiquePersonnage;


        public Personnage(string pNom, ClassePersonnage pClassPersonnage, Arme pArme, List<Sort> pSorts)
        {
            this.Nom = pNom;
            this.ClassePersonnage = pClassPersonnage;
            this.Arme = pArme;
            this.Sorts = pSorts;
            this.NbPotions = 0;
            this.StatistiquePersonnage = new StatistiquePersonnage(this.ClassePersonnage);
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

        public ClassePersonnage ClassePersonnage
        {
            get { return classePersonnage; }
            private set { classePersonnage = value; }
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
                if (this.ClassePersonnage == ClassePersonnage.Marge)
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

        public StatistiquePersonnage StatistiquePersonnage
        {
            get { return statistiquePersonnage; }
            private set
            {
                statistiquePersonnage = value;
            }
        }


        public bool EstMort()
        {
            return this.StatistiquePersonnage.PtsVie == 0;
        }

        public void Attaquer(Personnage ennemi)
        {
            GenererNombre deVingtFaces = new GenererNombre(1, 21);
            int resultatDe = deVingtFaces.ValeurSuivant();

            if (resultatDe > ennemi.StatistiquePersonnage.PtsDefense)
            {
                int domages = 0;

                if (this.ClassePersonnage == ClassePersonnage.Marge)
                {
                    GenererNombre generateurSort=new GenererNombre(0,sorts.Count);
                    int indexsort = generateurSort.ValeurSuivant();

                    domages = Sorts[indexsort].ObtenirDegats();

                }
                else
                {
                    switch (this.Arme)
                    {
                        case Arme.Aucune:
                            domages = (int)UtiliteArme.PtsDommageAucune;
                            break;
                        case Arme.EpeeBouclier:
                            domages = (int)UtiliteArme.PtsDommageEpeeBouclier;
                            break;
                        case Arme.EpeeDeuxMain:
                            domages = (int)UtiliteArme.PtsDommageEpeeDeuxMains;
                            break;
                        case Arme.ArcFleches:
                            domages = (int)UtiliteArme.PtsDommageArcFleches;
                            break;
                        default:
                            break;
                    }

                }


                int degats = this.statistiquePersonnage.PtsAttaque + domages;
            }

        }

        public void BoirePotion()
        {
            if (nbPotions > 0)
            {
                nbPotions--;
                GenererNombre generateur = new GenererNombre((int)PotionMagique.NbPotionMin, (int)PotionMagique.NbPotionMax);
                int nbPotionAboire = generateur.ValeurSuivant();
                this.StatistiquePersonnage.PtsVie = nbPotionAboire;

            }
        }

    }
}
