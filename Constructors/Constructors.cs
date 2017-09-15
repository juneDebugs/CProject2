﻿using System;

//Constructor = A Method that is called when an instance of a class is created
//Why do we need a Constructor? = To put an object in an early state

namespace CProject2.Constructors
{
    ////Demo 1
    ////This is how to Declare a Constructor
    ////The Constructor is the same name as the class (*REQUIREMENT*)
    //public class Constructors
    //{
    //    //This is the Constructor
    //    //Constuctors, unlike other Methods, does not have a return type
    //    //If you need to initialize an Object upon creation, use a constuctor 
    //    public Constructors()
    //    {
    //    }
    //}

    //Demo 2
    public class Customer
    {
        public string Name;

        //Here
        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
