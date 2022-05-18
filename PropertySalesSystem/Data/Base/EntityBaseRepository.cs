namespace PropertySalesSystem.Data.Base
{
    private readonly ApplicationDbContext _data;

    public class EntityBaseRepository(ApplicationDbContext data)
    {
         this._data = data;
    }
}
