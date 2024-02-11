using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolManagement;
using SchoolManagement.Contexts;
using SchoolManagement.Repositories;
using SchoolManagement.Services;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{


    services.AddDbContext<DataContexts>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\SQL\SchoolManagement\SchoolManagement\Data\database_school.mdf;Integrated Security=True;Connect Timeout=30"));

    services.AddScoped<ContactInfoRepository>();
    services.AddScoped<SchoolRepository>();
    services.AddScoped<RoleRepository>();
    services.AddScoped<CourseRepository>();
    services.AddScoped<MemberRepository>();


    services.AddScoped<ContactInfoService>();
    services.AddScoped<SchoolService>();
    services.AddScoped<RoleService>();
    services.AddScoped<CourseService>();
    services.AddScoped<MemberService>();

    services.AddSingleton<SchoolManagementUI>();


}).Build();


var schoolManagementUI = builder.Services.GetRequiredService<SchoolManagementUI>();
//schoolManagementUI.CreateCourse_UI();
//schoolManagementUI.GetCourses_UI();
schoolManagementUI.UpdateCourse_UI();