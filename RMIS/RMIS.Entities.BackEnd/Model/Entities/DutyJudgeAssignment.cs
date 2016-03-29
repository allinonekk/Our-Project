﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace RMIS.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'BackEndSpecific.DutyJudgeAssignment'</summary>
    public partial class DutyJudgeAssignment : IBackEndSpecific
    {
        #region Properties

        public virtual string DutyJudgeAssignmentId { get; set; }

        public virtual string UserId { get; set; }

        public virtual MForumType MForumType { get; set; }

        public virtual DateTime FromDate { get; set; }

        public virtual DateTime ToDate { get; set; }

        public virtual string ObsInd { get; set; }

        public virtual string LastModifiedBy { get; set; }

        public virtual DateTime LastModifiedDate { get; set; }

        #endregion

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            DutyJudgeAssignment toCompareWith = obj as DutyJudgeAssignment;
            return toCompareWith == null ? false : ((this.DutyJudgeAssignmentId == toCompareWith.DutyJudgeAssignmentId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DutyJudgeAssignmentId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}