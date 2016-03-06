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

    /// <summary>Class which represents the entity 'Enforcement.EMSPaymentVoucherMisc'</summary>
    public partial class EMSPaymentVoucherMisc : IEnforcement
    {
        #region Fields

        private System.String _addLess;
        private System.Decimal _amount;
        private System.String _description;
        private EMSPaymentVoucherFinal _eMSPaymentVoucherFinal;
        private System.String _eMSPaymentVoucherMiscId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSPaymentVoucherMisc"/> class.</summary>
        public EMSPaymentVoucherMisc()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AddLess field. </summary>
        public virtual System.String AddLess
        {
            get { return _addLess; }
            set { _addLess = value; }
        }

        /// <summary>Gets or sets the Amount field. </summary>
        public virtual System.Decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucherMisc.EMSPaymentVoucherFinal - Enforcement.EMSPaymentVoucherFinal.EMSPaymentVoucherFinalOthers (m:1)'</summary>
        public virtual EMSPaymentVoucherFinal EMSPaymentVoucherFinal
        {
            get { return _eMSPaymentVoucherFinal; }
            set { _eMSPaymentVoucherFinal = value; }
        }

        /// <summary>Gets or sets the EMSPaymentVoucherMiscId field. </summary>
        public virtual System.String EMSPaymentVoucherMiscId
        {
            get { return _eMSPaymentVoucherMiscId; }
            set { _eMSPaymentVoucherMiscId = value; }
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
            EMSPaymentVoucherMisc toCompareWith = obj as EMSPaymentVoucherMisc;
            return toCompareWith == null ? false : ((this.EMSPaymentVoucherMiscId == toCompareWith.EMSPaymentVoucherMiscId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSPaymentVoucherMiscId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}