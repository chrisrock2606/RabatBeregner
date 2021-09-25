namespace DiplomOpgaver
{
    public class Transportpris
    {
        public double BeregnTransportpris(double km, double vaegt) 
        {
            double pris = 0;

            if (km >= 5 && vaegt < 10)
            {
                pris = 75;
            }

            else if (vaegt >= 10)
            {
                pris = km >= 5 ? 100 : 50;
            }

            return pris;
        }
    }
}
