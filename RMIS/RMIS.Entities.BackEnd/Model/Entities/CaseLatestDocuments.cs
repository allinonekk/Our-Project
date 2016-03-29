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

    /// <summary>Class which represents the entity 'Document.CaseLatestDocuments'</summary>
    public partial class CaseLatestDocuments : IDocument
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="CaseParty"/> class.</summary>
        public CaseLatestDocuments()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public virtual Int64 CaseInfoId
        {
            get;
            set;
        }

        public virtual String DocId
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

        public virtual MDocCode MDocCode
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
            CaseLatestDocuments toCompareWith = obj as CaseLatestDocuments;
            return toCompareWith == null ? false : ((this.CaseInfoId == toCompareWith.CaseInfoId) && (this.DocId == toCompareWith.DocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseInfoId.GetHashCode();
            toReturn ^= this.DocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}