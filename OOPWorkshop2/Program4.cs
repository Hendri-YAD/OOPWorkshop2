using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;

namespace OOPWorkshop2
{
    class Program4
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice();
            Console.WriteLine(dice1.StrFaceUp);
            dice1.Throw();
            Console.WriteLine(dice1.StrFaceUp);
            dice1.Throw();
            Console.WriteLine(dice1.StrFaceUp);
            dice1.Throw();
            Console.WriteLine(dice1.StrFaceUp);
        }
    }

    class Dice
    {
        private int faceUp;

        public void Throw()
        {
            faceUp = MyMath.RNDInt(6) + 1;
        }

        public int GetFaceUp()
        {
            return faceUp;
        }
        
        public string StrFaceUp
        {
            get
            {
                return GetFaceUp().ToString();
            }
        }

        public Dice()
        {
            Throw();
        }

    }
    
    
    
}
