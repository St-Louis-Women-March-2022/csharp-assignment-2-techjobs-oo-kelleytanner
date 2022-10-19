using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;


//tests for job classs
//define a test called TestSettingJobId

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        TechJob techJob1;
        TechJob techJob2;
        TechJob techJob3;
        TechJob techJob4;

        //}

        [TestInitialize]

        public void CreateJobObject()
        {
            techJob1 = new TechJob();
            techJob2 = new TechJob();
            techJob3 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            techJob4 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

    [TestMethod]
        public void TestMethod()
        {

        }
        [TestMethod]
        public void TestSettingJobId()
        {


            //using assert test if id values for objects are not the same and differ by 1
            TechJob techJob1 = new TechJob();
            TechJob techJob2 = new TechJob();
            Assert.AreEqual((techJob1.Id - techJob2.Id), -1);
            Assert.AreNotEqual(techJob1, techJob2);
        }

        //

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //TechJob job = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            Assert.AreEqual(techJob3.Name, "Product tester");
            Assert.AreEqual(techJob3.EmployerName.ToString(), "ACME");
            Assert.AreEqual(techJob3.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(techJob3.JobType.ToString(), "Quality control");
            Assert.AreEqual(techJob3.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            //TechJob techJob1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //TechJob techJob2 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            //Assert.AreEqual(techJob1, techJob1);
            Assert.AreNotEqual(techJob3, techJob4);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {

            techJob3.JobCoreCompetency.Value = "";
            string expected = Environment.NewLine + "ID: " + techJob3.Id + Environment.NewLine + "Name: Data not available" + Environment.NewLine + "Employer: Data not available" + Environment.NewLine + "Location: Data not available" + Environment.NewLine + "Position Type: Data not available" + Environment.NewLine + "Core Competency: Data not available";
            string actual = techJob3.ToString();
            char text = actual[0];
            char lasttext = actual[actual.Length - 1];
            Assert.AreEqual(text, lasttext);
          
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string expected = Environment.NewLine + "ID: " + techJob3.Id + Environment.NewLine + "Name: " + techJob3.Name + Environment.NewLine + "Employer: " + techJob3.EmployerName.Value + Environment.NewLine + "Location: " + techJob3.EmployerLocation.Value + Environment.NewLine + "Position Type: " + techJob3.JobType.Value + Environment.NewLine + "Core Competency: " + techJob3.JobCoreCompetency.Value + Environment.NewLine;

            Assert.AreEqual(expected, techJob3.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            techJob3.JobCoreCompetency.Value = "";
            string expected = Environment.NewLine + "ID: " + techJob3.Id + Environment.NewLine + "Name: " + techJob3.Name + Environment.NewLine + "Employer: " + techJob3.EmployerName.Value + Environment.NewLine + "Location: " + techJob3.EmployerLocation.Value +  Environment.NewLine + "Position Type: " + techJob3.JobType.Value + Environment.NewLine + "Core Competency: " + techJob3.JobCoreCompetency.Value + Environment.NewLine;

            Assert.AreEqual(expected, techJob3.ToString());
        }
    }
}
