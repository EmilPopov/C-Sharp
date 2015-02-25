using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndSequence
{
    class Caller
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            Console.Write(firstCat.Name+" / ");
            Console.WriteLine(firstCat.Color);
            firstCat.Name = "Maxi";
            firstCat.Color = "Orange";
            Console.WriteLine("My first cat {0} is {1}.",firstCat.Name,firstCat.Color );
            firstCat.SayMiau();

            Cat secondCat = new Cat("Gogo","White");
            secondCat.SayMiau();
            Console.WriteLine("My second cat {0} is {1}",secondCat.Name,secondCat.Color);


            Console.WriteLine("Sequence[1..3]: {0}, {1}, {2}",Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());

            Cat[] allCats=new Cat[10];
            string[] catName = new string[10] { "KOKO", "PESHO", "GOGO", "MAX", "NIKI", "SONY", "DANI", "ELI", "JHON", "STAN" };
            string[] catColor = new string[10] { "RED", "GREEN", "BLUE", "WHITE", "BLACK", "ORANGE", "GRAY", "PURPLE", "YELLOW", "BROWN" };
            for (int i = 0; i < allCats.Length; i++)
            {
                allCats[i]= new Cat(catName[i],catColor[i]);
                allCats[i].SayMiau();
                Console.WriteLine("This cat is {0}", catColor[i]);
            }
        }
    }
}
