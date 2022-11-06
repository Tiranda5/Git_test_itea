using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class Users
    {
        public string name;
        public string password;
        public string email;
        public byte age;
        public Admin Administrator = new Admin();
        

        public void setAll(string _name, string _email, string _pass, byte _age)
        {
            name = _name;
            email = _email;
            password = _pass;
            age = _age;
                
        }

        public void setEmail(string _email)
        {  
            email = _email;        
        }

        public void setAdmin(string role)
        {
            Administrator.role = role;

        }

        public void printAll()
        {
            Console.WriteLine($"Ім'я: {name}, email: {email}, пароль: {password}, вік: {age}");
        }
    }
}
