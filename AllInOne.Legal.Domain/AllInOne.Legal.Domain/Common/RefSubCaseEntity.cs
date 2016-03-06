﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.RefSubCaseEntity'</summary>
    public partial class RefSubCaseEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="RefSubCaseEntity"/> class.</summary>
        public RefSubCaseEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdditionalDetails field. </summary>
        public String RefSubCaseId
        {
            get;
            set;
        }

        public String SubCaseInfoId
        {
            get;
            set;
        }

        public String ClaimantPartyId
        {
            get;
            set;
        }


        public string ClaimantDCPId
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
            RefSubCaseEntity toCompareWith = obj as RefSubCaseEntity;
            return toCompareWith == null ? false : ((this.RefSubCaseId == toCompareWith.RefSubCaseId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RefSubCaseId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}