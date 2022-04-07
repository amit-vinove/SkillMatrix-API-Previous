﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillMatrix.Data;

#nullable disable

namespace SkillMatrix.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220401100104_FirstDB")]
    partial class FirstDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SkillMatrix.Model.AdditionalSkill", b =>
                {
                    b.Property<int>("AdditionalSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdditionalSkillId"), 1L, 1);

                    b.Property<string>("AdditionalSkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("AdditionalSkillId");

                    b.ToTable("AdditionalSkills");
                });

            modelBuilder.Entity("SkillMatrix.Model.AllAdditionalSkill", b =>
                {
                    b.Property<int>("AllAdditionalSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllAdditionalSkillId"), 1L, 1);

                    b.Property<int>("AdditionalSkillId")
                        .HasColumnType("int");

                    b.Property<string>("AllAdditionalSkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("AllAdditionalSkillId");

                    b.ToTable("AllAdditionalSkills");
                });

            modelBuilder.Entity("SkillMatrix.Model.BasicFoundation", b =>
                {
                    b.Property<int>("BasicFoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasicFoundId"), 1L, 1);

                    b.Property<int>("BEST_PRACTICES")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("GIT_OR_REVISION_CONTROL")
                        .HasColumnType("int");

                    b.Property<int>("JIRA_OR_AGILE_PRACTICES")
                        .HasColumnType("int");

                    b.Property<int>("SERVER_UPLOADS_OR_MANAGEMENT")
                        .HasColumnType("int");

                    b.Property<int>("TFS")
                        .HasColumnType("int");

                    b.Property<int>("UNIT_TESTING")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("BasicFoundId");

                    b.ToTable("BasicFoundation");
                });

            modelBuilder.Entity("SkillMatrix.Model.BehaviourDrivenDevelopment", b =>
                {
                    b.Property<int>("BehaviourDrivenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BehaviourDrivenId"), 1L, 1);

                    b.Property<int>("Cucumber")
                        .HasColumnType("int");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("Maven")
                        .HasColumnType("int");

                    b.Property<int>("UserApproach")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("BehaviourDrivenId");

                    b.ToTable("BehaviourDrivenDevelopments");
                });

            modelBuilder.Entity("SkillMatrix.Model.Cloud", b =>
                {
                    b.Property<int>("CloudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CloudId"), 1L, 1);

                    b.Property<int>("AWS")
                        .HasColumnType("int");

                    b.Property<int>("Azure")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("CloudId");

                    b.ToTable("Cloud");
                });

            modelBuilder.Entity("SkillMatrix.Model.Devop", b =>
                {
                    b.Property<int>("DevopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DevopId"), 1L, 1);

                    b.Property<int>("CiCd")
                        .HasColumnType("int");

                    b.Property<int>("CiCdDevopPractice")
                        .HasColumnType("int");

                    b.Property<int>("DockerKubernetes")
                        .HasColumnType("int");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("WebDb")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("DevopId");

                    b.ToTable("Devops");
                });

            modelBuilder.Entity("SkillMatrix.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportingManager")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SkillMatrix.Model.GenericSkills", b =>
                {
                    b.Property<int>("GenericId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenericId"), 1L, 1);

                    b.Property<int>("Adaptability_And_Flexibility")
                        .HasColumnType("int");

                    b.Property<int>("Critical_and_Analytical_Thinking")
                        .HasColumnType("int");

                    b.Property<int>("Customer_Focus")
                        .HasColumnType("int");

                    b.Property<int>("Demonstrate_Teamwork")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Interpersonal_Skills")
                        .HasColumnType("int");

                    b.Property<int>("Leadership_Skills")
                        .HasColumnType("int");

                    b.Property<int>("Management")
                        .HasColumnType("int");

                    b.Property<int>("Negotiation_Skills")
                        .HasColumnType("int");

                    b.Property<int>("Oral_Communication")
                        .HasColumnType("int");

                    b.Property<int>("Planning_And_Organizing")
                        .HasColumnType("int");

                    b.Property<int>("Presentation_skill")
                        .HasColumnType("int");

                    b.Property<int>("Problem_Solving_Skills")
                        .HasColumnType("int");

                    b.Property<int>("Process_Conformance")
                        .HasColumnType("int");

                    b.Property<int>("Takes_Initiative")
                        .HasColumnType("int");

                    b.Property<int>("Written_Communication")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("GenericId");

                    b.ToTable("GenericSkills");
                });

            modelBuilder.Entity("SkillMatrix.Model.JSFrontEnd", b =>
                {
                    b.Property<int>("JSFrontEndId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JSFrontEndId"), 1L, 1);

                    b.Property<int>("AngularJS")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("HTML_CSS")
                        .HasColumnType("int");

                    b.Property<int>("Jquery")
                        .HasColumnType("int");

                    b.Property<int>("ReactJS")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("JSFrontEndId");

                    b.ToTable("JSFrontEnd");
                });

            modelBuilder.Entity("SkillMatrix.Model.SDLCProceeses", b =>
                {
                    b.Property<int>("SDLCId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SDLCId"), 1L, 1);

                    b.Property<int>("Code_Optimization_Techniques")
                        .HasColumnType("int");

                    b.Property<int>("Coding_Standards")
                        .HasColumnType("int");

                    b.Property<int>("ER_Diagram")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Postman")
                        .HasColumnType("int");

                    b.Property<int>("Swagger_UI")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("SDLCId");

                    b.ToTable("SDLCProceeses");
                });

            modelBuilder.Entity("SkillMatrix.Model.Skills", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"), 1L, 1);

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("SkillMatrix.Model.SqlServer", b =>
                {
                    b.Property<int>("SqlServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SqlServerId"), 1L, 1);

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("SqlQueries")
                        .HasColumnType("int");

                    b.Property<int>("StoredPocedure")
                        .HasColumnType("int");

                    b.Property<int>("Triggers")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.Property<int>("ssrs")
                        .HasColumnType("int");

                    b.HasKey("SqlServerId");

                    b.ToTable("SqlServers");
                });

            modelBuilder.Entity("SkillMatrix.Model.Subskills", b =>
                {
                    b.Property<int>("SubskillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubskillsId"), 1L, 1);

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<string>("SubskillsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubskillsId");

                    b.ToTable("Subskills");
                });

            modelBuilder.Entity("SkillMatrix.Model.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SkillMatrix.Model.TestDrivenDevelopment", b =>
                {
                    b.Property<int>("TestDrivenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestDrivenId"), 1L, 1);

                    b.Property<int>("AdaptabilityFlexibility")
                        .HasColumnType("int");

                    b.Property<int>("CriticalAnalytical")
                        .HasColumnType("int");

                    b.Property<int>("CustomerFocus")
                        .HasColumnType("int");

                    b.Property<int>("DemonstratesTeamwork")
                        .HasColumnType("int");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("InterpersonalSkills")
                        .HasColumnType("int");

                    b.Property<int>("LeadershipSkills")
                        .HasColumnType("int");

                    b.Property<int>("Management")
                        .HasColumnType("int");

                    b.Property<int>("NegotiationSkills")
                        .HasColumnType("int");

                    b.Property<int>("OralCommunication")
                        .HasColumnType("int");

                    b.Property<int>("PlanningOrganizing")
                        .HasColumnType("int");

                    b.Property<int>("PresentationSkills")
                        .HasColumnType("int");

                    b.Property<int>("ProblemSolvingSkills")
                        .HasColumnType("int");

                    b.Property<int>("ProcessConformance")
                        .HasColumnType("int");

                    b.Property<int>("TakesInitiative")
                        .HasColumnType("int");

                    b.Property<int>("WrittenCommunication")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("TestDrivenId");

                    b.ToTable("TestDrivenDevelopments");
                });

            modelBuilder.Entity("SkillMatrix.Model.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("RoleLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SkillMatrix.Model.WebService", b =>
                {
                    b.Property<int>("WebServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WebServiceId"), 1L, 1);

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("Soap")
                        .HasColumnType("int");

                    b.Property<int>("ThirdParty")
                        .HasColumnType("int");

                    b.Property<int>("Wcf")
                        .HasColumnType("int");

                    b.Property<int>("WebApi")
                        .HasColumnType("int");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("WebServiceId");

                    b.ToTable("WebServices");
                });
#pragma warning restore 612, 618
        }
    }
}