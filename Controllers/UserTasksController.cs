using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orbit.Models;

[Route("api/[controller]")]
[ApiController]
public class UserTasksController : ControllerBase
{
    private readonly UserTaskContext _context;
    public UserTasksController(UserTaskContext context)
    {
        _context = context;
    }

    // GET: api/Task
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserTask>>> GetTask()
    {
        return await _context.Tasks.ToListAsync();
    }

    // GET: api/Task/5
    [HttpGet("{id}")]
    public async Task<ActionResult<UserTask>> GetTask(int id)
    {
        var task = await _context.Tasks.FindAsync(id);

        if (task == null)
        {
            return NotFound();
        }

        return task;
    }

    // PUT: api/Task/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTask(int? id, Task task)
    {
        if (id != task.Id)
        {
            return BadRequest();
        }

        _context.Entry(task).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TaskExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Task
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<UserTask>> PostTask(UserTask task)
    {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTask", new { id = task.Id }, task);
    }

    // DELETE: api/Task/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTask(int? id)
    {
        var task = await _context.Tasks.FindAsync(id);
        if (task == null)
        {
            return NotFound();
        }

        _context.Tasks.Remove(task);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TaskExists(int? id)
    {
        return _context.Tasks.Any(e => e.Id == id);
    }
}
