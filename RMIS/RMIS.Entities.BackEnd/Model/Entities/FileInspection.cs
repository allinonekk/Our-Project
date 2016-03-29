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

    /// <summary>Class which represents the entity 'Subsequent.FileInspection'</summary>
    public partial class FileInspection : ISubsequent
    {
        #region Fields

        private DocumentInfo _documentInfo;
        private System.String _eMail;
        private Nullable<System.DateTime> _expiryDate;
        private System.Collections.Generic.ICollection<FileInspectionDocDetail> _fileInspectionDocDetails;
        private System.String _fileInspectionId;
        private System.String _idNumber;
        private System.Int32 _inspectionLocation;
        private Nullable<System.Int32> _inspectionPeriod;
        private Nullable<System.DateTime> _inspectionStartedDate;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MCountry _mCountry;
        private MPersonIDType _mPersonIDType;
        private System.String _status;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="FileInspection"/> class.</summary>
        public FileInspection()
            : base()
        {
            _fileInspectionDocDetails = new System.Collections.Generic.HashSet<FileInspectionDocDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.DocumentInfo - Document.DocumentInfo.FileInspections (m:1)'</summary>
        public virtual string DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMail field. </summary>
        public virtual System.String EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        /// <summary>Gets or sets the ExpiryDate field. </summary>
        public virtual Nullable<System.DateTime> ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }

        /// <summary>Gets or sets the FileInspectionId field. </summary>
        public virtual System.String FileInspectionId
        {
            get { return _fileInspectionId; }
            set { _fileInspectionId = value; }
        }

        /// <summary>Gets or sets the IdNumber field. </summary>
        public virtual System.String IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        /// <summary>Gets or sets the InspectionLocation field. </summary>
        public virtual System.Int32 InspectionLocation
        {
            get { return _inspectionLocation; }
            set { _inspectionLocation = value; }
        }

        /// <summary>Gets or sets the InspectionPeriod field. </summary>
        public virtual Nullable<System.Int32> InspectionPeriod
        {
            get { return _inspectionPeriod; }
            set { _inspectionPeriod = value; }
        }

        /// <summary>Gets or sets the InspectionStartedDate field. </summary>
        public virtual Nullable<System.DateTime> InspectionStartedDate
        {
            get { return _inspectionStartedDate; }
            set { _inspectionStartedDate = value; }
        }

        /// <summary>Gets or sets the EMail field. </summary>
        public virtual String InspectionToken
        {
            get;
            set;
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

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.MCountry - Master.MCountry.FileInspections (m:1)'</summary>
        public virtual MCountry MCountry
        {
            get { return _mCountry; }
            set { _mCountry = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.FileInspection.MPersonIDType - Master.MPersonIDType.FileInspections (m:1)'</summary>
        public virtual MPersonIDType MPersonIDType
        {
            get { return _mPersonIDType; }
            set { _mPersonIDType = value; }
        }

        /// <summary>Gets or sets the Status field. </summary>
        public virtual System.String Status
        {
            get { return _status; }
            set { _status = value; }
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
            FileInspection toCompareWith = obj as FileInspection;
            return toCompareWith == null ? false : ((this.FileInspectionId == toCompareWith.FileInspectionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FileInspectionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}