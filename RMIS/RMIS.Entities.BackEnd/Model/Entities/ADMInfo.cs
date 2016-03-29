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

    /// <summary>Class which represents the entity 'CaseSpecific.ADMInfo'</summary>
    public partial class ADMInfo : ICaseSpecific
    {
        #region Fields

        private System.String _aDMInfoId;
        private System.String _admiraltyWritType;
        private System.String _attachmentType;
        private Nullable<System.DateTime> _caveatSearchDateTime;
        private System.String _caveatSearchResult;
        private System.String _isInjunctionFiled;
        private System.String _isManagedEWT;
        private System.String _isPartnerInFirm;
        private System.String _isServeOutJDC;
        private System.String _isWOARequired;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _submissionGroupId;
        private Nullable<System.Decimal> _totalLIQAwardedAmount;
        private Nullable<System.Decimal> _totalLIQClaimAmount;
        private Nullable<System.Decimal> _totalUnLIQESTAmount;
        private Nullable<System.Decimal> _totlaUnLIQAwardedAmount;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ADMInfo"/> class.</summary>
        public ADMInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ADMInfoId field. </summary>
        public virtual System.String ADMInfoId
        {
            get { return _aDMInfoId; }
            set { _aDMInfoId = value; }
        }

        /// <summary>Gets or sets the AdmiraltyWritType field. </summary>
        public virtual System.String AdmiraltyWritType
        {
            get { return _admiraltyWritType; }
            set { _admiraltyWritType = value; }
        }

        /// <summary>Gets or sets the AttachmentType field. </summary>
        public virtual System.String AttachmentType
        {
            get { return _attachmentType; }
            set { _attachmentType = value; }
        }

        /// <summary>Gets or sets the CaveatSearchDateTime field. </summary>
        public virtual Nullable<System.DateTime> CaveatSearchDateTime
        {
            get { return _caveatSearchDateTime; }
            set { _caveatSearchDateTime = value; }
        }

        /// <summary>Gets or sets the CaveatSearchResult field. </summary>
        public virtual System.String CaveatSearchResult
        {
            get { return _caveatSearchResult; }
            set { _caveatSearchResult = value; }
        }

        /// <summary>Gets or sets the IsInjunctionFiled field. </summary>
        public virtual System.String IsInjunctionFiled
        {
            get { return _isInjunctionFiled; }
            set { _isInjunctionFiled = value; }
        }

        /// <summary>Gets or sets the IsManagedEWT field. </summary>
        public virtual System.String IsManagedEWT
        {
            get { return _isManagedEWT; }
            set { _isManagedEWT = value; }
        }

        /// <summary>Gets or sets the IsPartnerInFirm field. </summary>
        public virtual System.String IsPartnerInFirm
        {
            get { return _isPartnerInFirm; }
            set { _isPartnerInFirm = value; }
        }

        /// <summary>Gets or sets the IsServeOutJDC field. </summary>
        public virtual System.String IsServeOutJDC
        {
            get { return _isServeOutJDC; }
            set { _isServeOutJDC = value; }
        }

        /// <summary>Gets or sets the IsWOARequired field. </summary>
        public virtual System.String IsWOARequired
        {
            get { return _isWOARequired; }
            set { _isWOARequired = value; }
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set { _lastModifiedBy = value; }
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>Gets or sets the TotalLIQAwardedAmount field. </summary>
        public virtual Nullable<System.Decimal> TotalLIQAwardedAmount
        {
            get { return _totalLIQAwardedAmount; }
            set { _totalLIQAwardedAmount = value; }
        }

        /// <summary>Gets or sets the TotalLIQClaimAmount field. </summary>
        public virtual Nullable<System.Decimal> TotalLIQClaimAmount
        {
            get { return _totalLIQClaimAmount; }
            set { _totalLIQClaimAmount = value; }
        }

        /// <summary>Gets or sets the TotalUnLIQESTAmount field. </summary>
        public virtual Nullable<System.Decimal> TotalUnLIQESTAmount
        {
            get { return _totalUnLIQESTAmount; }
            set { _totalUnLIQESTAmount = value; }
        }

        /// <summary>Gets or sets the TotlaUnLIQAwardedAmount field. </summary>
        public virtual Nullable<System.Decimal> TotlaUnLIQAwardedAmount
        {
            get { return _totlaUnLIQAwardedAmount; }
            set { _totlaUnLIQAwardedAmount = value; }
        }

        /// <summary>Gets or sets the WritAmount field. </summary>
        public virtual Nullable<System.Decimal> WritAmount
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
            ADMInfo toCompareWith = obj as ADMInfo;
            return toCompareWith == null ? false : ((this.ADMInfoId == toCompareWith.ADMInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADMInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}