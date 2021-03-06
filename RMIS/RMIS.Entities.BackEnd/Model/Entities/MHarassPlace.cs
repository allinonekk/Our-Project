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

    /// <summary>Class which represents the entity 'Master.MHarassPlace'</summary>
    public partial class MHarassPlace : IMaster
    {
        

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MHarassPlace"/> class.</summary>
        public MHarassPlace()
            : base()
        {
            
        }

        #endregion Constructors

        #region Properties

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

        /// <summary>Gets or sets the Salutation field. </summary>
        public virtual System.String HarassPlaceCode
        {
            get;
            set;
        }


        public virtual System.String Description
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
            MHarassPlace toCompareWith = obj as MHarassPlace;
            return toCompareWith == null ? false : ((this.HarassPlaceCode == toCompareWith.HarassPlaceCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HarassPlaceCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}