using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill_Calculator

    {
        public class Customer
        {
            public int AccountNo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal KWhUsed { get; set; }
            public decimal BillAmount { get; set; }

            private const decimal ADMIN_CHARGE = 12.0m;
            private const decimal KWH_RATE = 0.07m;

            public Customer(int accountNo, string firstName, string lastName, decimal kWhUsed)
            {
                AccountNo = accountNo;
                FirstName = firstName;
                LastName = lastName;
                KWhUsed = kWhUsed;
                BillAmount = CalculateCharge();
            }

            public decimal CalculateCharge()
            {
                return ADMIN_CHARGE + (KWhUsed * KWH_RATE);
            }

            public override string ToString()
            {
                return $"{AccountNo,-10}{FirstName,-15}{LastName,-15}{KWhUsed,-10}{BillAmount,-10}";
            }
        }
    }

