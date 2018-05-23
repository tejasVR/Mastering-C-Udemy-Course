using System.Collections.Generic;

namespace Lesson
{
    public class Customer
    {
        public int id;
        public string name;
        public List<Order> orders;

        public Customer()
        {
            orders = new List<Order>();
        }

        public Customer(int id)
            : this() 
        {
            this.id = id;
        }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
