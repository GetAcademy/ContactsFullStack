using System.Text.Json;
using ContactsFullStack.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var filename = "contacts.json";

app.MapGet("/contact", ReadFromFile);
app.MapPost("/contact", (Contact contact) =>
{
    var contacts = ReadFromFile();
    contacts.Add(contact);
    SaveToFile(contacts);
});
app.MapPut("/contact", (Contact contact) =>
{
    var contacts = ReadFromFile();
    var theContact = contacts.FirstOrDefault(c=>c.Id==contact.Id);
    theContact.Email = contact.Email;
    theContact.FirstName = contact.FirstName;
    SaveToFile(contacts);
});
app.MapDelete("/contact/{id}", (Guid id) =>
{
    var contacts = ReadFromFile();
    contacts.RemoveAll(c => c.Id == id);
    SaveToFile(contacts);
});
app.UseStaticFiles();
app.Run();

List<Contact> ReadFromFile()
{
    var json = File.ReadAllText(filename);
    return JsonSerializer.Deserialize<Contact[]>(json).ToList();
}

void SaveToFile(IEnumerable<Contact> contacts)
{
    var json = JsonSerializer.Serialize(contacts);
    File.WriteAllText(filename, json);
}

/*
 * CRUD
 * Create <-
 * Read <- v1: fra hardkodet data, v2: fra fil
 * Update <-
 * Delete <-
 *
 * id: int vs guid
 *
 * Lagre til og lese fra fil // JSON
 *
 * Peke på materiale på Moodle
 */




/*
 * Kode for å intitalisere json-fil:
 
    if (!File.Exists(filename))
    {
        var contacts = new Contact[]{
            new Contact(1, "Terje", "terje@getacademy.no"),
            new Contact(2, "Per", "per@getacademy.no"),
        };
        var json = JsonSerializer.Serialize(contacts);
        File.WriteAllText(filename, json);
    } 
 */