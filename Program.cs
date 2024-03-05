using System.Security.Cryptography.X509Certificates;

namespace ClubInterface
{
    interface IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname();
    }
    class Program
    {
        class Member : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Member()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Member(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public string Display()
            {
                return Id + ". " + Fullname();
            }
        }

        static void Main(string[] args)
        {
            Member john = new Member(1, "John", "Doe");
            Console.WriteLine(john.Display());
            Console.ReadLine();
        }
    }
}
