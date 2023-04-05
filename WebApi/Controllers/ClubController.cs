using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DTO;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/club")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        [HttpGet("all/{userid:Guid}")]
        public IEnumerable<ClubProfileDTO> GetAllClubs(Guid userid)
        {
            return _clubService.GetAllClubs(userid);
        }

        [HttpPost("report/{userid:Guid}")]
        public bool ReportClub(Guid userid, ActionUpdaterDTO action)
        {
            return _clubService.ReportClub(userid, action);
        }

        [HttpPut("information/{userid:Guid}")]
        public bool UpdateClubInformation(Guid userid, ClubInformationDTO clubInformation)
        {
            return _clubService.UpdateClubInformation(userid, clubInformation);
        }

        [HttpPut("type/{userid:Guid}")]
        public bool UpdateClubType(Guid userid, Guid ClubId, int ClubType)
        {
            return _clubService.UpdateClubType(userid, ClubId, ClubType);
        }

        [HttpPost("create/{userid:Guid}")]
        public Guid CreateClub(Guid userid, ClubDTO club)
        {
            return _clubService.CreateClub(userid, club);
        }

        [HttpPost("join/{userid:Guid}")]
        public void JoinClub(Guid userid, Guid ClubId)
        {
            _clubService.JoinClub(userid, ClubId);
        }

        [HttpDelete("cancelrequest/{userid:Guid}")]
        public bool CancelClubRequest(Guid userid, Guid ClubId)
        {
            return _clubService.CancelClubRequest(userid, ClubId);
        }

    }
}