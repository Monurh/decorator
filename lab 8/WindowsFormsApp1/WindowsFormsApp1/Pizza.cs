using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IPizza
    {
        string GetDescription();
        double GetCost();
    }

    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Тонке тісто";
        }

        public double GetCost()
        {
            return 4.00;
        }
    }
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza pizza;

        public ToppingDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return pizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return pizza.GetCost();
        }
    }

    public class Cheese : ToppingDecorator
    {
        public Cheese(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", сир моцарела";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 1.00;
        }
    }

    public class Pepperoni : ToppingDecorator
    {
        public Pepperoni(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", пепероні";
        }

        public override double GetCost()
        {
            return pizza.GetCost() + 1.50;
        }
    }
}

