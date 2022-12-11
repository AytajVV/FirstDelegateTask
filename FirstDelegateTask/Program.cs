using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDelegateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //list.Add("lorem");
            //list.Add("ipsum");
            //Console.WriteLine(list.Find(l=> l == "ayan"));
            Employee person1 = new Employee("lorem", 25, 500);
            Employee person2 = new Employee("lorem1", 20, 1000);
            Employee person3 = new Employee("lorem2", 30, 1500);
            Employee person4 = new Employee("lorem3", 45, 5000);

            List<Employee> list = new List<Employee>();
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            list.Add(person4);
            int sum = 0;
            int count = 0;

            
            foreach (var item in list.FindAll(employee=>employee.Age>20 && employee.Age<40))
            {
                
                sum += item.Salary;
                    count++;
            }
            int avg = sum / count;
            Console.WriteLine(avg);



        }
        

    }
}


