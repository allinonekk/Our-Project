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

    /// <summary>Class which represents the entity 'Master.MApplicantCapacity'</summary>
    public partial class MApplicantCapacity : IMaster
    {
        #region Fields

        private System.String _applicantCapacityCode;
        private System.Collections.Generic.ICollection<CaseParty> _caseParties;
        private System.String _description;
        private System.Collections.Generic.ICollection<DocCaseParty> _docCaseParties;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _probateNatureCode;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MApplicantCapacity"/> class.</summary>
        public MApplicantCapacity()
            : base()
        {
            _caseParties = new System.Collections.Generic.HashSet<CaseParty>();
            _docCaseParties = new System.Collections.Generic.HashSet<DocCaseParty>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ApplicantCapacityCode field. </summary>
        public virtual System.String ApplicantCapacityCode
        {
            get { return _applicantCapacityCode; }
            set { _applicantCapacityCode = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.CaseParty.MApplicantCapacity - Master.MApplicantCapacity.CaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<CaseParty> CaseParties
        {
            get { return _caseParties; }
            set { _caseParties = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Document.DocCaseParty.MApplicantCapacity - Master.MApplicantCapacity.DocCaseParties (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<DocCaseParty> DocCaseParties
        {
            get { return _docCaseParties; }
            set { _docCaseParties = value; }
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

        /// <summary>Gets or sets the ProbateNatureCode field. </summary>
        public virtual System.String ProbateNatureCode
        {
            get { return _probateNatureCode; }
            set { _probateNatureCode = value; }
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
            MApplicantCapacity toCompareWith = obj as MApplicantCapacity;
            return toCompareWith == null ? false : ((this.ApplicantCapacityCode == toCompareWith.ApplicantCapacityCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ApplicantCapacityCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}