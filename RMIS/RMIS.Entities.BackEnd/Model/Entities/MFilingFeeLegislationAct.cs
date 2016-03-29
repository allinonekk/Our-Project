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

    /// <summary>Class which represents the entity 'Master.MFilingFee'</summary>
    public partial class MFilingFeeLegislationAct : IMaster
    {
      
        #region Properties

        /// <summary>Gets or sets the FeeRuleCode field. </summary>
        public virtual System.String FeeLegislationActCode
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

       

        /// <summary>Gets or sets the ROCReferences field. </summary>
        public virtual System.String IsInterfaced
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ROCReferences field. </summary>
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
            MFilingFeeLegislationAct toCompareWith = obj as MFilingFeeLegislationAct;
            return toCompareWith == null ? false : ((this.FeeLegislationActCode == toCompareWith.FeeLegislationActCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FeeLegislationActCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}