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

    /// <summary>Class which represents the entity 'Common.TravelPassInfo'</summary>
    public partial class TravelPassInfo
    {
        #region Fields

        private Nullable<System.DateTime> _dateOfExpiry;
        private Nullable<System.DateTime> _dateOfIssue;
        private System.String _idNumber;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCountry _mCountry;
        private MPersonIDType _mPersonIDType;
        private System.String _submissionGroupId;
        private System.String _travelPassInfoId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="TravelPassInfo"/> class.</summary>
        public TravelPassInfo()
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

        /// <summary>Gets or sets the IdNumber field. </summary>
        public virtual System.String IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        public virtual String IdRemarks
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

        /// <summary>Represents the navigator which is mapped onto the association 'Common.TravelPassInfo.MCountry - Master.MCountry.TravelPassInfos (m:1)'</summary>
        public virtual MCountry MCountry
        {
            get { return _mCountry; }
            set { _mCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.TravelPassInfo.MPersonIDType - Master.MPersonIDType.TravelPassInfos (m:1)'</summary>
        public virtual MPersonIDType MPersonIDType
        {
            get { return _mPersonIDType; }
            set { _mPersonIDType = value; }
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
        }

        /// <summary>Gets or sets the TravelPassInfoId field. </summary>
        public virtual System.String TravelPassInfoId
        {
            get { return _travelPassInfoId; }
            set { _travelPassInfoId = value; }
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
            TravelPassInfo toCompareWith = obj as TravelPassInfo;
            return toCompareWith == null ? false : ((this.TravelPassInfoId == toCompareWith.TravelPassInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TravelPassInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}