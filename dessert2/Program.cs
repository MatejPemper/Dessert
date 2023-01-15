using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dessert2
{
    class Dessert
    {
        private string name;
        private double weight;
        private int calories;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        public Dessert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }


       // public override string ToString()
        //{
        //}

        public string getDessertType()
        {
            return "dessert";
        }
    }

    class Cake : Dessert
    {
        private bool containsGluten;
        private string cakeType;

        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }

        public Cake(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
        {
            this.containsGluten = containsGluten;
            this.cakeType = cakeType;
        }

        public override string ToString()
        {
            return base.ToString() + $", Contains Gluten: {containsGluten}, Cake Type: {cakeType}";
        }

        public string getDessertType()
        {
            return cakeType + " cake";
        }
    }

    class IceCream : Dessert
    {
        private string flavour;
        private string color;

        public string Flavour { get => flavour; set => flavour = value; }
        public string Color { get => color; set => color = value; }

        public IceCream(string name, double weight, int calories, string flavour, string color) : base(name, weight, calories)
        {
            this.flavour = flavour;
            this.color = color;
        }


     //   public override string ToString()
       // {
        //}

     /*   public string getDessertType()
        {
        }*/
    }

    class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }


        internal class Program
        {
            static void Main(string[] args)
            {



                Console.ReadKey();
            }
        }
    }

