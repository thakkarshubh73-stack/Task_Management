using Microsoft.EntityFrameworkCore;           
using TaskManagement_BE.AppData;
using TaskManagement_BE.Model;

namespace TaskManagement_BE.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagementEntity _context;

        public TaskRepository(TaskManagementEntity context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
            => await _context.Tasks.ToListAsync();

        public async Task<TaskItem?> GetByIdAsync(int id)
            => await _context.Tasks.FindAsync(id);

        public async Task<TaskItem> AddAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskItem> UpdateAsync(TaskItem task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Tasks.FindAsync(id);
            if (entity == null) return false;

            _context.Tasks.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}