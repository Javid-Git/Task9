using System;

namespace Task9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp1 = new Company();
            comp1.Limit = 1;
            int a = 0;
            do
            {
                Console.WriteLine("Nece dene isci elave etmek isteyirsiniz?");
                a = int.Parse(Console.ReadLine());
                if (a > comp1.Limit)
                {
                    Console.WriteLine($"Siz limiti asdiniz, limit {comp1.Limit} denedir");
                }
            } while (a > comp1.Limit);
            Employee comp = new Employee();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Sirketin adini daxil edin");
                comp1.Name = Console.ReadLine();
                Console.WriteLine("Isci haqqinda melumatlari daxil edin.");
                Console.WriteLine("Nomre");
                comp.No = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ad ve soyad");
                comp.FullName = Console.ReadLine();
                Console.WriteLine("Vezifesi");
                comp.Position = Console.ReadLine();
                Console.WriteLine("Maas");
                comp.Salary = Convert.ToDouble(Console.ReadLine());
                if (i < a-1)
                {
                    Console.WriteLine("Bir daha tekrarlayin");
                }


                comp1.AddEmployee(comp);
            }

            comp1.GetEmployees();

            Console.WriteLine("Nece nomreli iscini silmek isteyirsiniz?");
            int remove = int.Parse(Console.ReadLine());
            comp1.RemoveEmployee(remove);

        }
    }
}
