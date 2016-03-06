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

    /// <summary>Class which represents the entity 'Common.InfantInfo'</summary>
    public partial class IndexDocDetail : IBackEndSpecific
    {
        #region Properties

        public virtual Int64 CaseInfoId
        {
            get;
            set;
        }

        public virtual String IndexDocDetailId
        {
            get;
            set;
        }

        public virtual String IndexDocInfoId
        {
            get;
            set;
        }

        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual String ObsInd
        {
            get;
            set;
        }

        public virtual Nullable<Int64> SubCaseInfoId
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
            IndexDocDetail toCompareWith = obj as IndexDocDetail;
            return toCompareWith == null ? false : ((this.IndexDocDetailId == toCompareWith.IndexDocDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.IndexDocDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}