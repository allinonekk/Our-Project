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

    /// <summary>Class which represents the entity 'Master.MPersonIDGroup'</summary>
    public partial class MPersonIDGroup : IMaster
    {
        #region Fields

        private System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> _bankruptcyOtherDefDetails;
        private System.Collections.Generic.ICollection<CaseParty> _caseParties;
        private System.Collections.Generic.ICollection<CasePartyAICDetail> _casePartyAICDetails;
        private System.Collections.Generic.ICollection<CaveatAAInfo> _caveatAAInfos;
        private System.Collections.Generic.ICollection<DeceasedInfo> _deceasedInfos;
        private System.Collections.Generic.ICollection<DocCaseParty> _docCaseParties;
        private System.Collections.Generic.ICollection<DocCasePartyAICDetail> _docCasePartyAICDetails;
        private System.String _idGroupCode;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<LiquidatorPIC> _liquidatorPICs;
        private System.Collections.Generic.ICollection<Liquidator> _liquidators;
        private System.String _obsInd;
        private System.Int32 _seqNo;
        private System.String _uIDescription;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPersonIDGroup"/> class.</summary>
        public MPersonIDGroup()
            : base()
        {
            _caseParties = new System.Collections.Generic.HashSet<CaseParty>();
            _casePartyAICDetails = new System.Collections.Generic.HashSet<CasePartyAICDetail>();
            _bankruptcyOtherDefDetails = new System.Collections.Generic.HashSet<BankruptcyOtherDefDetail>();
            _caveatAAInfos = new System.Collections.Generic.HashSet<CaveatAAInfo>();
            _deceasedInfos = new System.Collections.Generic.HashSet<DeceasedInfo>();
            _liquidators = new System.Collections.Generic.HashSet<Liquidator>();
            _liquidatorPICs = new System.Collections.Generic.HashSet<LiquidatorPIC>();
            _docCaseParties = new System.Collections.Generic.HashSet<DocCaseParty>();
            _docCasePartyAICDetails = new System.Collections.Generic.HashSet<DocCasePartyAICDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.BankruptcyOtherDefDetail.MPersonIDGroup - Master.MPersonIDGroup.BankruptcyOtherDefDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<BankruptcyOtherDefDetail> BankruptcyOtherDefDetails
        {
            get { return _bankruptcyOtherDefDetails; }
            set { _bankruptcyOtherDefDetails = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MPersonIDGroup - Master.MPersonIDGroup.CaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> CaseParties
        {
            get { return _caseParties; }
            set { _caseParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CasePartyAICDetail.MPersonIDGroup - Master.MPersonIDGroup.CasePartyAICDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CasePartyAICDetail> CasePartyAICDetails
        {
            get { return _casePartyAICDetails; }
            set { _casePartyAICDetails = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.CaveatAAInfo.MPersonIDGroup - Master.MPersonIDGroup.CaveatAAInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaveatAAInfo> CaveatAAInfos
        {
            get { return _caveatAAInfos; }
            set { _caveatAAInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.DeceasedInfo.MPersonIDGroup - Master.MPersonIDGroup.DeceasedInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DeceasedInfo> DeceasedInfos
        {
            get { return _deceasedInfos; }
            set { _deceasedInfos = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MPersonIDGroup - Master.MPersonIDGroup.DocCaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> DocCaseParties
        {
            get { return _docCaseParties; }
            set { _docCaseParties = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCasePartyAICDetail.MPersonIDGroup - Master.MPersonIDGroup.DocCasePartyAICDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCasePartyAICDetail> DocCasePartyAICDetails
        {
            get { return _docCasePartyAICDetails; }
            set { _docCasePartyAICDetails = value; }
        }

        /// <summary>Gets or sets the IdGroupCode field. </summary>
        public virtual System.String IdGroupCode
        {
            get { return _idGroupCode; }
            set { _idGroupCode = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LiquidatorPIC.MPersonIDGroup - Master.MPersonIDGroup.LiquidatorPICs (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<LiquidatorPIC> LiquidatorPICs
        {
            get { return _liquidatorPICs; }
            set { _liquidatorPICs = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.Liquidator.MPersonIDGroup - Master.MPersonIDGroup.Liquidators (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Liquidator> Liquidators
        {
            get { return _liquidators; }
            set { _liquidators = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the SeqNo field. </summary>
        public virtual System.Int32 SeqNo
        {
            get { return _seqNo; }
            set { _seqNo = value; }
        }

        /// <summary>Gets or sets the UIDescription field. </summary>
        public virtual System.String UIDescription
        {
            get { return _uIDescription; }
            set { _uIDescription = value; }
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
            MPersonIDGroup toCompareWith = obj as MPersonIDGroup;
            return toCompareWith == null ? false : ((this.IdGroupCode == toCompareWith.IdGroupCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.IdGroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}