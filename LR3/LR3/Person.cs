using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LR3
{
    class Person
    {
        Human[] data;
        public Person()
        {
            data = new Human[10];
        }
        public Human this[int index1]
        {
            get
            {
                return data[index1];
            }
            set
            {
                data[index1] = value;
            }
        }
    }
}
