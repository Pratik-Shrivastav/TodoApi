using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data;

public class TodoContext : DbContext
{
    private string _connectionString;
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    public TodoContext()
    {
        _connectionString = @"Server=DELL1615\SQLEXPRESS;Database=todolistdb;User Id=DELL1615\Aurionpro;Password=;Integrated Security=True;Encrypt=False;";
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}