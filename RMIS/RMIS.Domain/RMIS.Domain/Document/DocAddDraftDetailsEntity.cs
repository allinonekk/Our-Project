#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DocAddDraftDetailsEntity.
 *----
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * Sep 20 2010  2:58PM        Japheth             	 	Created
 *****************************************************************************************************
 *	                                    File Usage
 *	Module
 *	1. Case Conversion
 *
 *****************************************************************************************************/
// <summary>
// File: DocAddDraftDetailsEntity.cs
// Description: Represents a standard DocAddDraftDetailsEntity.
// </summary>
// <copyright file= "DocAddDraftDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace RMIS.Domain.Document
{
    using System;
    using System.Collections.Generic;

    using RMIS.Domain.Abstract;
    using RMIS.Domain.Interfaces;
    using RMIS.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DocAddDraftDetails.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class DocAddDraftDetailEntity : AbstractDocId, IDocumentEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DocAddDraftDetailsEntity"/> class.</summary> 
        public DocAddDraftDetailEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public DSCIN DSCIn
        {
            get;
            set;
        }

        public DSCType DSCType
        {
            get;
            set;
        }

        public String RefAffidavitId
        {
            get;
            set;
        }

        public String RefNo
        {
            get;
            set;
        }

        #endregion Properties
    }
}