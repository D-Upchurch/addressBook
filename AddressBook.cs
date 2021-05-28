using System;
using System.Collections.Generic;

public class AddressBook
{
    public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

    public void AddContact(Contact obj)
    {

        try
        {
            Contacts.Add(obj.Email, obj);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("This contact has already been added.");
        }
    }


    public Contact GetByEmail(string email)
    {
        return Contacts.GetValueOrDefault(email);
    }
}