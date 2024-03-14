using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Engineer : Employee
    {
        public string Major {  get; }

        public Engineer(string name, int age, string sex, string address, string major) 
            : base(name, age, sex, address)
        {
            Major = major;
        }

        public override string ToString()
        {
            return string.Format("Engineer {{Name = {0}, Age = {1}, Sex = {2}, Address = {3}, Major = {4}}}", Name, Age,
                                 Sex, Address, Major);
        }
    }
}
