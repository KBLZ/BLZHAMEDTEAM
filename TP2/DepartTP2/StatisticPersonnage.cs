namespace DepartTP2
{
    public class StatisticPersonnage
    {
        private Personnage personnage;
        private int ptsVie;
        private int ptsVieMax;
        private int ptsAttaque; 
        private int ptsDefense;
        private int ptsExperience;
        private int ptsArmureSupplementaires;

        public StatisticPersonnage(Personnage pPersonnage)
        {
            this.personnage = pPersonnage;
        }

      
        public Personnage Personnage
        {
            get { return personnage; }
            set { personnage = value; }
        }

        public int PtsVie
        {
            get { return ptsVie; }
            set { ptsVie = value; }
        }

        public int PtsVieMax
        {
            get { return ptsVieMax; }
            set { ptsVieMax = value; }
        }

        public int PtsAttaque
        {
            get { return ptsAttaque; }
            set { ptsAttaque = value; }
        }

        public int PtsDefense
        {
            get { return ptsDefense; }
            set { ptsDefense = value; }
        }

        public int PtsExperience
        {
            get { return ptsExperience; }
            set { ptsExperience = value; }
        }

        public int PtsArmureSupplementaires
        {
            get { return ptsArmureSupplementaires; }
            set { ptsArmureSupplementaires = value; }
        }
    }
}
