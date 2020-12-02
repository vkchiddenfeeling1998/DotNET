using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            
            Employee e1 = new Employee();
            Employee e2 = new Employee("Amol", 1234, 10);
            Employee e3 = new Employee("Amol", 1234);
            Employee e4 = new Employee("Amol");
            Console.WriteLine(e1.EmpNo + " " + e1.Name + " " + e1.Basic + " " + e1.DeptNo + " salary= " + e1.GetNetSalary());
            Console.WriteLine(e2.EmpNo + " " + e2.Name + " " + e2.Basic + " " + e2.DeptNo + " salary= " + e2.GetNetSalary());
            Console.WriteLine(e3.EmpNo + " " + e3.Name + " " + e3.Basic + " " + e3.DeptNo + " salary= " + e3.GetNetSalary());
            Console.WriteLine(e4.EmpNo + " " + e4.Name + " " + e4.Basic + " " + e4.DeptNo + " salary= " + e4.GetNetSalary());
            Console.ReadLine();
           
        }
        public class Employee
        {
            #region Properties
            private string name;
            public string Name 
            {
                set
                {
                    if (value != "")
                        name = value;
                    else
                    {
                        Console.WriteLine("invalid name");
                        
                    }
                }
                get
                {
                    return name;
                }
            }

            static int counter = 0;
            private int empno;
            public int EmpNo
            {
     
                get 
                {
                    return empno;
                }
            }


            private short deptno;
            public short DeptNo 
            {
                set
                {
                    if (value > 0)
                        deptno = value;
                    else
                    {
                        Console.WriteLine("invalid deptno");
                    
                    }
                }
                get
                {
                    return deptno;
                }
            }

            private decimal basic;
            public decimal Basic 
            {
                set
                {
                    if (value > 10000 || value < 25000)
                        basic = value;
                    else
                    {
                        Console.WriteLine("invalid basic");
                        Console.ReadLine();
                    }
                }
                get
                {
                    return basic;
                }
            }
            #endregion

            
            public Employee(string name = null, decimal basic = 0, short deptId = 0)
            {
                // Console.WriteLine("no param called");
                Employee.counter++;
                EmpNo = Employee.counter;
                Name = name;
                Basic = basic;
                DeptNo = deptId;
            }


            public decimal GetNetSalary()
            {
                return this.Basic;
            }
        }
    }
}

