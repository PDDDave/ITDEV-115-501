﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment2
{
    internal class Employee
    {
        const double RECEIVED_SALES = 0.07;
        const double SS_TAX_RATE = 0.06;
        const double FED_TAX_RATE = 0.18;
        const double retireCont = 0.1;

        private double commissionedIncome = 0.0;
        private double fedTaxPaid = 0.0;
        private double socTaxPaid = 0.0;
        private double retireHeld = 0.0;


        public string firstName { get; set; } = "";
        public string lastName { get; set; } = "";
        public double monthlySales { get; set; } = 0.0;
        public string output { get; set; } = "";

        public Employee(string firstName, string lastName, double monthlySales)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.monthlySales = monthlySales;
        }

        public Employee() {
            firstName = "";
            lastName = "";
            monthlySales = 0.0;
        }

        public void calcCommission() {
            commissionedIncome = monthlySales * RECEIVED_SALES;
        }

        public void calcFedTax() {
            fedTaxPaid = commissionedIncome * FED_TAX_RATE;
        }

        public void calcSocialTax() {
            socTaxPaid = commissionedIncome * SS_TAX_RATE;
        }

        public void calcRetirement() {
            retireHeld = commissionedIncome * retireCont;
        }

        public string formattedOutput() {
            string m = 
                "Name:\t\t\t" + firstName + " " + lastName + "\n\n" +
                "Gross Income: \t\t" + monthlySales + "\n" +
                "Federal Income Tax Witheld: \t\t" + fedTaxPaid + "\n" +
                "Social Security Tax Witheld: \t\t" + socTaxPaid + "\n" +
                "Retirement Contribution: \t\t" + retireHeld + "\n" +
                "_________________________________________________________________\n" +
                "Net Income: \t\t\t" + (commissionedIncome - (fedTaxPaid + socTaxPaid + retireHeld)) + "\n";

            return m;
        }
    }
}
