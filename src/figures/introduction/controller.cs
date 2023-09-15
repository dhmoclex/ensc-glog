[Route("api/[controller]")]
[ApiController]
public class StudentApiController : ControllerBase
{
    private readonly UniversityContext _context;
    public StudentApiController(UniversityContext context) {}

    public async Task<ActionResult<IEnumerable<Student>>> GetStudents() {}

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id) {}

    [HttpPost]
    public async Task<ActionResult<Student>> PostStudent(Student student) {}

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id) {}
}
