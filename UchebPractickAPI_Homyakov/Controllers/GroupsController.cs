using Microsoft.AspNetCore.Mvc;
using UchebPractickAPI_Homyakov.DTO;
using UchebPractickAPI_Homyakov.Services;

namespace UchebPractickAPI_Homyakov.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly IScheduleService _service;

        public GroupsController(IScheduleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<GroupDto>>> GetAllGroups()
        {
            var groups = await _service.GetAllGroupsAsync();
            return Ok(groups);
        }
    }
}
