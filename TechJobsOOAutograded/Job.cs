using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class TechJob
    {

        public int Id { get; }
        public static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public TechJob()
        {
            Id = nextId;
            nextId++;
        }

   
        //Code a second constructor that takes 5 parameters and
        //assigns values to name, employerName, employerLocation,
        //jobType, and jobCoreCompetency

        public TechJob(string name, Employer employer, Location location, PositionType positionType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = positionType;
            JobCoreCompetency = coreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is TechJob job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            string NaN = "Data not available";
            if (Name == null || Name == "")
            {
                JobCoreCompetency.Value = NaN;
            }

            return Environment.NewLine + "ID: " + Id + Environment.NewLine +
         "Name: " + Name + Environment.NewLine +
         "Employer: " + EmployerName.Value + Environment.NewLine +
         "Location: " + EmployerLocation.Value + Environment.NewLine +
         "Position Type: " + JobType.Value + Environment.NewLine +
         "Core Competency: " + JobCoreCompetency.Value + Environment.NewLine;
        }
    }
}

//must comment out all tests besides test running to check