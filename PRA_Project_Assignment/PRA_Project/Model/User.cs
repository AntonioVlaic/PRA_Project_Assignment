using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public abstract class User : IComparable<User>
    {
        private static int id;
        
        protected User(string firstName, string lastName)
        {
            Id = id++;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get;}

        public override string ToString() => $"{Id}, {FirstName} {LastName}";

        public int CompareTo(User? other)
            => this.Id.CompareTo(other.Id);

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
