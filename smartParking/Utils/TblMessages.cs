using System;
using System.Collections.Generic;

namespace smartParking.Utils
{
    public partial class TblMessages
    {
        public int MessId { get; set; }
        public DateTime? Time { get; set; }
        public string Message { get; set; }
        public string MessStatus { get; set; }
        public string UserId { get; set; }

        public TblUsers User { get; set; }
    }
}
