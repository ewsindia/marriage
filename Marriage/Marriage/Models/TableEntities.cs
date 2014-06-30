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
    public class country
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int sortorder { get; set; }
    }

    [Table("fevoritelist")]
    public class fevoritelist
    {
        [Key]
        public int myid { get; set; }
        [ForeignKey("myid")]
        public members members { get; set; }

        public int reciverid { get; set; }
        [ForeignKey("reciverid")]
        public members members1 { get; set; }
    }

    [Table("friendlist")]
    public class friendlist
    {
        [Key]
        public int senderid { get; set; }
        [ForeignKey("senderid")]
        public members members { get; set; }

        public int reciverid { get; set; }
        [ForeignKey("reciverid")]
        public members members1 { get; set; }

        public string status { get; set; }
        public string senttime { get; set; }
    }

    [Table("members")]
    public class members
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Fields is Required")]
        public int writtenby { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string middlename { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string displayname { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string forwaht { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string timeformarriage { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int maritalstatus { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public DateTime dob { get; set; }
        [Required(ErrorMessage = "Fields is Required")]
        public DateTime tob { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string contactno { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int issecured { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string timeforcall { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string persontocontact { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int lastdegree { get; set; }
        [ForeignKey("lastdegree")]
        public singlefieldmaster singlefildmaster { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int profession { get; set; }
        [ForeignKey("profession")]
        public singlefieldmaster singlefildmaster1 { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int familystatus { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int annualincome { get; set; }
        [ForeignKey("annualincome")]
        public singlefieldmaster singlefildmaster2 { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string livingwith { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string fatheralive { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string motheralive { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int marriedbrother { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int unmarriedbrother { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int marriedsister { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int unmarredsister { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int countrycode { get; set; }
        [ForeignKey("countrycode")]
        public country country { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int state { get; set; }
        [ForeignKey("state")]
        public statesprovinces statesprovinces { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string city { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string address1 { get; set; }

      
        public int bornin { get; set; }

      
        public int growupin { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string ihave { get; set; }

        
        public string relocatable { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int nationality { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int passport { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int height { get; set; }
        [ForeignKey("height")]
        public singlefieldmaster singlefildmaster3 { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int weight { get; set; }
        [ForeignKey("weight")]
        public singlefieldmaster singlefildmaster4 { get; set; }

      
        public string built { get; set; }

       
        public string complexion { get; set; }

       
        public string eyecolor { get; set; }

      
        public string haircolor { get; set; }

       
        public string food { get; set; }

      
        public string candrink { get; set; }

       
        public string cansmoke { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int religion { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string manglik { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int culture { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int language { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string lifestyle { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int randomno { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string verificatoncode { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Fields is not valid")]
        public string email { get; set; }

       
        public int isactive { get; set; }

       
        public int isdeleted { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public string password { get; set; }

        [Required(ErrorMessage = "Fields is Required")]
        public int ismobileverified { get; set; }

        public int agentid { get; set; }
        [ForeignKey("agentid")]
        public agent_master agentmaster { get; set; }
    }

    [Table("messages")]
    public class messages
    {
        [Key]
        public int id { get; set; }

        public int senderid { get; set; }
        [ForeignKey("senderid")]
        public members members { get; set; }

        public int reciverid { get; set; }
        [ForeignKey("reciverid")]
        public members members1 { get; set; }

        public string subject { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public string sentdate { get; set; }
    }

    [Table("singlefieldmaster")]
    public class singlefieldmaster
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }

    [Table("statesprovinces")]
    public class statesprovinces
    {
        [Key]
        public int StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public int CountryID { get; set; }
    }

   
    public class Globalvars
    {
        public static string dn { get; set; }
        public static string user { get; set; }
        public static string pwd { get; set; }
        public static string sid { get; set; }
    }

    [Table("userprofile")]
    public class useprofile
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string confirmpassword { get; set; }
        public string Autogenrate { get; set; }
        public virtual string Title { get; set; }

    }

    public class Message
    {
        public string strMobile { get; set; }
        public string strAlertText { get; set; }
    }

    

    [Table ("multiuploads")]
    public class multiuploads
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int File { get; set; }
        public int File1 { get; set; }
        public int File2 { get; set; }
    }

    [Table("admin")]
    public class admin
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }

    [Table("agent_master")]
    public class agent_master
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string isactive { get; set; }
        public string mobile { get; set; }
    }

    [Table("simple")]
    public class simple
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    
}

   