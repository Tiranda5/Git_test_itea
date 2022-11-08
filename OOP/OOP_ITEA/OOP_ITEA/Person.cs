using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ITEA
{
    internal class Person
    {
        string fam = string.Empty,
            status = string.Empty,
            health = string.Empty;
        int age = 0,
            salary = 0;
        int count_ch = 0;

        Person[] children = new Person[2];

        //Read,Write-once
        public string Fam
        {
            get { return fam; }
            set { if (fam =="") fam = value; }
        }

        //Readonly

        public string Status
        {
            get { return status; }
        }

        // Read - Write
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 7)
                    status = "Child";
                else if (age < 21)
                    status = "Student";
                else
                    status = "Other";
            }
        }

        //Write only
        public int Salary
        {
            set { salary = value; }

        }

        public int Counth_ch
        {
            get { return count_ch; }    
        }

        public Person this[int i]
        {
            get
            {
                if (i > 0 && i < 3)
                {
                    return children[i];
                }
                else
                {
                    return children[0];
                }
            }
            set
            {
                if (i == count_ch && i < 3)
                {
                    children[i] = value;
                    count_ch++;
                }
        }
        }
    }
}
