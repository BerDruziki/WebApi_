using user.controllers;

var builder = WebApplication.CreateBuilder(args);
var  corsPolicy_ = "corsPolicy_";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicy_,
                      policy  =>
                      {
                          policy.WithOrigins("https://localhost:7088",
                                              "http://localhost:5088");
                      });
});


var app = builder.Build();

app.UseRouting();

app.MapPost("/saveuser", userController.saveProduct);//Saver user.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

//app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(corsPolicy_);

app.MapControllers();

app.Run();
