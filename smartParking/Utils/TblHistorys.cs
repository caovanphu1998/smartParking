using System;
using System.Collections.Generic;

namespace smartParking.Utils
{
    public partial class TblHistorys
    {
        public int HistoryId { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public string Position { get; set; }
        public double? Money { get; set; }
        public string KeyCode { get; set; }
        public string UserId { get; set; }

        public TblUsers User { get; set; }
    }
}
