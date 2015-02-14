using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compares
{
    public class Person : IComparable
    {
        public Person() { }
        // private fields
        private string _FirstName;
        private string _LastName;
        private int _Age;
        public Person(string FirstName, string LastName, int Age)
        {
           
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        //Properties
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        //This was the interface member
        public int CompareTo(object obj)
        {
            Person Temp = (Person)obj;
            return (this.FirstName.CompareTo(Temp.FirstName));
        }

        public delegate int eventhandle(object obj);
        public void hanl(){
            eventhandle eventhandle1 = CompareTo; 
        } 
        
    }
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // TODO: Implement Functionality Here
            Person me = new Person("Krithik", "John", 56);
            Person myFather = new Person("Srinivas", "Roshan", 92);
            Person myGrandFather = new Person("Arun", "Thiru", 79);
            int state = me.CompareTo(myFather);
            List<Person> arrayofpersons = new List<Person>();
            
            if (state == 1) Console.WriteLine("My father is older than me");
            if (state == -1) Console.WriteLine("I'm older than my father!!!");
            if (state == 0) Console.WriteLine("My Father and I have the same age!");
            arrayofpersons.Add(me);
            arrayofpersons.Add(myFather);
            arrayofpersons.Add(myGrandFather);
            arrayofpersons.Sort();
            foreach (Person item in arrayofpersons)
            {
                Console.WriteLine("1st person:" + item.FirstName + "," + item.LastName + ", age:" + item.Age);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
