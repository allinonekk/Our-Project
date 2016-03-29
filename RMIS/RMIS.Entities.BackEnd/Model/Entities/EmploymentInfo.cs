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

    /// <summary>Class which represents the entity 'Common.EmploymentInfo'</summary>
    public partial class EmploymentInfo
    {
        #region Fields

        private Nullable<System.DateTime> _dateOfExpiry;
        private Nullable<System.DateTime> _dateOfIssue;
        private System.String _employmentInfoId;
        private System.String _employmentPassNumber;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EmploymentInfo"/> class.</summary>
        public EmploymentInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DateOfExpiry field. </summary>
        public virtual Nullable<System.DateTime> DateOfExpiry
        {
            get { return _dateOfExpiry; }
            set { _dateOfExpiry = value; }
        }

        /// <summary>Gets or sets the DateOfIssue field. </summary>
        public virtual Nullable<System.DateTime> DateOfIssue
        {
            get { return _dateOfIssue; }
            set { _dateOfIssue = value; }
        }

        /// <summary>Gets or sets the EmploymentInfoId field. </summary>
        public virtual System.String EmploymentInfoId
        {
            get { return _employmentInfoId; }
            set { _employmentInfoId = value; }
        }

        /// <summary>Gets or sets the EmploymentPassNumber field. </summary>
        public virtual System.String EmploymentPassNumber
        {
            get { return _employmentPassNumber; }
            set { _employmentPassNumber = value; }
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
            EmploymentInfo toCompareWith = obj as EmploymentInfo;
            return toCompareWith == null ? false : ((this.EmploymentInfoId == toCompareWith.EmploymentInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EmploymentInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}