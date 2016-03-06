﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Enforcement.EMSRecapitDetails'</summary>
    [Serializable]
    public class EMSRecapitDetailsEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the CurrBal field. </summary>
        public System.Decimal CurrBal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public System.String EMSAccountId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSRecapitDetailsId field. </summary>
        public System.String EMSRecapitDetailsId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSRecapitulationId field. </summary>
        public System.String EMSRecapitulationId
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

        /// <summary>Gets or sets the LastTransDate field. </summary>
        public System.DateTime LastTransDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JudicialUser field. </summary>
        public System.String LastTransUserId
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
            EMSRecapitDetailsEntity toCompareWith = obj as EMSRecapitDetailsEntity;
            return toCompareWith == null ? false : ((this.EMSRecapitDetailsId == toCompareWith.EMSRecapitDetailsId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSRecapitDetailsId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}