﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEClassroom.Models
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
