using AutoMapper;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Mappings
{
    public static class AutoMapperMapper
    {
        public static void Configure(out MapperConfiguration mps)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IRepository<UserPdfSplitPaths>, UserPdfSplitPathsRepository>();

            });
            mps = configuration;
        }
        public static MapperConfiguration Configuration
        {
            get
            {
                MapperConfiguration mp = null;
                Configure(out mp);
                return mp;
            }
        }
    }
}
