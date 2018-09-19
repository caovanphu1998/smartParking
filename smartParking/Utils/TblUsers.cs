using System;
using System.Collections.Generic;

namespace smartParking.Utils
{
    public partial class TblUsers
    {
        public TblUsers()
        {
            TblCars = new HashSet<TblCars>();
            TblHistorys = new HashSet<TblHistorys>();
            TblMessages = new HashSet<TblMessages>();
        }

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }

        public TblAccount TblAccount { get; set; }
        public ICollection<TblCars> TblCars { get; set; }
        public ICollection<TblHistorys> TblHistorys { get; set; }
        public ICollection<TblMessages> TblMessages { get; set; }
    }
}
