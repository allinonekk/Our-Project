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

    /// <summary>Class which represents the entity 'Enforcement.EMSPaymentVoucherFinalOther'</summary>
    public partial class EMSPaymentVoucherFinalOther : IEnforcement
    {
        #region Fields

        private System.String _addr1;
        private System.String _addr2;
        private System.String _addr3;
        private System.String _addr4;
        private System.String _address;
        private System.String _blkNo;
        private System.String _buildingName;
        private CaseParty _caseParty;
        private EMSPaymentVoucherFinal _eMSPaymentVoucherFinal;
        private EMSPaymentVoucher _eMSPaymentVoucher;
        private System.String _eMSPaymentVoucherFinalOtherId;
        private System.String _floorNo;
        private System.String _formatInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private MEMSNatureOfPayment _mEMSNatureOfPayment;
        private System.String _payeeName;
        private System.String _payeeRefNo;
        private System.Decimal _paymentAmt;
        private System.String _paymentToOtherIdentifier;
        private System.String _postalCode;
        private System.String _reason;
        private System.String _remarks;
        private System.String _streetName;
        private System.String _unitNo;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSPaymentVoucherFinalOther"/> class.</summary>
        public EMSPaymentVoucherFinalOther()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Addr1 field. </summary>
        public virtual System.String Addr1
        {
            get { return _addr1; }
            set { _addr1 = value; }
        }

        /// <summary>Gets or sets the Addr2 field. </summary>
        public virtual System.String Addr2
        {
            get { return _addr2; }
            set { _addr2 = value; }
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public virtual System.String Addr3
        {
            get { return _addr3; }
            set { _addr3 = value; }
        }

        /// <summary>Gets or sets the Addr4 field. </summary>
        public virtual System.String Addr4
        {
            get { return _addr4; }
            set { _addr4 = value; }
        }

        /// <summary>Gets or sets the Address field. </summary>
        public virtual System.String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>Gets or sets the BlkNo field. </summary>
        public virtual System.String BlkNo
        {
            get { return _blkNo; }
            set { _blkNo = value; }
        }

        /// <summary>Gets or sets the BuildingName field. </summary>
        public virtual System.String BuildingName
        {
            get { return _buildingName; }
            set { _buildingName = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucherFinalOther.CaseParty - Enforcement.CaseParty.EMSPaymentVoucherFinalOthers (m:1)'</summary>
        public virtual CaseParty CaseParty
        {
            get { return _caseParty; }
            set { _caseParty = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucherFinalOther.EMSPaymentVoucherFinal - Enforcement.EMSPaymentVoucherFinal.EMSPaymentVoucherFinalOthers (m:1)'</summary>
        public virtual EMSPaymentVoucherFinal EMSPaymentVoucherFinal
        {
            get { return _eMSPaymentVoucherFinal; }
            set { _eMSPaymentVoucherFinal = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucherFinalOther.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSPaymentVoucherFinalOthers (m:1)'</summary>
        public virtual EMSPaymentVoucher EMSPaymentVoucher
        {
            get { return _eMSPaymentVoucher; }
            set { _eMSPaymentVoucher = value; }
        }

        /// <summary>Gets or sets the EMSPaymentVoucherFinalOtherId field. </summary>
        public virtual System.String EMSPaymentVoucherFinalOtherId
        {
            get { return _eMSPaymentVoucherFinalOtherId; }
            set { _eMSPaymentVoucherFinalOtherId = value; }
        }

        /// <summary>Gets or sets the FloorNo field. </summary>
        public virtual System.String FloorNo
        {
            get { return _floorNo; }
            set { _floorNo = value; }
        }

        /// <summary>Gets or sets the FormatInd field. </summary>
        public virtual System.String FormatInd
        {
            get { return _formatInd; }
            set { _formatInd = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucherFinalOther.MEMSNatureOfPayment - Enforcement.MEMSNatureOfPayment.EMSPaymentVoucherFinalOthers (m:1)'</summary>
        public virtual MEMSNatureOfPayment MEMSNatureOfPayment
        {
            get { return _mEMSNatureOfPayment; }
            set { _mEMSNatureOfPayment = value; }
        }

        /// <summary>Gets or sets the PayeeName field. </summary>
        public virtual System.String PayeeName
        {
            get { return _payeeName; }
            set { _payeeName = value; }
        }

        /// <summary>Gets or sets the PayeeRefNo field. </summary>
        public virtual System.String PayeeRefNo
        {
            get { return _payeeRefNo; }
            set { _payeeRefNo = value; }
        }

        /// <summary>Gets or sets the PaymentAmt field. </summary>
        public virtual System.Decimal PaymentAmt
        {
            get { return _paymentAmt; }
            set { _paymentAmt = value; }
        }

        /// <summary>Gets or sets the PaymentToOtherIdentifier field. </summary>
        public virtual System.String PaymentToOtherIdentifier
        {
            get { return _paymentToOtherIdentifier; }
            set { _paymentToOtherIdentifier = value; }
        }

        /// <summary>Gets or sets the PostalCode field. </summary>
        public virtual System.String PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        /// <summary>Gets or sets the Reason field. </summary>
        public virtual System.String Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the StreetName field. </summary>
        public virtual System.String StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }

        /// <summary>Gets or sets the UnitNo field. </summary>
        public virtual System.String UnitNo
        {
            get { return _unitNo; }
            set { _unitNo = value; }
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
            EMSPaymentVoucherFinalOther toCompareWith = obj as EMSPaymentVoucherFinalOther;
            return toCompareWith == null ? false : ((this.EMSPaymentVoucherFinalOtherId == toCompareWith.EMSPaymentVoucherFinalOtherId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSPaymentVoucherFinalOtherId.GetHashCode();
            return toReturn;
        }

        //public Dictionary<string,string> Validate()
        //{
        //    Dictionary<string, string> dictErrors = new Dictionary<string, string>();
        //    if (this.PayeeRefNo.Length > 30)
        //        dictErrors.Add("PayeeRefNo", "Length of Payee Ref No should not be longer than 30");
        //    if (this.PayeeName.Length > 200)
        //        dictErrors.Add("PayeeName", "Length of Payee Name should not be longer than 200");
        //    if (this.Address.Length > 300)
        //        dictErrors.Add("Address", "Length of Address should not be longer than 300");
        //    if (this.StreetName.Length > 32)
        //        dictErrors.Add("StreetName", "Length of Street Name should not be longer than 32");
        //    if (this.BuildingName.Length > 32)
        //        dictErrors.Add("BuildingName", "Length of Building Name should not be longer than 32");
        //    return dictErrors; 
        //}

        #endregion Methods
    }
}