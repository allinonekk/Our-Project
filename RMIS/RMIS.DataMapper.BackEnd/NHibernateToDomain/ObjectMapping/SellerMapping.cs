using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using RMIS.Domain.Hospital;
using log4net;
using RMIS.Entities.BackEnd;
using RMIS.Entities.BackEnd.Model.Entities;
using RMIS.Domain.RiceMill;

namespace RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    internal  class SellerMapping
    {


        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(HospitalMapping));

        #endregion Fields
        /// <summary>
        /// Method which maps the <see cref="AffidavitDeponentDetail"/> to <see cref="AffidavitDeponentDetailEntity"/>.
        /// </summary>
        internal void MapSellerTypeEntity()
        {
            try
            {
                Mapper.CreateMap<SellerType, SellerTypeEntity>()
                    .ForMember(dest => dest.SellerTypeID, opts => opts.MapFrom(src => src.SellerTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID ))
                    .ForMember(dest => dest.SellerType, opts => opts.MapFrom(src => src.Type ))
                    .ForMember(dest => dest.ObsInd , opts => opts.MapFrom(src => src.ObsInd ))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAffidavitDeponentDetailToAffidavitDeponentDetailEntity", ex);
                throw;
            }
        }
    }
}
