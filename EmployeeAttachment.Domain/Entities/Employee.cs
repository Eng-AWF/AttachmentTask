using EmployeeAttachment.Domain.Primitives;

namespace EmployeeAttachment.Domain.Entities
{
    public class Employee : AggregateRoot
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Email { get; private set; }
        public string? ImagePath { get; set; }
        public int? Salary { get; private set; }
        public string? Phone { get; private set; }
        public string? FullName { get; private set; }
        public DateTime HireDate { get; private set; }
        public string? Country { get; private set; }
        public string? City { get; private set; }

        public ICollection<Attachment>? Attachments { get; private set; }

        public Employee()
        { }

        public Employee(string? firstName, string? lastName, string? email, string? image, int? salary, string? phone, DateTime hireDate, string? fullName, string? country, string? city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ImagePath = image;
            Salary = salary;
            Phone = phone;
            HireDate = hireDate;
            FullName = fullName;
            Country = country;
            City = city;
            Attachments = new List<Attachment>();
        }

        public void UpdateEmployee(string? firstName, string? lastName, string? email, string? image, int? salary, string? phone, DateTime hireDate, string? fullName, string? country, string? city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ImagePath = image;
            Salary = salary;
            Phone = phone;
            HireDate = hireDate;
            FullName = fullName;
            Country = country;
            City = city;
            Attachments = new List<Attachment>();
        }
    }
}