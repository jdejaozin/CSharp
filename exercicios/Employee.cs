using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicios
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Increase(double percent)
        {
            Salary = Salary + (Salary *(percent/100));
        }

        public void Decrease(double percent)
        {
            Salary = Salary - (Salary * (percent / 100));
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
