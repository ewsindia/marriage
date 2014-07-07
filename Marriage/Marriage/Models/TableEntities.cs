using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Text;
using System.Web.Security;
using System.Data.Entity;
using System.Globalization;



namespace Marriage.Models
{
    [Table("country")]
    public class Country
    {
        [Key]
        public long CountryID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public long sortorder { get; set; }
    }

    [Table("fevoritelist")]
    public class FevoriteList
    {
        [Key]
        public long MyId { get; set; }
        [ForeignKey("MyId")]
        public Members MembersMyId { get; set; }

        public long ReciverId { get; set; }
        [ForeignKey("ReciverId")]
        public Members MembersReciverId { get; set; }
    }

    [Table("friendlist")]
    public class FriendList
    {
        [Key]
        public long SenderId { get; set; }
        [ForeignKey("SenderId")]
        public Members Members { get; set; }

        public long ReciverId { get; set; }
        [ForeignKey("ReciverId")]
        public Members MembersReciverId { get; set; }

        public int Status { get; set; }
        public DateTime SentTime { get; set; }
    }

    [Table("members")]
    public class Members
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Fields is Required")]
        public int WrittenBy { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string forwaht { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string TimeForMarriage { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int MaritalStatus { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Fields is Required")]
        public DateTime TOB { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Issecured { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public DateTime TimeForCall { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string persontocontact { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int LastDegree { get; set; }
        [ForeignKey("LastDegree")]
        public SingleFieldMaster SingleFieldMasterLastDegree { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Profession { get; set; }
        [ForeignKey("Profession")]
        public SingleFieldMaster SingleFieldMasterProfession { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int FamilyStatus { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int AnnualIncome { get; set; }
        [ForeignKey("AnnualIncome")]
        public SingleFieldMaster SingleFieldMasterAnnualIncome { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string LivingWith { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string FatherAlive { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string MotherAlive { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int MarriedBrother { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int UnmarriedBrother { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int MarriedSister { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int UnmarredSister { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int CountryCode { get; set; }
        [ForeignKey("CountryCode")]
        public Country CountryCountryCode { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int State { get; set; }
        [ForeignKey("State")]
        public SingleFieldMaster StatesProvincesState { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string Address1 { get; set; }


        public int BornIn { get; set; }


        public int GrowupIn { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string Ihave { get; set; }


        public string relocatable { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Nationality { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Passport { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Height { get; set; }
        [ForeignKey("Height")]
        public SingleFieldMaster SingleFieldMasterHeight { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Weight { get; set; }
        [ForeignKey("Weight")]
        public SingleFieldMaster SingleFieldMasterWeight { get; set; }


        public string Built { get; set; }


        public string Complexion { get; set; }


        public string Eyecolor { get; set; }


        public string Haircolor { get; set; }


        public string Food { get; set; }


        public string CanDrink { get; set; }


        public string CanSmoke { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Religion { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string Manglik { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Culture { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Language { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string Lifestyle { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int Randomno { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string VerificatonCode { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Fields is not valid")]
        public string Email { get; set; }


        public int IsActive { get; set; }


        public int IsDeleted { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int IsMobileVerified { get; set; }

        public int AgentId { get; set; }
        [ForeignKey("AgentId")]
        public AgentMaster AgentmasterId { get; set; }

    }

    [Table("messages")]
    public class Messages
    {
        [Key]
        public long Id { get; set; }

        public long SenderId { get; set; }
        [ForeignKey("SenderId")]
        public Members MembersSenderId { get; set; }

        public long ReciverId { get; set; }
        [ForeignKey("ReciverId")]
        public Members MembersReciverId { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }
        public Boolean Status { get; set; }
        public DateTime SentDate { get; set; }
    }

    [Table("singlefieldmaster")]
    public class SingleFieldMaster
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    [Table("statesprovinces")]
    public class StatesProvinces
    {
        [Key]
        public long StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public long CountryID { get; set; }
    }

   
    public class Globalvars
    {
        public static string dn { get; set; }
        public static string user { get; set; }
        public static string pwd { get; set; }
        public static string sid { get; set; }
    }

    [Table ("multiuploads")]
    public class MultiUploads
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public long File { get; set; }
        public long File1 { get; set; }
        public long File2 { get; set; }
    }

    [Table("admin")]
    public class Admin
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }

    [Table("agent_master")]
    public class AgentMaster
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Boolean IsActive { get; set; }
        public string Mobile { get; set; }
    }
}

   