﻿namespace StorageMaster.Models.Products
{
    using Validators;

    public abstract class Product
    {
        private double price;
        private double weight;

        public Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                Validator.ValidateProductPrice(nameof(this.Price), value);

                this.price = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                this.weight = value;
            }
        }
    }
}
