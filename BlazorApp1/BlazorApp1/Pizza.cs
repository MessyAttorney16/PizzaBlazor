namespace BlazorApp1
{
    public class Pizza
    {
        public Toppings PizzaToppings { get; set; }
        public Crust PizzaCrust { get; set; }
        public TipAmount Tip { get; set; }

        public Pizza()
        {
            PizzaToppings = new Toppings();
            PizzaCrust = new Crust();
            Tip = new TipAmount();
        }

        public double GetTotalPrice()
        {
            double totalTip = (PizzaToppings.tPrice() + PizzaCrust.cPrice() + 2.00) * Tip.Tip();
            double totalPrice = PizzaToppings.tPrice() + PizzaCrust.cPrice() + 2.00 + totalTip;
            return totalPrice;
        }
    }

    public class Toppings()
    {
        public bool pepperoni { get; set; }
        public bool extraCheese { get; set; }
        public bool ham { get; set; }
        public bool chicken { get; set; }

        public double tPrice()
        {
            double toppingTotal = 0;
            if (pepperoni)
            {
                toppingTotal += 1.50;
            }
            if (extraCheese)
            {
                toppingTotal += 2.00;
            }
            if (ham)
            {
                toppingTotal += 1.79;
            }
            if (chicken)
            {
                toppingTotal += 3.00;
            }
            return toppingTotal;
        }
    }

    public class Crust()
    {
        public bool thinCrust { get; set; }
        public bool panCrust { get; set; }
        public bool handTossed { get; set; }

        public double cPrice()
        {
            double crustTotal = 0;
            if (thinCrust)
            {
                crustTotal += 1.50;
            }
            if (panCrust)
            {
                crustTotal += 2.00;
            }
            if (handTossed)
            {
                crustTotal += 1.79;
            }
            return crustTotal;
        }
    }

    public class TipAmount()
    {
        public bool tip1 { get; set; }
        public bool tip2 { get; set; }
        public bool tip3 { get; set; }

        public double Tip()
        {
            double tip = 0;
            if (tip1)
            {
                tip = .12;
            }
            if (tip2)
            {
                tip = .15;
            }
            if (tip3)
            {
                tip = .18;
            }
            return tip;
        }
    }
}