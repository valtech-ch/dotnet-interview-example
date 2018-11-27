using System;

namespace IC.DotNet.Interview.Core.Models
{
    public class UserRole : BaseModel
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
