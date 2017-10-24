using System;

namespace MentorViet.Model
{
    public class UserProfileModel
    {
        public int UserProfileId { get; set; }

        public string AspNetUserId { get; set; }

        public byte ProfileTypeId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }

        public byte? CityId { get; set; }

        public byte[] Avatar { get; set; }

        public short? CategoryId { get; set; }
    }
}