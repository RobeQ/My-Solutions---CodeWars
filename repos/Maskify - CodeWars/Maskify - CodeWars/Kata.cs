using System;
using System.Collections.Generic;
using System.Text;

namespace Maskify___CodeWars
{
    class Kata
    {
        public static string Maskify(string cc)
        {
            int a = 0;
            string hashNumber = "";
            string sentence = "";

            if(cc.Length > 4)
            {
                for (int i = cc.Length - 4; i < cc.Length; i++)
                {
                    sentence += cc[i];
                }

                a = cc.Length - 4;
                int x = 0;
                while(x < a)
                {
                    hashNumber += "#";
                    x++;
                }
                return hashNumber + sentence;
            }
            return cc;
        }
    }
}
