using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users alex = new Users();
            //alex.age = 45;
            //alex.email = "test@gmail.com";
            //alex.name = "Олексій";
            alex.setAll("Олексій", "test@gmail.com", "1234", 45);
            alex.setEmail("test2@gmail.com");

            Users admin = new Users();
            admin.setAdmin("Aдміністратор");
            //admin.age = 22;
            //admin.email = "admin@gmail.com";
            //admin.name = "Адмін";
            admin.setAll("Адмін", "admin@gmail.com", "1234", 22);
            admin.setEmail("admin2@gmail.com");

            admin.printAll();
            alex.printAll();

            Console.WriteLine(admin.Administrator.role);

        }
    }
}
