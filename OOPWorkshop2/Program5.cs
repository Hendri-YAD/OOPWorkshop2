using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;

namespace OOPWorkshop2
{
    class Program5
    {
        static void Main(string[] args)
        {
            Test8();
            Probability8();        
            Console.WriteLine();
            Test(4);
            Probability(4);
        }

        public static void Test8()
        {
            Dice2 dice1 = new Dice2();

            int num = 8;
            int n = 100000;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (num == dice1.Throw() + dice1.Throw())
                {
                    count++;
                }
            }

            double prob = ((double)count) / n;

            Console.WriteLine("Occurrence of obtaining {0} is: {1}", num, prob);

        }

        public static void Test(int num)
        {
            Dice2 dice1 = new Dice2();
           
            int n = 100000;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (num == dice1.Throw() + dice1.Throw())
                {
                    count++;
                }
            }

            double prob = ((double)count) / n;

            Console.WriteLine("Occurence of obtaining {0} is: {1}", num, prob);

        }

        public static void Probability8()
        {
            int count = 0;
            int num = 8;

            for(int i=1;i <= 6; i++)            
                for(int j = 1; j <= 6; j++)
                {
                    if (i + j == num)
                        count++;
                }

            Console.WriteLine("Probability of {0} is {1}", num, count / 36.0);            
        }

        public static void Probability(int num)
        {
            int count = 0;

            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                {
                    if (i + j == num)
                        count++;
                }

            Console.WriteLine("Probability of {0} is {1}", num, count / 36.0);
        }


    }

    class Dice2
    {
        private int faceUp;

        public int Throw()
        {
            faceUp = MyMath.RNDInt(6) + 1;
            return faceUp;
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

        public Dice2()
        {
            Throw();
        }

    }




}
