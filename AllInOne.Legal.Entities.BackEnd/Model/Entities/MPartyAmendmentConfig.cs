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

    /// <summary>Class which represents the entity 'Master.MPartyAmendmentConfig'</summary>
    public partial class MPartyAmendmentConfig : IMaster
    {
        #region Fields

        private System.String _amendmentAt;
        private System.String _amendmentConfigId;
        private System.String _configXML;
        private System.String _isAmendmentApplicable;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCaseType _mCaseType;
        private System.String _obsInd;
        private System.Collections.Generic.ICollection<PartyAmendmentDetail> _partyAmendmentDetails;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPartyAmendmentConfig"/> class.</summary>
        public MPartyAmendmentConfig()
            : base()
        {
            _partyAmendmentDetails = new System.Collections.Generic.HashSet<PartyAmendmentDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmendmentAt field. </summary>
        public virtual System.String AmendmentAt
        {
            get { return _amendmentAt; }
            set { _amendmentAt = value; }
        }

        /// <summary>Gets or sets the AmendmentConfigId field. </summary>
        public virtual System.String AmendmentConfigId
        {
            get { return _amendmentConfigId; }
            set { _amendmentConfigId = value; }
        }

        /// <summary>Gets or sets the ConfigXML field. </summary>
        public virtual System.String ConfigXML
        {
            get { return _configXML; }
            set { _configXML = value; }
        }

        /// <summary>Gets or sets the IsAmendmentApplicable field. </summary>
        public virtual System.String IsAmendmentApplicable
        {
            get { return _isAmendmentApplicable; }
            set { _isAmendmentApplicable = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MPartyAmendmentConfig.MCaseType - Master.MCaseType.MPartyAmendmentConfigs (m:1)'</summary>
        public virtual MCaseType MCaseType
        {
            get { return _mCaseType; }
            set { _mCaseType = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.PartyAmendmentDetail.MPartyAmendmentConfig - Master.MPartyAmendmentConfig.PartyAmendmentDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<PartyAmendmentDetail> PartyAmendmentDetails
        {
            get { return _partyAmendmentDetails; }
            set { _partyAmendmentDetails = value; }
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
            MPartyAmendmentConfig toCompareWith = obj as MPartyAmendmentConfig;
            return toCompareWith == null ? false : ((this.AmendmentConfigId == toCompareWith.AmendmentConfigId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AmendmentConfigId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}