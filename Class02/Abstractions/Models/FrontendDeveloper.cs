using Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    public class FrontendDeveloper : Developer, IDeveloper
    {
        public FrontendDeveloper(string fullName, int age) 
            : base(fullName, age)
        {
        }

        public void Code()
        {
            Console.WriteLine("I am frontend developer, I am using HTML, CSS, JavaScript");
        }

        public void Debug()
        {
            Console.WriteLine("I am frontend dev, using HTML, CSS, JavaScript and debugging");
        }
    }
}
