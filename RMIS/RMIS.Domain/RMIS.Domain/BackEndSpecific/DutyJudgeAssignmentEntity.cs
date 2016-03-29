using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Master;
using RMIS.Domain.Interfaces;

namespace RMIS.Domain.BackEndSpecific
{
    [Serializable]
    public class DutyJudgeAssignmentEntity:IBackEndSpecificEntity
    {
        public string DutyJudgeAssignmentId { get; set; }

        public string UserId { get; set; }

        public MForumTypeEntity MForumType { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public YesNo ObsInd { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string UserName { get; set; }
    }
}
