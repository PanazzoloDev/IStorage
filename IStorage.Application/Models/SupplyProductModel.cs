namespace IStorage.Application.Models
{
    public class NewSupplyProductModel
    {
        public long SupplyId { get; set; }
        public long ProductId { get; set; }
    }

    public class ViewSupplyProductModel
    {
        public long Id { get; set; }
        public long SupplyId { get; set; }
        public long ProductId { get; set; }
    }

    public class UpdateSupplyProductModel : ViewSupplyProductModel
    {

    }
}