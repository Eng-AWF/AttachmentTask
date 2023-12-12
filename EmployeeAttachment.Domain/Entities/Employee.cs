using EmployeeAttachment.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Domain.Entities
{
    public class Employee : AggregateRoot
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Email { get; private set; }
        public string? Image { get; private set; }
        public decimal? Salary { get; private set; }
        public string? Phone { get; private set; }
        public string? FullName { get; private set; }
        public DateTime HireDate { get; private set; }
        public Address? Address { get; private set; }


        public ICollection<Attachment>? Attachments { get; private set; }

        //private List<Attachment> _attachments = new List<Attachment>();

        //public IEnumerable<Attachment> Attachments => _attachments;

        private Employee() { }

        public Employee(string firstName, string lastName, string email, string image, decimal salary, string phone, string fullName , DateTime hireDate, Address? address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Image = image;
            Salary = salary;
            Phone = phone;
            FullName = fullName;
            HireDate = hireDate;
            Address = address;
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
