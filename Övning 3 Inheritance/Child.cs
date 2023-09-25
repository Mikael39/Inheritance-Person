using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3_Inheritance
{
    public class Child : Person
    {

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value >= 15)
                    throw new ArgumentException("Child's age must be less than 15!");
                else
                    base.age = value;
            }
        }




        public Child(string name, int age) : base(name, age)
        {
        }

    }
}
