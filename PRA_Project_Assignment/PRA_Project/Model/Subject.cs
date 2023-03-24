﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public class Subject : IComparable<Subject>
    {
        private static int id;
        public int Id { get;}
        public string Name { get; set; }

        public Subject(string name)
        {
            Id = id++;
            Name = name;
        }

        public override string ToString() => $"{Id}, {Name}";

        public override bool Equals(object? obj)
        {
            return obj is Subject subject &&
                   Id == subject.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public int CompareTo(Subject? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
