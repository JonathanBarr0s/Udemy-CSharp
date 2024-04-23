﻿namespace Impostometro.Entities {
    internal class Company : TaxPayer {

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            double tax = 0;

            if (NumberOfEmployees <= 10) {
                tax = AnualIncome * 0.16;
            } else if (NumberOfEmployees > 10) {
                tax = AnualIncome * 0.14;
            }

            return tax > 0 ? tax : 0;
        }
    }
}
