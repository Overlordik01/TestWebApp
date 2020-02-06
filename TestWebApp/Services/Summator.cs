using TestWebApp.Interfaces;

namespace TestWebApp.Services
{
    public class Summator : ISummator
    {
        public int Sum(int a,int b) 
        {
            return a + b;
        }
    }
}
