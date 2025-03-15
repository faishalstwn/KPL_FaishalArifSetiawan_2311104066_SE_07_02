using System;

namespace tpmodul5
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }
}
