using EmployeeAttachment.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Domain.Entities
{
    public class Address : ValueObject, IEquatable<Address>
    {
        public string? City { get; private set; }
        public string? Country { get; private set; }

        //private Address()
        //{ }

        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;

            yield return Country;
        }



        public bool Equals(Address? other)
        {
            throw new NotImplementedException();
        }

      
    }
}
