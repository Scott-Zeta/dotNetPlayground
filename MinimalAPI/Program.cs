using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

var builder = WebApplication.CreateBuilder(args);

//config the connection string to DB
var connectionString = builder.Configuration.GetConnectionString("Pizzas") ?? "Data Source=Pizzas.db";

builder.Services.AddEndpointsApiExplorer();
// Add connect to sqllite DB
builder.Services.AddSqlite<PizzaDb>(connectionString);
builder.Services.AddSwaggerGen(c =>
     {
         c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pizza Store API", Description = "Making the Pizzas you love", Version = "v1" });
     });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
     {
         c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
     });
}

// Interact with DB by EF built-in functions
app.MapGet("/pizzas", async (PizzaDb db) => await db.Pizzas.ToListAsync());

app.MapGet("/pizza/{id}", async (PizzaDb db, int id) =>
{
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(pizza);
});

app.MapPost("/pizza", async (PizzaDb db, Pizza pizza) =>
{
    await db.Pizzas.AddAsync(pizza);
    await db.SaveChangesAsync();
    return Results.Created($"/pizza/{pizza.Id}", pizza);
});

app.MapPut("/pizza/{id}", async (PizzaDb db, Pizza updatepizza, int id) =>
{
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza is null) return Results.NotFound();
    pizza.Name = updatepizza.Name;
    pizza.Description = updatepizza.Description;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/pizza/{id}", async (PizzaDb db, int id) =>
{
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza is null)
    {
        return Results.NotFound();
    }
    db.Pizzas.Remove(pizza);
    await db.SaveChangesAsync();
    return Results.Ok();
});

app.Run();

