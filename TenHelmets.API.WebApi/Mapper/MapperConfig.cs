using AutoMapper;
using System.Collections.Generic;
using TenHelmets.API.Core.DTOs.Organizations;
using TenHelmets.API.Core.Entities;

namespace TenHelmets.API.UI.CentralManagement.WebApi.Mapper
{
    public sealed class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Organization, OrganizationDetailDTO>();
            CreateMap<OrganizationDetailDTO, Organization>();
            CreateMap<Organization, OrganizationInput>();
            CreateMap<OrganizationInput, Organization>();
        }
    }
}
