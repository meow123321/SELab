using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SEClassroom.Models
{
    public class ApplicationUser: IdentityUser
    {
       
        public string PhotoPath { get; set; }
    }
}
