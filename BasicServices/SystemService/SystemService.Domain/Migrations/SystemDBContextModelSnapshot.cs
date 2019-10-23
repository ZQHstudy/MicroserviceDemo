﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SystemService.Domain;

namespace SystemService.Domain.Migrations
{
    [DbContext(typeof(SystemDBContext))]
    partial class SystemDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CommonLibrary.Recycle", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid>("DeleteBatchID");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("RowData")
                        .IsRequired();

                    b.Property<Guid>("RowKey");

                    b.Property<string>("TableName")
                        .IsRequired();

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.ToTable("Recycle");
                });

            modelBuilder.Entity("SystemService.Domain.Resource", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid>("ParentResourceID");

                    b.Property<string>("ResourceCode")
                        .IsRequired();

                    b.Property<string>("ResourceDesc");

                    b.Property<string>("ResourceName")
                        .IsRequired();

                    b.Property<int>("ResourceType");

                    b.Property<int>("SortNO");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("ID");

                    b.HasIndex("ParentResourceID");

                    b.HasIndex("ResourceCode")
                        .IsUnique();

                    b.ToTable("Resource");

                    b.HasData(
                        new
                        {
                            ID = new Guid("88888888-8888-8888-8888-888888888888"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "RootMenu",
                            ResourceName = "RootMenu",
                            ResourceType = 1,
                            SortNO = 0
                        },
                        new
                        {
                            ID = new Guid("f86d59fd-a5a3-4d56-b31b-59667ebc5878"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "ProductMngmt",
                            ResourceName = "产品管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("c82bc08d-1130-441e-b224-2e71eb286ce9"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("f86d59fd-a5a3-4d56-b31b-59667ebc5878"),
                            ResourceCode = "ProductMngmt.Read",
                            ResourceName = "查看",
                            ResourceType = 2,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("09daed1f-6028-4977-90d5-7a552ffd35e6"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("f86d59fd-a5a3-4d56-b31b-59667ebc5878"),
                            ResourceCode = "ProductMngmt.Add",
                            ResourceName = "添加",
                            ResourceType = 2,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("23ffc1d4-7f8a-47de-bf72-db0329e46b83"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("09daed1f-6028-4977-90d5-7a552ffd35e6"),
                            ResourceCode = "ProductMngmt.Add.AddBtn",
                            ResourceName = "添加按钮",
                            ResourceType = 3,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("59454a4e-a939-43fc-957e-4ba83e05ff22"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("f86d59fd-a5a3-4d56-b31b-59667ebc5878"),
                            ResourceCode = "ProductMngmt.Edit",
                            ResourceName = "修改",
                            ResourceType = 2,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("72c0ec72-3b0f-4f49-971a-a7a15430ca70"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("f86d59fd-a5a3-4d56-b31b-59667ebc5878"),
                            ResourceCode = "ProductMngmt.Delete",
                            ResourceName = "删除",
                            ResourceType = 2,
                            SortNO = 4
                        },
                        new
                        {
                            ID = new Guid("edf3f3bf-8e96-4da8-92f9-337c05224c7a"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "OrderingMngmt",
                            ResourceName = "订单管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("ff605e09-3c8c-42f6-9715-202eccdbc13e"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "PaymentMngmt",
                            ResourceName = "支付管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("52cda552-3ee6-4bd3-9c1d-f9aa9df4b660"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "SystemMngmt",
                            ResourceName = "系统管理",
                            ResourceType = 1,
                            SortNO = 4
                        },
                        new
                        {
                            ID = new Guid("61f0aeff-e6ac-465d-8a44-6db8d53d7e6a"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("52cda552-3ee6-4bd3-9c1d-f9aa9df4b660"),
                            ResourceCode = "SystemMngmt.PermissionMngmt",
                            ResourceName = "权限管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("8ef840bf-6ba4-4b69-b7e5-3cd4a92942fd"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("61f0aeff-e6ac-465d-8a44-6db8d53d7e6a"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt",
                            ResourceName = "角色管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("1bb55302-660c-408b-acf0-31b79879f706"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("8ef840bf-6ba4-4b69-b7e5-3cd4a92942fd"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Read",
                            ResourceName = "查看",
                            ResourceType = 2,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("18c63528-b090-49f3-8268-d254e34c520d"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("8ef840bf-6ba4-4b69-b7e5-3cd4a92942fd"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Update",
                            ResourceName = "更改",
                            ResourceType = 2,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("b8e13a80-4f5d-4a2e-8f1f-604905a77253"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("61f0aeff-e6ac-465d-8a44-6db8d53d7e6a"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.ScopeMngmt",
                            ResourceName = "范围管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("b28025e0-c948-44a8-9f9d-060d5814a2e0"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("61f0aeff-e6ac-465d-8a44-6db8d53d7e6a"),
                            ResourceCode = "SystemMngmt.PermissionMngmt.AssignmnentMngmt",
                            ResourceName = "授权管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("7d7d472e-43aa-449f-bf0e-68e157ae2fd0"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("52cda552-3ee6-4bd3-9c1d-f9aa9df4b660"),
                            ResourceCode = "SystemMngmt.JobMngmt",
                            ResourceName = "任务管理",
                            ResourceType = 1,
                            SortNO = 2
                        },
                        new
                        {
                            ID = new Guid("5c17f9ea-5b02-4cad-aa55-059ca51b8d39"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("52cda552-3ee6-4bd3-9c1d-f9aa9df4b660"),
                            ResourceCode = "SystemMngmt.MessageMngmt",
                            ResourceName = "消息管理",
                            ResourceType = 1,
                            SortNO = 3
                        },
                        new
                        {
                            ID = new Guid("9e3765bc-6588-44f2-8f57-618412474deb"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("52cda552-3ee6-4bd3-9c1d-f9aa9df4b660"),
                            ResourceCode = "SystemMngmt.LogMngmt",
                            ResourceName = "日志管理",
                            ResourceType = 1,
                            SortNO = 4
                        },
                        new
                        {
                            ID = new Guid("faf35762-96ec-4edf-9575-d87c632cb2fe"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ResourceCode = "PlatformMngmt",
                            ResourceName = "平台管理",
                            ResourceType = 1,
                            SortNO = 5
                        },
                        new
                        {
                            ID = new Guid("ed281247-b146-46b9-9e9b-1e078a6e2332"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("faf35762-96ec-4edf-9575-d87c632cb2fe"),
                            ResourceCode = "PlatformMngmt.ResourceMngmt",
                            ResourceName = "资源管理",
                            ResourceType = 1,
                            SortNO = 1
                        },
                        new
                        {
                            ID = new Guid("b591b07a-c116-4340-8905-fef63ce1030c"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ParentResourceID = new Guid("faf35762-96ec-4edf-9575-d87c632cb2fe"),
                            ResourceCode = "PlatformMngmt.TenantMngmt",
                            ResourceName = "租户管理",
                            ResourceType = 1,
                            SortNO = 2
                        });
                });

            modelBuilder.Entity("SystemService.Domain.Tenant", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("SortNO");

                    b.Property<string>("TenantCode")
                        .IsRequired();

                    b.Property<string>("TenantDesc");

                    b.Property<string>("TenantLogo")
                        .IsRequired();

                    b.Property<string>("TenantName")
                        .IsRequired();

                    b.Property<string>("TenantUrl")
                        .IsRequired();

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("ID");

                    b.HasIndex("TenantCode")
                        .IsUnique();

                    b.ToTable("Tenant");

                    b.HasData(
                        new
                        {
                            ID = new Guid("af5b4445-046f-4561-8310-556137bb82ce"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 0,
                            TenantCode = "SYSTEM",
                            TenantLogo = "",
                            TenantName = "SYSTEM",
                            TenantUrl = "www.system.com"
                        },
                        new
                        {
                            ID = new Guid("1b89ac39-a25e-4d77-b6dc-1f37958276dd"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 1,
                            TenantCode = "MSFT",
                            TenantLogo = "",
                            TenantName = "Microsoft",
                            TenantUrl = "www.microsoft.com"
                        },
                        new
                        {
                            ID = new Guid("c7a749fa-f703-4e2f-b6ee-d0d66da58464"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SortNO = 2,
                            TenantCode = "GOOG",
                            TenantLogo = "",
                            TenantName = "Google",
                            TenantUrl = "www.Google.com"
                        });
                });

            modelBuilder.Entity("SystemService.Domain.Resource", b =>
                {
                    b.HasOne("SystemService.Domain.Resource", "ParentResource")
                        .WithMany("ChildrenResources")
                        .HasForeignKey("ParentResourceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}