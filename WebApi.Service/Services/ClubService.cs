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
        public Guid CreateClub(Guid UserId, ClubDTO club)
        {
            return _clubRepository.CreateClub(UserId, _mapper.Map<Club>(club));
        }
        public bool CancelClubRequest(Guid UserId, Guid ClubId)
        {
            return _clubRepository.CancelClubRequest(UserId, ClubId);
        }
        public void JoinClub(Guid UserId, Guid ClubId)
        {
            _clubRepository.JoinClub(UserId, ClubId);
        }
    }
}