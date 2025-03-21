using System;

namespace tpmodul5
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new();
            halo.SapaUser("Faishal"); 

            Console.WriteLine(); 

            // Memanggil method dari class DataGeneric
            DataGeneric<string> data = new DataGeneric<string>("2311104066"); 
            data.PrintData();

            Console.ReadLine(); 
        }
    }
}
