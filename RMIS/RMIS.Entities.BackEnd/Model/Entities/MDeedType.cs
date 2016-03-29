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

    /// <summary>Class which represents the entity 'Master.MDeedType'</summary>
    public partial class MDeedType : IMaster
    {
        #region Fields

        private System.String _comDocGroupInd;
        private System.String _deedDescription;
        private System.String _deedTypeCode;
        private System.String _description;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private Nullable<System.Int32> _seqNo;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MDeedType"/> class.</summary>
        public MDeedType()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ComDocGroupInd field. </summary>
        public virtual System.String ComDocGroupInd
        {
            get { return _comDocGroupInd; }
            set { _comDocGroupInd = value; }
        }

        /// <summary>Gets or sets the DeedDescription field. </summary>
        public virtual System.String DeedDescription
        {
            get { return _deedDescription; }
            set { _deedDescription = value; }
        }

        /// <summary>Gets or sets the DeedTypeCode field. </summary>
        public virtual System.String DeedTypeCode
        {
            get { return _deedTypeCode; }
            set { _deedTypeCode = value; }
        }

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the SeqNo field. </summary>
        public virtual Nullable<System.Int32> SeqNo
        {
            get { return _seqNo; }
            set { _seqNo = value; }
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
            MDeedType toCompareWith = obj as MDeedType;
            return toCompareWith == null ? false : ((this.DeedTypeCode == toCompareWith.DeedTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DeedTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}