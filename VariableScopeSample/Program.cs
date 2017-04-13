using static System.Console;

namespace VariableScopeSample
{
    class Program
    {
        static int Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                WriteLine(i);
            }
            for (int i = 9; i >=0; i--)
            {
                WriteLine(i);
            }
            return 0;
        }
    }
}