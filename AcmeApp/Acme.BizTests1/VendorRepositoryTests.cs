using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void ReturnValueTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = 42;

            //Act
            var actual = repository.ReturnValue<int>("Select * from whatever", 42);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReturnValueStringTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = "test";

            //Act
            var actual = repository.ReturnValue<string>("Select * from whatever", "test");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
                {
                    new Vendor()
                    {
                        VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com"
                    },
                    new Vendor()
                    {
                        VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com"
                    }
                };

            //Act
            var actual = repository.Retrieve();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor() { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" } },
                { "XYZ Inc", new Vendor() { VendorId = 8, CompanyName = "XYX Inc", Email = "xyz@xyz.com" } }
            };

            //Act
            var actual = repository.RetrieveWithKeys();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}