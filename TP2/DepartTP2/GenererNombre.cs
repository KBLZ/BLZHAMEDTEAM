
namespace DepartTP2
{
    public class GenererNombre
    {

        private int min;
        private int max;
        private Random random;

        public int Min
        {
            get { return min; }
            private set 
            { 
                if(value<0)
                {
                    throw new ArgumentException("le nombre ne doit pas être négatif!");
                }
               
                min = value;
            }
        }

        public int Max
        {
            get { return max; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("le nombre ne doit pas être négatif");
                }
                if (value < this.Min)
                {
                    throw new ArgumentException("le nombre ne doit pas être négatif");
                }
                max = value;
            }
        }

        public GenererNombre(int pMin, int pMax)
        {
            this.Min = pMin;
            this.Max = pMax;
            this.random = new Random();
        }

        public int ValeurSuivant()
        {
            return random.Next(this.Min, this.Max+1);
        }
    }
}

