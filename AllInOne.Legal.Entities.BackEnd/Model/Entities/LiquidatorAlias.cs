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

    /// <summary>Class which represents the entity 'Common.LiquidatorAlias'</summary>
    public partial class LiquidatorAlias : ICommon
    {
        #region Fields

        private System.String _aliasName;
        private System.Int32 _itemNo;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        //private Liquidator _liquidator;
        private System.String _liquidatorAliasId;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="LiquidatorAlias"/> class.</summary>
        public LiquidatorAlias()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AliasName field. </summary>
        public virtual System.String AliasName
        {
            get { return _aliasName; }
            set { _aliasName = value; }
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public virtual System.Int32 ItemNo
        {
            get { return _itemNo; }
            set { _itemNo = value; }
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set { _lastModifiedBy = value; }
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        /// <summary>Gets or sets the LiquidatorAliasId field. </summary>
        public virtual System.String LiquidatorAliasId
        {
            get { return _liquidatorAliasId; }
            set { _liquidatorAliasId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CWU.LiquidatorAlias.Liquidator - CWU.Liquidator.LiquidatorAliases (m:1)'</summary>
        //public virtual Liquidator Liquidator
        //{
        //    get { return _liquidator; }
        //    set { _liquidator = value; }
        //}
        public virtual System.String LiquidatorId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public virtual System.String SubmissionGroupId
        {
            get { return _submissionGroupId; }
            set { _submissionGroupId = value; }
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
            LiquidatorAlias toCompareWith = obj as LiquidatorAlias;
            return toCompareWith == null ? false : ((this.LiquidatorAliasId == toCompareWith.LiquidatorAliasId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatorAliasId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}