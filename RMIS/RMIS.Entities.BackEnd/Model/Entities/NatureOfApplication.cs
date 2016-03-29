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

    /// <summary>Class which represents the entity 'Common.NatureOfApplication'</summary>
    public partial class NatureOfApplication : ICommon
    {
        #region Fields

        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _mainInd;
        private MNOACode _mNOACode;
        private System.String _natureOfApplicationId;
        private System.String _obsInd;
        private System.String _otherText;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="NatureOfApplication"/> class.</summary>
        public NatureOfApplication()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Common.NatureOfApplication.CaseInfo - Case.CaseInfo.NatureOfApplications (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual Int64? CaseInfoId
        {
            get;
            set;
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

        /// <summary>Gets or sets the MainInd field. </summary>
        public virtual System.String MainInd
        {
            get { return _mainInd; }
            set { _mainInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.NatureOfApplication.MNOACode - Master.MNOACode.NatureOfApplications (m:1)'</summary>
        public virtual MNOACode MNOACode
        {
            get { return _mNOACode; }
            set { _mNOACode = value; }
        }

        /// <summary>Gets or sets the NatureOfApplicationId field. </summary>
        public virtual System.String NatureOfApplicationId
        {
            get { return _natureOfApplicationId; }
            set { _natureOfApplicationId = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the OtherText field. </summary>
        public virtual System.String OtherText
        {
            get { return _otherText; }
            set { _otherText = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.NatureOfApplication.SubCaseInfo - SubCase.SubCaseInfo.NatureOfApplications (m:1)'</summary>
        //public virtual SubCaseInfo SubCaseInfo
        //{
        //    get { return _subCaseInfo; }
        //    set { _subCaseInfo = value; }
        //}
        /// <summary>Gets the SubCaseInfoId field. </summary>
        public virtual Nullable<System.Int64> SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
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
            NatureOfApplication toCompareWith = obj as NatureOfApplication;
            return toCompareWith == null ? false : ((this.NatureOfApplicationId == toCompareWith.NatureOfApplicationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NatureOfApplicationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}