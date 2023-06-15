namespace ContactsFullStack.Model
{
    public class Contact
    {
        // { id: '1', firstName: 'Per', email: 'per@mail.com' }

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
