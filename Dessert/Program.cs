using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dessert.Person;

namespace Dessert
{
    public class Dessert
    {
        private string name;
        private double weight;
        private int calories;

        public Dessert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public override string ToString()
        {
            return $"Dessert: {name} ({weight} grams, {calories} calories)";
        }

        public string GetDessertType()
        {
            return "dessert";
        }
    }

    public class Cake : Dessert
    {
        private bool containsGluten;
        private string cakeType;

        public Cake(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
        {
            this.containsGluten = containsGluten;
            this.cakeType = cakeType;
        }

        public bool ContainsGluten
        {
            get { return containsGluten; }
            set { containsGluten = value; }
        }

        public string CakeType
        {
            get { return cakeType; }
            set { cakeType = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $", contains gluten: {containsGluten}, type: {cakeType} cake";
        }

        public new string GetDessertType()
        {
            return cakeType + " cake";
        }
    }

    public class IceCream : Dessert
    {
        private string flavor;
        private string color;

        public IceCream(string name, double weight, int calories, string flavor, string color) : base(name, weight, calories)
        {
            this.flavor = flavor;
            this.color = color;
        }

        public string Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $", flavor: {flavor}, color: {color}";
        }

        public new string GetDessertType()
        {
            return "ice cream";
        }
    }

    public class Person
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Person;
            if (other == null)
            {
                return false;
            }
            return name == other.name && surname == other.surname && age == other.age;
        }

        public override string ToString()
        {
            return $"Person: {name}, {surname}, {age} years old";
        }
    }







    public class Student : Person
        {
            private string studentId;
            private short academicYear;

            public Student(string name, string surname, int age, string studentId, short academicYear) : base(name, surname, age)
            {
                this.studentId = studentId;
                this.academicYear = academicYear;
            }

            public string StudentId
            {
                get { return studentId; }
                set { studentId = value; }
            }

            public short AcademicYear
            {
                get { return academicYear; }
                set { academicYear = value; }
            }

            public override bool Equals(object obj)
            {
                var other = obj as Student;
                if (other == null)
                {
                    return false;
                }
                return studentId == other.studentId;
            }

            public override string ToString()
            {
                return $"Student: {Name} {Surname} ({Age} years old, student ID: {studentId}, academic year: {academicYear})";
            }
        }

        public class Teacher : Person
        {
            private string email;
            private string subject;
            private double salary;

            public Teacher(string name, string surname, int age, string email, string subject, double salary) : base(name, surname, age)
            {
                this.email = email;
                this.subject = subject;
                this.salary = salary;
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Subject
            {
                get { return subject; }
                set { subject = value; }
            }

            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public void IncreaseSalary(int percentage)
            {
                salary *= (1 + percentage / 100.0);
            }

            public static void IncreaseSalary(int percentage, params Teacher[] teachers)
            {
                foreach (var teacher in teachers)
                {
                    teacher.salary *= (1 + percentage / 100.0);
                }
            }

            public override bool Equals(object obj)
            {
                var other = obj as Teacher;
                if (other == null)
                {
                    return false;
                }
                return email == other.email;
            }

            public override string ToString()
            {
                return $"Teacher: {Name} {Surname} ({Age} years old, email: {email}, subject: {subject}, salary: {salary})";
            }
        }



        internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
