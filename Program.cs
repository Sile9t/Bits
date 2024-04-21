namespace BitsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bit = new Bits(16);
            Console.WriteLine(bit);
            bit.setBits(0, true);
            Console.WriteLine(bit);
            bit = (Bits)257;
            Console.WriteLine(bit);
            long l = 257;
            bit = (Bits)l;
            Console.WriteLine(bit);
        }
    }
}
