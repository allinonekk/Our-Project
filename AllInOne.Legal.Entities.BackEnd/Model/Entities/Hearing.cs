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

    /// <summary>Class which represents the entity 'Case.Hearing'</summary>
    public partial class Hearing : ICase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="Hearing"/> class.</summary>
        public Hearing()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.CaseInfo - Case.CaseInfo.Hearings (m:1)'</summary>
        //public virtual CaseInfo CaseInfo
        //{
        //    get { return _caseInfo; }
        //    set { _caseInfo = value; }
        //}
        public virtual System.Int64 CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ComputedHearingFee field. </summary>
        public virtual Nullable<System.Decimal> ComputedHearingFee
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ComputedHearingFeeDatetime field. </summary>
        public virtual Nullable<System.DateTime> ComputedHearingFeeDatetime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CountAsCDRSession field. </summary>
        public virtual System.String CountAsCDRSession
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CourtId field. </summary>
        public virtual System.String CourtId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Docid field. </summary>
        public virtual System.String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DsgName field. </summary>
        public virtual String DsgName
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'Document.DocOrderDetail.Hearing - Case.Hearing.DocOrderDetails (m:1)'</summary>
        //public virtual System.Collections.Generic.ICollection<DocOrderDetail> DocOrderDetails
        //{
        //    get;
        //    set;
        //}
        ///// <summary>Represents the navigator which is mapped onto the association 'Document.DocumentInfo.Hearing - Case.Hearing.DocumentInfos (m:1)'</summary>
        //public virtual System.Collections.Generic.ICollection<DocumentInfo> DocumentInfos
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the EHearingInd field. </summary>
        public virtual System.String EHearingInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EHearingStatus field. </summary>
        public virtual System.String EHearingStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EndDateTime field. </summary>
        public virtual Nullable<System.DateTime> EndDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EstimatedHearingFee field. </summary>
        public virtual Nullable<System.Decimal> EstimatedHearingFee
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EstimatedHearingFeeDatetime field. </summary>
        public virtual Nullable<System.DateTime> EstimatedHearingFeeDatetime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FinalAdjournment field. </summary>
        public virtual System.String FinalAdjournment
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HearingModeInd field. </summary>
        public virtual System.String HearingModeInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGApproveInd field. </summary>
        public virtual System.String HRGApproveInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGDateTime field. </summary>
        public virtual System.DateTime HRGDateTime
        {
            get;
            set;
        }

        /// <summary>Gets the HRGID field. </summary>
        public virtual System.Int64 HRGID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGInstructions field. </summary>
        public virtual System.String HRGInstructions
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGLockInd field. </summary>
        public virtual System.String HRGLockInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGOutcomeApprInd field. </summary>
        public virtual System.String HRGOutcomeApprInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGOutcomeRemarks field. </summary>
        public virtual System.String HRGOutcomeRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGOutComeRSNCode field. </summary>
        public virtual System.String HRGOutComeRSNCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGRoomCode field. </summary>
        public virtual System.String HRGRoomCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGSlotcode field. </summary>
        public virtual System.String HRGSlotcode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGTrench field. </summary>
        public virtual Nullable<System.Int64> HRGTrench
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGTypeCode field. </summary>
        public virtual System.String HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IndicationsGiven field. </summary>
        public virtual System.String IndicationsGiven
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Indicator field. </summary>
        public virtual System.String Indicator
        {
            get;
            set;
        }

        public virtual System.String IsCDRRefixed
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MultiDayInd field. </summary>
        public virtual System.String IsPartiesAbsent
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.JudicialUser - BackEndSpecific.JudicialUser.Hearings (m:1)'</summary>
        public virtual JudicialUser JudicialUser
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual MCoram MCoram
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.MCourtType - Master.MCourtType.Hearings (m:1)'</summary>
        public virtual MCourtType MCourtType
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.MDesignation - Master.MDesignation.Hearings (m:1)'</summary>
        public virtual MDesignation MDesignation
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.MHRGBeforeTypeEstimatedHRGBeforeTypeCode - Master.MHRGBeforeType.HearingsEstimatedHRGBeforeTypeCode (m:1)'</summary>
        public virtual MHRGBeforeType MHRGBeforeTypeEstimatedHRGBeforeTypeCode
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.MHRGBeforeTypeHRGBeforeTypeCode - Master.MHRGBeforeType.HearingHRGBeforeTypeCode (m:1)'</summary>
        public virtual MHRGBeforeType MHRGBeforeTypeHRGBeforeTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGOutComeCode field. </summary>
        public virtual MHRGOutCome MHRGOutCome
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MinuteSheet.Hearing - Case.Hearing.MinuteSheet (1:1)'</summary>
        public virtual MinuteSheet MinuteSheet
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MultiDayInd field. </summary>
        public virtual System.String MultiDayInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PartHeardInd field. </summary>
        public virtual System.String PartHeardInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the QueueNo field. </summary>
        public virtual System.String QueueNo
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.RequestHearingFeeDetail.Hearing - Case.Hearing.RequestHearingFeeDetails (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<RequestHearingFeeDetail> RequestHearingFeeDetails
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SCInd field. </summary>
        public virtual System.String SCInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SpecialHrgDateInd field. </summary>
        public virtual System.String SpecialHrgDateInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StartDateTime field. </summary>
        public virtual Nullable<System.DateTime> StartDateTime
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Case.Hearing.SubCaseInfo - SubCase.SubCaseInfo.Hearings (m:1)'</summary>
        //public virtual SubCaseInfo SubCaseInfo
        //{
        //    get { return _subCaseInfo; }
        //    set { _subCaseInfo = value; }
        //}
        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public virtual System.Int64? SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Subsequent.SubpoenaInfo.Hearing - Case.Hearing.SubpoenaInfos (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<SubpoenaInfo> SubpoenaInfos
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ToShow field. </summary>
        public virtual System.String ToShow
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UserId field. </summary>
        public virtual System.String UserId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DsgName field. </summary>
        public virtual String USERNAME
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WorkflowSerialNo field. </summary>
        public virtual System.String WorkflowSerialNo
        {
            get;
            set;
        }

        public virtual string MSType
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
            Hearing toCompareWith = obj as Hearing;
            return toCompareWith == null ? false : ((this.HRGID == toCompareWith.HRGID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HRGID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}