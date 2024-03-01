using System.Runtime.CompilerServices;
using utils;

namespace Hash_Threema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ThreemaLookup.init();

            //string hash = utils.Helpers.Sha256("+41775788338");
            //ThreemaLookup.registerId("ABCDEF00", hash);
            //hash = utils.Helpers.Sha256("+41791234560");
            //ThreemaLookup.registerId("ABCDEF01", hash); 
            //hash = utils.Helpers.Sha256("+41781235555");
            //ThreemaLookup.registerId("ABCDEF02", hash);

            string hash = utils.Helpers.Sha256("+41781235555");
            string result = ThreemaLookup.lookup(hash);
            Console.WriteLine("Threema lookup: {0}", result);

            hash = utils.Helpers.Sha256("+41781235556");
            result = ThreemaLookup.lookup(hash);
            Console.WriteLine("Threema lookup: {0}", result);

            Console.ReadKey();  

        }
    }
}