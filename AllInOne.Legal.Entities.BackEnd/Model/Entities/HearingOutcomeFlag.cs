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

    /// <summary>Class which represents the entity 'ICase.HearingOutcomeFlag'</summary>
    public partial class HearingOutcomeFlag : ICase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the HRGID.
        /// </summary>
        /// <value>The HRGID.</value>
        public virtual long HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public virtual int ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the HRG out come flag code.
        /// </summary>
        /// <value>The HRG out come flag code.</value>
        public virtual MHRGOutComeFlag MHRGOutComeFlag
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obsInd.
        /// </summary>
        /// <value>The obs ind.</value>
        public virtual string ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate.
        /// </summary>
        /// <value>The LastModifiedDate.</value>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
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
            HearingOutcomeFlag toCompareWith = obj as HearingOutcomeFlag;
            return toCompareWith == null ? false : ((this.HRGID == toCompareWith.HRGID) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGID.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}