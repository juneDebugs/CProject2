﻿using System;
using System.Collections.Generic;

namespace CProject2.Fields
{
    //Customer Class
    public class Customer
    {
        //Here, we are declaring Fields
        public int Id;
        public string Name;

        //Since we have a list, we need to set an empty list
        //We have to make sure that this default constructor is ALWAYS called first...
        //so the Order fields will be intialized 
        public Customer()
        {
            Orders = new List<Order>();
        }


        //List of Orders for Customer
        public List<Order> Orders;

        //Declaring Constructors
        public Customer(int id)
        {
            this.Id = id;
        }

        //Second Constructor
        public Customer(int id, string name)
        //Notice that we are using ":this" to delegate "id" to the constructor above
            : this(id)
        {
            this.Name = name;
        }
    }

    //Order Class
    public class Order
    {

    }


    public class FieldsEx
    {
        static void Main(string[] args)
        {

        }
    }
}
