using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configrations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products"); // tên bảng
            builder.HasKey(x => x.Id); // khóa chính
            builder.Property(x => x.Id).UseIdentityColumn(); // id tự tăng
            builder.Property(x=> x.Price).IsRequired(); // giá tiền
            builder.Property(x => x.OriginalPrice).IsRequired(); // giá gốc
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0); // số lượng
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0); // số lượt xem
        }
    }
}
