using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {

        private List<Vendor> _vendors;

        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            this.Retrieve();

            foreach (var vendor in _vendors)
            {
                Console.WriteLine($"Vendor id: {vendor.VendorId}");
                yield return vendor;
            }
        }

        public IEnumerable<Vendor> RetrieveAll()
        {
            return new List<Vendor>()
            {
                new Vendor()
                    {
                        VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com"
                    },
                    new Vendor()
                    {
                        VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com"
                    },
                    new Vendor()
                    {
                        VendorId = 2, CompanyName = "EFG Ltd", Email = "efg@efg.com"
                    },
                    new Vendor()
                    {
                        VendorId = 2, CompanyName = "HIJ AG", Email = "hij@hij.com"
                    },
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
                        VendorId = 2, CompanyName = "Home Products Inc", Email = "home@abc.com"
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
        }

        public ICollection<Vendor> Retrieve()
        {
            if(_vendors == null)
            {
                _vendors = new List<Vendor>()
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
            }
            Console.WriteLine(_vendors);
            foreach(var vendor in _vendors)
            {
                Console.WriteLine(vendor.CompanyName);
            }

            return _vendors;
        }

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }

        public T ReturnValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }
    }
}
