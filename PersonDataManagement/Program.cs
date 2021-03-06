using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person Data Management!");
            Console.WriteLine("****==============*****");

            List<Person> personList = new List<Person>();
            AddRecords(personList);
            RetrievingTopTwoRecordsForAgeLessThanSixty(personList);

        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "AJ", "12 Main Street, Washington,DC", 15));
            listPersonInCity.Add(new Person("203456877", "AK", "13 Main Ct, Washington,DC", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Washington,DC", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Washington,DC", 45));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Washington,DC", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Washington,DC", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 54));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 80));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
        }
        public static void RetrievingTopTwoRecordsForAgeLessThanSixty(List<Person> personList)
        {
            //retrive first two records from the list  for age less than 60

            foreach (Person p in personList.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + p.Name + " Age :" + p.Age);
            }
        }
    }
}
