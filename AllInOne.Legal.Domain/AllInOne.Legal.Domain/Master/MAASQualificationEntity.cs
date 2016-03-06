﻿namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MAASQualificationEntity'</summary>
    public class MAASQualificationEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the AASQualificationCode field. </summary>
        public System.String AASQualificationCode
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
            if(obj == null)
            {
                return false;
            }
            MAASQualificationEntity toCompareWith = obj as MAASQualificationEntity;
            return toCompareWith == null ? false : ((this.AASQualificationCode == toCompareWith.AASQualificationCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AASQualificationCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}