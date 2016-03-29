using System.Collections.Generic;
using RMIS.Domain.Common;
using RMIS.Domain.Interfaces;
using System;

namespace RMIS.Domain.CaseData
{
    [Serializable]
    public class RFLData : ICaseTypeInfo
    {
        #region Properties

        public List<RegistrationOfForeignLawyerEntity> ListRegistrationOfForeignLawyerEntity
        {
            get;
            set;
        }
        public List<ForeignUserRegAddressDetailsEntity> ListForeignUserRegAddressDetailsEntity
        {
            get;
            set;
        }
        public List<ForeignUserPracticeInformationEntity> ListForeignUserPracticeInformationEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}
