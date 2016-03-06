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

    /// <summary>Class which represents the entity 'Common.GroundInfo'</summary>
    public partial class GroundInfo : ICommon
    {
        #region Fields

        private System.String _groundInfoId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Int32 _level;
        private System.String _requestedGrounds;
        private Nullable<System.Int32> _subLevel;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="GroundInfo"/> class.</summary>
        public GroundInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the GroundInfoId field. </summary>
        public virtual System.String GroundInfoId
        {
            get { return _groundInfoId; }
            set { _groundInfoId = value; }
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

        /// <summary>Gets or sets the Level field. </summary>
        public virtual System.Int32 Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>Gets or sets the RequestedGrounds field. </summary>
        public virtual System.String RequestedGrounds
        {
            get { return _requestedGrounds; }
            set { _requestedGrounds = value; }
        }

        /// <summary>Gets or sets the SubLevel field. </summary>
        public virtual Nullable<System.Int32> SubLevel
        {
            get { return _subLevel; }
            set { _subLevel = value; }
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
            GroundInfo toCompareWith = obj as GroundInfo;
            return toCompareWith == null ? false : ((this.GroundInfoId == toCompareWith.GroundInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.GroundInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}