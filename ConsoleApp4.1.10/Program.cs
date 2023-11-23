namespace ConsoleApp4._1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Inv = true;
            bool Res1 = !Inv;
            bool Res2 = !Res1;
            
            Console.WriteLine(Res1);
            Console.WriteLine(Res2);
            Console.ReadKey();
        }
    }
}