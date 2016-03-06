﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBillNature entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MBillNatureEntity.cs
// Description: Represents a standard MBillNature entity.
// </summary>
// <copyright file= "MBillNatureEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBillNature.
    /// </summary>
    [Serializable]
    public class MMassCallHrgDateEntity : AbstractMasterInfo, IMasterEntity
    {
       
        #region Properties

        /// <summary>
        /// Gets or sets the BillNatureCode field.
        /// </summary>
        /// <value>The bill nature code.</value>
        public String MMassCallHrgDateId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public DateTime MassCallHrgDate
        {
            get; set;
        }

      
        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MMassCallHrgDateEntity toCompareWith = obj as MMassCallHrgDateEntity;
            return toCompareWith == null ? false : ((this.MMassCallHrgDateId == toCompareWith.MMassCallHrgDateId));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MMassCallHrgDateId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}