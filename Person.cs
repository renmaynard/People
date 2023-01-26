using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private int age;
        private string favouriteColour;
        private bool isWorking;

        public string DisplayPersonInfo()
        {
            string Name = this.firstName +" "+this.lastName;
            return this.personId+ ": " + Name + " Favorite color is "+ this.favouriteColour;
        }
        public string ChangeFavouriteColor()
        {
            this.favouriteColour = "White";
            return this.favouriteColour;
        }
        public string GetAgeInTenYears()
        {
            int newAge = this.age + 10;
            return this.firstName +" "+ this.lastName + " Age in 10 years is : " + newAge;
        }
        public override string ToString()
        {
            string personList = String.Format("Person ID: {0}\nFirst Name: {1}\nLast Name: {2}\n" +
                                                "Favourite Colour: {3}\nAge: {4}\nIs Working: {5}",this.personId,
                                                this.firstName,this.lastName,this.favouriteColour,this.age,this.isWorking);
            return personList;
        }
        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.isWorking = isWorking;
            this.favouriteColour = favouriteColour;
        }
    }
}
