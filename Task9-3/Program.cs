using System;

namespace Task9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Kitabin Adini Daxil Edin");
                string Name = Console.ReadLine();

                Console.WriteLine("Kitabin Sehifesini Daxil Edin");
                int Page = Convert.ToInt32(Console.ReadLine());

                Book book = new Book(Name, Page);

                books[i] = book;
                //Console.WriteLine("Davam edirsiniz? y/n");
                //char a = char.Parse(Console.ReadLine());
                //if (a != 'y')
                //{
                //    Console.WriteLine("Okay");
                //    break;
                //}
            }
            int count = 1;
            foreach (Book item in books)
            {

                if(item.Name == null || item.PageCount == 0)
                {
                    Console.WriteLine($"{count}. Sehv melumat\n(Kitablarin adi 3 herfden ve sehifeleri 10 dan cox olmalidir!!!)\n");
                }
                else
                {
                    Console.WriteLine($"{count}. {item.Name} kitabin {item.PageCount} sehifesi var\n");
                }
                count++;
            }

        }
    }
}
