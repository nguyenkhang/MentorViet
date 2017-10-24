using System.Data.Entity;
using System.Linq;
using AutoMapper;
using MentorViet.Contract;
using MentorViet.Entity;
using MentorViet.Model;

namespace MentorViet.Service
{
    public class UserProfileService : BaseService, IUserProfileService
    {
        private readonly DbSet<UserProfile> _dbSetUserProfile;

        public UserProfileService(MentorVietContext dbContext) : base(dbContext)
        {
            _dbSetUserProfile = Db.Set<UserProfile>();
        }

        public void CreateUserProfile(UserProfileModel userProfileModel)
        {
            var userProfile = Mapper.Map<UserProfile>(userProfileModel);

            _dbSetUserProfile.Add(userProfile);
            Db.SaveChanges();
        }

        public UserProfileModel GetUserProfile(string aspNetUserId)
        {
            var userProfile = _dbSetUserProfile.FirstOrDefault(x => x.AspNetUserId == aspNetUserId);

            return userProfile != null ? Mapper.Map<UserProfileModel>(userProfile) : null;
        }
    }
}