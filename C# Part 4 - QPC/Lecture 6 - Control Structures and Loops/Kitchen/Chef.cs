using System;

namespace Kitchen
{
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Carrot carrot = this.GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.IsCut = true;
        }
    }
}