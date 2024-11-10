namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio de variables
            int rival = 0, girona , punts = 0, guanyats = 0, perduts = 0, empatats = 0, cont = 0;
            string linia;
            StreamReader sr = new StreamReader("lliga2324.txt");

            //demanar primer valor
            linia = sr.ReadLine();
            while (linia != null)
            {
                if(cont %2 == 0)
                    rival = Convert.ToInt32(linia);
                else
                {
                    girona = Convert.ToInt32(linia);
                    if (girona > rival)
                    {
                        guanyats++;
                        punts += 3;
                    }
                    else if (girona == rival)
                    {
                        empatats++;
                        punts++;
                    }
                    else
                        perduts++;
                    
                }
                cont++;
                //demanar següent
                linia = sr.ReadLine();

            }
        }
    }
}
