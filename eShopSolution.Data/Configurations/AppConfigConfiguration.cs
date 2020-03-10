using eShopSolution.Data.Enities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            // Ten bang
            builder.ToTable("AppConfigs");
            //Khoa chinh
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
