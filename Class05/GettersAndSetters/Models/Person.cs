using System.Text.RegularExpressions;

namespace GettersAndSetters.Models
{
    public class Person
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }

            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Empty value");

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Empty value");

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Empty value");

                _firstName = value;
            }
        }

        public string LastName { get; set; }

        //public void SetFirstName(string firstName)
        //{
        //    if (string.IsNullOrEmpty(firstName))
        //        throw new ArgumentException("Empty value");

        //    // ...

        //    _firstName = firstName;
        //}

        //public string GetFirstName()
        //{
        //    return _firstName;
        //}
    }
}
