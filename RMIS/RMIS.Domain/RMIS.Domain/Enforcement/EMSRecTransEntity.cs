﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace RMIS.Domain.Enforcement
{
    using System;

    using RMIS.Domain.Master;

    /// <summary>Class which represents the entity 'Enforcement.EMSRecTrans'</summary>
    [Serializable]
    public class EMSRecTransEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the Amount field. </summary>
        public System.Decimal Amount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSReceiptId field. </summary>
        public System.String EMSReceiptId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSRecTransId field. </summary>
        public System.String EMSRecTransId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsDishonoured field. </summary>
        public System.String IsDishonoured
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSRecTrans.MEMSRecBank - Master.MEMSRecBank.EMSRecTrans (m:1)'</summary>
        public MEMSRecBankEntity MEMSRecBank
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSRecTrans.MEMSRecTransMode - Master.MEMSRecTransMode.EMSRecTrans (m:1)'</summary>
        public MEMSRecTransModeEntity MEMSRecTransMode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ReferenceNo field. </summary>
        public System.String ReferenceNo
        {
            get;
            set;
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
            EMSRecTransEntity toCompareWith = obj as EMSRecTransEntity;
            return toCompareWith == null ? false : ((this.EMSRecTransId == toCompareWith.EMSRecTransId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSRecTransId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}