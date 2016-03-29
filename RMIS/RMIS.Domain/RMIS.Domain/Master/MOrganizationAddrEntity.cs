﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace RMIS.Domain.Master
{
    using System;

    using RMIS.Domain.Abstract;
    using RMIS.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MOrganizationAddrEntity.
    /// </summary>
    [Serializable]
    public partial class MOrganizationAddrEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MOrganizationAddrEntity"/> class.</summary>
        public MOrganizationAddrEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

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

        /// <summary>Gets or sets the FloorNo field. </summary>
        public System.String FloorNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public Nullable<System.Int32> FrequencyInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MOrganization field. </summary>
        public MOrganizationEntity MOrganization
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MOrganizationCode field. </summary>
        public System.String MOrganizationCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OrgDesc field. </summary>
        public System.String OrgDesc
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
            if(obj == null)
            {
                return false;
            }
            MOrganizationEntity toCompareWith = obj as MOrganizationEntity;
            return toCompareWith == null ? false : ((this.MOrganizationCode == toCompareWith.MOrganizationCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MOrganizationCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}