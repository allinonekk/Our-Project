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

    /// <summary>Class which represents the entity 'CaseSpecific.TaxationClaim'</summary>
    public partial class TaxationClaim : ICaseSpecific
    {
        #region Properties

        public virtual Decimal? AwardedAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MBasisOfTaxationType field. </summary>
        public virtual Decimal? ClaimAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual String HRGTypeCode
        {
            get;
            set;
        }

        public virtual String Instructions
        {
            get;
            set;
        }

        public virtual String IsCorrectInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual String Remarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public virtual String SectionNumber
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BOTRemarks field. </summary>
        public virtual String SubmissionGroupId
        {
            get;
            set;
        }

        public virtual Decimal? SumAwardedAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TaxationBOTDetailId field. </summary>
        public virtual String TaxationClaimId
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
            if (obj == null)
            {
                return false;
            }
            TaxationClaim toCompareWith = obj as TaxationClaim;
            return toCompareWith == null ? false : ((this.TaxationClaimId == toCompareWith.TaxationClaimId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TaxationClaimId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}