using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerAppShared.Models
{
    public class UserManagerResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string[] Errors { get; set; }

        public Dictionary<string, string> UserInfo { get; set; }

        public DateTime? ExpireDate { get; set; }
    }
}
