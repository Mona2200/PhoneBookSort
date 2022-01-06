// <copyright file="Program.cs" company="Alyona">
// Copyright (c) 2012 All Rights Reserved
// </copyright>

namespace PhoneBookSort
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   /// <summary>
   /// Program Class.
   /// </summary>
   public class Program
   {
      /// <summary>
      /// Main Method.
      /// </summary>
      public static void Main()
      {
         var phoneBook = new List<Contact>
         {
            new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
            new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
            new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
            new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
            new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
            new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
         };

         var sortedPhoneBook = phoneBook
            .OrderBy(p => p.Name)
            .ThenBy(p => p.LastName); ////Решение поставленной задачи

         while (true)
         {
            var input = Console.ReadKey().KeyChar;
            var parsed = int.TryParse(input.ToString(), out int pageNumber);
            if (!parsed || pageNumber < 1 || pageNumber > 3)
            {
               Console.WriteLine("Страницы не существует\n");
            }
            else
            {
               var pageContent = sortedPhoneBook.Skip((pageNumber - 1) * 2).Take(2);
               Console.WriteLine();
               foreach (var entry in pageContent)
               {
                  Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber + "\n");
               }
            }
         }
      }
   }
}
