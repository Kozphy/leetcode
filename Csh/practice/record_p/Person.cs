using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice.record_p
{
    //public record class Person(string FirstName, string LastName);

    internal record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }

        public Person(string FirstName, string LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void Test() {
            var person1 = new Person("Joe", "Bloggs");
            var person2 = new Person("Joe", "Bloggs");
            var person3 = new Person("Jane", "Bloggs");
            var person4 = person3 with { LastName = "Doe" };
            List<Person> people = new List<Person>{ person1, person2, person3, person4 };
            foreach (var item in people.ToList())
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }


}
