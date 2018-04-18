using System;

namespace Csharp70New
{
    internal class Topic_4
    {
        internal void Entry()
        {
            PrintStars(10);
        }

        public void PrintStars(object o)
        {
            if (o is null) return;  //constant pattern 'null'
            if (!(o is int i)) return; //type pattern 'int i'.if o is int then it will assign the value of o to i
            Console.WriteLine(new string('*', i));
        }

    }
}