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

    /// <summary>Class which represents the entity 'Master.MBusinessJobLegalDetail'</summary>
    public partial class MBusinessJobLegalDetail : IMaster
    {
        #region Properties

        /// <summary>Gets or sets the BusinessJobLegalDetailId field. </summary>
        public virtual System.String BusinessJobLegalDetailId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BusinessJobLegalInfoId field. </summary>
        public virtual System.String BusinessJobLegalInfoId
        {
            get;
            set;
        }

        public virtual String Description
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get;
            set;
        }

        public virtual Int32 Timeframe
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
            MBusinessJobLegalDetail toCompareWith = obj as MBusinessJobLegalDetail;
            return toCompareWith == null ? false : ((this.BusinessJobLegalDetailId == toCompareWith.BusinessJobLegalDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BusinessJobLegalDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}