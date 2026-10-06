
using DAL;
using DAL.Classes;

using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// הוספת שירותים ל-Container (לדוגמה: Controllers)
builder.Services.AddControllers();

var app = builder.Build();

// הגדרת ה-Middlewares והניתובים
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

app.Run();