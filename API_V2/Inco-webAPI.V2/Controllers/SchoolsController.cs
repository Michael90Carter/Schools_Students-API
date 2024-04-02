using AutoMapper;
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

            var schools = _repository.School.GetAllSchools(trackChanges: false);

            var schoolsDto = _mapper.Map<IEnumerable<SchoolDto>>(schools);

            return Ok(schoolsDto);
        }

    }
}
