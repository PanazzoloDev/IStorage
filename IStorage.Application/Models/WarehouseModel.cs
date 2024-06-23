namespace IStorage.Application.Models
{
    public class NewWarehouseModel
    {
        public string Description { get; set; }
        public int Code { get; set; }
        public bool AvailableStock { get; set; }
    }

    public class ViewWarehouseModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public int Code { get; set; }
        public bool AvailableStock { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class UpdateWarehouseModel : ViewWarehouseModel
    {

    }
}