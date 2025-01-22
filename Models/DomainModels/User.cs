using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Bookstore.Models
{
    public class User : IdentityUser
    {
        [NotMapped]
        // This property holds the names of the roles assigned to the user
                public IList<string> RoleNames { get; set; }
    }
}
