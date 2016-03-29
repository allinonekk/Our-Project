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

    /// <summary>Class which represents the entity 'BackEndSpecific.DisciplinaryActionInfo'</summary>
    public partial class DisciplinaryActionInfo
    {
        #region Fields

        private System.String _dACCaseNumber;
        private System.String _disciplinaryActionInfoId;
        private System.String _disciplinaryTypeRemarks;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MAASDisciplinaryType _mAASDisciplinaryType;
        private Nullable<System.DateTime> _periodEndDate;
        private Nullable<System.DateTime> _periodStartDate;
        private System.String _remarks;
        private System.String _result;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DisciplinaryActionInfo"/> class.</summary>
        public DisciplinaryActionInfo()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the DACCaseNumber field. </summary>
        public virtual System.String DACCaseNumber
        {
            get { return _dACCaseNumber; }
            set { _dACCaseNumber = value; }
        }

        /// <summary>Gets or sets the DisciplinaryActionInfoId field. </summary>
        public virtual System.String DisciplinaryActionInfoId
        {
            get { return _disciplinaryActionInfoId; }
            set { _disciplinaryActionInfoId = value; }
        }

        /// <summary>Gets or sets the DisciplinaryTypeRemarks field. </summary>
        public virtual System.String DisciplinaryTypeRemarks
        {
            get { return _disciplinaryTypeRemarks; }
            set { _disciplinaryTypeRemarks = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.MAASDisciplinaryResultType.MAASDisciplinaryType - Master.MAASDisciplinaryType.DisciplinaryActionInfos (m:1)'</summary>
        public virtual MAASDisciplinaryResultType MAASDisciplinaryResultType
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.DisciplinaryActionInfo.MAASDisciplinaryType - Master.MAASDisciplinaryType.DisciplinaryActionInfos (m:1)'</summary>
        public virtual MAASDisciplinaryType MAASDisciplinaryType
        {
            get { return _mAASDisciplinaryType; }
            set { _mAASDisciplinaryType = value; }
        }

        /// <summary>Gets or sets the PeriodEndDate field. </summary>
        public virtual Nullable<System.DateTime> PeriodEndDate
        {
            get { return _periodEndDate; }
            set { _periodEndDate = value; }
        }

        /// <summary>Gets or sets the PeriodStartDate field. </summary>
        public virtual Nullable<System.DateTime> PeriodStartDate
        {
            get { return _periodStartDate; }
            set { _periodStartDate = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the Result field. </summary>
        public virtual System.String Result
        {
            get { return _result; }
            set { _result = value; }
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
            DisciplinaryActionInfo toCompareWith = obj as DisciplinaryActionInfo;
            return toCompareWith == null ? false : ((this.DisciplinaryActionInfoId == toCompareWith.DisciplinaryActionInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DisciplinaryActionInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}