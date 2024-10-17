using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;
using StarWars.Components;
using StarWarsModels;
using System.Text.RegularExpressions;
using static MudBlazor.CategoryTypes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddHttpClient();
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var httpClient = app.Services.GetRequiredService<HttpClient>();

using (var ctx = new ApplicationDbContext())
{
    if ((await ctx.Starship.ToListAsync()).Count == 0)
    {
        var jsonResponse = "";
        var nextURL = "https://swapi.dev/api/starships/";
        do
        {
            using HttpResponseMessage response = await httpClient.GetAsync(nextURL);

            if (!response.IsSuccessStatusCode)
                break;

            jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");
            if (jsonResponse is string json)
            {
                StarshipsGetResponse? APIResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<StarshipsGetResponse>(json);

                foreach (var shipAPI in APIResponse?.results ?? [])
                    ctx.Add(new Starship(shipAPI));
                nextURL = APIResponse?.next ?? "";
            }
            response.Dispose();
        }
        while (!string.IsNullOrEmpty(nextURL));
        await ctx.SaveChangesAsync();
        await ctx.DisposeAsync();
    }
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

await app.RunAsync();