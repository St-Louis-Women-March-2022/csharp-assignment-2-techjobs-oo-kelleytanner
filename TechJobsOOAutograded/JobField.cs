﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOOAutograded
{
    public abstract class JobField
    {
        public int Id { get; }
        public static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    }


