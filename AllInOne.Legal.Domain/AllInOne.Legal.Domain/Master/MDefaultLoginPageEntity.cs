﻿namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MTaskListType'</summary>
    [Serializable]
    public class MDefaultLoginPageEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        public string LoginPageId { get; set; }
        public string URL { get; set; }
        public string CourtID { get; set; }

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
            MDefaultLoginPageEntity toCompareWith = obj as MDefaultLoginPageEntity;
            return toCompareWith == null ? false : ((this.LoginPageId == toCompareWith.LoginPageId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LoginPageId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}