using System;
using System.Collections.Generic;

namespace Homework_week2
{
    class Shirt
    {
        public string size;
        public string color;
        public string image;
        public float prize;

        public Shirt(string valuesize, string valuecolor, string valueimage, float valueprize)
        {
             size = valuesize;
             color = valuecolor;
             image = valueimage;
             prize = valueprize;
        }
        public void output()
        {
            Console.WriteLine("Size: {0}", this.size);
            Console.WriteLine("Color: {0}", this.color);
            Console.WriteLine("Image: {0}", this.image);
            Console.WriteLine("Prize: {0}", this.prize);
        }
    }
    class User
    {
        public string name;
        public string email;
        public List<Shirt> order;
        public List<Address> location;
        public User(string valuename, string valueemail)
        {
            name = valuename;
            email = valueemail;
            order = new List<Shirt>();
        }
        public void TS(Shirt tshirt)
        {
            order.Add(tshirt);
        }
        public void Ad(Address Ad)
        {
            location.Add(Ad);
        }
        public void sent()
        {
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Email: {0}", this.email);
        }
    }

    /*class ShoppingCart
    {
        public List<Shirt> tshirt;
        private List<Address> ad;
        public ShoppingCart()
        {
            tshirt = new List<Shirt>();
            Address = new List<Address>();
        }
    }*/
    class Address
    {
        public string street;
        public string city;
        public string zipcode;
        public Address(string valuestreet, string valuecity, string valuezipcode)
        {
            street = valuestreet;
            city = valuecity;
            zipcode = valuezipcode;
        }
        public void adress()
        {
            Console.WriteLine("Street: {0}", this.street);
            Console.WriteLine("City: {0}", this.city);
            Console.WriteLine("Zipcode: {0}", this.zipcode);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User all = new User("Jame Watson", "Jame@email.com");
            Shirt shirt1 = new Shirt("S", "Yellow", "King of Thailand", 625f);
            Shirt shirt2 = new Shirt("M", "Black", "DEAD", 750f);
            Shirt shirt3 = new Shirt("L", "Red", "Fire", 500f);
            Address at = new Address("Puttamonthon", "Nakon Pathom", "10180");

            all.sent();
            at.adress();
            shirt1.output();
            shirt2.output();
            shirt3.output();
            Console.WriteLine("Total Cost: {0} Bath", shirt1.prize + shirt2.prize + shirt3.prize);
 
        }
    }
}
