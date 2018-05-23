using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }

    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("The order is already shipped");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }

    }

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
