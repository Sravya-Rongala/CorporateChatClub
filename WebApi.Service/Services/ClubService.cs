using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Clubs.ViewModels;
using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Infrastructure.Interfaces;
using WebApi.Interfaces;

namespace WebApi.Service.Services
{
    public class ClubService : IClubService
    {
        private readonly IClubRepository _clubRepository;
        private IMapper _mapper;
        public ClubService(IClubRepository clubRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _mapper = mapper;
        }

        public IEnumerable<ClubProfileDTO> GetAllClubs(Guid UserId)
        {
            return _mapper.Map<IEnumerable<ClubProfileDTO>>(_clubRepository.GetAllClubs(UserId));
        }
        public bool ReportClub(Guid UserId, ActionUpdaterDTO action)
        {

            return _clubRepository.ReportClub(UserId, _mapper.Map<ActionUpdater>(action));
        }
        public bool UpdateClubInformation(Guid UserId, ClubInformationDTO clubInformation)
        {
            return _clubRepository.UpdateClubInformation(UserId, _mapper.Map<ClubInformation>(clubInformation));
        }
        public bool UpdateClubType(Guid UserId, Guid ClubId, int ClubType)
        {
            return _clubRepository.UpdateClubType(UserId, ClubId, ClubType);
        }

        public Guid AddClub(Guid UserId, ClubDTO club)
        {
            return _clubRepository.AddClub(UserId, _mapper.Map<Club>(club));
        }

        public bool CreateClub(Guid UserId, ClubDTO club)
        {
            var ClubId = this.AddClub(UserId, club);
            _clubRepository.AddUserToClub(UserId, ClubId, UserId, 1);
            _clubRepository.AddUserDataToClubAction(UserId, ClubId);
            var isClubExist = _clubRepository.IsClubExist(ClubId);
            if (isClubExist)
            {
                _clubRepository.AddClubToClubStatus(ClubId);
                foreach (var id in club.ClubAdmins!)
                {
                    _clubRepository.AddUserToClub(id.UserId, ClubId, UserId,2);
                    _clubRepository.AddUserDataToClubAction(id.UserId, ClubId);
                }
                foreach(var id in club.ClubMembers!)
                {
                    _clubRepository.AddUserToClub(id.UserId, ClubId, UserId,3);
                    _clubRepository.AddUserDataToClubAction(id.UserId, ClubId);
                }
                return true;
            }
            return false;
        }

        public bool CancelClubRequest(Guid UserId, Guid ClubId)
        {
            return _clubRepository.CancelClubRequest(UserId, ClubId);
        }

        public void JoinClub(Guid UserId, Guid ClubId, int ClubType)
        {
            _clubRepository.JoinClub(UserId, ClubId, ClubType);
        }
    }
}