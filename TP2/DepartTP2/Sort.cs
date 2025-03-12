namespace DepartTP2
{
    public class Sort
    {
        private NomSort nom;
        private int ptsDegatsMin;
        private int ptsDegatsMax;

        public Sort(NomSort pNomSort)
        {
            this.Nom = pNomSort;
            DonnerPointsDegatsMinMax();
        }

        public NomSort Nom
        {
            get { return nom; }
           private set { nom = value; }
        }

        public int PtsDegatsMin
        {
            get { return ptsDegatsMin; }
            private set { ptsDegatsMin = value; }
        }
        public int PtsDegatsMax
        {
            get { return ptsDegatsMax; }
            private set { ptsDegatsMax = value; }
        }

        private void DonnerPointsDegatsMinMax()
        {
            switch (this.Nom)
            {
                case NomSort.BouleDeFeu:
                    ptsDegatsMin = 2;
                    ptsDegatsMax = 16;
                    break;
                case NomSort.MissileMagique:
                    ptsDegatsMin = 3;
                    ptsDegatsMax = 12;
                    break;
                case NomSort.Foudre:
                    ptsDegatsMin = 1;
                    ptsDegatsMax = 20;
                    break;
                default:
                    break;
            }

        }

        public int ObtenirDegats()
        {
            int degats=0;
            switch (this.nom)
            {
                case NomSort.BouleDeFeu:
                    GenererNombre generator1 = new GenererNombre(2,17);
                    degats = generator1.ValeurSuivant();
                    break;
                case NomSort.MissileMagique:
                    GenererNombre generator2 = new GenererNombre(3, 13);
                    degats = generator2.ValeurSuivant();
                    break;
                case NomSort.Foudre:
                    GenererNombre generator3 = new GenererNombre(1,21);
                    degats = generator3.ValeurSuivant();
                    break;
                default:
                    break;
            }

            return degats;
        }
    }
}


