namespace ContactsFullStack.Model
{
    public class Contact
    {
        // { id: '1', firstName: 'Per', email: 'per@mail.com' }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public Contact()
        {
            Id = Guid.NewGuid();
        }

        public Contact(Guid id, string firstName, string email)
        {
            Id = id;
            FirstName = firstName;
            Email = email;
        }
    }
}
