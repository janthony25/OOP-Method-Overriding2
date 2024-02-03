using System;
using System.Threading.Channels;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding -  Practice

            Jun jun = new Jun();
            Lim lim = new Lim();

            jun.selfIntroduce();
            lim.selfIntroduce();

            Console.ReadKey();
        }
    }

    class Introduce
    {
        public virtual void selfIntroduce()
        {
            Console.WriteLine("Hi I am this person");
        }
    }

    class Jun : Introduce
    {
        public override void selfIntroduce()
        {
            Console.WriteLine("Hi, my name is Jun and I am 24 years old");
        }
    }

    class Lim : Introduce
    {
        public override void selfIntroduce()
        {
            Console.WriteLine("Hi, my name is Lim and I am 21 years old");
        }
    }


}