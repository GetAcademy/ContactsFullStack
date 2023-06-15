using ContactsFullStack.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/contact", () =>
{
    return new Contact[]{
        new Contact(1, "Terje", "terje@getacademy.no"),
        new Contact(2, "Per", "per@getacademy.no"),
    };
});
app.UseStaticFiles();
app.Run();

/*
 * CRUD
 * Create
 * Read
 * Update
 * Delete
 */
