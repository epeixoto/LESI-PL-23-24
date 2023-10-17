namespace WHOLENUMBERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte S = 34;
            byte B = 250;
            short SH = 32000;
            ushort U = 60000;
            int I = 1000000012;
            uint UI = 3500000000;
            long L = 1532333333334581239;
            ulong UL = 14532333333334581239;
            Console.WriteLine(S + "<" + B + "<" + SH + "<" + U + "<");
            Console.WriteLine(I + "<" + L + "<" + UI + "<" + UL);
        }
    }
}