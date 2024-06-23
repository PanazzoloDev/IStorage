namespace IStorage.Application.Models
{
    public class NewUserModel
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public int Code { get; set; }
        public DateTime Birthdate { get; set; }
    }

    public class ViewUserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public int Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
        public DateTime Birthdate { get; set; }
    }

    public class UpdateUserModel : ViewUserModel
    {

    }
}