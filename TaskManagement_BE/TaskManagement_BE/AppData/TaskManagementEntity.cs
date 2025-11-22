using Microsoft.EntityFrameworkCore;                 
using TaskManagement_BE.Model;                       

namespace TaskManagement_BE.AppData
{
    public class TaskManagementEntity : DbContext
    {
        public TaskManagementEntity(DbContextOptions<TaskManagementEntity> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; } = null!;

        
    }
}