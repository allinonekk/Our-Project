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

    /// <summary>Class which represents the entity 'Enforcement.EMSApptDebtor'</summary>
    public partial class EMSApptDebtor : IEnforcement
    {
        #region Fields

        private CaseParty _caseParty;
        private EMSAppointment _eMSAppointment;
        private System.String _eMSApptDebtorId;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSApptDebtor"/> class.</summary>
        public EMSApptDebtor()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSApptDebtor.CaseParty - Case.CaseParty.EMSApptDebtors (m:1)'</summary>
        public virtual CaseParty CaseParty
        {
            get { return _caseParty; }
            set { _caseParty = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSApptDebtor.EMSAppointment - Enforcement.EMSAppointment.EMSApptDebtors (m:1)'</summary>
        public virtual EMSAppointment EMSAppointment
        {
            get { return _eMSAppointment; }
            set { _eMSAppointment = value; }
        }

        /// <summary>Gets or sets the EMSApptDebtorId field. </summary>
        public virtual System.String EMSApptDebtorId
        {
            get { return _eMSApptDebtorId; }
            set { _eMSApptDebtorId = value; }
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
            EMSApptDebtor toCompareWith = obj as EMSApptDebtor;
            return toCompareWith == null ? false : ((this.EMSApptDebtorId == toCompareWith.EMSApptDebtorId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSApptDebtorId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}