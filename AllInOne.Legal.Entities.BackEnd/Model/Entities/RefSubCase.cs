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

    /// <summary>Class which represents the entity 'Common.RefSubCase'</summary>
    public partial class RefSubCase : ICommon
    {
        #region Fields

        private System.Int64 _caseInfoId;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _refSubCaseId;
        private System.Int64 _subCaseInfoId;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RefSubCase"/> class.</summary>
        public RefSubCase()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public virtual System.Int64 CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public virtual System.Int32 ItemNo
        {
            get { return _itemNo; }
            set { _itemNo = value; }
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

        /// <summary>Gets or sets the AdditionalDetails field. </summary>
        public virtual System.String RefSubCaseId
        {
            get { return _refSubCaseId; }
            set { _refSubCaseId = value; }
        }

        public virtual System.Int64 SubCaseInfoId
        {
            get { return _subCaseInfoId; }
            set { _subCaseInfoId = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        public virtual String ClaimantPartyId
        {
            get;
            set;
        }

        public virtual string ClaimantDCPId
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
            RefSubCase toCompareWith = obj as RefSubCase;
            return toCompareWith == null ? false : ((this.RefSubCaseId == toCompareWith.RefSubCaseId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RefSubCaseId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}