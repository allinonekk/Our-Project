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

    /// <summary>Class which represents the entity 'Enforcement.EMSCivCrmSeizure'</summary>
    public partial class EMSCivCrmSeizure : IEnforcement
    {
        #region Fields

        private EMSAccount _eMSAccount;
        private EMSAppointment _eMSAppointment;
        private System.Collections.Generic.ICollection<EMSCivCrmMissing> _eMSCivCrmMissings;
        private System.String _eMSCivCrmSeizureId;
        private System.Decimal _estValue;
        private System.Int32 _itemsSeized;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private Nullable<System.Decimal> _otherCourtFee;
        private Nullable<System.Decimal> _otherLegalExpense;
        private System.String _remarks;
        private System.DateTime _seizureDateTime;
        private Nullable<System.Decimal> _watchmanCharges;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSCivCrmSeizure"/> class.</summary>
        public EMSCivCrmSeizure()
            : base()
        {
            _eMSCivCrmMissings = new System.Collections.Generic.HashSet<EMSCivCrmMissing>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSCivCrmSeizure.EMSAccount - Enforcement.EMSAccount.EMSCivCrmSeizures (m:1)'</summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSCivCrmSeizure.EMSAppointment - Enforcement.EMSAppointment.EMSCivCrmSeizures (m:1)'</summary>
        public virtual EMSAppointment EMSAppointment
        {
            get { return _eMSAppointment; }
            set { _eMSAppointment = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSCivCrmMissing.EMSCivCrmSeizure - Enforcement.EMSCivCrmSeizure.EMSCivCrmMissings (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSCivCrmMissing> EMSCivCrmMissings
        {
            get { return _eMSCivCrmMissings; }
            set { _eMSCivCrmMissings = value; }
        }

        /// <summary>Gets or sets the EMSCivCrmSeizureId field. </summary>
        public virtual System.String EMSCivCrmSeizureId
        {
            get { return _eMSCivCrmSeizureId; }
            set { _eMSCivCrmSeizureId = value; }
        }

        /// <summary>Gets or sets the EstValue field. </summary>
        public virtual System.Decimal EstValue
        {
            get { return _estValue; }
            set { _estValue = value; }
        }

        /// <summary>Gets or sets the ItemsSeized field. </summary>
        public virtual System.Int32 ItemsSeized
        {
            get { return _itemsSeized; }
            set { _itemsSeized = value; }
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

        /// <summary>Gets or sets the OtherCourtFee field. </summary>
        public virtual Nullable<System.Decimal> OtherCourtFee
        {
            get { return _otherCourtFee; }
            set { _otherCourtFee = value; }
        }

        /// <summary>Gets or sets the OtherLegalExpense field. </summary>
        public virtual Nullable<System.Decimal> OtherLegalExpense
        {
            get { return _otherLegalExpense; }
            set { _otherLegalExpense = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the SeizureDateTime field. </summary>
        public virtual System.DateTime SeizureDateTime
        {
            get { return _seizureDateTime; }
            set { _seizureDateTime = value; }
        }

        /// <summary>Gets or sets the WatchmanCharges field. </summary>
        public virtual Nullable<System.Decimal> WatchmanCharges
        {
            get { return _watchmanCharges; }
            set { _watchmanCharges = value; }
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
            EMSCivCrmSeizure toCompareWith = obj as EMSCivCrmSeizure;
            return toCompareWith == null ? false : ((this.EMSCivCrmSeizureId == toCompareWith.EMSCivCrmSeizureId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSCivCrmSeizureId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}