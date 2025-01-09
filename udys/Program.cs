var builder = WebApplication.CreateBuilder(args);
 
// Configure Kestrel to read settings from appsettings.json (Optional, it will read by default)

builder.WebHost.ConfigureKestrel(options =>

{

    // You could explicitly configure Kestrel here, but it's generally managed via appsettings.json.

    // This is not needed unless you want to add additional customization for Kestrel.

});
 
// Add services to the container.

builder.Services.AddRazorPages();
 
var app = builder.Build();
 
// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())

{

    app.UseExceptionHandler("/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.

    app.UseHsts();

}
 
app.UseHttpsRedirection();

app.UseStaticFiles();
 
app.UseRouting();
 
app.UseAuthorization();
 
app.MapRazorPages();
 
app.Run();

 