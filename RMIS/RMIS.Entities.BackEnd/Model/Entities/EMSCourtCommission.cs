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

    /// <summary>Class which represents the entity 'Enforcement.EMSCourtCommission'</summary>
    public partial class EMSCourtCommission : IEnforcement
    {
        #region Fields

        private System.String _action;
        private System.DateTime _actionDate;
        private System.Decimal _amount;
        private EMSAccount _eMSAccount;
        private System.String _eMSCourtCommissionId;
        private EMSPaymentVoucher _eMSPaymentVoucher;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSCourtCommission"/> class.</summary>
        public EMSCourtCommission()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Action field. </summary>
        public virtual System.String Action
        {
            get { return _action; }
            set { _action = value; }
        }

        /// <summary>Gets or sets the ActionDate field. </summary>
        public virtual System.DateTime ActionDate
        {
            get { return _actionDate; }
            set { _actionDate = value; }
        }

        /// <summary>Gets or sets the Amount field. </summary>
        public virtual System.Decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>Gets or sets the EMSAccount field. </summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Gets or sets the EMSCourtCommissionId field. </summary>
        public virtual System.String EMSCourtCommissionId
        {
            get { return _eMSCourtCommissionId; }
            set { _eMSCourtCommissionId = value; }
        }

        /// <summary>Gets or sets the EMSPaymentVoucher field. </summary>
        public virtual EMSPaymentVoucher EMSPaymentVoucher
        {
            get { return _eMSPaymentVoucher; }
            set { _eMSPaymentVoucher = value; }
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
            EMSCourtCommission toCompareWith = obj as EMSCourtCommission;
            return toCompareWith == null ? false : ((this.EMSCourtCommissionId == toCompareWith.EMSCourtCommissionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSCourtCommissionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}