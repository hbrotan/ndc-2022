using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient; // >= v.3.0.0 - Viktig
using Dapper;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDeveloperExceptionPage();

app.MapGet("/", async () => {

    var connectionString = "Server=ndc-demo.database.windows.net;Database=mydatabase;Authentication=Active Directory Default;";
    
    await using var connection = new SqlConnection(connectionString);
    await connection.QueryAsync<int>("SELECT 1");

    return "Success!";
});

app.Run();