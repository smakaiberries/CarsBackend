using AutoMapper;
using CarsBackend.Controllers.Resources;
using CarsBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsBackend
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vehicle, VehicleResource>().ForMember(vr => vr.Contact, opt => opt.MapFrom(v => new ContactResource
            {
                Name = v.ContactName,
                Email = v.ContactEmail,
                Phone = v.ContactPhone
            })).ForMember(vr => vr.Features, opt => opt.MapFrom(v => v.Features.Select(vf => vf.FeatureId)));

            // API Resource to Domain 
            CreateMap<VehicleResource, Vehicle>().ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name));
            CreateMap<VehicleResource, Vehicle>().ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email));
            CreateMap<VehicleResource, Vehicle>().ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone));
            CreateMap<VehicleResource, Vehicle>().ForMember(v => v.Features, 
                opt => opt.MapFrom(vr => vr.Features.Select(id => new VehicleFeature {
                FeatureId = id})));



        }
    }
}
