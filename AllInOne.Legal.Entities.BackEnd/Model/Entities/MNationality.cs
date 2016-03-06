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

    /// <summary>Class which represents the entity 'Master.MNationality'</summary>
    public partial class MNationality : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<CaseParty> _caseParties;
        private System.Collections.Generic.ICollection<ChildInfo> _childInfos;
        private System.Collections.Generic.ICollection<DeceasedInfo> _deceasedInfos;
        private System.String _description;
        private System.Collections.Generic.ICollection<DocCaseParty> _docCaseParties;
        private Nullable<System.Int32> _frequencyInd;
        private System.Collections.Generic.ICollection<InfantInfo> _infantInfos;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _nationalityCode;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<Solicitor> _solicitorNationality;
        private System.Collections.Generic.ICollection<Solicitor> _solicitorNationalityCode;
        private Nullable<System.Int32> _sortingType;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MNationality"/> class.</summary>
        public MNationality()
            : base()
        {
            _caseParties = new System.Collections.Generic.HashSet<CaseParty>();
            _childInfos = new System.Collections.Generic.HashSet<ChildInfo>();
            _deceasedInfos = new System.Collections.Generic.HashSet<DeceasedInfo>();
            _infantInfos = new System.Collections.Generic.HashSet<InfantInfo>();
            _solicitorNationality = new System.Collections.Generic.HashSet<Solicitor>();
            _solicitorNationalityCode = new System.Collections.Generic.HashSet<Solicitor>();
            _docCaseParties = new System.Collections.Generic.HashSet<DocCaseParty>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MNationality - Master.MNationality.CaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> CaseParties
        {
            get { return _caseParties; }
            set { _caseParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.ChildInfo.MNationality - Master.MNationality.ChildInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<ChildInfo> ChildInfos
        {
            get { return _childInfos; }
            set { _childInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DeceasedInfo.MNationality - Master.MNationality.DeceasedInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DeceasedInfo> DeceasedInfos
        {
            get { return _deceasedInfos; }
            set { _deceasedInfos = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MNationality - Master.MNationality.DocCaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> DocCaseParties
        {
            get { return _docCaseParties; }
            set { _docCaseParties = value; }
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public virtual Nullable<System.Int32> FrequencyInd
        {
            get { return _frequencyInd; }
            set { _frequencyInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.InfantInfo.MNationality - Master.MNationality.InfantInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<InfantInfo> InfantInfos
        {
            get { return _infantInfos; }
            set { _infantInfos = value; }
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

        /// <summary>Gets or sets the NationalityCode field. </summary>
        public virtual System.String NationalityCode
        {
            get { return _nationalityCode; }
            set { _nationalityCode = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Solicitor.SolicitorNationality - Master.MNationality.SolicitorNationality (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Solicitor> SolicitorNationality
        {
            get { return _solicitorNationality; }
            set { _solicitorNationality = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Solicitor.SolicitorNationalityCode - Master.MNationality.SolicitorNationalityCode (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Solicitor> SolicitorNationalityCode
        {
            get { return _solicitorNationalityCode; }
            set { _solicitorNationalityCode = value; }
        }

        /// <summary>Gets or sets the SortingType field. </summary>
        public virtual Nullable<System.Int32> SortingType
        {
            get { return _sortingType; }
            set { _sortingType = value; }
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
            MNationality toCompareWith = obj as MNationality;
            return toCompareWith == null ? false : ((this.NationalityCode == toCompareWith.NationalityCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NationalityCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}