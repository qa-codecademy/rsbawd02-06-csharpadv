using Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Models
{
    internal class MobileDeveloper : Developer, IDeveloper
    {
        public MobileDeveloper(string fullName, int age) : base(fullName, age)
        {
        }

        public void Code()
        {
            throw new NotImplementedException();
        }

        public void Debug()
        {
            throw new NotImplementedException();
        }
    }
}
