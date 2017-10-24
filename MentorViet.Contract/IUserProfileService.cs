using MentorViet.Model;

namespace MentorViet.Contract
{
    public interface IUserProfileService
    {
        void CreateUserProfile(UserProfileModel userProfileModel);

        UserProfileModel GetUserProfile(string aspNetUserId);
    }
}