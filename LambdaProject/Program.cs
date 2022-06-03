﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //uc 1
            List<Person> listPerson = new List<Person>();
            listPerson.Add(new Person("10000", "Ram", "Assam", 50));
            listPerson.Add(new Person("10001", "Shyam", "West Bengal", 60));
            listPerson.Add(new Person("10002", "Jodu", "Bihar", 70));
            listPerson.Add(new Person("10003", "Madhu", "UP", 55));
            listPerson.Add(new Person("10004", "Bikash", "Andhra Pradesh", 15));
            listPerson.Add(new Person("10005", "Bimal", "Telangana", 75));
            listPerson.Add(new Person("10004", "Biki", "Maharastra", 18));

            foreach (Person person in listPerson.ToList())
            {
                Console.WriteLine(person.Name);
            }
            //uc2
            foreach (Person person in listPerson.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name:   " +person.Name + "      Age:    "+person.Age);
            }
        }
    }
}
