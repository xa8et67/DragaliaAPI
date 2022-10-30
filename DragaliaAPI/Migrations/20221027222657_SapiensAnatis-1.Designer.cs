﻿// <auto-generated />
using System;
using DragaliaAPI.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DragaliaAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20221027222657_SapiensAnatis-1")]
    partial class SapiensAnatis1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DragaliaAPI.Models.Database.DbDeviceAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeviceAccounts");

                    b.HasData(
                        new
                        {
                            Id = "id",
                            HashedPassword = "NMvdakTznEF6khwWcz17i6GTnDA="
                        });
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbParty", b =>
                {
                    b.Property<string>("DeviceAccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PartyNo")
                        .HasColumnType("int");

                    b.Property<string>("PartyName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("DeviceAccountId", "PartyNo");

                    b.ToTable("PartyData");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPartyUnit", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CharaId")
                        .HasColumnType("int");

                    b.Property<int>("EditSkill1CharaId")
                        .HasColumnType("int");

                    b.Property<int>("EditSkill2CharaId")
                        .HasColumnType("int");

                    b.Property<int>("EquipCrestSlotType1CrestId1")
                        .HasColumnType("int");

                    b.Property<int>("EquipCrestSlotType1CrestId2")
                        .HasColumnType("int");

                    b.Property<int>("EquipCrestSlotType1CrestId3")
                        .HasColumnType("int");

                    b.Property<int>("EquipCrestSlotType2CrestId1")
                        .HasColumnType("int");

                    b.Property<int>("EquipCrestSlotType2CrestId2")
                        .HasColumnType("int");

                    b.Property<int>("EquipCrestSlotType3CrestId1")
                        .HasColumnType("int");

                    b.Property<int>("EquipCrestSlotType3CrestId2")
                        .HasColumnType("int");

                    b.Property<long>("EquipDragonKeyId")
                        .HasColumnType("bigint");

                    b.Property<long>("EquipTalismanKeyId")
                        .HasColumnType("bigint");

                    b.Property<int>("EquipWeaponBodyId")
                        .HasColumnType("int");

                    b.Property<int>("EquipWeaponSkinId")
                        .HasColumnType("int");

                    b.Property<string>("PartyDeviceAccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PartyNo")
                        .HasColumnType("int");

                    b.Property<int>("UnitNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartyDeviceAccountId", "PartyNo");

                    b.ToTable("PlayerPartyUnits");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPlayerBannerData", b =>
                {
                    b.Property<string>("DeviceAccountId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DeviceAccountId");

                    b.Property<int>("SummonBannerId")
                        .HasColumnType("int")
                        .HasColumnName("SummonBannerId");

                    b.Property<int>("ConsecutionSummonPoints")
                        .HasColumnType("int")
                        .HasColumnName("CsSummonPoints");

                    b.Property<DateTimeOffset>("ConsecutionSummonPointsMaxDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("CsSummonPointsMaxDate");

                    b.Property<DateTimeOffset>("ConsecutionSummonPointsMinDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("CsSummonPointsMinDate");

                    b.Property<int>("DailyLimitedSummonCount")
                        .HasColumnType("int")
                        .HasColumnName("DailyLimitedSummons");

                    b.Property<int>("IsBeginnerFreeSummonAvailable")
                        .HasColumnType("int")
                        .HasColumnName("BeginnerSummonAvailable");

                    b.Property<int>("IsConsecutionFreeSummonAvailable")
                        .HasColumnType("int")
                        .HasColumnName("CsSummonAvailable");

                    b.Property<int>("IsFreeSummonAvailable")
                        .HasColumnType("int")
                        .HasColumnName("FreeSummonAvailable");

                    b.Property<byte>("PityRate")
                        .HasColumnType("tinyint")
                        .HasColumnName("Pity");

                    b.Property<int>("SummonCount")
                        .HasColumnType("int")
                        .HasColumnName("SummonCount");

                    b.Property<int>("SummonPoints")
                        .HasColumnType("int")
                        .HasColumnName("SummonPoints");

                    b.HasKey("DeviceAccountId", "SummonBannerId");

                    b.ToTable("PlayerBannerData");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPlayerCharaData", b =>
                {
                    b.Property<string>("DeviceAccountId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DeviceAccountId");

                    b.Property<int>("CharaId")
                        .HasColumnType("int")
                        .HasColumnName("CharaId");

                    b.Property<byte>("AdditionalMaxLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("AddMaxLevel");

                    b.Property<int>("Attack")
                        .HasColumnType("int")
                        .HasColumnName("Atk");

                    b.Property<byte>("AttackPlusCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("AtkPlusCount");

                    b.Property<byte>("BurstAttackLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("BurstAtkLvl");

                    b.Property<int>("ComboBuildupCount")
                        .HasColumnType("int")
                        .HasColumnName("ComboBuildupCount");

                    b.Property<int>("Exp")
                        .HasColumnType("int")
                        .HasColumnName("Exp");

                    b.Property<byte>("FirstAbilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Abil1Lvl");

                    b.Property<byte>("FirstExAbilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("ExAbility1Lvl");

                    b.Property<byte>("FirstSkillLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Skill1Lvl");

                    b.Property<DateTimeOffset>("GetTime")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("GetTime");

                    b.Property<int>("Hp")
                        .HasColumnType("int")
                        .HasColumnName("Hp");

                    b.Property<byte>("HpPlusCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("HpPlusCount");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit")
                        .HasColumnName("IsNew");

                    b.Property<bool>("IsTemporary")
                        .HasColumnType("bit")
                        .HasColumnName("IsTemp");

                    b.Property<bool>("IsUnlockEditSkill")
                        .HasColumnType("bit")
                        .HasColumnName("IsUnlockEditSkill");

                    b.Property<byte>("Level")
                        .HasColumnType("tinyint")
                        .HasColumnName("Level");

                    b.Property<byte>("LimitBreakCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("LimitBreakCount");

                    b.Property<bool>("ListViewFlag")
                        .HasColumnType("bit")
                        .HasColumnName("ListViewFlag");

                    b.Property<int>("ManaNodeUnlockCount")
                        .HasColumnType("int")
                        .HasColumnName("ManaNodeUnlockCount");

                    b.Property<byte>("Rarity")
                        .HasColumnType("tinyint")
                        .HasColumnName("Rarity");

                    b.Property<byte>("SecondAbilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Abil2Lvl");

                    b.Property<byte>("SecondExAbilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("ExAbility2Lvl");

                    b.Property<byte>("SecondSkillLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Skill2Lvl");

                    b.Property<byte>("ThirdAbilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Abil3Lvl");

                    b.HasKey("DeviceAccountId", "CharaId");

                    b.ToTable("PlayerCharaData");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPlayerDragonData", b =>
                {
                    b.Property<long>("DragonKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("DragonKeyId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DragonKeyId"), 1L, 1);

                    b.Property<byte>("AttackPlusCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("AttackPlusCount");

                    b.Property<string>("DeviceAccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DeviceAccountId");

                    b.Property<int>("DragonId")
                        .HasColumnType("int")
                        .HasColumnName("DragonId");

                    b.Property<long>("Exp")
                        .HasColumnType("bigint")
                        .HasColumnName("Exp");

                    b.Property<byte>("FirstAbilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Abil1Level");

                    b.Property<byte>("FirstSkillLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Skill1Level");

                    b.Property<DateTimeOffset>("GetTime")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("GetTime");

                    b.Property<byte>("HpPlusCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("HpPlusCount");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit")
                        .HasColumnName("IsLocked");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit")
                        .HasColumnName("IsNew");

                    b.Property<byte>("Level")
                        .HasColumnType("tinyint")
                        .HasColumnName("Level");

                    b.Property<byte>("LimitBreakCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("LimitBreakCount");

                    b.Property<byte>("SecondAbilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Abil2Level");

                    b.HasKey("DragonKeyId");

                    b.ToTable("PlayerDragonData");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPlayerDragonReliability", b =>
                {
                    b.Property<string>("DeviceAccountId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DeviceAccountId");

                    b.Property<int>("DragonId")
                        .HasColumnType("int")
                        .HasColumnName("DragonId");

                    b.Property<DateTimeOffset>("LastContactTime")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("LastContactTime");

                    b.Property<byte>("ReliabilityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Level");

                    b.Property<int>("ReliabilityTotalExp")
                        .HasColumnType("int")
                        .HasColumnName("TotalExp");

                    b.HasKey("DeviceAccountId", "DragonId");

                    b.ToTable("PlayerDragonReliability");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPlayerStoryState", b =>
                {
                    b.Property<string>("DeviceAccountId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DeviceAccountId");

                    b.Property<int>("StoryType")
                        .HasColumnType("int")
                        .HasColumnName("StoryType");

                    b.Property<int>("StoryId")
                        .HasColumnType("int")
                        .HasColumnName("StoryId");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint")
                        .HasColumnName("State");

                    b.HasKey("DeviceAccountId", "StoryType", "StoryId");

                    b.ToTable("PlayerStoryState");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPlayerSummonHistory", b =>
                {
                    b.Property<long>("SummonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("SummonId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SummonId"), 1L, 1);

                    b.Property<int>("BannerId")
                        .HasColumnType("int")
                        .HasColumnName("BannerId");

                    b.Property<string>("DeviceAccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DeviceAccountId");

                    b.Property<int>("DewPointGet")
                        .HasColumnType("int")
                        .HasColumnName("DewPointGet");

                    b.Property<int>("EntityAtkPlusCount")
                        .HasColumnType("int")
                        .HasColumnName("AtkPlusCount");

                    b.Property<int>("EntityHpPlusCount")
                        .HasColumnType("int")
                        .HasColumnName("HpPlusCount");

                    b.Property<int>("EntityId")
                        .HasColumnType("int")
                        .HasColumnName("EntityId");

                    b.Property<byte>("EntityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("Level");

                    b.Property<byte>("EntityLimitBreakCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("LimitBreakCount");

                    b.Property<int>("EntityQuantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.Property<byte>("EntityRarity")
                        .HasColumnType("tinyint")
                        .HasColumnName("Rarity");

                    b.Property<int>("EntityType")
                        .HasColumnType("int")
                        .HasColumnName("EntityType");

                    b.Property<DateTimeOffset>("ExecDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("SummonDate");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int")
                        .HasColumnName("PaymentType");

                    b.Property<byte>("SummonExecType")
                        .HasColumnType("tinyint")
                        .HasColumnName("SummonExecType");

                    b.Property<int>("SummonPointGet")
                        .HasColumnType("int")
                        .HasColumnName("SummonPointGet");

                    b.Property<int>("SummonPrizeRank")
                        .HasColumnType("int")
                        .HasColumnName("SummonPrizeRank");

                    b.HasKey("SummonId");

                    b.ToTable("PlayerSummonHistory");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPlayerUserData", b =>
                {
                    b.Property<string>("DeviceAccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ActiveMemoryEventId")
                        .HasColumnType("int");

                    b.Property<int>("BuildTimePoint")
                        .HasColumnType("int");

                    b.Property<int>("Coin")
                        .HasColumnType("int");

                    b.Property<int>("CreateTime")
                        .HasColumnType("int");

                    b.Property<int>("Crystal")
                        .HasColumnType("int");

                    b.Property<int>("DewPoint")
                        .HasColumnType("int");

                    b.Property<int>("EmblemId")
                        .HasColumnType("int");

                    b.Property<int>("Exp")
                        .HasColumnType("int");

                    b.Property<int>("FortOpenTime")
                        .HasColumnType("int");

                    b.Property<int>("IsOptin")
                        .HasColumnType("int");

                    b.Property<int>("LastLoginTime")
                        .HasColumnType("int");

                    b.Property<int>("LastStaminaMultiUpdateTime")
                        .HasColumnType("int");

                    b.Property<int>("LastStaminaSingleUpdateTime")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MainPartyNo")
                        .HasColumnType("int");

                    b.Property<int>("ManaPoint")
                        .HasColumnType("int");

                    b.Property<int>("MaxAmuletQuantity")
                        .HasColumnType("int");

                    b.Property<int>("MaxDragonQuantity")
                        .HasColumnType("int");

                    b.Property<int>("MaxWeaponQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrologueEndTime")
                        .HasColumnType("int");

                    b.Property<int>("QuestSkipPoint")
                        .HasColumnType("int");

                    b.Property<int>("StaminaMulti")
                        .HasColumnType("int");

                    b.Property<int>("StaminaMultiSurplusSecond")
                        .HasColumnType("int");

                    b.Property<int>("StaminaSingle")
                        .HasColumnType("int");

                    b.Property<int>("StaminaSingleSurplusSecond")
                        .HasColumnType("int");

                    b.Property<int>("TutorialFlag")
                        .HasColumnType("int");

                    b.Property<int>("TutorialStatus")
                        .HasColumnType("int");

                    b.Property<long>("ViewerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ViewerId"), 1L, 1);

                    b.HasKey("DeviceAccountId");

                    b.ToTable("PlayerUserData");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbQuest", b =>
                {
                    b.Property<string>("DeviceAccountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.Property<float>("BestClearTime")
                        .HasColumnType("real");

                    b.Property<int>("DailyPlayCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsAppear")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMissionClear1")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMissionClear2")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMissionClear3")
                        .HasColumnType("bit");

                    b.Property<int>("LastDailyResetTime")
                        .HasColumnType("int");

                    b.Property<int>("LastWeeklyResetTime")
                        .HasColumnType("int");

                    b.Property<int>("PlayCount")
                        .HasColumnType("int");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint");

                    b.Property<int>("WeeklyPlayCount")
                        .HasColumnType("int");

                    b.HasKey("DeviceAccountId", "QuestId");

                    b.ToTable("DbQuest");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbPartyUnit", b =>
                {
                    b.HasOne("DragaliaAPI.Models.Database.Savefile.DbParty", "Party")
                        .WithMany("Units")
                        .HasForeignKey("PartyDeviceAccountId", "PartyNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Party");
                });

            modelBuilder.Entity("DragaliaAPI.Models.Database.Savefile.DbParty", b =>
                {
                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}