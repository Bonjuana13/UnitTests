
namespace UnitTests.Services
{
    public class DivisionUnitService
    {
        public static void Main(string[] args)
        {

        }

        public double Division(int x, int y)
        {
            return y != 0 ? (double)x/y : 0;
        }
    }
};
