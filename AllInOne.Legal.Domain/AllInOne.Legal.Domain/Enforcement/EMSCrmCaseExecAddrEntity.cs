﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    /// <summary>Class which represents the entity 'Enforcement.EMSCrmCaseExecAddr'</summary>
    [Serializable]
    public class EMSCrmCaseExecAddrEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the Addr1 field. </summary>
        public System.String Addr1
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr2 field. </summary>
        public System.String Addr2
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public System.String Addr3
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public System.String Addr4
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Address field. </summary>
        public System.String Address
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BlkNo field. </summary>
        public System.String BlkNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BuildingName field. </summary>
        public System.String BuildingName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSCrmCaseExecAddrId field. </summary>
        public System.String EMSCrmCaseExecAddrId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSCrmCaseId field. </summary>
        public System.String EMSCrmCaseId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FloorNo field. </summary>
        public System.String FloorNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FormatInd field. </summary>
        public AddressFormatType FormatInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public System.Int32 ItemNo
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PostalCode field. </summary>
        public System.String PostalCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StreetName field. </summary>
        public System.String StreetName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnitNo field. </summary>
        public System.String UnitNo
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
            if (obj == null)
            {
                return false;
            }
            EMSCrmCaseExecAddrEntity toCompareWith = obj as EMSCrmCaseExecAddrEntity;
            return toCompareWith == null ? false : ((this.EMSCrmCaseExecAddrId == toCompareWith.EMSCrmCaseExecAddrId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSCrmCaseExecAddrId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}