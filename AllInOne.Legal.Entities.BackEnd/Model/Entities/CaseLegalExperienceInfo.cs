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

    /// <summary>Class which represents the entity 'Common.CaseLegalExperienceInfo'</summary>
    public partial class CaseLegalExperienceInfo : ICommon
    {
        #region Fields

        private Nullable<System.DateTime> _employmentEndDate;
        private Nullable<System.DateTime> _employmentStartDate;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private LawFirm _lawFirm;
        private System.String _caseLegalExperienceInfoId;
        private System.String _legalExperienceType;
        private System.String _designation;
        private System.String _obsInd;
        
        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CaseLegalExperienceInfo"/> class.</summary>
        public CaseLegalExperienceInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the EmploymentEndDate field. </summary>
        public virtual Nullable<System.DateTime> EmploymentEndDate
        {
            get { return _employmentEndDate; }
            set { _employmentEndDate = value; }
        }

        /// <summary>Gets or sets the EmploymentStartDate field. </summary>
        public virtual Nullable<System.DateTime> EmploymentStartDate
        {
            get { return _employmentStartDate; }
            set { _employmentStartDate = value; }
        }

        /// <summary>Gets or sets the ExperienceLength field. </summary>
        public virtual String ExperienceLength
        {
            get;
            set;
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.LegalExperienceInfo.LawFirm - LawFirm.LawFirm.LegalExperienceInfos (m:1)'</summary>
        public virtual string LFID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the caseLegalExperienceInfoId field. </summary>
        public virtual System.String CaseLegalExperienceInfoId
        {
            get { return _caseLegalExperienceInfoId; }
            set { _caseLegalExperienceInfoId = value; }
        }

        /// <summary>Gets or sets the LegalExperienceType field. </summary>
        public virtual System.String LegalExperienceType
        {
            get { return _legalExperienceType; }
            set { _legalExperienceType = value; }
        }

        public virtual String OrganisationName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseInfoID field. </summary>
        public virtual System.Int64 CaseInfoID
        {
            get;
            set;
        }

        public virtual String TypeofOrganization
        {
            get;
            set;
        }
        
        public virtual String Designation
        {

            get { return _designation; }
            set { _designation = value; }
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
            CaseLegalExperienceInfo toCompareWith = obj as CaseLegalExperienceInfo;
            return toCompareWith == null ? false : ((this.CaseLegalExperienceInfoId == toCompareWith.CaseLegalExperienceInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseLegalExperienceInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}