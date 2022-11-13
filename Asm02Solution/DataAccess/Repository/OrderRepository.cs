using BusinessObject.Objects;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private FstoreContext _db;
        public void AddOrder(Order order)
        {
            if(order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
        }

        public void DeleteOrder(int orderId)
        {
            var order = _db.Orders.Find(orderId);
            if (order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
        }

        public List<Order> GetOrders() => _db.Orders.ToList();

        public void UpdateOrder(Order order)
        {
            if (order != null)
            {
                _db.Orders.Update(order);
                _db.SaveChanges();
            }
        }
    }
}
