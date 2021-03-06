﻿namespace RMIS.Domain.Master
{
    using System;

    using RMIS.Domain.Abstract;
    using RMIS.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.RMAASSectionExternalAgencyEntity'</summary>
    [Serializable]
    public class MAASUniversityEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASUniversityCode field. </summary>
        public String AASUniversityCode
        {
            get;
            set;
        }

        public string CountryCode
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
            MAASUniversityEntity toCompareWith = obj as MAASUniversityEntity;
            return toCompareWith == null ? false : ((this.AASUniversityCode == toCompareWith.AASUniversityCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASUniversityCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}