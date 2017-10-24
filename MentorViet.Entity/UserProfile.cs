namespace MentorViet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserProfile")]
    public partial class UserProfile
    {
        public int UserProfileId { get; set; }

        [Required]
        [StringLength(50)]
        public string AspNetUserId { get; set; }

        public byte ProfileTypeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Birthday { get; set; }

        public byte? CityId { get; set; }

        [MaxLength(50)]
        public byte[] Avatar { get; set; }

        public short? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
