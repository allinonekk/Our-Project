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

    /// <summary>Class which represents the entity 'Master.MFormTemplateLocationHistory'</summary>
    public partial class MFormTemplateLocationHistory : IMaster
    {
        #region Fields

        private System.String _docCode;
        private System.String _formTemplateId;
        private System.String _formVersion;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _xmlLocation;
        private System.String _xsnLocation;

        #endregion Fields


        #region Properties

        /// <summary>Gets or sets the DocCode field. </summary>
        public virtual System.String DocCode
        {
            get { return _docCode; }
            set { _docCode = value; }
        }

        /// <summary>Gets the FormTemplateHistoryId field. </summary>
        public virtual System.Int64 FormTemplateHistoryId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FormTemplateId field. </summary>
        public virtual System.String FormTemplateId
        {
            get { return _formTemplateId; }
            set { _formTemplateId = value; }
        }

        /// <summary>Gets or sets the FormVersion field. </summary>
        public virtual System.String FormVersion
        {
            get { return _formVersion; }
            set { _formVersion = value; }
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

        /// <summary>Gets or sets the XmlLocation field. </summary>
        public virtual System.String XmlLocation
        {
            get { return _xmlLocation; }
            set { _xmlLocation = value; }
        }

        /// <summary>Gets or sets the XsnLocation field. </summary>
        public virtual System.String XsnLocation
        {
            get { return _xsnLocation; }
            set { _xsnLocation = value; }
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
            MFormTemplateLocationHistory toCompareWith = obj as MFormTemplateLocationHistory;
            return toCompareWith == null ? false : ((this.FormTemplateHistoryId == toCompareWith.FormTemplateHistoryId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FormTemplateHistoryId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}