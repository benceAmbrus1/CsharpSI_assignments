using System;

namespace CreateClass
{
    class Run
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person("Ben", new DateTime(1990, 09,12), Gender.Male);
            Person p2 = new Person("vki", new DateTime(1992, 09, 13), Gender.Female);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            p2.Name = "Fanni";
            Console.WriteLine(p2.ToString());

            Room room1 = new Room(11);
            Person p3 = new Employee("Ben", new DateTime(1990, 09, 12), Gender.Male, 0, "Student", room1);
            Person p4 = new Employee("vki", new DateTime(1992, 09, 13), Gender.Female, 500000, "Milliomos", room1);

            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());
            p4.Name = "Fanni";
            Console.WriteLine(p4.ToString());

            Room room2 = new Room(12);
            Employee Kovacs = new Employee("Géza", DateTime.Now, Gender.Male, 1000, "léhűtő", room2);
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();

        }
    }
}
