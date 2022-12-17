using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDelegateTask
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
       
        public void AverageSalary(Employee item)
        {
            int sum = 0;
            int count = 0;
            if (item.Age>20 && item.Age<40)
            {
                sum += item.Salary;
                count++;
            }
            Console.WriteLine(sum/count);
        }
    }
}
