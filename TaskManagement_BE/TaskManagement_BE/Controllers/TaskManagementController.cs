using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement_BE.DTOs;
using TaskManagement_BE.Model;
using TaskManagement_BE.Repository;

namespace TaskManagement_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagementController : ControllerBase
    {
        private readonly ITaskRepository _repo;

        public TaskManagementController(ITaskRepository repo)
        {
            _repo = repo;
        }

        [HttpGet] 
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _repo.GetAllAsync();
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskDto dto)
        {
            var task = new TaskItem
            {
                Title = dto.Title,
                Description = dto.Description,
                DueDate = dto.DueDate,
                Status = dto.Status,

                CreatedAt = DateTime.Now,
               
                MachineName = Environment.MachineName
            };

            await _repo.AddAsync(task);
            return Ok(task);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TaskDto dto)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.Title = dto.Title;
            existing.Description = dto.Description;
            existing.DueDate = dto.DueDate;
            existing.Status = dto.Status;

            existing.UpdatedAt = DateTime.Now;
            
            await _repo.UpdateAsync(existing);
            return Ok(existing);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _repo.DeleteAsync(id);
            if (!result) return NotFound();

            return Ok("Task deleted successfully.");
        }

    }
}
