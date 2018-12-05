﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {

        private List<Vendor> _vendors;

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
