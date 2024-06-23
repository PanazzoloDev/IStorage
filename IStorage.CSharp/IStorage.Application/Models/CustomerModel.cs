namespace IStorage.Application.Models
{
    public class NewCustomerModel
    {
        public string Identification { get; set; }
        public string? Email { get; set; }
        public string Cellphone { get; set; }
    }

    public class ViewCustomerModel
    {
        public long Id { get; set; }
        public string Identification { get; set; }
        public string? Email { get; set; }
        public string Cellphone { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
    }
    
    public class UpdateCustomerModel : ViewCustomerModel
    {

    }
}