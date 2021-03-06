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

    /// <summary>Class which represents the entity 'Master.MHRGOutComeReason'</summary>
    public partial class MHRGOutComeReason : IMaster
    {
        #region Fields

        private System.String _description;
        private System.Collections.Generic.ICollection<Hearing> _hearings;
        private System.String _hRGOutComeRSNCode;
        private System.String _isInterfaced;
        private System.String _lastModifiedBY;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MHRGOutComeReason"/> class.</summary>
        public MHRGOutComeReason()
            : base()
        {
            _hearings = new System.Collections.Generic.HashSet<Hearing>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.MHRGOutComeReason - Master.MHRGOutComeReason.Hearings (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<Hearing> Hearings
        {
            get { return _hearings; }
            set { _hearings = value; }
        }

        /// <summary>Gets or sets the HRGOutComeRSNCode field. </summary>
        public virtual System.String HRGOutComeRSNCode
        {
            get { return _hRGOutComeRSNCode; }
            set { _hRGOutComeRSNCode = value; }
        }

        /// <summary>Gets or sets the IsInterfaced field. </summary>
        public virtual System.String IsInterfaced
        {
            get { return _isInterfaced; }
            set { _isInterfaced = value; }
        }

        /// <summary>Gets or sets the LastModifiedBY field. </summary>
        public virtual System.String LastModifiedBY
        {
            get { return _lastModifiedBY; }
            set { _lastModifiedBY = value; }
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
            MHRGOutComeReason toCompareWith = obj as MHRGOutComeReason;
            return toCompareWith == null ? false : ((this.HRGOutComeRSNCode == toCompareWith.HRGOutComeRSNCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGOutComeRSNCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}