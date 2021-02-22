using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Employee> employees = new List<Employee>()
           {
            new Employee(){ Id=1,Name="Vijay",DepartmentId=1},
            new Employee(){ Id=2,Name="Abhi",DepartmentId=1},
            new Employee(){ Id=3,Name="Prasad",DepartmentId=2},
            new Employee(){ Id=4,Name="Tej",DepartmentId=2},
            new Employee(){ Id=5,Name="Mukul",DepartmentId=1},
            new Employee(){ Id=6,Name="Shubham",DepartmentId=3}

            };

         List<Department> Departments = new List<Department>()
        {
            new Department(){ Id=1, Name="IT"},
            new Department(){ Id=2, Name="HR"},
            new Department(){ Id=3, Name="Account"}
        };

            var lq = Departments.GroupJoin(employees, cat => cat.Id, std => std.DepartmentId,
                (cat, std) => new { cat, std });

            foreach (var item in lq)
            {
                Console.WriteLine( item.cat.Name +"=>");
                foreach (var it in item.std)
                {
                    Console.WriteLine(" " + it.Name );
                }

            }

            Console.ReadLine();
        }

        
        

    
    }
}
