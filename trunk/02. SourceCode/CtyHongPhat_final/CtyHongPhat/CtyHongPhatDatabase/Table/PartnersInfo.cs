using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class PartnersInfo
    {
        private int partnerId;
        private string partnerName = String.Empty;
        private string address = String.Empty;
        private string phoneNumber = String.Empty;
        private int deleted;

        #region Public Properties
        public int PartnerId
        {
            get { return partnerId; }
            set { partnerId = value; }
        }

        public string PartnerName
        {
            get { return partnerName; }
            set { partnerName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        #endregion
    }
}
