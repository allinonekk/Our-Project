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

    /// <summary>Class which represents the entity 'Master.MEMSRecTransMode'</summary>
    public partial class MEMSRecTransMode : IMaster
    {
        #region Fields

        private System.String _description;
        private System.Collections.Generic.ICollection<EMSRecTrans> _eMSRecTrans;
        private System.String _eMSRecTransModeCode;
        private Nullable<System.Int32> _frequencyInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MEMSRecTransMode"/> class.</summary>
        public MEMSRecTransMode()
            : base()
        {
            _eMSRecTrans = new System.Collections.Generic.HashSet<EMSRecTrans>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSRecTrans.MEMSRecTransMode - Master.MEMSRecTransMode.EMSRecTrans (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSRecTrans> EMSRecTrans
        {
            get { return _eMSRecTrans; }
            set { _eMSRecTrans = value; }
        }

        /// <summary>Gets or sets the EMSRecTransModeCode field. </summary>
        public virtual System.String EMSRecTransModeCode
        {
            get { return _eMSRecTransModeCode; }
            set { _eMSRecTransModeCode = value; }
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public virtual Nullable<System.Int32> FrequencyInd
        {
            get { return _frequencyInd; }
            set { _frequencyInd = value; }
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
            MEMSRecTransMode toCompareWith = obj as MEMSRecTransMode;
            return toCompareWith == null ? false : ((this.EMSRecTransModeCode == toCompareWith.EMSRecTransModeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSRecTransModeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}