using System;
using System.Collections.Generic;

namespace week4.HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ilceSayisi = new Dictionary<string, int>();
            ilceSayisi.Add("Bursa", 17);
            ilceSayisi.Add("İstanbul", 39);
            ilceSayisi.Add("Ankara", 25);
            ilceSayisi.Add("İzmir", 30);

            foreach (var ilceEslesmesi in ilceSayisi)
            {
                Console.WriteLine(ilceEslesmesi);
            }

        }
            
    
    }
}
