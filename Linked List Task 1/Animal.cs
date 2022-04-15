using System;
using System.Collections.Generic;

namespace Lab_3_1
{
    public class Animal : IComparable<Animal>, IEquatable<Animal>
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Animal()
        {
            Name = "Empty";
            Weight = 0;
        }
        public Animal(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
        public int CompareTo(Animal a)
        {
            Animal it = a as Animal;
            if (it != null)
                return this.Weight.CompareTo(a.Weight);
            else
                throw new ArgumentException("the object does not belong to the Animal type");
        }
        public bool Equals(Animal other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
}
