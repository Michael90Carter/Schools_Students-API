using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schools;

namespace Inco_webAPI.V2.Controllers
{
    [Route("api/schools")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SchoolsController(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetSchools()
        {
            /* try
             {
                 var schools = _repository.School.GetAllSchools(trackChanges: false);

                 *//*return Ok(schools);*//*


                 var schoolsDto = schools.Select(c => new SchoolDto
                 {
                     Id = c.Id,
                     Name = c.Name,
                     Address = string.Join(' ', c.Address, c.Country)
                 }).ToList();

                 return Ok(schoolsDto);

             }
             catch (Exception ex)
             {
                 _logger.LogError($"Something went wrong in the {nameof(GetSchools)} action {ex}");
             return StatusCode(500, "Internal server error");
             }*/

            var schools = _repository.School.GetAllSchools(trackChanges: false);

            var schoolsDto = _mapper.Map<IEnumerable<SchoolDto>>(schools);

            return Ok(schoolsDto);
        }

    }
}
