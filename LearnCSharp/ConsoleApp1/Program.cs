using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myBety = 34;
            int score = 6000;
            long count = 10000000300;

            char myChar = 'a';
            string mystring = "a";
            bool myBool = false;
            Console.WriteLine("char :{0}, string : {1}, bool : {2}", myChar, mystring, myBool);

            string name = "siki";
            int hp = 100;
            int level = 34;
            float exp = 345.3f;
            long l = 1000000000000000l;
            Console.WriteLine("主角的名字是：\\ \t \"{0}\" \n血量：{1}\n等级：{2}\n经验值：{3}", name, hp, level, exp);
            Console.ReadKey();
        }
    }
}
