using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {   List<Person> PersonList = new List<Person>();
            PersonList.Add(new Person(1,"Ian","Brooks","Red", 30,true));
            PersonList.Add(new Person(2, "Gina", "James", "Green", 18, false));
            PersonList.Add(new Person(3, "Mike", "Briscoe", "Blue", 45, true));
            PersonList.Add(new Person(4, "Mary", "Beals", "Yellow", 28, true));

            Console.WriteLine(PersonList[1].DisplayPersonInfo());
            Console.WriteLine(PersonList[2].ToString());
            PersonList[0].ChangeFavouriteColor();
            Console.WriteLine(PersonList[0].DisplayPersonInfo());
            Console.WriteLine(PersonList[3].GetAgeInTenYears());

                     
        }
    }
}
