using System.Data.Entity;
using MentorViet.Entity;

namespace MentorViet.Service
{
    public class BaseService
    {
        protected DbContext Db { get; }

        public BaseService(MentorVietContext dbContext)
        {
            Db = dbContext;
        }
    }
}