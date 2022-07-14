using System;
using System.Collections.Generic;
using System.Text;

namespace Task_jetkins
{
    class input
    {
        public int id { get; set; }
        public string name { get; set; }

        public input(int i, string n)
        {
            this.id = i;
            this.name = n;
        }

        public void show()
        {
            Console.WriteLine("ID: {0} Name: {1}",id,name);
        }

    }
}
