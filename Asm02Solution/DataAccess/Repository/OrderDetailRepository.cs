using BusinessObject.Objects;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private FstoreContext _db;
        public OrderDetailRepository()
        {
            _db = new();
        }
        public void Add(Detail detail)
        {
            if(detail != null)
            {
                _db.Details.Add(detail);
                _db.SaveChanges();
            }
        }

        public void Delete(int productId, int orderId)
        {
            var detail = _db.Details.FirstOrDefault(d => d.ProductId == productId && d.OrderId == orderId);
            if (detail != null)
            {
                _db.Details.Add(detail);
                _db.SaveChanges();
            }
        }

        public List<Detail> GetDetails() => _db.Details.ToList();

        public void Update(Detail detail)
        {
            if (detail != null)
            {
                _db.Details.Update(detail);
                _db.SaveChanges();
            }
        }
    }
}
