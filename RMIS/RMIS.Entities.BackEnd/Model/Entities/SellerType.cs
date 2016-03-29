using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd.Model.Entities
{
    public class SellerType
    {
        private string _SellerTypeID;
        private string _CustID;
        private string _SellerType;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private char _ObsInd;

        public string SellerTypeID { get; set; }
        public string  CustID { get; set; }
        public string Type { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public char ObsInd { get; set; }
    }
}
