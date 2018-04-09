using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace cyCJ
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
            if(connStr!="")
            { 
                SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from person";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            persons.Clear();
        }
        public Person GetPerson(int index)
        {
            return persons[index];
        }
        public void UpdatePerson(int index,Person person)
        {
            if (index >= Count)
                return;

            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "update person set name=@name,text=@text,imgpath=@imgpath where name=\"" + persons[index].Name +"\"";
            cmd.Parameters.Add("name", DbType.String).Value = person.Name;
            cmd.Parameters.Add("text", DbType.String).Value = person.Text;
            cmd.Parameters.Add("imgpath", DbType.String).Value = person.Picpath;
            cmd.ExecuteNonQuery();
            cn.Close();
            persons[index] = person;
        }
        public void DeletePerson(int index)
        {
            if (index >= Count)
                return;

            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from person where name=@name";
            cmd.Parameters.Add("name", DbType.String).Value = persons[index].Name;
            cmd.ExecuteNonQuery();
            cn.Close();

            persons.RemoveAt(index);
        }
        public int Count
        {
            get { return persons.Count; }
        }
        public SQLiteConnection OpenTran()
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            return cn;

        }
        public void CloseTran(SQLiteConnection cn)
        {
            cn.Close();
        }
        // 结合OpenTran，CloseTran两个函数，批量添加使用
        public bool Add(Person person,SQLiteConnection cn)
        {
            if (persons.Contains(person))
                return false;
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "insert into person(name,text,imgpath) values(@name,@text,@imgpath)";
            cmd.Parameters.Add("name", DbType.StringFixedLength).Value = person.Name;
            cmd.Parameters.Add("text", DbType.String).Value = person.Text;
            cmd.Parameters.Add("imgpath", DbType.String).Value = person.Picpath;
            cmd.ExecuteNonQuery();
            persons.Add(person);
            return true;
        }

        public bool Add(Person person)
        {
            if (persons.Contains(person))
                return false;

            if (connStr != "")
            {
                SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into person(name,text,imgpath) values(@name,@text,@imgpath)";
                cmd.Parameters.Add("name", DbType.StringFixedLength).Value = person.Name;
                cmd.Parameters.Add("text", DbType.String).Value = person.Text;
                cmd.Parameters.Add("imgpath", DbType.String).Value = person.Picpath;
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            persons.Add(person);
            return true;
        }
        public void ReadDB()
        {
            persons.Clear();
            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from person";
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                Person item = new Person(sr.GetString(1), sr.GetString(2), sr.GetString(3));
                persons.Add(item);
            }
            sr.Close();
            cn.Close();
        }
    }

    public class Person
    {
        private string name;
        private string text;
        private string picpath;

        public Person(string _name,string _text="",string _picpath="")
        {
            Name = _name;
            Text = _text;
            Picpath = _picpath;
        }

        public string Name { get => name; set => name = value; }
        public string Text { get => text; set => text = value; }
        public string Picpath { get => picpath; set => picpath = value; }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if( p.Name == this.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
