using AutoMapper;
using BSD.Models.DTO;
using chinasA.Models;
using System.Drawing;

namespace BSD.Models
{
    public class DIProfile : Profile
    {
        public DIProfile()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<DonationDto, Donation>();
            CreateMap<GiftDto, Gift>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<CardDto, Card>();
            CreateMap<PurchaseDto, Purchase>();
        }
    }
}
