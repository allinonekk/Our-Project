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

    /// <summary>Class which represents the entity 'Subsequent.DisWithDocPtyDetail'</summary>
    public partial class DisWithDocPtyDetail : ISubsequent
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DisWithDocPtyDetail"/> class.</summary>
        public DisWithDocPtyDetail()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the LPALPRSectionType field. </summary>
        public virtual System.String ConsentInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AASQualificationRemarks field. </summary>
        public virtual System.String DisWithDocDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AASInfoId field. </summary>
        public virtual System.String DisWithDocPtyDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the QualifiedPersonDate field. </summary>
        public virtual MWithDrawalInType MWithDrawalInType
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.AASInfo.MAASQualification - Master.MAASQualification.AASInfos (m:1)'</summary>
        public virtual MWithDrawalOfType MWithdrawalOfType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get;
            set;
        }

        public virtual String WithInRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsMLawExemptionApproved field. </summary>
        public virtual System.String WithPartyAgainst
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BLEDocExemptionRemarks field. </summary>
        public virtual System.String WithPartyID
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            DisWithDocPtyDetail toCompareWith = obj as DisWithDocPtyDetail;
            return toCompareWith == null ? false : ((this.DisWithDocDetailId == toCompareWith.DisWithDocDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DisWithDocDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}