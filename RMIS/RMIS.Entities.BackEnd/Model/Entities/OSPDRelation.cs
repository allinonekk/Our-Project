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

    /// <summary>Class which represents the entity 'CaseSpecific.OSPDRelation'</summary>
    public partial class OSPDRelation
    {
        #region Fields

        private DocCaseParty _docCaseParty;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MRelationship _mRelationship;
        private System.String _oSPDRelationId;
        private System.String _otherRelation;
        private System.String _submissionGroupId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="OSPDRelation"/> class.</summary>
        public OSPDRelation()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.OSPDRelation.DocCaseParty - Document.DocCaseParty.OSPDRelations (m:1)'</summary>
        public virtual DocCaseParty DocCaseParty
        {
            get { return _docCaseParty; }
            set { _docCaseParty = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.OSPDRelation.MRelationship - Master.MRelationship.OSPDRelations (m:1)'</summary>
        public virtual MRelationship MRelationship
        {
            get { return _mRelationship; }
            set { _mRelationship = value; }
        }

        /// <summary>Gets or sets the OSPDRelationId field. </summary>
        public virtual System.String OSPDRelationId
        {
            get { return _oSPDRelationId; }
            set { _oSPDRelationId = value; }
        }

        /// <summary>Gets or sets the OtherRelation field. </summary>
        public virtual System.String OtherRelation
        {
            get { return _otherRelation; }
            set { _otherRelation = value; }
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
            OSPDRelation toCompareWith = obj as OSPDRelation;
            return toCompareWith == null ? false : ((this.OSPDRelationId == toCompareWith.OSPDRelationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OSPDRelationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}