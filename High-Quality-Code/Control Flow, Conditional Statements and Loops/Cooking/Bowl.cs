﻿namespace Conditional_Statment_HQC
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }

        public List<Vegetable> Ingredients { get; set; }

        public void Add(Vegetable vegetable)
        {
            this.Ingredients.Add(vegetable);
        }

        public  void Cook()
        {
            foreach (var ingredient in this.Ingredients)
            {
                ingredient.Cook();
            }
        }

        public override string ToString()
        {
            return string.Join("; ", this.Ingredients);
        }
    }
}
