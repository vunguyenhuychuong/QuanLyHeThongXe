﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class StaffAccount
    {
        public StaffAccount()
        {
           
        }

        public string StaffId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
    }
}
