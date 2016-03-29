﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace RMIS.Domain.Enforcement
{
    using System;

    using RMIS.Domain.Master;

    /// <summary>Class which represents the entity 'Enforcement.EMSSale'</summary>
    [Serializable]
    public class EMSSaleEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the OthersaleDetails field. </summary>
        public System.String OthersaleDetails
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleAddr1 field. </summary>
        public System.String AdmSaleAddr1
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleAddr2 field. </summary>
        public System.String AdmSaleAddr2
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleAddr3 field. </summary>
        public System.String AdmSaleAddr3
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleAddr4 field. </summary>
        public System.String AdmSaleAddr4
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleAddress field. </summary>
        public System.String AdmSaleAddress
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleBlkNo field. </summary>
        public System.String AdmSaleBlkNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleBuildingName field. </summary>
        public System.String AdmSaleBuildingName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleFloorNo field. </summary>
        public System.String AdmSaleFloorNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleFormatInd field. </summary>
        public AddressFormatType AdmSaleFormatInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSalePostalCode field. </summary>
        public System.String AdmSalePostalCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleStreetName field. </summary>
        public System.String AdmSaleStreetName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AdmSaleUnitNo field. </summary>
        public System.String AdmSaleUnitNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AmountSold field. </summary>
        public System.Decimal AmountSold
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AuctioneerCharges field. </summary>
        public Nullable<System.Decimal> AuctioneerCharges
        {
            get;
            set;
        }

        /// <summary>Gets or sets the AuctioneerDateEngaged field. </summary>
        public Nullable<System.DateTime> AuctioneerDateEngaged
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BelowValueOrderDate field. </summary>
        public Nullable<System.DateTime> BelowValueOrderDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CFASDate field. </summary>
        public Nullable<System.DateTime> CFASDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CommissionRemarks field. </summary>
        public System.String CommissionRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ConductedBy field. </summary>
        public System.String ConductedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ConductedByOthers field. </summary>
        public System.String ConductedByOthers
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DebtSatisfied field. </summary>
        public System.String DebtSatisfied
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public System.String EMSAccountId
        {
            get;
            set;
        }

        ///// <summary>Gets or sets the EMSAdmChargeId field. </summary>
        //public System.String EMSAdmChargeId
        //{
        //    get;
        //    set;
        //}

        /// <summary>Gets or sets the EMSAdmPropertyId field. </summary>
        public System.String EMSAdmPropertyId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAppointmentId field. </summary>
        public System.String EMSAppointmentId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSSaleId field. </summary>
        public System.String EMSSaleId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemSold field. </summary>
        public System.String ItemSold
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MEMSAuctioneer field. </summary>
        public MEMSAuctioneerEntity MEMSAuctioneer
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public System.String ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherAuctioneer field. </summary>
        public System.String OtherAuctioneer
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Remarks field. </summary>
        public System.String Remarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SaleDateTime field. </summary>
        public Nullable<System.DateTime> SaleDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SaleOrderDate field. </summary>
        public Nullable<System.DateTime> SaleOrderDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SaleType field. </summary>
        public System.String SaleType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TypeOfAuction field. </summary>
        public AutionType TypeOfAuction
        {
            get;
            set;
        }

        public YesNo SyncRequired
        {
            get;
            set;
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
            EMSSaleEntity toCompareWith = obj as EMSSaleEntity;
            return toCompareWith == null ? false : ((this.EMSSaleId == toCompareWith.EMSSaleId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSSaleId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}