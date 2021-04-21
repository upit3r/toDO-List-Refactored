using System;
using System.Collections.Generic;
using BLL.Implementations;
using BLL.Interfaces;
using DBL;
using Domain.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;


//FAILED couldn't connect tests to the project in vs code idk why
namespace BLL.Tests{
    [TestFixture]   
    public class ProjectTest{
        Command test_command1;
        Command test_command2;

        IProjectBLL project {get;set;}

        [SetUp]
        public void Setup(){
            test_command1 = new Command(){
                Heading = "TestHead",
                Description = "TestDesc",
                Signature = "TestSig"
            };
        }

        [Test]//check whether the tests are working or not ( not :c )
        public void Create_Succ_Test(){
            test_command1.Heading.Should().Be("TestHead");
        }
    }
}