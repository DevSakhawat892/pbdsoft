using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sakhawat.Model.Models;

namespace Sakhawat.Data
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccAFinancialYear> AccAFinancialYears { get; set; } = null!;
        public virtual DbSet<AccBChartOfAccount> AccBChartOfAccounts { get; set; } = null!;
        public virtual DbSet<AccCJournalMaster> AccCJournalMasters { get; set; } = null!;
        public virtual DbSet<AccDJournalDetail> AccDJournalDetails { get; set; } = null!;
        public virtual DbSet<CompACompanyInfo> CompACompanyInfos { get; set; } = null!;
        public virtual DbSet<CompBBranchInfo> CompBBranchInfos { get; set; } = null!;
        public virtual DbSet<CompCTransportTypeInfo> CompCTransportTypeInfos { get; set; } = null!;
        public virtual DbSet<CompDTransportInfo> CompDTransportInfos { get; set; } = null!;
        public virtual DbSet<EduABuildingInfo> EduABuildingInfos { get; set; } = null!;
        public virtual DbSet<EduBClassOrHallRoomInfo> EduBClassOrHallRoomInfos { get; set; } = null!;
        public virtual DbSet<EduCClassOrHallSeatInfo> EduCClassOrHallSeatInfos { get; set; } = null!;
        public virtual DbSet<EduDStudentAllocateHallSeatInfo> EduDStudentAllocateHallSeatInfos { get; set; } = null!;
        public virtual DbSet<EduETransportAreaInfo> EduETransportAreaInfos { get; set; } = null!;
        public virtual DbSet<EduFTransportChargeInfo> EduFTransportChargeInfos { get; set; } = null!;
        public virtual DbSet<EduGLinkTransportAreaInfo> EduGLinkTransportAreaInfos { get; set; } = null!;
        public virtual DbSet<EduHStudentAllocateTransport> EduHStudentAllocateTransports { get; set; } = null!;
        public virtual DbSet<EduIClassInfo> EduIClassInfos { get; set; } = null!;
        public virtual DbSet<EduJClassSectionInfo> EduJClassSectionInfos { get; set; } = null!;
        public virtual DbSet<EduKClassGroupInfo> EduKClassGroupInfos { get; set; } = null!;
        public virtual DbSet<EduLClassShiftInfo> EduLClassShiftInfos { get; set; } = null!;
        public virtual DbSet<EduMClassSubjectInfo> EduMClassSubjectInfos { get; set; } = null!;
        public virtual DbSet<EduNLinkClassGroupInfo> EduNLinkClassGroupInfos { get; set; } = null!;
        public virtual DbSet<EduOLinkClassSectionInfo> EduOLinkClassSectionInfos { get; set; } = null!;
        public virtual DbSet<EduPLinkClassShiftInfo> EduPLinkClassShiftInfos { get; set; } = null!;
        public virtual DbSet<EduQLinkClassSubjectInfo> EduQLinkClassSubjectInfos { get; set; } = null!;
        public virtual DbSet<EduRExamInfo> EduRExamInfos { get; set; } = null!;
        public virtual DbSet<EduSAcademicYearInfo> EduSAcademicYearInfos { get; set; } = null!;
        public virtual DbSet<EduTAcadeicSessionInfo> EduTAcadeicSessionInfos { get; set; } = null!;
        public virtual DbSet<EduUClassPeriodInfo> EduUClassPeriodInfos { get; set; } = null!;
        public virtual DbSet<HrASalaryPayScalInfo> HrASalaryPayScalInfos { get; set; } = null!;
        public virtual DbSet<HrBEmployeeCategoryInfo> HrBEmployeeCategoryInfos { get; set; } = null!;
        public virtual DbSet<HrCEmployeeDivisionInfo> HrCEmployeeDivisionInfos { get; set; } = null!;
        public virtual DbSet<HrDEmployeeDepartmentInfo> HrDEmployeeDepartmentInfos { get; set; } = null!;
        public virtual DbSet<HrEEmployeeDesignationInfo> HrEEmployeeDesignationInfos { get; set; } = null!;
        public virtual DbSet<HrFEmployeeJobRefNoInfo> HrFEmployeeJobRefNoInfos { get; set; } = null!;
        public virtual DbSet<HrGEmployeeGenderInfo> HrGEmployeeGenderInfos { get; set; } = null!;
        public virtual DbSet<HrHBloodGroupInfo> HrHBloodGroupInfos { get; set; } = null!;
        public virtual DbSet<HrIReligionInfo> HrIReligionInfos { get; set; } = null!;
        public virtual DbSet<HrJEmployeeInfo> HrJEmployeeInfos { get; set; } = null!;
        public virtual DbSet<HrKReferenceTypeInfo> HrKReferenceTypeInfos { get; set; } = null!;
        public virtual DbSet<HrLPresentAddressInfo> HrLPresentAddressInfos { get; set; } = null!;
        public virtual DbSet<HrMPermanentAddressInfo> HrMPermanentAddressInfos { get; set; } = null!;
        public virtual DbSet<SecAUserGroupInfo> SecAUserGroupInfos { get; set; } = null!;
        public virtual DbSet<SecBUserInfo> SecBUserInfos { get; set; } = null!;
        public virtual DbSet<SecCLinkUserBranchInfo> SecCLinkUserBranchInfos { get; set; } = null!;
        public virtual DbSet<SecDScreenInfo> SecDScreenInfos { get; set; } = null!;
        public virtual DbSet<SecELinkUserGroupScreenInfo> SecELinkUserGroupScreenInfos { get; set; } = null!;
        public virtual DbSet<SecFScreenCommandInfo> SecFScreenCommandInfos { get; set; } = null!;
        public virtual DbSet<SecGLinkUserGroupScreenCommandInfo> SecGLinkUserGroupScreenCommandInfos { get; set; } = null!;
        public virtual DbSet<SecHUserLoginTracking> SecHUserLoginTrackings { get; set; } = null!;
        public virtual DbSet<SoftConfigACountryInfo> SoftConfigACountryInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigBDivisionOrStateInfo> SoftConfigBDivisionOrStateInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigCDistrictOrCityInfo> SoftConfigCDistrictOrCityInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigDPoliceStationInfo> SoftConfigDPoliceStationInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigEBusinessTypeInfo> SoftConfigEBusinessTypeInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigFLanguageInfo> SoftConfigFLanguageInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigGFontInfo> SoftConfigGFontInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigHInvoiceModeInfo> SoftConfigHInvoiceModeInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigIModuleInfo> SoftConfigIModuleInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigJCompanyLinkModule> SoftConfigJCompanyLinkModules { get; set; } = null!;
        public virtual DbSet<SoftConfigKBoothInfo> SoftConfigKBoothInfos { get; set; } = null!;
        public virtual DbSet<SoftConfigLBoothLinkBranch> SoftConfigLBoothLinkBranches { get; set; } = null!;
        public virtual DbSet<SoftConfigMGlobalOption> SoftConfigMGlobalOptions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=103.125.253.235,4473;Initial Catalog=pbERP_Development; User ID=pbERP;Password=pbd@@123!@#");
            
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccAFinancialYear>(entity =>
            {
                entity.HasKey(e => e.FinancialYearId)
                    .HasName("PK_FinalcialYear");

                entity.ToTable("ACC_A_FinancialYear");

                entity.Property(e => e.FinancialYearId)
                    .ValueGeneratedNever()
                    .HasColumnName("FinancialYearID");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Udate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AccBChartOfAccount>(entity =>
            {
                entity.HasKey(e => e.ChartOfAccountId)
                    .HasName("PK_Acc_A_ChartOfAccount");

                entity.ToTable("ACC_B_ChartOfAccount");

                entity.Property(e => e.ChartOfAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ChartOfAccountID");

                entity.Property(e => e.ChartOfAccountName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ChartOfAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChartOfAccountParentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ChartOfAccountParentID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReserveAmountForTheFinancialYearOf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AccCJournalMaster>(entity =>
            {
                entity.HasKey(e => e.JournalCode);

                entity.ToTable("ACC_C_JournalMaster");

                entity.Property(e => e.JournalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AmountReference)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.BoothCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BranchID");

                entity.Property(e => e.CompanyId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("FinancialYearID");

                entity.Property(e => e.JournalDate).HasColumnType("datetime");

                entity.Property(e => e.JournalMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("JournalMasterID");

                entity.Property(e => e.PostingBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Udate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Udt)
                    .HasColumnType("datetime")
                    .HasColumnName("UDt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserID");

                entity.Property(e => e.VoucherDirection)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Voucher_Direction");
            });

            modelBuilder.Entity<AccDJournalDetail>(entity =>
            {
                entity.HasKey(e => e.JournalDetailsId)
                    .HasName("PK_JournalDetails");

                entity.ToTable("ACC_D_JournalDetails");

                entity.Property(e => e.JournalDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("JournalDetailsID");

                entity.Property(e => e.BoothCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BranchID");

                entity.Property(e => e.ChartofAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ChartofAccountID");

                entity.Property(e => e.CompanyId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("FinancialYearID");

                entity.Property(e => e.JournalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reference)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TrChartOfAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TrChartOfAccountID");

                entity.Property(e => e.TrDt).HasColumnType("datetime");

                entity.Property(e => e.Udate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserID");

                entity.HasOne(d => d.JournalCodeNavigation)
                    .WithMany(p => p.AccDJournalDetails)
                    .HasForeignKey(d => d.JournalCode)
                    .HasConstraintName("FK_ACC_D_JournalDetails_ACC_C_JournalMaster");
            });

            modelBuilder.Entity<CompACompanyInfo>(entity =>
            {
                entity.HasKey(e => e.ComapanyId)
                    .HasName("PK_Comp_1_CompanyInfo");

                entity.ToTable("Comp_A_CompanyInfo");

                entity.Property(e => e.ComapanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ComapanyID");

                entity.Property(e => e.BusinessTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BusinessTypeID");

                entity.Property(e => e.ComapanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddressEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddressLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyBackgroundImage).HasColumnType("image");

                entity.Property(e => e.CompanyBin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CompanyBIN");

                entity.Property(e => e.CompanyEin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CompanyEIN");

                entity.Property(e => e.CompanyEmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyLogo).HasColumnType("image");

                entity.Property(e => e.CompanyNameEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNameLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CompanyTIN");

                entity.Property(e => e.CompanyVatRegistration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWhatsApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupOfCompanyNameEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GroupOfCompanyNameLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PoliceStationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PoliceStationID");
            });

            modelBuilder.Entity<CompBBranchInfo>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("PK_Comp_2_BranchInfo");

                entity.ToTable("Comp_B_BranchInfo");

                entity.Property(e => e.BranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BranchID");

                entity.Property(e => e.BranchAddressEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BranchAddressLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchWhatsApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComapanyId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PoliceStationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PoliceStationID");
            });

            modelBuilder.Entity<CompCTransportTypeInfo>(entity =>
            {
                entity.HasKey(e => e.TransportTypeId)
                    .HasName("PK_Comp_C_TransportInfo");

                entity.ToTable("Comp_C_TransportTypeInfo");

                entity.Property(e => e.TransportTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportTypeID");

                entity.Property(e => e.TransportTypeEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TransportTypeLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompDTransportInfo>(entity =>
            {
                entity.HasKey(e => e.TransportId)
                    .HasName("PK_Edu_D_TransportInfo");

                entity.ToTable("Comp_D_TransportInfo");

                entity.Property(e => e.TransportId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportID");

                entity.Property(e => e.Ait).HasColumnName("AIT");

                entity.Property(e => e.TransportEngineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransportNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransportNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransportRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransportTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportTypeID");
            });

            modelBuilder.Entity<EduABuildingInfo>(entity =>
            {
                entity.HasKey(e => e.BuildingId);

                entity.ToTable("Edu_A_BuildingInfo");

                entity.Property(e => e.BuildingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BuildingID");

                entity.Property(e => e.BuildingNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsesType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduBClassOrHallRoomInfo>(entity =>
            {
                entity.HasKey(e => e.ClassRoomId)
                    .HasName("PK_Edu_B_ClassRoomInfo");

                entity.ToTable("Edu_B_ClassOrHallRoomInfo");

                entity.Property(e => e.ClassRoomId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassRoomID");

                entity.Property(e => e.BuildingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BuildingID");

                entity.Property(e => e.ClassRoomNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassRoomNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduCClassOrHallSeatInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu_C_ClassOrHallSeatInfo");

                entity.Property(e => e.ClassRoomId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassRoomID");

                entity.Property(e => e.HallSeatId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("HallSeatID");

                entity.Property(e => e.HallSeatNumber).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<EduDStudentAllocateHallSeatInfo>(entity =>
            {
                entity.HasKey(e => e.AllocateStudentHallSeatId);

                entity.ToTable("Edu_D_StudentAllocateHallSeatInfo");

                entity.Property(e => e.AllocateStudentHallSeatId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AllocateStudentHallSeatID");

                entity.Property(e => e.ClassRoomId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassRoomID");

                entity.Property(e => e.HallSeatId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("HallSeatID");

                entity.Property(e => e.StudentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("StudentID");
            });

            modelBuilder.Entity<EduETransportAreaInfo>(entity =>
            {
                entity.HasKey(e => e.TransportAreaId);

                entity.ToTable("Edu_E_TransportAreaInfo");

                entity.Property(e => e.TransportAreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportAreaID");

                entity.Property(e => e.TransportAreaNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransportAreaNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduFTransportChargeInfo>(entity =>
            {
                entity.HasKey(e => e.TransportChargeId);

                entity.ToTable("Edu_F_TransportChargeInfo");

                entity.Property(e => e.TransportChargeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportChargeID");

                entity.Property(e => e.TransportAreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportAreaID");

                entity.Property(e => e.TransportId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportID");
            });

            modelBuilder.Entity<EduGLinkTransportAreaInfo>(entity =>
            {
                entity.HasKey(e => e.LinkAreaTransportId);

                entity.ToTable("Edu_G_LinkTransportAreaInfo");

                entity.Property(e => e.LinkAreaTransportId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkAreaTransportID");

                entity.Property(e => e.TransportAreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportAreaID");

                entity.Property(e => e.TransportId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportID");
            });

            modelBuilder.Entity<EduHStudentAllocateTransport>(entity =>
            {
                entity.HasKey(e => e.AllocateTransportId);

                entity.ToTable("Edu_H_StudentAllocateTransport");

                entity.Property(e => e.AllocateTransportId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AllocateTransportID");

                entity.Property(e => e.StudentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("StudentID");

                entity.Property(e => e.TransportAreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportAreaID");

                entity.Property(e => e.TransportId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransportID");
            });

            modelBuilder.Entity<EduIClassInfo>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK_Edu_A_ClassInfo");

                entity.ToTable("Edu_I_ClassInfo");

                entity.Property(e => e.ClassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassID");

                entity.Property(e => e.ClassNameEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClassNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduJClassSectionInfo>(entity =>
            {
                entity.HasKey(e => e.ClassSectionId)
                    .HasName("PK_Edu_B_ClassSectionInfo");

                entity.ToTable("Edu_J_ClassSectionInfo");

                entity.Property(e => e.ClassSectionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassSectionID");

                entity.Property(e => e.ClassSectionNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassSectionNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduKClassGroupInfo>(entity =>
            {
                entity.HasKey(e => e.ClassGroupId)
                    .HasName("PK_Edu_C_ClassGroupInfo");

                entity.ToTable("Edu_K_ClassGroupInfo");

                entity.Property(e => e.ClassGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassGroupID");

                entity.Property(e => e.ClassGroupNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassGroupNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduLClassShiftInfo>(entity =>
            {
                entity.HasKey(e => e.ClassShiftId)
                    .HasName("PK_Edu_ClassShiftInfo");

                entity.ToTable("Edu_L_ClassShiftInfo");

                entity.Property(e => e.ClassShiftId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassShiftID");

                entity.Property(e => e.ClassShiftNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassShiftNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduMClassSubjectInfo>(entity =>
            {
                entity.HasKey(e => e.ClassSubjectId)
                    .HasName("PK_Edu_D_ClassSubjectInfo");

                entity.ToTable("Edu_M_ClassSubjectInfo");

                entity.Property(e => e.ClassSubjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassSubjectID");

                entity.Property(e => e.ClassSubjectCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassSubjectNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassSubjectNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassSubjectSl).HasColumnName("ClassSubjectSL");
            });

            modelBuilder.Entity<EduNLinkClassGroupInfo>(entity =>
            {
                entity.HasKey(e => e.LinkClassGroupId)
                    .HasName("PK_Edu_LinkClassGroupInfo");

                entity.ToTable("Edu_N_LinkClassGroupInfo");

                entity.Property(e => e.LinkClassGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkClassGroupID");

                entity.Property(e => e.ClassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassID");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("GroupID");
            });

            modelBuilder.Entity<EduOLinkClassSectionInfo>(entity =>
            {
                entity.HasKey(e => e.LinkClassSectionId)
                    .HasName("PK_Edu_F_LinkClassSectionInfo");

                entity.ToTable("Edu_O_LinkClassSectionInfo");

                entity.Property(e => e.LinkClassSectionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkClassSectionID");

                entity.Property(e => e.ClassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassID");

                entity.Property(e => e.SectionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SectionID");
            });

            modelBuilder.Entity<EduPLinkClassShiftInfo>(entity =>
            {
                entity.HasKey(e => e.LinkClassShiftId)
                    .HasName("PK_Edu_G_LinkClassShiftInfo");

                entity.ToTable("Edu_P_LinkClassShiftInfo");

                entity.Property(e => e.LinkClassShiftId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkClassShiftID");

                entity.Property(e => e.ClassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassID");

                entity.Property(e => e.ShiftId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ShiftID");
            });

            modelBuilder.Entity<EduQLinkClassSubjectInfo>(entity =>
            {
                entity.HasKey(e => e.LinkClassSubjectId)
                    .HasName("PK_Edu_H_LinkClassSubjectInfo");

                entity.ToTable("Edu_Q_LinkClassSubjectInfo");

                entity.Property(e => e.LinkClassSubjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkClassSubjectID");

                entity.Property(e => e.ClassGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassGroupID");

                entity.Property(e => e.ClassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassID");

                entity.Property(e => e.SubjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SubjectID");
            });

            modelBuilder.Entity<EduRExamInfo>(entity =>
            {
                entity.HasKey(e => e.ExamId)
                    .HasName("PK_Edu_R_ClassExamInfo");

                entity.ToTable("Edu_R_ExamInfo");

                entity.Property(e => e.ExamId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ExamID");

                entity.Property(e => e.ExamNameEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExamNameLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExamSl).HasColumnName("ExamSL");

                entity.Property(e => e.ExamType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduSAcademicYearInfo>(entity =>
            {
                entity.HasKey(e => e.AcademicYearId)
                    .HasName("PK_Edu_S_AcademicYearSessionInfo");

                entity.ToTable("Edu_S_AcademicYearInfo");

                entity.Property(e => e.AcademicYearId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AcademicYearID");

                entity.Property(e => e.AcademicYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduTAcadeicSessionInfo>(entity =>
            {
                entity.HasKey(e => e.AcademicSessionId);

                entity.ToTable("Edu_T_AcadeicSessionInfo");

                entity.Property(e => e.AcademicSessionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AcademicSessionID");

                entity.Property(e => e.AcademicSession)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduUClassPeriodInfo>(entity =>
            {
                entity.HasKey(e => e.ClassPeriodId)
                    .HasName("PK_Edu_T_ClassPeriodInfo");

                entity.ToTable("Edu_U_ClassPeriodInfo");

                entity.Property(e => e.ClassPeriodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassPeriodID");

                entity.Property(e => e.ClassPeriodName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassPeriodSl)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ClassPeriodSL");
            });

            modelBuilder.Entity<HrASalaryPayScalInfo>(entity =>
            {
                entity.HasKey(e => e.SalaryPayScalId)
                    .HasName("PK_HR_SalaryPayScalInfo");

                entity.ToTable("HR_A_SalaryPayScalInfo");

                entity.Property(e => e.SalaryPayScalId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SalaryPayScalID");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CompanyID");
            });

            modelBuilder.Entity<HrBEmployeeCategoryInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeCategoryId);

                entity.ToTable("HR_B_EmployeeCategoryInfo");

                entity.Property(e => e.EmployeeCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.EmployeeCategoryEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCategoryLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeGradeEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeGradeLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrCEmployeeDivisionInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeDivisionId);

                entity.ToTable("HR_C_EmployeeDivisionInfo");

                entity.Property(e => e.EmployeeDivisionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeDivisionID");

                entity.Property(e => e.EmployeeDivisionEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeDivisionLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrDEmployeeDepartmentInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeDepartmentId);

                entity.ToTable("HR_D_EmployeeDepartmentInfo");

                entity.Property(e => e.EmployeeDepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeDepartmentID");

                entity.Property(e => e.EmployeeDepartmentEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeDepartmentLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrEEmployeeDesignationInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeDesignationId);

                entity.ToTable("HR_E_EmployeeDesignationInfo");

                entity.Property(e => e.EmployeeDesignationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeDesignationID");

                entity.Property(e => e.EmployeeDesignationEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeDesignationLoacl)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrFEmployeeJobRefNoInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeJobRefNoId);

                entity.ToTable("HR_F_EmployeeJobRefNoInfo");

                entity.Property(e => e.EmployeeJobRefNoId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeJobRefNoID");

                entity.Property(e => e.EmployeeCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.EmployeeDepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeDepartmentID");

                entity.Property(e => e.EmployeeDesignationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeDesignationID");

                entity.Property(e => e.EmployeeDivisionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeDivisionID");

                entity.Property(e => e.EmployeeJobRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrGEmployeeGenderInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeGenderId);

                entity.ToTable("HR_G_EmployeeGenderInfo");

                entity.Property(e => e.EmployeeGenderId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeGenderID");

                entity.Property(e => e.EmployeeGenderNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeGenderNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrHBloodGroupInfo>(entity =>
            {
                entity.HasKey(e => e.BloodGroupId);

                entity.ToTable("HR_H_BloodGroupInfo");

                entity.Property(e => e.BloodGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BloodGroupID");

                entity.Property(e => e.BloodGroupNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroupNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrIReligionInfo>(entity =>
            {
                entity.HasKey(e => e.ReligionId);

                entity.ToTable("HR_I_ReligionInfo");

                entity.Property(e => e.ReligionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ReligionID");

                entity.Property(e => e.ReligionNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrJEmployeeInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("HR_J_EmployeeInfo");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.BloodGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BloodGroupID");

                entity.Property(e => e.EmployeeCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeFathersNameEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeFathersNameLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeGenderId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeGenderID");

                entity.Property(e => e.EmployeeJobRefNoId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeJobRefNoID");

                entity.Property(e => e.EmployeeJoiningDate).HasColumnType("date");

                entity.Property(e => e.EmployeeNameEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNameLocal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNationalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNationalID");

                entity.Property(e => e.EmployeePassportNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePhoto).HasColumnType("image");

                entity.Property(e => e.ReligionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ReligionID");
            });

            modelBuilder.Entity<HrKReferenceTypeInfo>(entity =>
            {
                entity.HasKey(e => e.ReferenceTypeId);

                entity.ToTable("HR_K_ReferenceTypeInfo");

                entity.Property(e => e.ReferenceTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ReferenceTypeID");

                entity.Property(e => e.ReferenceTypeNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceTypeNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrLPresentAddressInfo>(entity =>
            {
                entity.HasKey(e => e.PresentAddressId)
                    .HasName("PK_HR_K_PresentAddressInfo");

                entity.ToTable("HR_L_PresentAddressInfo");

                entity.Property(e => e.PresentAddressId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PresentAddressID");

                entity.Property(e => e.AddressReferenceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AddressReferenceID");

                entity.Property(e => e.PoliceStationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PoliceStationID");

                entity.Property(e => e.PostOfficeEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostOfficeLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PresentAddressEnglish)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PresentAddressLocal)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ReferenceID");

                entity.Property(e => e.ReferenceTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ReferenceTypeID");
            });

            modelBuilder.Entity<HrMPermanentAddressInfo>(entity =>
            {
                entity.HasKey(e => e.PermanentAddressId);

                entity.ToTable("HR_M_PermanentAddressInfo");

                entity.Property(e => e.PermanentAddressId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PermanentAddressID");

                entity.Property(e => e.AddressReferenceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AddressReferenceID");

                entity.Property(e => e.PermanentAddressEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddressLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoliceStationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PoliceStationID");

                entity.Property(e => e.PostOfficeEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostOfficeLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ReferenceID");

                entity.Property(e => e.ReferenceTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ReferenceTypeID");
            });

            modelBuilder.Entity<SecAUserGroupInfo>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.ToTable("Sec_A_UserGroupInfo");

                entity.Property(e => e.UserGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserGroupID");

                entity.Property(e => e.UserGroupDescriptionEnglish)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupDescriptionLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecBUserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Sec_B_UserInfo");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LoginNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UserGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserGroupID");
            });

            modelBuilder.Entity<SecCLinkUserBranchInfo>(entity =>
            {
                entity.HasKey(e => e.LinkUserBranchId);

                entity.ToTable("Sec_C_LinkUserBranchInfo");

                entity.Property(e => e.LinkUserBranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkUserBranchID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BranchID");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SecDScreenInfo>(entity =>
            {
                entity.HasKey(e => e.ScreenId);

                entity.ToTable("Sec_D_ScreenInfo");

                entity.Property(e => e.ScreenId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ScreenID");

                entity.Property(e => e.MenuUrl)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ModuleID");

                entity.Property(e => e.ParentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ParentID");

                entity.Property(e => e.ScreenName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecELinkUserGroupScreenInfo>(entity =>
            {
                entity.HasKey(e => e.LinkUserGroupScreenId)
                    .HasName("PK_Sec_E_LinkUserGroupScreenI");

                entity.ToTable("Sec_E_LinkUserGroupScreenInfo");

                entity.Property(e => e.LinkUserGroupScreenId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkUserGroupScreenID");

                entity.Property(e => e.ScreenId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ScreenID");

                entity.Property(e => e.UserGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserGroupID");
            });

            modelBuilder.Entity<SecFScreenCommandInfo>(entity =>
            {
                entity.HasKey(e => e.ScreenCommandId);

                entity.ToTable("Sec_F_ScreenCommandInfo");

                entity.Property(e => e.ScreenCommandId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ScreenCommandID");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenCommandName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ScreenID");
            });

            modelBuilder.Entity<SecGLinkUserGroupScreenCommandInfo>(entity =>
            {
                entity.HasKey(e => e.LinkUserGroupScreenCommandId)
                    .HasName("PK_LinkUserGroupScreenCommandInfo");

                entity.ToTable("Sec_G_LinkUserGroupScreenCommandInfo");

                entity.Property(e => e.LinkUserGroupScreenCommandId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LinkUserGroupScreenCommandID");

                entity.Property(e => e.ScreenCommandId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ScreenCommandID");

                entity.Property(e => e.UserGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserGroupID");
            });

            modelBuilder.Entity<SecHUserLoginTracking>(entity =>
            {
                entity.HasKey(e => e.UserLoginTrackingId);

                entity.ToTable("Sec_H_UserLoginTracking");

                entity.Property(e => e.UserLoginTrackingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserLoginTrackingID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SoftConfigACountryInfo>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_Comp_1_CountryInfo");

                entity.ToTable("SoftConfig_A_CountryInfo");

                entity.Property(e => e.CountryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CountryID");

                entity.Property(e => e.CountryNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigBDivisionOrStateInfo>(entity =>
            {
                entity.HasKey(e => e.DivisionId)
                    .HasName("PK_Comp_2_DivisionInfo");

                entity.ToTable("SoftConfig_B_DivisionOrStateInfo");

                entity.Property(e => e.DivisionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DivisionID");

                entity.Property(e => e.CountryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CountryID");

                entity.Property(e => e.DivisionNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigCDistrictOrCityInfo>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("PK_Comp_2_DistrictInfo");

                entity.ToTable("SoftConfig_C_DistrictOrCityInfo");

                entity.Property(e => e.DistrictId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DistrictID");

                entity.Property(e => e.DistrictNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DivisionID");
            });

            modelBuilder.Entity<SoftConfigDPoliceStationInfo>(entity =>
            {
                entity.HasKey(e => e.PoliceStationId)
                    .HasName("PK_Comp_3_PoliceStationInfo");

                entity.ToTable("SoftConfig_D_PoliceStationInfo");

                entity.Property(e => e.PoliceStationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PoliceStationID");

                entity.Property(e => e.DistrictId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DistrictID");

                entity.Property(e => e.PoliceStationNameEnglish)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoliceStationNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigEBusinessTypeInfo>(entity =>
            {
                entity.HasKey(e => e.BusinessTypeId)
                    .HasName("PK_Config_1_BusinessInfo");

                entity.ToTable("SoftConfig_E_BusinessTypeInfo");

                entity.Property(e => e.BusinessTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BusinessTypeID");

                entity.Property(e => e.BusinessTypeNameEnglish)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessTypeNameLocal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigFLanguageInfo>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK_Config_3_LanguageName");

                entity.ToTable("SoftConfig_F_LanguageInfo");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LanguageID");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigGFontInfo>(entity =>
            {
                entity.HasKey(e => e.FontId)
                    .HasName("PK_Config_4_FontInfo");

                entity.ToTable("SoftConfig_G_FontInfo");

                entity.Property(e => e.FontId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("FontID");

                entity.Property(e => e.FontName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigHInvoiceModeInfo>(entity =>
            {
                entity.HasKey(e => e.InvoiceModeId)
                    .HasName("PK_Config_5_InvoiceModeInfo");

                entity.ToTable("SoftConfig_H_InvoiceModeInfo");

                entity.Property(e => e.InvoiceModeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("InvoiceModeID");

                entity.Property(e => e.InvoiceModeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigIModuleInfo>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_Config_2_BusinessWiseCompanyFormView");

                entity.ToTable("SoftConfig_I_ModuleInfo");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ModuleID");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftConfigJCompanyLinkModule>(entity =>
            {
                entity.HasKey(e => e.CompanyLinkModuleId)
                    .HasName("PK_SoftConfig_3_BusinessLinkModule");

                entity.ToTable("SoftConfig_J_CompanyLinkModule");

                entity.Property(e => e.CompanyLinkModuleId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CompanyLinkModuleID");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CompanyID");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ModuleID");
            });

            modelBuilder.Entity<SoftConfigKBoothInfo>(entity =>
            {
                entity.HasKey(e => e.BoothId)
                    .HasName("PK_Config_4_BoothInfo");

                entity.ToTable("SoftConfig_K_BoothInfo");

                entity.Property(e => e.BoothId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BoothID");

                entity.Property(e => e.BoothCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoothName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FontId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("FontID");

                entity.Property(e => e.InvoiceModeId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LanguageID");
            });

            modelBuilder.Entity<SoftConfigLBoothLinkBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SoftConfig_L_BoothLinkBranch");

                entity.Property(e => e.BoothId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BoothID");

                entity.Property(e => e.BoothLinkBranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BoothLinkBranchID");

                entity.Property(e => e.BranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BranchID");
            });

            modelBuilder.Entity<SoftConfigMGlobalOption>(entity =>
            {
                entity.HasKey(e => e.GlobalOptionId)
                    .HasName("PK_Config_4_GlobalOption");

                entity.ToTable("SoftConfig_M_GlobalOption");

                entity.Property(e => e.GlobalOptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("GlobalOptionID");

                entity.Property(e => e.BoothId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BoothID");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalOptionDefaultValue)
                    .HasMaxLength(2550)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalOptionDescription)
                    .HasMaxLength(2550)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalOptionValue)
                    .HasMaxLength(2550)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalOptionValueDefinition)
                    .HasMaxLength(2550)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
