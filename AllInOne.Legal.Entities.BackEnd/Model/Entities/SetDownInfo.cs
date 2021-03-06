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

    /// <summary>Class which represents the entity 'SubCaseSpecific.SetDownInfo'</summary>
    public partial class SetDownInfo : ISubCaseSpecific
    {
        #region Fields

        private System.String _isCertExcAEICFiled;
        private System.String _isHearingFeePayable;
        private System.String _isOrder25R8Complied;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private Nullable<System.Int32> _noOfHRGDays;
        private System.String _sDPursuantTo;
        private System.String _setDownId;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SetDownInfo"/> class.</summary>
        public SetDownInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the IsCertExcAEICFiled field. </summary>
        public virtual System.String IsCertExcAEICFiled
        {
            get { return _isCertExcAEICFiled; }
            set { _isCertExcAEICFiled = value; }
        }

        /// <summary>Gets or sets the IsHearingFeePayable field. </summary>
        public virtual System.String IsHearingFeePayable
        {
            get { return _isHearingFeePayable; }
            set { _isHearingFeePayable = value; }
        }

        /// <summary>Gets or sets the IsOrder25R8Complied field. </summary>
        public virtual System.String IsOrder25R8Complied
        {
            get { return _isOrder25R8Complied; }
            set { _isOrder25R8Complied = value; }
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

        /// <summary>Gets or sets the NoOfHRGDays field. </summary>
        public virtual Nullable<System.Int32> NoOfHRGDays
        {
            get { return _noOfHRGDays; }
            set { _noOfHRGDays = value; }
        }

        /// <summary>Gets or sets the SDPursuantTo field. </summary>
        public virtual System.String SDPursuantTo
        {
            get { return _sDPursuantTo; }
            set { _sDPursuantTo = value; }
        }

        /// <summary>Gets or sets the SetDownId field. </summary>
        public virtual System.String SetDownId
        {
            get { return _setDownId; }
            set { _setDownId = value; }
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
            SetDownInfo toCompareWith = obj as SetDownInfo;
            return toCompareWith == null ? false : ((this.SetDownId == toCompareWith.SetDownId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SetDownId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}