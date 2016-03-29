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

    /// <summary>Class which represents the entity 'CaseSpecific.AASInfo'</summary>
    public partial class AASInfo : ICaseSpecific
    {
        #region Fields

        private System.String _aASInfoId;
        private System.String _aASQualificationRemarks;
        private System.String _bLEDocExemptionRemarks;
        private System.String _isMLawExemptionApproved;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _lPALPRSectionType;
        private MAASLawDegree _mAASLawDegree;
        private Nullable<System.DateTime> _qualifiedPersonDate;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="AASInfo"/> class.</summary>
        public AASInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AASInfoId field. </summary>
        public virtual System.String AASInfoId
        {
            get { return _aASInfoId; }
            set { _aASInfoId = value; }
        }

        /// <summary>Gets or sets the AASQualificationRemarks field. </summary>
        public virtual System.String AASQualificationRemarks
        {
            get { return _aASQualificationRemarks; }
            set { _aASQualificationRemarks = value; }
        }

        /// <summary>Gets or sets the BLEDocExemptionRemarks field. </summary>
        public virtual System.String BLEDocExemptionRemarks
        {
            get { return _bLEDocExemptionRemarks; }
            set { _bLEDocExemptionRemarks = value; }
        }

        /// <summary>Gets or sets the IsMLawExemptionApproved field. </summary>
        public virtual System.String IsMLawExemptionApproved
        {
            get { return _isMLawExemptionApproved; }
            set { _isMLawExemptionApproved = value; }
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

        /// <summary>Gets or sets the LPALPRSectionType field. </summary>
        public virtual System.String LPALPRSectionType
        {
            get { return _lPALPRSectionType; }
            set { _lPALPRSectionType = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.AASInfo.MAASLawDegree - Master.MAASLawDegree.AASInfos (m:1)'</summary>
        public virtual MAASLawDegree MAASLawDegree
        {
            get { return _mAASLawDegree; }
            set { _mAASLawDegree = value; }
        }

        /// <summary>Gets or sets the QualifiedPersonDate field. </summary>
        public virtual Nullable<System.DateTime> QualifiedPersonDate
        {
            get { return _qualifiedPersonDate; }
            set { _qualifiedPersonDate = value; }
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
            AASInfo toCompareWith = obj as AASInfo;
            return toCompareWith == null ? false : ((this.AASInfoId == toCompareWith.AASInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}