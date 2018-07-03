using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int salary;
        private String profession;
        private Room room;

        public Employee(String name, DateTime birthDate, Gender gender, int salary, string profession, Room room) 
            :base(name, birthDate, gender)
        {
            this.salary = salary;
            this.profession = profession;
            this.room = room;
        }
        #region // Getters Setters //
        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
        public String Profession
        {
            get
            {
                return this.profession;
            }
            set
            {
                this.profession = value;
            }
        }

        public Room Room
        {
            get
            {
                return this.room;
            }
            set
            {
                this.room = value;
            }
        }
        #endregion

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(this.Room.RoomNumber);
            return newEmployee;

        }

        public override string ToString()
        {
            return "My name is: " + this.Name + ", born in: " + this.BirthDate + ", gender: " + this.Gender +
                ", Salary:" + this.Salary + ", Proffesion: " + this.profession + ", Room Number:" + this.room.RoomNumber;
        }
    }
}
