//Brandon Le
//10-26-22
//Mini Challenge 8 - Reverse It
//Web API project that will have 2 different endpoints. One for reversing a string and one for reversing an int. Both have data validation so an error message will pop up when you enter the incorrect variable type. There is also an instructions page at the /minich8 URL. So it makes it a little easier for people to go to the two different end points. URLs also provided in the error messages for easy routing.
//Peer Review: the program looks nice there was not any flaws/errors code works properly i aprrove of the code. the links from the error codes were a good addition.


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
