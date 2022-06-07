using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Application.Mappings
{
    public class TblOrdeneMappingProfile : Profile
    {
        public TblOrdeneMappingProfile()
        {
            CreateMap<CreateTblOrdeneRequest, TblOrdene>();
            CreateMap<TblOrdene, CreateTblOrdeneRequest>();
            CreateMap<UpdateTblOrdeneRequest, TblOrdene>();
            CreateMap<TblOrdene, UpdateTblOrdeneRequest>();
            CreateMap<ReadTblOrdeneRequest, TblOrdene>();
            CreateMap<TblOrdene, ReadTblOrdeneRequest>();
            CreateMap<DeleteTblOrdeneRequest, TblOrdene>();
            CreateMap<TblOrdene, DeleteTblOrdeneRequest>();
        }
    }
}
