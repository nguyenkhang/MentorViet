using MentorViet.Entity;
using MentorViet.Model;

namespace MentorViet.WebApplication
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserProfile, UserProfileModel>();
                cfg.CreateMap<UserProfileModel, UserProfile>();
            });
        }
    }
}