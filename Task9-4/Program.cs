using System;

namespace Task9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Group gr = new Group();
            gr.Limit = 2;
            Console.WriteLine("Hansi qrup?");
            gr.No = int.Parse(Console.ReadLine());

            int a = 0;
            Console.WriteLine("Nece dene telebe elave elemek isteyirsiniz?");
            do
            {
                Console.WriteLine($"Maksimum elave oluna bilecek telebe sayi: {gr.Limit} denedir");
                a = int.Parse(Console.ReadLine());
            } while (a > gr.Limit);

            for (int i = 0; i < a; i++)
            {
                if (a <= gr.Limit)
                {
                    Console.WriteLine("Melumatlari daxil edin");
                    Student per = new Student();
                    Console.WriteLine("Telebenin adi");
                    per.Name = Console.ReadLine();
                    Console.WriteLine("Telebenin Soyadi");
                    per.Surname = Console.ReadLine();
                    gr.AddStudent(per);
                    Console.WriteLine("Davam edirsiz? y/n");
                    char b = char.Parse(Console.ReadLine());
                    if(b != 'y')
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Maksimum elave oluna bilecek telebe sayi: {gr.Limit} denedir");
                    break;
                }
            }
            Console.WriteLine("Umumi telebelebelerin siyahisi");
            gr.GetStudent();
        }
    }
}
