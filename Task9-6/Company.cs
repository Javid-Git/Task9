using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_6
{
    class Company 
    {
        private string _name;
        public string Name
        {
            set
            {
                if (Char.IsUpper(value[0]))
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!(Char.IsSymbol(value[i])))
                        {
                            _name = value;
                            

                        }
                        else
                        {
                            Console.WriteLine("Adinizda ancaq reqem, herf ve bosluq ola biler");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Adiniz boyuk herfle baslamalidir");
                }
            }

            get
            {
                return _name;
            }
        }
        public int Limit;
        public Employee[] Employees = new Employee[0];

        public void AddEmployee(Employee empl)
        {
            if (Employees.Length < Limit)
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    Array.Resize(ref Employees, Employees.Length + 1);
                    Employees[i] = empl;
                }
                

            }
            else
            {
                Console.WriteLine("Siz limiti asmisiniz");
            }
        }

        public void GetEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                foreach (Employee item in Employees)
                {
                    Console.WriteLine($"Nomresi: {item.No}\nAdi, Soyadi:{item.FullName}\nVezife: {item.Position}\nMaas: {item.Salary}");
                }
            }
            
        }
        public void RemoveEmployee(int number)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                foreach (Employee item in Employees)
                {
                    if (item.No == number)
                    {
                        Employees[i] = null;
                        Console.WriteLine($"{item.No} nomreli isci silindi");
                    }
                    else
                    {
                        Console.WriteLine("Bu nomreli isci yoxdur");
                    }
                }
            }
        }

    }
}
