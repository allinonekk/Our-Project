#region Header

/*****************************************************************************************************
 * Description : This file represents a standard WOSRenewDocDetailsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  3:00PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: WOSRenewDocDetailsEntity.cs
// Description: Represents a standard WOSRenewDocDetailsEntity.
// </summary>
// <copyright file= "WOSRenewDocDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace RMIS.Domain.WritOfSummons
{
    using System;
    using System.Collections.Generic;

    using RMIS.Domain.Abstract;
    using RMIS.Domain.Interfaces;
    using RMIS.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for WOSRenewDocDetails.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class WOSRenewDocDetailsEntity : AbstractCaseInfo
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOSRenewDocDetailsEntity"/> class.</summary> 
        public WOSRenewDocDetailsEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string DocID
        {
            get; set;
        }

        public DateTime RenewalEffectiveDate
        {
            get; set;
        }

        public object RenewalPeriod
        {
            get; set;
        }

        #endregion Properties
    }
}