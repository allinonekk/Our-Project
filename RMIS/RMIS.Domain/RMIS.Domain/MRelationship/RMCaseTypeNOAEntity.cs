﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCaseTypeNOA entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   08/06/2011   		      CJ             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMCaseTypeNOAEntity.cs
// Description: Represents a standard RMCaseTypeNOA entity.
// </summary>
// <copyright file= "RMNOAForumHrgTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace RMIS.Domain.MRelationship
{
    using System;

    using RMIS.Domain.Abstract;
    using RMIS.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMCaseTypeNOAEntity'</summary>
    [Serializable]
    public class RMCaseTypeNOAEntity : AbstractLastModified, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RMCaseTypeNOAEntity"/> class.
        /// </summary>
        public RMCaseTypeNOAEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String NOACode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
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
            RMCaseTypeNOAEntity toCompareWith = obj as RMCaseTypeNOAEntity;
            return toCompareWith == null ? false : ((this.NOACode == toCompareWith.NOACode) && (this.CaseTypeCode == toCompareWith.CaseTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NOACode.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}