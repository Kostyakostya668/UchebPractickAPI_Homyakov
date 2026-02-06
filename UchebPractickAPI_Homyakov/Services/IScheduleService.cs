using UchebPractickAPI_Homyakov.DTO;

namespace UchebPractickAPI_Homyakov.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
       startDate, DateTime endDate);

        Task<List<GroupDto>> GetAllGroupsAsync();
    }
}
