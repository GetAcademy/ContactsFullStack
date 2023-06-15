using System.Text.Json;
using ContactsFullStack.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var filename = "contacts.json";
if (!File.Exists(filename))
{
    var contacts = new Contact[]{
        new Contact(1, "Terje", "terje@getacademy.no"),
        new Contact(2, "Per", "per@getacademy.no"),
    };
    var json = JsonSerializer.Serialize(contacts);
    File.WriteAllText(filename, json);
}

app.MapGet("/contact", () =>
{
    var json = File.ReadAllText(filename);
    return JsonSerializer.Deserialize<Contact[]>(json);
});
app.UseStaticFiles();
app.Run();

/*
 * CRUD
 * Create
 * Read <-
 * Update
 * Delete
 *
 * Lagre til og lese fra fil // JSON
 *
 * Peke på materiale på Moodle
 */
