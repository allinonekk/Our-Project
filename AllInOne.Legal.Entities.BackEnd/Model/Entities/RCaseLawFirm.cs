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

    /// <summary>Class which represents the entity 'Case.RCaseLawFirm'</summary>
    public partial class RCaseLawFirm : ICase
    {
        #region Fields

        //private CaseInfo _caseInfo;
        private System.Int64 _caseInfoId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _lFFileRefNumber;

        //private LawFirm _lawFirm;
        private System.String _lFID;
        private System.String _obsInd;
        private System.String _rCLFId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RCaseLawFirm"/> class.</summary>
        public RCaseLawFirm()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.RCaseLawFirm.CaseInfo - Case.CaseInfo.RCaseLawFirms (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual System.Int64 CaseInfoId
        {
            get { return _caseInfoId; }
            set { _caseInfoId = value; }
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

        /// <summary>Gets or sets the LFFileRefNumber field. </summary>
        public virtual System.String LFFileRefNumber
        {
            get { return _lFFileRefNumber; }
            set { _lFFileRefNumber = value; }
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'Case.RCaseLawFirm.LawFirm - LawFirm.LawFirm.RCaseLawFirms (m:1)'</summary>
        //public virtual LawFirm LawFirm
        //{
        //   get { return _lawFirm; }
        //    set { _lawFirm = value; }
        //}
        /// <summary>Gets or sets the LFID field. </summary>
        public virtual System.String LFID
        {
            get { return _lFID; }
            set { _lFID = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the RCLFId field. </summary>
        public virtual System.String RCLFId
        {
            get { return _rCLFId; }
            set { _rCLFId = value; }
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
            RCaseLawFirm toCompareWith = obj as RCaseLawFirm;
            return toCompareWith == null ? false : ((this.RCLFId == toCompareWith.RCLFId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RCLFId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}