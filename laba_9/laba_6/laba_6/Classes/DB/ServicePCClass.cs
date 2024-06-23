using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    internal class ServicePCClass : IEntityTypeConfiguration<PC>
    {
        public void Configure(EntityTypeBuilder<PC> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Image).HasMaxLength(200);
            //builder.Property(x => x.Price);
            builder.Property(x => x.CPU).HasMaxLength(200);
            builder.Property(x => x.GPU).HasMaxLength(200);
            builder.Property(x => x.Description_En).HasMaxLength(800);
            builder.Property(x => x.Description_Ru).HasMaxLength(800);
        }
    }
}
