var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();

app.Urls.Add("http://localhost:5273/");
// app.Urls.Add("http://localhost:3000/images/pic.jpg");

app.MapGet("/", () => "Hello World!");

app.MapGet("/health", () => "Server ok");

app.MapPost("/index.html", () =>
{
    return "recived!";
});

// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
//     app.UseHsts();
// }

// app.UseHttpsRedirection();

// app.UseAuthentication();
// app.UseAuthorization();

// app.UseStaticFiles(new StaticFileOptions
// {
//     FileProvider = new PhysicalFileProvider(
//            Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
//     RequestPath = "/StaticFiles"
// });

app.Run();