using System;
using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace DeBugWorkOnlyNoutbook
{
    class Program
    {
        static void Main()
        {
            var phoneBook = new List<Contact>();
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            Console.WriteLine(" Введите цифры от 1 до 3");
            while (true)
            {
                var KeyChar = Console.ReadKey().KeyChar;
                var parsed = Int32.TryParse(KeyChar.ToString(), out int pageNumber);
                Console.WriteLine();
                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.WriteLine(" Неверное значение : Введите цифры от 1 до 3");
                }
                else
                {
                    var pagesortCont = phoneBook.OrderBy(p => p.Name).OrderBy(p => p.LastName).Skip((pageNumber - 1) * 2).Take(2).Select(p => p);
                    foreach (var entry in pagesortCont)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);
                    Console.WriteLine();
                }
            }
        }
    }
}

