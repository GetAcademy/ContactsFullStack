namespace ContactsFullStack.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public Contact()
        {
        }

        public Contact(int id, string firstName, string email)
        {
            Id = id;
            FirstName = firstName;
            Email = email;
        }
    }
}
