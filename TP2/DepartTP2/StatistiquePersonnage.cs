namespace DepartTP2
{
    public class StatistiquePersonnage
    {
        private int ptsVie;
        private int ptsVieMax;
        private int ptsAttaque; 
        private int ptsDefense;
        private int ptsExperience;
        private int ptsArmureSupplementaires;

        public StatistiquePersonnage(ClassePersonnage pClassePersonnage)
        {
            switch (pClassePersonnage)
            {
                case ClassePersonnage.Archer:
                    GenererNombre generateurPtsVieArcher = new GenererNombre((int)UtiliteArcher.NbPtsVieMin, (int)UtiliteArcher.NbPtsVieMax);
                    this.PtsVie = generateurPtsVieArcher.ValeurSuivant();
                    this.PtsVieMax = (int)UtiliteArcher.NbPtsVieMax;
                    GenererNombre generateurPtsAttaqueArcher = new GenererNombre((int)UtiliteArcher.NbPtsAttaqueMin, (int)UtiliteArcher.NbPtsAttaqueMax);
                    this.PtsAttaque = generateurPtsAttaqueArcher.ValeurSuivant();
                    GenererNombre generateurPtsDefenseArcher = new GenererNombre((int)UtiliteArcher.NbPtsArmureMin, (int)UtiliteArcher.NbPtsArmureMax);
                    this.PtsDefense = generateurPtsDefenseArcher.ValeurSuivant();
                    this.PtsExperience = (int)UtiliteArcher.NbPtsExperienceDepart;
                    break;
                case ClassePersonnage.Marge:
                    GenererNombre generateurPtsVieMage = new GenererNombre((int)UtiliteMage.NbPtsVieMin, (int)UtiliteMage.NbPtsVieMax);
                    this.PtsVie = generateurPtsVieMage.ValeurSuivant();
                    this.PtsVieMax = (int)UtiliteMage.NbPtsVieMax;
                    GenererNombre generateurPtsAttaqueMage = new GenererNombre((int)UtiliteMage.NbPtsAttaqueMin, (int)UtiliteMage.NbPtsAttaqueMax);
                    this.PtsAttaque = generateurPtsAttaqueMage.ValeurSuivant();
                    GenererNombre generateurPtsDefenseMage = new GenererNombre((int)UtiliteMage.NbPtsArmureMin, (int)UtiliteMage.NbPtsArmureMax);
                    this.PtsDefense = generateurPtsDefenseMage.ValeurSuivant();
                    this.PtsExperience = (int)UtiliteMage.NbPtsExperienceDepart;
                    break;
                case ClassePersonnage.Guerrier:
                    GenererNombre generateurPtsVieGuerrier = new GenererNombre((int)UtiliteGuerrier.NbPtsVieMin, (int)UtiliteGuerrier.NbPtsVieMax);
                    this.PtsVie = generateurPtsVieGuerrier.ValeurSuivant();
                    this.PtsVieMax = (int)UtiliteGuerrier.NbPtsVieMax;
                    GenererNombre generateurPtsAttaqueGuerrier = new GenererNombre((int)UtiliteGuerrier.NbPtsAttaqueMin, (int)UtiliteGuerrier.NbPtsAttaqueMax);
                    this.PtsAttaque = generateurPtsAttaqueGuerrier.ValeurSuivant();
                    GenererNombre generateurPtsDefenseGuerrier = new GenererNombre((int)UtiliteGuerrier.NbPtsArmureMin, (int)UtiliteGuerrier.NbPtsArmureMax);
                    this.PtsDefense = generateurPtsDefenseGuerrier.ValeurSuivant();
                    this.PtsExperience = (int)UtiliteGuerrier.NbPtsExperienceDepart;
                    break;
                case ClassePersonnage.Assassin:
                    GenererNombre generateurPtsVieAssassin = new GenererNombre((int)UtiliteAssassin.NbPtsVieMin, (int)UtiliteAssassin.NbPtsVieMax);
                    this.PtsVie = generateurPtsVieAssassin.ValeurSuivant();
                    this.PtsVieMax = (int)UtiliteAssassin.NbPtsVieMax;
                    GenererNombre generateurPtsAttaqueAssassin = new GenererNombre((int)UtiliteAssassin.NbPtsAttaqueMin, (int)UtiliteAssassin.NbPtsAttaqueMax);
                    this.PtsAttaque = generateurPtsAttaqueAssassin.ValeurSuivant();
                    GenererNombre generateurPtsDefenseAssassin = new GenererNombre((int)UtiliteAssassin.NbPtsArmureMin, (int)UtiliteAssassin.NbPtsArmureMax);
                    this.PtsDefense = generateurPtsDefenseAssassin.ValeurSuivant();
                    this.PtsExperience = (int)UtiliteAssassin.NbPtsExperienceDepart;
                    break;
                case ClassePersonnage.Moine:
                    GenererNombre generateurPtsVieMoine = new GenererNombre((int)UtiliteMoine.NbPtsVieMin, (int)UtiliteMoine.NbPtsVieMax);
                    this.PtsVie = generateurPtsVieMoine.ValeurSuivant();
                    this.PtsVieMax = (int)UtiliteMoine.NbPtsVieMax;
                    GenererNombre generateurPtsAttaqueMoine = new GenererNombre((int)UtiliteMoine.NbPtsAttaqueMin, (int)UtiliteMoine.NbPtsAttaqueMax);
                    this.PtsAttaque = generateurPtsAttaqueMoine.ValeurSuivant();
                    GenererNombre generateurPtsDefenseMoine = new GenererNombre((int)UtiliteMoine.NbPtsArmureMin, (int)UtiliteMoine.NbPtsArmureMax);
                    this.PtsDefense = generateurPtsDefenseMoine.ValeurSuivant();
                    this.PtsExperience = (int)UtiliteMoine.NbPtsExperienceDepart;
                    break;
                default:
                    break;
            }

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
