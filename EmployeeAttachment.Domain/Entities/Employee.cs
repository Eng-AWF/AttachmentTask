using EmployeeAttachment.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Domain.Entities
{
    public class Employee : AggregateRoot
    {
        private decimal? salary;

        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Email { get; private set; }
        public string? Image { get;  set; }
        public int? Salary { get; private set; }
        public string? Phone { get; private set; }
        public string? FullName { get; private set; }
        public DateTime HireDate { get; private set; }
        public string? Country { get; private set; }
        public string? City { get; private set; }



        public ICollection<Attachment>? Attachments { get; private set; }

        //private List<Attachment> _attachments = new List<Attachment>();

        //public IEnumerable<Attachment> Attachments => _attachments;

        public Employee() { }

        //public Employee(string firstName, string lastName, string email, string image, int salary, string phone, string fullName , DateTime hireDate, string country, string city)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    Image = image;
        //    Salary = salary;
        //    Phone = phone;
        //    FullName = fullName;
        //    HireDate = hireDate;
        //    Country = country;
        //    City = city;
        //    Attachments = new List<Attachment>();
        //}

        public Employee(string? firstName, string? lastName, string? email, string? image, decimal? salary, string? phone, DateTime hireDate, string? fullName, string? country, string? city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Image = image;
            this.salary = salary;
            Phone = phone;
            HireDate = hireDate;
            FullName = fullName;
            Country = country;
            City = city;
            Attachments = new List<Attachment>();
        }

        public void UpdateEmployee(string? firstName, string? lastName, string? email, string? image, decimal? salary, string? phone, DateTime hireDate, string? fullName, string? country, string? city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Image = image;
            this.salary = salary;
            Phone = phone;
            HireDate = hireDate;
            FullName = fullName;
            Country = country;
            City = city;
            Attachments = new List<Attachment>();
        }
       

        //public void AddAttachment(Attachment attachment)
        //{
        //    _attachments.Add(attachment);
        //}

        //public void RemoveAttachment(Attachment attachment)
        //{
        //    _attachments.Remove(attachment);
        //}
    }
}
