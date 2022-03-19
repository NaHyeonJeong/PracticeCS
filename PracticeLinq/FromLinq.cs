using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiveCS
{
    class FromLinq
    {
        static void Main0(string[] args)
        {
            int[] members = { 9,2,6,4,5,3,7,8,1,10};

            var result = from n in members //n에는 실제로 데이터를 담지 X
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach(int n in result)
                Console.WriteLine($"짝수 : {n}");
        }
    }
}
