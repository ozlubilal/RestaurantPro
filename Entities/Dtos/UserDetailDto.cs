﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserDetailDto : IDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; } 
        public string Email { get; set; }
        public string ClaimName { get; set; }
    }
}
