using System;
using System.Collections.Generic;

namespace smartParking.Utils
{
    public partial class TblAccount
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }

        public TblUsers User { get; set; }
    }
}
