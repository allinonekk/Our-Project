﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'Subsequent.WOENCPEInfo'</summary>
    public partial class WOENCPEInfo : ISubsequent
    {
        #region Fields

        private Nullable<System.Decimal> _amountClaimed;
        private System.String _claimDesc;
        private System.String _claimObject;
        private System.String _claimRemarks;
        private MCurrency _currencyCode;
        private Nullable<System.Int32> _itemClaimed;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _submissionGroupId;
        private System.String _wOENCPEInfoId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOENCPEInfo"/> class.</summary>
        public WOENCPEInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmountClaimed field. </summary>
        public virtual Nullable<System.Decimal> AmountClaimed
        {
            get { return _amountClaimed; }
            set { _amountClaimed = value; }
        }

        /// <summary>Gets or sets the ClaimDesc field. </summary>
        public virtual System.String ClaimDesc
        {
            get { return _claimDesc; }
            set { _claimDesc = value; }
        }

        /// <summary>Gets or sets the ClaimObject field. </summary>
        public virtual System.String ClaimObject
        {
            get { return _claimObject; }
            set { _claimObject = value; }
        }

        /// <summary>Gets or sets the ClaimRemarks field. </summary>
        public virtual System.String ClaimRemarks
        {
            get { return _claimRemarks; }
            set { _claimRemarks = value; }
        }

        /// <summary>Gets or sets the CurrencyCode field. </summary>
        public virtual MCurrency CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        /// <summary>Gets or sets the ItemClaimed field. </summary>
        public virtual Nullable<System.Int32> ItemClaimed
        {
            get { return _itemClaimed; }
            set { _itemClaimed = value; }
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

        /// <summary>Gets or sets the WOENCPEInfoId field. </summary>
        public virtual System.String WOENCPEInfoId
        {
            get { return _wOENCPEInfoId; }
            set { _wOENCPEInfoId = value; }
        }

        public virtual String PropertyClaimed
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
            WOENCPEInfo toCompareWith = obj as WOENCPEInfo;
            return toCompareWith == null ? false : ((this.WOENCPEInfoId == toCompareWith.WOENCPEInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOENCPEInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}