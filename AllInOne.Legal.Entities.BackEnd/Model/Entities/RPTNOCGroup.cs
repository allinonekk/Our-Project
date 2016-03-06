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

    /// <summary>Class which represents the entity 'IBackEndSpecific.RPTNOCGroup'</summary>
    public partial class RPTNOCGroup : IBackEndSpecific
    {
        #region Properties

        /// <summary>
        /// Gets or sets the noc group code.
        /// </summary>
        /// <value>The noc group code.</value>
        public virtual string NocGroupCode
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the name of the noc group.
        /// </summary>
        /// <value>The name of the noc group.</value>
        public virtual string NocGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the location group.
        /// </summary>
        /// <value>The location group.</value>
        public virtual string LocationGroup
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
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
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

        public virtual string RPTNOCGroupID
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
            RPTNOCGroup toCompareWith = obj as RPTNOCGroup;
            return toCompareWith == null ? false : ((this.RPTNOCGroupID == toCompareWith.RPTNOCGroupID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RPTNOCGroupID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}