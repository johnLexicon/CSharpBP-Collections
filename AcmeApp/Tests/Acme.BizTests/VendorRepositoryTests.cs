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
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod()]
        public void RetrieveWithIteratorTest()
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
            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var vendor in vendorIterator)
            {
                Console.WriteLine(vendor);
            }

            var actual = vendorIterator.ToList();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveAllTests()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                new Vendor()
                    {
                        VendorId = 2, CompanyName = "Amalgamated Toys", Email = "a@abc.com"
                    },
                    new Vendor()
                    {
                        VendorId = 2, CompanyName = "Toy Blocks Inc", Email = "blocks@abc.com"
                    },
                     new Vendor()
                    {
                        VendorId = 2, CompanyName = "Car Toys", Email = "car@abc.com"
                    },
                    new Vendor()
                    {
                        VendorId = 2, CompanyName = "Toys for Fun", Email = "fun@abc.com"
                    }
            };

            //Act
            var vendors = repository.RetrieveAll();
            var vendorQuery = from v in vendors
                              where v.CompanyName.Contains("Toy")
                              select v;

            //Assert
            CollectionAssert.AreEqual(expected, vendorQuery.ToList<Vendor>());
        }
    }
}