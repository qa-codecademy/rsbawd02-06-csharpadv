using Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class BackendDeveloper : Developer, IDeveloper
    {
        public BackendDeveloper(string fullName, int age) 
            : base(fullName, age)
        {
        }

        public void Code()
        {
            Console.WriteLine("I am Backend Developer and I am coding on web backend side");
        }

        public void Debug()
        {
            Console.WriteLine("I am Backend Developer and I am debugging the web backend side");
        }
    }
}
