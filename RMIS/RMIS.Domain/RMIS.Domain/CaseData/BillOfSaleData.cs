#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for BillOfSale case type.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BillOfSaleData.cs
// Description: Represents a standard data container object for BillOfSale case type.
// </summary>
// <copyright file= "BillOfSaleData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace RMIS.Domain.CaseData
{
    using System;
    using System.Collections.Generic;

    using RMIS.Domain.CaseSpecific;
    using RMIS.Domain.Common;
    using RMIS.Domain.Interfaces;
    using RMIS.Domain.Subsequent;

    /// <summary>
    /// Represents a standard data container object for BillOfSale case type.
    /// </summary>
    [Serializable]
    public class BillOfSaleData : ICaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the bill of sale info entity.
        /// </summary>
        /// <value>The bill of sale info entity.</value>
        public BillOfSaleInfoEntity BillOfSaleInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="BillOfSaleSubInfoEntity"/>
        /// </summary>
        /// <value>The BillOfSaleSubInfoEntity.</value>
        public BillOfSaleSubInfoEntity BillOfSaleSubInfoEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ref order details.
        /// </summary>
        /// <value>The ref order details.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        public List<RefOrderJOInfoEntity> ListRefOrderJOInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}