namespace WebApi.Domain.Enums
{
    public class Enum
    {
        public enum Gender
        {
            Male=1,
            Female=2,
            Others=3
        }

        public enum BloodGroup
        {
            APositive=1,
            ANegative=2,
            BPositive=3,
            BNegative=4,
            ABPositive=5,
            ABNegative=6,
            OPositive=7,
            ONegative=8
        }

        public enum MaritalStatus
        {
            Single = 1,
            Married = 2,
            Divorced=3,
            Widowed=4
        }

        public enum UserAccess
        {
            Invited=1,
            NotInvited=2,
            Active=3,
            Inactive=4
        }

        public enum RequestStatus
        {
            Pending=1,
            Accepted=2,
            Rejected=3
        }

        public enum ClubType
        {
            PublicOpenClub=1,
            PublicClosedClub=2,
            PrivateClub=3
        }

        public enum Role
        {
            Owner = 1, ClubAdmin = 2, User = 3
        }


    }
}
