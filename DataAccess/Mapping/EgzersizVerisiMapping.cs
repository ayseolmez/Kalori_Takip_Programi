﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class EgzersizVerisiMapping : EntityTypeConfiguration<EgzersizVerisi>
    {
        public EgzersizVerisiMapping()
        {
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(x => x.Egzersiz).HasColumnName("Egzersiz");


            this.Property(x => x.CreatedBy).HasMaxLength(50);
            this.Property(x => x.ModifiedBy).HasMaxLength(50);
            this.Property(x => x.DeletedBy).HasMaxLength(50);



            this.Property(x => x.CreatedDate).IsRequired();
            this.Property(x => x.DeletedDate).IsOptional();
            this.Property(x => x.ModifiedDate).IsOptional();

            this.Property(x => x.Status).HasColumnName("Statu");


            this.HasOptional(ev => ev.Kullanici)
               .WithMany(k => k.Egzersizler)
               .HasForeignKey(ev => ev.KullaniciID);
        }
    }
    
}
