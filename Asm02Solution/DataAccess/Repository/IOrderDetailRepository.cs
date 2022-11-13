using BusinessObject.Objects;

namespace DataAccess.Repository;

public interface IOrderDetailRepository
{
    List<Detail> GetDetails();
    void Add(Detail detail);
    void Update(Detail detail);
    void Delete(int productId, int orderId);
}
