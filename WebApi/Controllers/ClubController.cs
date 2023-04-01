/*using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Domain.ViewModels.Clubs;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        public ClubController()
        {

        }

        [HttpGet("all/{userid}")]
        public IEnumerable<ClubProfile> GetAllClubs(Guid UserId)
        {
            IEnumerable<ClubProfile> allClubs = new List<ClubProfile>();
            return allClubs;
        }

        [HttpPut("report/{clubid}/{userid}")]
        public void ReportClub(Guid Clubid,Guid UserId)
        {

        }

        [HttpPut("information")]
        public void UpdateClubInformation(ClubInformation clubInformation)
        {

        }

        [HttpPut("type/{clubid}/{userid}")]
        public void UpdateClubType(Guid UserId, Guid ClubId,int ClubType)
        {

        }

        [HttpPost("create")]
        public void CreateClub(Club club)
        {

        }

        [HttpPost("join/{userid}/{clubid}")]
        public void JoinClub(Guid UserId, Guid ClubId)
        {

        }

        [HttpDelete("cancelrequest/{clubid}/{userid}")]
        public void CancelClubRequest(Guid ClubId, Guid UserId)
        {

        }

    }
}
*/