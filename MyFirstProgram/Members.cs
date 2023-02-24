using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MembersC
{
    public class Members
    {
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - private field

        //member - public field
        public int age;

        //member property which exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My name is {0} and my job is {1} and my salary is {2} and my age is {3}", memberName, jobTitle, salary, age);
        }

        //member constructor 
       public Members(string memberName, string jobTitle, int salary, int age)
        {
            this.memberName = memberName;
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.age = age;
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            // cleanUp statements
            Console.WriteLine("deconstruction of members object");
            Debug.Write("deconstruction of members object");
        }


    }
}