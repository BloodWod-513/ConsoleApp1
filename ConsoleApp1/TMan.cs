using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TMan
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public bool IsVoter 
        {
            get
            {
                if (Age >= 18)
                    return true;
                else
                    return false;
            }
        }

        public TMan() { }
        public TMan(string surname, string name, string patronymic, int age, string address)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Age = age;
            Address = address;
        }
        public TMan(TMan TMan)
        {
            Surname = TMan.Surname;
            Name = TMan.Name;
            Patronymic = TMan.Patronymic;
            Age = TMan.Age;
            Address = TMan.Address;
        }

        public void SetData(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }
        public void SetData(string surname, string name, string patronymic, int age)
        {
            SetData(surname, name, patronymic);
            Age = age;
        }
        public void SetData(string surname, string name, string patronymic, string address)
        {
            SetData(surname, name, patronymic);
            Address = address;
        }
        public void SetData(string surname, string name, string patronymic, int age, string address)
        {
            SetData(surname, name, patronymic, age);
            Address = address;
        }
        public TMan GetData()
        {
            return this;
        }
    }
}
