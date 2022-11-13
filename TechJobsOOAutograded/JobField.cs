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

        public JobField(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                Id == jobField.Id;

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


