﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace RMIS.Domain.Enforcement
{
    using System;

    using RMIS.Domain.Master;

    /// <summary>Class which represents the entity 'Enforcement.EMSRoundRobinAuctioneer'</summary>
    [Serializable]
    public class EMSRoundRobinAuctioneerEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the RoundRobinAuctioneerId field. </summary>
        public System.String RoundRobinAuctioneerId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailiffId field. </summary>
        public System.String BailiffId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAuctioneerCode field. </summary>
        public System.String EMSAuctioneerCode
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
            EMSRoundRobinAuctioneerEntity toCompareWith = obj as EMSRoundRobinAuctioneerEntity;
            return toCompareWith == null ? false : ((this.RoundRobinAuctioneerId == toCompareWith.RoundRobinAuctioneerId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RoundRobinAuctioneerId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}