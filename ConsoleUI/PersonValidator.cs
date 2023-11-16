using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class PersonValidator
    {

        public static bool Validate(Person person)
        {
            // Checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.Gender))
            {
                StandardMessages.DisplayValidationError("Gender");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.Email))
            {
                StandardMessages.DisplayValidationError("Email");
                return false;
            }
          

            return true;
        }
    }
}
