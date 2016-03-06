namespace AllInOne.Legal.Domain.FrontEndSpecific
{
	using System;
	using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping template
	/// </summary>
	[Serializable]
	public class StagingNotificationsEntity : IFrontEndSpecificEntity
	{

		/// <summary>
		/// Gets or sets the NotificationID field.
		/// </summary>
		public System.Int64 NotificationID
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the AlertDate field.
		/// </summary>
		public DateTime AlertDate
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the CaseInfoID field.
		/// </summary>
        public System.Int64 CaseInfoID
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the SubCaseInfoID field.
		/// </summary>
        public System.Int64 SubCaseInfoID
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the DocID field.
		/// </summary>
        public System.String DocID
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the FEInbox field.
		/// </summary>
		public System.String FEInbox
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the SMS field.
		/// </summary>
		public System.String SMS
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the Fax field.
		/// </summary>
		public System.String Fax
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the EmailSubject field.
		/// </summary>
		public System.String EmailSubject
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the EmailBody field.
		/// </summary>
		public System.String EmailBody
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the Status field.
		/// </summary>
		public System.String Status
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the StatusDate field.
		/// </summary>
		public DateTime StatusDate
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the AlertEventTemplateID field.
		/// </summary>
        public System.Int64 AlertEventTemplateID
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the GroupID field.
		/// </summary>
		public System.Int32 GroupID
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the MessageType field.
		/// </summary>
		public System.String MessageType
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the HrgID field.
		/// </summary>
		public System.Int64 HrgID
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the EServiceInfoId field.
		/// </summary>
        public System.Int64 EServiceInfoId
		{
			get; 
 			set; 
		}

		/// <summary>
		/// Gets or sets the CheckListSubmissionId field.
		/// </summary>
		public System.String CheckListSubmissionId
		{
			get; 
 			set; 
		}
#region ToString, Equals And HashCode Overrides
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            StagingNotificationsEntity toCompareWith = obj as StagingNotificationsEntity;
			return toCompareWith == null ? false : ((this.NotificationID == toCompareWith.NotificationID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NotificationID.GetHashCode();
            return toReturn;
        }

        public override string ToString()
        {
            return "NotificationID=" + NotificationID + "--" +
        "AlertDate=" + AlertDate + "--" +
        "CaseInfoID=" + CaseInfoID + "--" +
        "SubCaseInfoID=" + SubCaseInfoID + "--" +
        "DocID=" + DocID + "--" +
        "FEInbox=" + FEInbox + "--" +
        "SMS=" + SMS + "--" +
        "Fax=" + Fax + "--" +
        "EmailSubject=" + EmailSubject + "--" +
        "EmailBody=" + EmailBody + "--" +
        "Status=" + Status + "--" +
        "StatusDate=" + StatusDate + "--" +
        "AlertEventTemplateID=" + AlertEventTemplateID + "--" +
        "GroupID=" + GroupID + "--" +
        "MessageType=" + MessageType + "--" +
        "HrgID=" + HrgID + "--" +
        "EServiceInfoId=" + EServiceInfoId + "--" +
        "CheckListSubmissionId=" + CheckListSubmissionId + "--" +
        "";
        }
		
		#endregion

	}
}
