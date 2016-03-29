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

    /// <summary>Class which represents the entity 'Enforcement.EMSPaymentVoucher'</summary>
    public partial class EMSPaymentVoucher : IEnforcement
    {
        #region Fields

        private System.String _approvedBy;
        private Nullable<System.DateTime> _approvedDate;
        private JudicialUser _bailiff;
        private Nullable<System.Decimal> _bailiffDisburse;
        private Nullable<System.Decimal> _bailiffMisc;
        private Nullable<System.Decimal> _bailiffTransport;
        private EMSAccount _eMSAccount;
        private System.Collections.Generic.ICollection<EMSAdmClaim> _eMSAdmClaims;
        private System.Collections.Generic.ICollection<EMSDisburseClaim> _eMSDisburseClaims;
        private System.Collections.Generic.ICollection<EMSMiscClaim> _eMSMiscClaims;
        private System.Collections.Generic.ICollection<EMSPayment> _eMSPayments;
        private System.Collections.Generic.ICollection<EMSPaymentVoucherCheque> _eMSPaymentVoucherCheques;
        private System.Collections.Generic.ICollection<EMSPaymentVoucherFinal> _eMSPaymentVoucherFinals;
        private System.String _eMSPaymentVoucherId;
        private System.Collections.Generic.ICollection<EMSTptClaim> _eMSTptClaims;
        private System.DateTime _issueDate;
        private System.String _isUrgent;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.String _obsInd;
        private System.String _paymentVoucherNo;
        private System.String _paymentVoucherType;
        private System.String _remarks;
        private System.String _status;
        private System.DateTime _transDateFrom;
        private System.DateTime _transDateTo;
        private System.String _vettedBy;
        private Nullable<System.DateTime> _vettedDate;
        private System.String _submittedBySigPath;
        private System.String _approvedBySigPath;
        private System.String _oCDocId;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="EMSPaymentVoucher"/> class.</summary>
        public EMSPaymentVoucher()
            : base()
        {
            _eMSDisburseClaims = new System.Collections.Generic.HashSet<EMSDisburseClaim>();
            _eMSPaymentVoucherCheques = new System.Collections.Generic.HashSet<EMSPaymentVoucherCheque>();
            _eMSPaymentVoucherFinals = new System.Collections.Generic.HashSet<EMSPaymentVoucherFinal>();
            _eMSTptClaims = new System.Collections.Generic.HashSet<EMSTptClaim>();
            _eMSMiscClaims = new System.Collections.Generic.HashSet<EMSMiscClaim>();
            _eMSPayments = new System.Collections.Generic.HashSet<EMSPayment>();
            _eMSAdmClaims = new System.Collections.Generic.HashSet<EMSAdmClaim>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the OCDocId field. </summary>
        public virtual System.String OCDocId
        {
            get { return _oCDocId; }
            set { _oCDocId = value; }
        }

        /// <summary>Gets or sets the SubmittedBySigPath field. </summary>
        public virtual System.String SubmittedBySigPath
        {
            get { return _submittedBySigPath; }
            set { _submittedBySigPath = value; }
        }

        /// <summary>Gets or sets the ApprovedBySigPath field. </summary>
        public virtual System.String ApprovedBySigPath
        {
            get { return _approvedBySigPath; }
            set { _approvedBySigPath = value; }
        }

        /// <summary>Gets or sets the ApprovedBy field. </summary>
        public virtual System.String ApprovedBy
        {
            get { return _approvedBy; }
            set { _approvedBy = value; }
        }

        /// <summary>Gets or sets the ApprovedDate field. </summary>
        public virtual Nullable<System.DateTime> ApprovedDate
        {
            get { return _approvedDate; }
            set { _approvedDate = value; }
        }

        /// <summary>Gets or sets the Bailiff field. </summary>
        public virtual JudicialUser Bailiff
        {
            get { return _bailiff; }
            set { _bailiff = value; }
        }

        /// <summary>Gets or sets the BailiffDisburse field. </summary>
        public virtual Nullable<System.Decimal> BailiffDisburse
        {
            get { return _bailiffDisburse; }
            set { _bailiffDisburse = value; }
        }

        /// <summary>Gets or sets the BailiffMisc field. </summary>
        public virtual Nullable<System.Decimal> BailiffMisc
        {
            get { return _bailiffMisc; }
            set { _bailiffMisc = value; }
        }

        /// <summary>Gets or sets the BailiffTransport field. </summary>
        public virtual Nullable<System.Decimal> BailiffTransport
        {
            get { return _bailiffTransport; }
            set { _bailiffTransport = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucher.EMSAccount - Enforcement.EMSAccount.EMSPaymentVouchers (m:1)'</summary>
        public virtual EMSAccount EMSAccount
        {
            get { return _eMSAccount; }
            set { _eMSAccount = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAdmClaim.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSAdmClaims (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSAdmClaim> EMSAdmClaims
        {
            get { return _eMSAdmClaims; }
            set { _eMSAdmClaims = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSDisburseClaim.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSDisburseClaims (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSDisburseClaim> EMSDisburseClaims
        {
            get { return _eMSDisburseClaims; }
            set { _eMSDisburseClaims = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSMiscClaim.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSMiscClaims (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSMiscClaim> EMSMiscClaims
        {
            get { return _eMSMiscClaims; }
            set { _eMSMiscClaims = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPayment.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSPayment (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSPayment> EMSPayments
        {
            get { return _eMSPayments; }
            set { _eMSPayments = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucherCheque.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSPaymentVoucherCheques (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSPaymentVoucherCheque> EMSPaymentVoucherCheques
        {
            get { return _eMSPaymentVoucherCheques; }
            set { _eMSPaymentVoucherCheques = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSPaymentVoucherFinal.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSPaymentVoucherFinals (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSPaymentVoucherFinal> EMSPaymentVoucherFinals
        {
            get { return _eMSPaymentVoucherFinals; }
            set { _eMSPaymentVoucherFinals = value; }
        }

        /// <summary>Gets or sets the EMSPaymentVoucherId field. </summary>
        public virtual System.String EMSPaymentVoucherId
        {
            get { return _eMSPaymentVoucherId; }
            set { _eMSPaymentVoucherId = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSTptClaim.EMSPaymentVoucher - Enforcement.EMSPaymentVoucher.EMSTptClaims (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<EMSTptClaim> EMSTptClaims
        {
            get { return _eMSTptClaims; }
            set { _eMSTptClaims = value; }
        }

        /// <summary>Gets or sets the IssueDate field. </summary>
        public virtual System.DateTime IssueDate
        {
            get { return _issueDate; }
            set { _issueDate = value; }
        }

        /// <summary>Gets or sets the IsUrgent field. </summary>
        public virtual System.String IsUrgent
        {
            get { return _isUrgent; }
            set { _isUrgent = value; }
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

        /// <summary>Gets or sets the PaymentVoucherNo field. </summary>
        public virtual System.String PaymentVoucherNo
        {
            get { return _paymentVoucherNo; }
            set { _paymentVoucherNo = value; }
        }

        /// <summary>Gets or sets the PaymentVoucherType field. </summary>
        public virtual System.String PaymentVoucherType
        {
            get { return _paymentVoucherType; }
            set { _paymentVoucherType = value; }
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public virtual System.String Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        /// <summary>Gets or sets the Status field. </summary>
        public virtual System.String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>Gets or sets the TransDateFrom field. </summary>
        public virtual System.DateTime TransDateFrom
        {
            get { return _transDateFrom; }
            set { _transDateFrom = value; }
        }

        /// <summary>Gets or sets the TransDateTo field. </summary>
        public virtual System.DateTime TransDateTo
        {
            get { return _transDateTo; }
            set { _transDateTo = value; }
        }

        /// <summary>Gets or sets the VettedBy field. </summary>
        public virtual System.String VettedBy
        {
            get { return _vettedBy; }
            set { _vettedBy = value; }
        }

        /// <summary>Gets or sets the VettedDate field. </summary>
        public virtual Nullable<System.DateTime> VettedDate
        {
            get { return _vettedDate; }
            set { _vettedDate = value; }
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            EMSPaymentVoucher toCompareWith = obj as EMSPaymentVoucher;
            return toCompareWith == null ? false : ((this.EMSPaymentVoucherId == toCompareWith.EMSPaymentVoucherId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSPaymentVoucherId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}