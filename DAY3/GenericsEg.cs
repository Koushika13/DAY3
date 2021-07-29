using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{

    class Person
    {  
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

        internal Person(int id, string name,string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }

    }
    
    class GenericsEg
    {
        static void ListEg1()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1, "Pineapple");
            fruits.RemoveAt(3);

            //fruits.Add(10); error, typesafe

            List<string> Vegetables = new List<string>();
            Vegetables.Add("Carrot");
            Vegetables.Add("Beetroot");
            Vegetables.AddRange(fruits); //adding one list to another

            foreach(var list in fruits)
            {
                Console.WriteLine("Fruits:{0}", list);
            }

            foreach (var list in Vegetables)
            {
                Console.WriteLine("Vegetables:{0}", list);
            }
        }
        //key value pair
        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Java");
            dt.Add(2, "Networks");
            dt.Add(3, "AI");

            foreach(KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }

        static void StackEg()
        {
            //push, pop, peek, contains, clear methods

            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(10);
            st.Push(50);

            foreach(var stack in st)
            {
                Console.WriteLine(stack); // output: 50,10,30,40
            }

            st.Pop();

            Console.WriteLine("After one pop");

            foreach(var stack in st)
            {
                Console.WriteLine(stack);
            }

            Console.WriteLine("Peek is:{0}", st.Peek());
        }

        //sortedlist ,queue

        static void sortedEg()
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Hi");
            sl.Add(2, "Bye");
            sl.Add(3, "Apple");

            foreach(KeyValuePair<int,string> sp in sl)
            {
                Console.WriteLine(sp.Key + " " + sp.Value);
            }
        }

        static void QueueEg()
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);
            qu.Enqueue(40);

            foreach (var queue in qu)
            {
                Console.WriteLine(queue); 
            }

            qu.Dequeue();

            Console.WriteLine("-------------");
            foreach (var queue in qu)
            {
                Console.WriteLine(queue);
            }

            Console.WriteLine("Peek is:{0}", qu.Peek());

        }

        static void Main()
        {
            ListEg1();
            Console.WriteLine("Person details");
            Console.WriteLine("------------");
            List<Person> person = new List<Person>();
            person.Add(new Person(1, "SAI", "Pune"));
            person.Add(new Person(2, "Ram", "Mumbai"));
            person.Add(new Person(3, "Geetha", "Pune"));

            foreach(Person p in person)
            {
                Console.WriteLine("ID:{0} || name:{1} || City:{2}", p.id, p.name, p.city);
            }

            Console.WriteLine("-------------")
            DictionaryEg();
            Console.WriteLine("--------------");
            StackEg();
            Console.WriteLine("-------------");
            sortedEg();
            Console.WriteLine("-------------");
            QueueEg();
        }
    }
}
