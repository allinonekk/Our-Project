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

    /// <summary>Class which represents the entity 'Master.MUserGroup'</summary>
    public partial class MUserGroup : IMaster
    {
        #region Fields

        private System.String _description;
        private System.String _groupCode;
        private System.String _groupName;
        private System.Collections.Generic.ICollection<JudicialUser> _judicialUsers;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _signatureMandatory;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MUserGroup"/> class.</summary>
        public MUserGroup()
            : base()
        {
            _judicialUsers = new System.Collections.Generic.HashSet<JudicialUser>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the GroupCode field. </summary>
        public virtual System.String GroupCode
        {
            get { return _groupCode; }
            set { _groupCode = value; }
        }

        /// <summary>Gets or sets the GroupName field. </summary>
        public virtual System.String GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'BackEndSpecific.JudicialUser.MUserGroup - Master.MUserGroup.JudicialUsers (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<JudicialUser> JudicialUsers
        {
            get { return _judicialUsers; }
            set { _judicialUsers = value; }
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

        /// <summary>Gets or sets the SignatureMandatory field. </summary>
        public virtual System.String SignatureMandatory
        {
            get { return _signatureMandatory; }
            set { _signatureMandatory = value; }
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
            MUserGroup toCompareWith = obj as MUserGroup;
            return toCompareWith == null ? false : ((this.GroupCode == toCompareWith.GroupCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.GroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}