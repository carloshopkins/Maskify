using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maskify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a value to maskify: ");
            var input = Console.ReadLine();
            Console.WriteLine(Maskify(input));
        }
        static string Maskify(string cc)
        {
            if (cc.Length <= 4)
                return cc;
            var maskedCC = "";
            var ccArray = cc.ToCharArray();
            for (var i = 0; i < ccArray.Length - 4; i++)
                ccArray[i] = '#';
            for (int i = 0; i < ccArray.Length; i++)
                maskedCC += ccArray[i];

            return maskedCC;
        }
    }
}
