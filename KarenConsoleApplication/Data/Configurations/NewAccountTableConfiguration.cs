﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using KarenConsoleApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KarenConsoleApplication.Data.Configurations
{
    public partial class NewAccountTableConfiguration : IEntityTypeConfiguration<NewAccountTable>
    {
        public void Configure(EntityTypeBuilder<NewAccountTable> entity)
        {
            entity.ToTable("NewAccountTable");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<NewAccountTable> entity);
    }
}
