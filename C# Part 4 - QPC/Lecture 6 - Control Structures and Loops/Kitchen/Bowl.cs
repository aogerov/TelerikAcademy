using System;
using System.Collections.Generic;

namespace Kitchen
{
    public class Bowl
    {
        private List<Vegetable> ingredients = new List<Vegetable>();

        public void Add(Vegetable vegetable)
        {
            ingredients.Add(vegetable);
        }
    }
}