using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest2020
{
    class Person
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int Id {get;set;}

        public Person(string name)
        {

            //initialiseret Name

            Name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
