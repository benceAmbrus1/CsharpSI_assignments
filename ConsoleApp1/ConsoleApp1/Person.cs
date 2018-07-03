using System;

namespace CreateClass
{
    enum Gender { Male, Female };

    class Person
    {
        private String name;
        private int birthDate;
        private Gender gender;
        

        public Person(string name, int birthDate, Gender gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public String Name
        {
            get
            {
                return this.name; 
            }
            set
            {
                this.name = value;
            }
        }

        public int BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public override String ToString()
        {
            return "My name is: " + this.name + ", born in: " + this.birthDate + ", gender: " + this.gender;
        }
   
        private static void Main(string[] args)
        {
            Person p1 = new Person("Ben", 1990, Gender.Male);
            Person p2 = new Person("vki", 1992, Gender.Female);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            p2.Name ="Fanni";
            
            Console.WriteLine(p2.ToString());

        }
    }
}
