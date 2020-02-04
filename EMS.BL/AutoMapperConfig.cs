using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Employee = ESM.BL.Employee;
using EmployeeDL = EMS.DL.Employee;

namespace EMS.BL
{
    public static class AutoMapperConfig
    {
        private static MapperConfiguration _config;
       
        public static IMapper getMapper()
        {
            _config = new MapperConfiguration(cfg => {
                cfg.CreateMap<EmployeeDL, Employee>().ReverseMap();
            });
            return _config.CreateMapper();
        }
    }
}
