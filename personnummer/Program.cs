namespace personnummer
{
    internal class Program
    {
        /*
        Gruppnummer 1
        Sam
        Albin
         */
        
        public static bool isValidPNR(string personnummer) 
        {
            personnummer = personnummer.Replace("-", "");
            
            
            if (personnummer.Length != 10)
            {
                return false;
            }
               

            int sum = 0;

            for (int i = 0; i< 10; i++)
            {
                int digit = int.Parse(personnummer[i].ToString());

                if (i % 2 == 0)
                {

                    digit *= 2;

                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }
                sum += digit;
            }

            return sum % 10 == 0;
        }
        
        
        
        static void Main(string[] args)
        {
            string personnummer = "99-08-18-01-------------------------37";

            if (isValidPNR(personnummer))
            {
                Console.WriteLine("giltigt personnummer");
            }
            else
            {
                Console.WriteLine("ogiltigt personnummer");
            } 
        }
    }
}