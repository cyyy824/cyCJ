using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using SQLite;

namespace cyCJ.Models
{
    public class PersonDrawCollection
    {
        private List<Person> persons;
        private Random random;

        public PersonDrawCollection()
        {
            persons = new List<Person>();
            random = new Random();
        }
        // 初始化随机数生成器
        public void InitRandom()
        {
            random = new Random();
        }

        // 随机取出count数量的个体
        public List<Person> GetRandomList(int count)
        {
            List<Person> list = new List<Person>();
            if (count > persons.Count)
                count = persons.Count;
            List<int> indexs = new List<int>();
            for (int i = 0; i < persons.Count; i++)
                indexs.Add(i);

            for (int i = 0; i < count; i++)
            {
                int index = random.Next(indexs.Count);
                list.Add(persons[indexs[index]]);
                indexs.RemoveAt(index);
            }
            return list;
        }
        public void Clear()
        {
            persons.Clear();
        }
        public Person GetPerson(int index)
        {
            return persons[index];
        }
        public bool Add(Person person)
        {
            if (persons.Contains(person))
                return false;

            persons.Add(person);
            return true;
        }

    }
    public class PersonCollection
    {
        private string connStr;
        private List<Person> persons;
//        private Random random;
        public PersonCollection(string connStr)
        {
            this.connStr = connStr;
            persons = new List<Person>();
//            random = new Random();
        }

        public void Clear()
        {
        }
        public Person GetPerson(int index)
        {
            return persons[index];
        }
        public void UpdatePerson(int index,Person person)
        {
            if (index >= Count)
                return;

        }
        public void DeletePerson(int index)
        {
            if (index >= Count)
                return;
        }
        public int Count
        {
            get { return persons.Count; }
        }

        public bool Add(Person person)
        {
            if (persons.Contains(person))
                return false;
            persons.Add(person);
            return true;
        }
        public void ReadDB()
        {
            persons.Clear();
        }
    }

    public class Person
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

        public Person(string name,string message="")
        {
            Name = name;
            Message = message;
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (p.Name == this.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

}
