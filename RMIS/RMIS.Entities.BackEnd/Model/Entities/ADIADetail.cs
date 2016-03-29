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

    /// <summary>Class which represents the entity 'BackEndSpecific.ADIADetail'</summary>
    public partial class ADIADetail : IBackEndSpecific
    {
        #region Fields

        private System.String _aDIADetailsId;
        private ADIDetail _aDIDetail;
        private Nullable<System.Decimal> _amountAwarded;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MNatureOfInjury _mNatureOfInjury;
        private System.String _nOIMEntry;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ADIADetail"/> class.</summary>
        public ADIADetail()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ADIADetailsId field. </summary>
        public virtual System.String ADIADetailsId
        {
            get { return _aDIADetailsId; }
            set { _aDIADetailsId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.ADIADetail.ADIDetail - BackEndSpecific.ADIDetail.ADIADetails (m:1)'</summary>
        public virtual ADIDetail ADIDetail
        {
            get { return _aDIDetail; }
            set { _aDIDetail = value; }
        }

        /// <summary>Gets or sets the AmountAwarded field. </summary>
        public virtual Nullable<System.Decimal> AmountAwarded
        {
            get { return _amountAwarded; }
            set { _amountAwarded = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.ADIADetail.MNatureOfInjury - Master.MNatureOfInjury.ADIADetails (m:1)'</summary>
        public virtual MNatureOfInjury MNatureOfInjury
        {
            get { return _mNatureOfInjury; }
            set { _mNatureOfInjury = value; }
        }

        /// <summary>Gets or sets the NOIMEntry field. </summary>
        public virtual System.String NOIMEntry
        {
            get { return _nOIMEntry; }
            set { _nOIMEntry = value; }
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
            ADIADetail toCompareWith = obj as ADIADetail;
            return toCompareWith == null ? false : ((this.ADIADetailsId == toCompareWith.ADIADetailsId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADIADetailsId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}