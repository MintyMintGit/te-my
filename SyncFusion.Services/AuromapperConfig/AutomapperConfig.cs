using AutoMapper.Configuration;
using _1TE_MY.Models;
using _1TE_MY.Models.DTO;
using System;
using AutoMapper;
using System.Globalization;
using _1TE_MY.Models.Models;
using _1TE_MY.Models.Models.DTO;

namespace SyncFusion.Services
{
    public static class AutomapperConfig
    {
        public static void Configure()
        {
            string[] formats = new[] { "MM/dd/yyyy" };
            MapperConfigurationExpression cfg = new MapperConfigurationExpression();

            cfg.CreateMap<OrderDTO, Orders>().ReverseMap();
            cfg.CreateMap<Registration_UserInformation, _1TE_MY.Models.Models.Registeration>().ReverseMap();
            cfg.CreateMap<Registration_ContactPerson, Contact>().ReverseMap();
            cfg.CreateMap<CountryCodeDTO, Country>().ReverseMap()
              .ForMember(dest => dest.DisplayText, opts => opts.ResolveUsing(src =>
              {
                  string DisplayText = src.CountryName + " (" + src.DailingCode + ")";
                  return DisplayText;
              }));

            cfg.CreateMap<DropdownDTO, UDC_Details>().ReverseMap()
                .ForMember(dest => dest.Code, opts => opts.ResolveUsing(src =>
            {
                string UDC_dCode = src.UDC_dCode;
                return UDC_dCode;
            }))
                  .ForMember(dest => dest.Text, opts => opts.ResolveUsing(src =>
                   {
                       string UDC_dDesc = src.UDC_dDesc;
                       return UDC_dDesc;
                   }))
                  .ForMember(dest => dest.Value, opts => opts.ResolveUsing(src =>
                   {
                       int UDC_dID = src.UDC_dID;
                       return UDC_dID;
                   }));
            cfg.CreateMap<DropdownDTO, Country>().ReverseMap()
               .ForMember(dest => dest.Code, opts => opts.ResolveUsing(src =>
               {
                   string DailingCode = src.DailingCode;
                   return DailingCode;
               }))
                 .ForMember(dest => dest.Text, opts => opts.ResolveUsing(src =>
                 {
                     string CountryName = src.CountryName;
                     return CountryName;
                 }))
                 .ForMember(dest => dest.Value, opts => opts.ResolveUsing(src =>
                 {
                     int CountryID = src.CountryID;
                     return CountryID;
                 }));
            cfg.CreateMap<DropdownDTO, State>().ReverseMap()
               .ForMember(dest => dest.Code, opts => opts.ResolveUsing(src =>
               {
                   string StateCode = src.StateCode;
                   return StateCode;
               }))
                 .ForMember(dest => dest.Text, opts => opts.ResolveUsing(src =>
                 {
                     string StateName = src.StateName;
                     return StateName;
                 }))
                 .ForMember(dest => dest.Value, opts => opts.ResolveUsing(src =>
                 {
                     int StateID = src.StateID;
                     return StateID;
                 }));
            cfg.CreateMap<DropdownDTO, City>().ReverseMap()
              .ForMember(dest => dest.Code, opts => opts.ResolveUsing(src =>
              {
                  string CityCode = src.CityCode;
                  return CityCode;
              }))
                .ForMember(dest => dest.Text, opts => opts.ResolveUsing(src =>
                {
                    string StateName = src.CityName;
                    return StateName;
                }))
                .ForMember(dest => dest.Value, opts => opts.ResolveUsing(src =>
                {
                    int CityID = src.CityID;
                    return CityID;
                }));
            //.ForMember(dest => dest.OrderDate, opts => opts.ResolveUsing(src =>
            //{                
            //    DateTime OrDate = DateTime.ParseExact(src.OrderDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);                
            //    return OrDate;
            //})).
            //ForMember(dest => dest.RequiredDate, opts => opts.ResolveUsing(src =>
            //{
            //    DateTime reqDate = DateTime.ParseExact(src.RequiredDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            //    return reqDate;
            //}))
            //.ForMember(dest => dest.ShippedDate, opts => opts.ResolveUsing(src =>
            //{
            //    DateTime shpDate = DateTime.ParseExact(src.ShippedDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            //    return shpDate;
            //}));
            cfg.CreateMap<OrderDTO, OrderDetails>();

            cfg.CreateMap<MerchantDTO, Merchant>();
            cfg.CreateMap<Merchant, MerchantDTO>();





            cfg.CreateMap<Registration_CompanyInformation, _1TE_MY.Models.Models.Registeration>().ReverseMap()
				.ForMember(dest => dest.CompanyName, opts => opts.ResolveUsing(src =>
				src.CompanyName))
				.ForMember(dest => dest.OganizationType, opts => opts.ResolveUsing(src =>
				src.OrganisationType))
				.ForMember(dest => dest.CompanyRegisterationNumber, opts => opts.ResolveUsing(src =>
				src.Comp_RegNo))
				.ForMember(dest => dest.GSTRegisterationNumber, opts => opts.ResolveUsing(src =>
				src.Comp_GSTNo))
				.ForMember(dest => dest.GSTRegisterationDate, opts => opts.ResolveUsing(src =>
				src.Comp_GSTRegistrationDate))
				//.ForMember(dest => dest.DagangNetAccountNo, opts => opts.ResolveUsing(src =>
				//src.Comp_GSTRegistrationDate))
				//.ForMember(dest => dest.ForwardingAgentCode, opts => opts.ResolveUsing(src =>
				//src.AgentCode))
				//.ForMember(dest => dest.ShippingAgentCode, opts => opts.ResolveUsing(src =>
				//src.AgentCode))
				;
			//cfg.CreateMap<Registration_CompanyInformation, Address>().ReverseMap()
			//	.ForMember(dest => dest.Address1, opts => opts.ResolveUsing(src =>
			//	src.raAddress1))
			//	.ForMember(dest => dest.Address2, opts => opts.ResolveUsing(src =>
			//	src.raAddress2))
			//	.ForMember(dest => dest.Address3, opts => opts.ResolveUsing(src =>
			//	src.raAddress3))
			//	.ForMember(dest => dest.Country, opts => opts.ResolveUsing(src =>
			//	src.CountryID))
			//	.ForMember(dest => dest.State, opts => opts.ResolveUsing(src =>
			//	src.StateID))
			//	.ForMember(dest => dest.City, opts => opts.ResolveUsing(src =>
			//	src.CityID))
			//	.ForMember(dest => dest.PostalCode, opts => opts.ResolveUsing(src =>
			//	src.raPostCode))
			//	;
			cfg.AllowNullDestinationValues = true;

            Mapper.Initialize(cfg);
        }

    }
}
