using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {

        //private int id
        //private static int nextId = 1;
        //private string value;

        //public int Id { get; }
        //public static int nextId = 1;
        //public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties.
        //change id and value only
        //public CoreCompetency()
        //{
        //    //Id = nextId;
        //    //nextId++;
        //}

        public CoreCompetency(string value) : base(value)
        {
            //Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

    }
}
