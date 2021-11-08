namespace task1API.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public User(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }
    }
}