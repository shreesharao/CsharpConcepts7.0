using System;

namespace Csharp70New
{
    class Topic_3
    {
        public void Entry()
        {
            var x = 10;
            var y = 10;

            Console.WriteLine($"Sum of {x}and{y}={Add(a:x,b:y)}");

            int Add(int a,int b)
            {
                return x + y;
            }
        }
    }
}