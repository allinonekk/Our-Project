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

    /// <summary>Class which represents the entity 'Master.MBailType'</summary>
    public partial class MBailType : IMaster
    {
        #region Fields

        private System.String _bailTypeCode;
        private System.Collections.Generic.ICollection<CasePartyBailorInfo> _casePartyBailorInfos;
        private System.String _description;
        private System.Collections.Generic.ICollection<DocCasePartyBailorInfo> _docCasePartyBailorInfos;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MBailType"/> class.</summary>
        public MBailType()
            : base()
        {
            _casePartyBailorInfos = new System.Collections.Generic.HashSet<CasePartyBailorInfo>();
            _docCasePartyBailorInfos = new System.Collections.Generic.HashSet<DocCasePartyBailorInfo>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the BailTypeCode field. </summary>
        public virtual System.String BailTypeCode
        {
            get { return _bailTypeCode; }
            set { _bailTypeCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyBailorInfo.MBailType - Master.MBailType.CasePartyBailorInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyBailorInfo> CasePartyBailorInfos
        {
            get { return _casePartyBailorInfos; }
            set { _casePartyBailorInfos = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyBailorInfo.MBailType - Master.MBailType.DocCasePartyBailorInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyBailorInfo> DocCasePartyBailorInfos
        {
            get { return _docCasePartyBailorInfos; }
            set { _docCasePartyBailorInfos = value; }
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
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
            MBailType toCompareWith = obj as MBailType;
            return toCompareWith == null ? false : ((this.BailTypeCode == toCompareWith.BailTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BailTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}