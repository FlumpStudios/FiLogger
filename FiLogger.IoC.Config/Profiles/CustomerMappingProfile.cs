using AutoMapper;
using vm = FiLogger.API.DataContracts.Customer;
using dm = FiLogger.Common;

namespace FiLogger.IoC.Config.Profiles
{
    public class CustomerMappingProfile :Profile
    {
        public CustomerMappingProfile()
        {   
            //Map to domain to view model
            CreateMap<dm.Models.CustomerDetails, vm.CustomerDetails>();

            //Reverse map
            CreateMap<vm.CustomerDetails, dm.Models.CustomerDetails>();
        }
    }
}

