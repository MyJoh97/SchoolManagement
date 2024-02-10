using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolManagement.Contexts;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{


    services.AddDbContext<DataContexts>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\SQL\SchoolManagement\SchoolManagement\Data\database_school.mdf;Integrated Security=True;Connect Timeout=30"));


}).Build();