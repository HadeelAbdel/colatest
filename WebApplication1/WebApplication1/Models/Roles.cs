﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ColaProject.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        [Key]
        [Column("RoleID")]
        public int RoleId { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        [InverseProperty("Role")]
        public virtual ICollection<Users> Users { get; set; }
    }
}
