using System;

namespace CreateClass
{
    enum Gender { Male, Female };

    class Person
    {
        private String name;
        private DateTime birthDate;
        private Gender gender;
        

        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        #region //Getter Setter
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

        public DateTime BirthDate
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
        #endregion

        public override String ToString()
        {
            return "My name is: " + this.name + ", born in: " + this.birthDate + ", gender: " + this.gender;
        }
    }
}
