using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace дз___гараж
{
    public class Auto
    {
        public Auto(string name_)
        {
            name = name_;
            id = ++counter;
        }

        protected static int counter = 0;
        public static int Counter { get { return counter; } }

        private int id;
        public int Id { get { return id; } }

        private string name;
        public string Name { get { return name; } }

    }
    public class Lamborghini : Auto
    {
        public Lamborghini(string name_ = "Lamborghini") : base(name_) { }

    }

    public class Ferrari : Auto
    {
        public Ferrari(string name_ = "Ferrari") : base(name_) { }
    }

    public class Mazda : Auto
    {
        public Mazda(string name_ = "Mazda") : base(name_) { }
    }

    public class Aventador : Lamborghini
    {
        public string model = "Aventador";
        public string Model { get { return model; } }
    }


    public class Miata : Mazda
    {
        public string model = "Miata";
        public string Model { get { return model; } }
    }
    public class Spider : Ferrari
    {
        public string model = "488 Spider";
        public string Model { get { return model; } }
    }
}