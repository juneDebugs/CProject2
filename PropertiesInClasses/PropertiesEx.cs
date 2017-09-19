﻿using System;

namespace CProject2.PropertiesInClasses
{
    public class Person
    {
        //Here we are creating an Auto-Implemented property without any fields
        //Note, that the compiler will create internally create a private field 
        //And implements the "get" and "set" Accessor Methods
        public DateTime Birthdate { get; set; }

        //We are creating a property called "age"
        //This property cannot be Auto-Implemented because we need some logic
        //We want the Age to be based on person
        public int Age
        {
            get
            {
                //When you subtract Two Datetime Objects you get a Time-Span
                var timeSpan = DateTime.Today - Birthdate;

                //This will give you the total number of years
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }

    public class PropertiesEx
    {
        static void Main(string[] args)
        {
            //Here, we are creating an Instance of the Person class
            var person = new Person();
            person.Birthdate = new DateTime(1990, 1, 1);

            Console.WriteLine(person.Age);
        }

    }
}
