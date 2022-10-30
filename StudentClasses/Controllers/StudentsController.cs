using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentClasses.Contracts;
using StudentClasses.Entities.DataTransferObjects;

namespace StudentClasses.Controllers
{
    [Route("api/students")]
    [Authorize]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public StudentsController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            try
            {
                var claims = User.Claims;

                var students = _repository.Student.GetAllStudents(trackChanges: false);

                var studentsDto = _mapper.Map<IEnumerable<StudentDto>>(students);

                return Ok(studentsDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
