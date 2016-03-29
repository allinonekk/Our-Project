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

    /// <summary>Class which represents the entity 'MPrinter'</summary>
    public partial class MPrinter : IMaster
    {
        #region Fields

        private System.String _moduleCode;
        private System.String _moduleDescription;
        private System.String _printerName;
        private System.String _printerDescription;
        private System.String _obsInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _emailAddress;
        private System.String _deliveryMode;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPrinter"/> class.</summary>
        public MPrinter()
            : base()
        {}

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ModuleCode field. </summary>
        public virtual System.String ModuleCode
        {
            get { return _moduleCode; }
            set { _moduleCode = value; }
        }

        /// <summary>Gets or sets the ModuleDescription field. </summary>
        public virtual System.String ModuleDescription
        {
            get { return _moduleDescription; }
            set { _moduleDescription = value; }
        }

        /// <summary>Gets or sets the PrinterName field. </summary>
        public virtual System.String PrinterName
        {
            get { return _printerName; }
            set { _printerName = value; }
        }

        /// <summary>Gets or sets the PrinterDescription field. </summary>
        public virtual System.String PrinterDescription
        {
            get { return _printerDescription; }
            set { _printerDescription = value; }
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

        /// <summary>Gets or sets the EmailAddress field. </summary>
        public virtual System.String EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        /// <summary>Gets or sets the DeliveryMode field. </summary>
        public virtual System.String DeliveryMode
        {
            get { return _deliveryMode; }
            set { _deliveryMode = value; }
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
            MPrinter toCompareWith = obj as MPrinter;
            return toCompareWith == null ? false : ((this.ModuleCode == toCompareWith.ModuleCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ModuleCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}