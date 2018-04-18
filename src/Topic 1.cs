using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp70New
{
    class Topic_1
    {
        public void Entry()
        {
            int[] binaryArray = { 0b1, 0b10, 0b101 };

            foreach (var item in binaryArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
