// <copyright file="Contact.cs" company="Alyona">
// Copyright (c) 2012 All Rights Reserved
// </copyright>

namespace PhoneBookSort
{
   /// <summary>
   /// Contact Class.
   /// </summary>
   public class Contact
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="Contact" /> class.
      /// Constructor of Contact Class.
      /// </summary>
      public Contact(string name, string lastName, long phoneNumber, string email)
      {
         Name = name;
         LastName = lastName;
         PhoneNumber = phoneNumber;
         Email = email;
      }

      public string Name { get; }

      public string LastName { get; }

      public long PhoneNumber { get; }

      public string Email { get; }
   }
}
