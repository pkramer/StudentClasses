using AutoMapper;
using StudentClasses.Contracts;
using StudentClasses.Entities.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentClasses.Controllers
{
    [Route("api/subjects")]
    [Authorize]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public SubjectsController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetSubjects()
        {
            try
            {
                var claims = User.Claims;

                var subjects = _repository.Subject.GetAllSubjects(trackChanges: false);

                var subjectsDto = _mapper.Map<IEnumerable<SubjectDto>>(subjects);

                return Ok(subjectsDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}