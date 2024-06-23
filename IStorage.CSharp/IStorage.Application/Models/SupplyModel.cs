namespace IStorage.Application.Models
{
    public class NewSupplyModel
    {
        public string Description { get; set; }
        public string UnitMeasure { get; set; }
        public double? SecurityInventory { get; set; }
        public double? MinimumLot { get; set; }
    }

    public class ViewSupplyModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
        public string UnitMeasure { get; set; }
        public double? SecurityInventory { get; set; }
        public double? MinimumLot { get; set; }
    }

    public class UpdateSupplyModel : ViewSupplyModel
    {

    }
}