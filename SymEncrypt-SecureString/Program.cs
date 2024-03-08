namespace SymEncrypt_SecureString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("secure string");
            SecureString secStr = new SecureString("this string must be kept secret in the memory!");
            Console.WriteLine(secStr.Value);
        }
    }
}