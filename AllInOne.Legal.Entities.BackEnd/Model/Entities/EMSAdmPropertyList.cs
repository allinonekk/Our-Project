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

    /// <summary>Class which represents the entity 'Enforcement.EMSAdmPropertyList'</summary>
    public partial class EMSAdmPropertyList : IEnforcement
    {
        #region Fields

        private EMSAdmProperty _eMSAdmProperty;
        private System.String _eMSAdmPropertyListId;
        private Nullable<System.Decimal> _grossProceeds;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private Nullable<System.Decimal> _netTonnage;
        private System.String _propertyType;
        private Nullable<System.Decimal> _releaseCourtCommission;
        private Nullable<System.DateTime> _releaseReceiptDate;
        private System.String _releaseReceiptNo;
        private Nullable<System.Decimal> _saleCourtCommission;
        private Nullable<System.DateTime> _saleReceiptDate;
        private System.String _saleReceiptNo;
        private Nullable<System.Decimal> _tonnage;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSAdmPropertyList"/> class.</summary>
        public EMSAdmPropertyList()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the EMSAdmProperty field. </summary>
        public virtual EMSAdmProperty EMSAdmProperty
        {
            get { return _eMSAdmProperty; }
            set { _eMSAdmProperty = value; }
        }

        /// <summary>Gets or sets the EMSAdmPropertyListId field. </summary>
        public virtual System.String EMSAdmPropertyListId
        {
            get { return _eMSAdmPropertyListId; }
            set { _eMSAdmPropertyListId = value; }
        }

        /// <summary>Gets or sets the GrossProceeds field. </summary>
        public virtual Nullable<System.Decimal> GrossProceeds
        {
            get { return _grossProceeds; }
            set { _grossProceeds = value; }
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

        /// <summary>Gets or sets the NetTonnage field. </summary>
        public virtual Nullable<System.Decimal> NetTonnage
        {
            get { return _netTonnage; }
            set { _netTonnage = value; }
        }

        /// <summary>Gets or sets the PropertyType field. </summary>
        public virtual System.String PropertyType
        {
            get { return _propertyType; }
            set { _propertyType = value; }
        }

        /// <summary>Gets or sets the ReleaseCourtCommission field. </summary>
        public virtual Nullable<System.Decimal> ReleaseCourtCommission
        {
            get { return _releaseCourtCommission; }
            set { _releaseCourtCommission = value; }
        }

        /// <summary>Gets or sets the ReleaseReceiptDate field. </summary>
        public virtual Nullable<System.DateTime> ReleaseReceiptDate
        {
            get { return _releaseReceiptDate; }
            set { _releaseReceiptDate = value; }
        }

        /// <summary>Gets or sets the ReleaseReceiptNo field. </summary>
        public virtual System.String ReleaseReceiptNo
        {
            get { return _releaseReceiptNo; }
            set { _releaseReceiptNo = value; }
        }

        /// <summary>Gets or sets the SaleCourtCommission field. </summary>
        public virtual Nullable<System.Decimal> SaleCourtCommission
        {
            get { return _saleCourtCommission; }
            set { _saleCourtCommission = value; }
        }

        /// <summary>Gets or sets the SaleReceiptDate field. </summary>
        public virtual Nullable<System.DateTime> SaleReceiptDate
        {
            get { return _saleReceiptDate; }
            set { _saleReceiptDate = value; }
        }

        /// <summary>Gets or sets the SaleReceiptNo field. </summary>
        public virtual System.String SaleReceiptNo
        {
            get { return _saleReceiptNo; }
            set { _saleReceiptNo = value; }
        }

        /// <summary>Gets or sets the Tonnage field. </summary>
        public virtual Nullable<System.Decimal> Tonnage
        {
            get { return _tonnage; }
            set { _tonnage = value; }
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
            EMSAdmPropertyList toCompareWith = obj as EMSAdmPropertyList;
            return toCompareWith == null ? false : ((this.EMSAdmPropertyListId == toCompareWith.EMSAdmPropertyListId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSAdmPropertyListId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}