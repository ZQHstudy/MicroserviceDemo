﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PermissionService.Domain;

namespace PermissionService.Domain.Migrations
{
    [DbContext(typeof(PermissionDBContext))]
    [Migration("20191205090247_20191205")]
    partial class _20191205
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PermissionService.Domain.Principal", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("PrincipalCode")
                        .IsRequired();

                    b.Property<string>("PrincipalDesc");

                    b.Property<string>("PrincipalName")
                        .IsRequired();

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "PrincipalCode")
                        .IsUnique();

                    b.ToTable("Principal");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("288d6758-80b8-4aa7-a7d9-707e6ffd7c01"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            PrincipalCode = "admin",
                            PrincipalName = "admin"
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.Role", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("RoleCode")
                        .IsRequired();

                    b.Property<string>("RoleDesc");

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.Property<int>("RoleType");

                    b.Property<int>("SortNO");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "RoleCode")
                        .IsUnique();

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            RoleCode = "administor",
                            RoleName = "administor",
                            RoleType = 1,
                            SortNO = 0
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.RoleAssignment", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<Guid>("PrincipalID");

                    b.Property<Guid>("RoleID");

                    b.Property<Guid>("ScopeID");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "PrincipalID");

                    b.HasIndex("TenantCode", "RoleID");

                    b.HasIndex("TenantCode", "ScopeID");

                    b.ToTable("RoleAssignment");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("b2efff48-1ac0-4958-84f3-cb3b02af8098"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            PrincipalID = new Guid("288d6758-80b8-4aa7-a7d9-707e6ffd7c01"),
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89"),
                            ScopeID = new Guid("88888888-8888-8888-8888-888888888888")
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.RolePermission", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("ResourceCode")
                        .IsRequired();

                    b.Property<string>("ResourceName")
                        .IsRequired();

                    b.Property<Guid>("RoleID");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "RoleID");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("a1d86598-1327-4cb6-8f5a-306ce0eac5e3"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "Permission.GetUserMenus",
                            ResourceName = "获取用户菜单",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("98102026-eebb-42c6-83cb-bc35cb982065"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "values.getuserclaims",
                            ResourceName = "getuserclaims",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("f59d6378-fe14-4283-b91b-118e9d5772a1"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "RootMenu",
                            ResourceName = "RootMenu",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("05c8d0cf-1ad5-4331-864f-585e053ffb07"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "ProductMngmt",
                            ResourceName = "产品管理",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("ce043224-0df7-4d93-a472-1a4012738749"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt",
                            ResourceName = "系统管理",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("f8fdf5b1-0193-411f-ada0-d352fab92a64"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt",
                            ResourceName = "权限管理",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("2c6c1c3f-c6e7-4b0e-9f71-83d461019734"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt",
                            ResourceName = "角色管理",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("a21c2c4f-59db-475b-bc18-6d4af8dd76aa"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Read",
                            ResourceName = "查看",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("0f5a9ab9-03f0-4c9f-b600-9f3a57bd3957"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Update",
                            ResourceName = "更改",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("e06bec7a-ec41-46b0-9e43-73bfd22c6d64"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.ScopeMngmt",
                            ResourceName = "范围管理",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("eeec07dc-e0c7-4f6f-9eab-ccdba7b0c819"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.AssignmnentMngmt",
                            ResourceName = "授权管理",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("cc1a8536-3136-4d08-b4ea-51fc75674ccc"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "basket.createorder",
                            ResourceName = "购物车下单",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("ba05d080-566a-4668-8d8a-470b7e30d1e3"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "ordering.add",
                            ResourceName = "新增订单",
                            RoleID = new Guid("8ae0bc01-b937-4e3a-a5cf-e32bc5650c89")
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.Scope", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<Guid>("ParentScopeID");

                    b.Property<string>("ScopeCode")
                        .IsRequired();

                    b.Property<string>("ScopeDesc");

                    b.Property<string>("ScopeName")
                        .IsRequired();

                    b.Property<int>("SortNO");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "ParentScopeID");

                    b.HasIndex("TenantCode", "ScopeCode")
                        .IsUnique();

                    b.ToTable("Scope");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("88888888-8888-8888-8888-888888888888"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ParentScopeID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ScopeCode = "RootScope",
                            ScopeName = "RootScope",
                            SortNO = 0
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("d5ec1a49-aad2-4f14-a6f3-111e35eca07d"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ParentScopeID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ScopeCode = "1Node1",
                            ScopeName = "一级组织",
                            SortNO = 0
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("f83687ae-8d50-41a0-8852-39ac93680774"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ParentScopeID = new Guid("d5ec1a49-aad2-4f14-a6f3-111e35eca07d"),
                            ScopeCode = "1Node1.2Node1",
                            ScopeName = "二级组织1",
                            SortNO = 1
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("0dd5fe76-8e84-4833-af32-cbd5f2c559b6"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ParentScopeID = new Guid("f83687ae-8d50-41a0-8852-39ac93680774"),
                            ScopeCode = "1Node1.2Node1.3Node1",
                            ScopeName = "三级组织1",
                            SortNO = 0
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("257a6adb-1e47-49d8-a291-50c3fc4489b0"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ParentScopeID = new Guid("d5ec1a49-aad2-4f14-a6f3-111e35eca07d"),
                            ScopeCode = "1Node1.2Node2",
                            ScopeName = "二级组织2",
                            SortNO = 2
                        });
                });

            modelBuilder.Entity("ServiceCommon.Recycle", b =>
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

            modelBuilder.Entity("PermissionService.Domain.RoleAssignment", b =>
                {
                    b.HasOne("PermissionService.Domain.Principal", "Principal")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("TenantCode", "PrincipalID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PermissionService.Domain.Role", "Role")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("TenantCode", "RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PermissionService.Domain.Scope", "Scope")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("TenantCode", "ScopeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PermissionService.Domain.RolePermission", b =>
                {
                    b.HasOne("PermissionService.Domain.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("TenantCode", "RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PermissionService.Domain.Scope", b =>
                {
                    b.HasOne("PermissionService.Domain.Scope", "ParentScope")
                        .WithMany("ChildrenScopes")
                        .HasForeignKey("TenantCode", "ParentScopeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}