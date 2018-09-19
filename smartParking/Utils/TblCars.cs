using System;
using System.Collections.Generic;

namespace smartParking.Utils
{
    public partial class TblCars
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string LicensePlate { get; set; }
        public string UserId { get; set; }

        public TblUsers User { get; set; }
    }
}
