using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Routing;
using Marriage.Models;

namespace Marriage.Controllers
{
    public class HomeController : Controller
    {

        MarriageexpDBContext DBContext = new MarriageexpDBContext();

        public ActionResult UserLogin()
        {
            return View();
        }

        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult UserLogin(LogIn objLogin)
        {
            if (ModelState.IsValid)
            {
              var objMember = (from obj in DBContext.Members select obj).ToList();
                if (objMember!=null)
                {
                    FormsAuthentication.SetAuthCookie(objLogin.UserName, false);
                    return RedirectToAction("Welcome", "Home");
                }
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
            }
            return View();
        }

        // GET: /Account/LogOff

        public ActionResult Logoff()
        {
            //FormsAuthentication.SignOut();

            return RedirectToAction("UserLogin", "Home");
        }

       
        public ActionResult Welcome()
        {
            return View();
        }

        List<SelectListItem> Heightlist = new List<SelectListItem>();
        private List<SelectListItem> getHeight()
        {
            var objHeight = (from objheight in DBContext.SingleFieldMaster where objheight.Type == "Height" select new { id = objheight.Id, name = objheight.Name });

            foreach (var obj in objHeight)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Heightlist.Add(objselectlistitem);
            }
            return Heightlist;
        }

        List<SelectListItem> Weightlist = new List<SelectListItem>();
        private List<SelectListItem> getWeight()
        {
            var objWeight = (from objweight in DBContext.SingleFieldMaster where objweight.Type == "Weight" select new { id = objweight.Id, name = objweight.Name });

            foreach (var obj in objWeight)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Weightlist.Add(objselectlistitem);
            }
            return Weightlist;
        }

        List<SelectListItem> ReligionCastlist = new List<SelectListItem>();
        private List<SelectListItem> getReligionCast()
        {
            var objReligionCast = (from objreligin in DBContext.SingleFieldMaster where objreligin.Type == "ReligionCast" select new { id = objreligin.Id, name = objreligin.Name });

            foreach (var obj in objReligionCast)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                ReligionCastlist.Add(objselectlistitem);
            }
            return ReligionCastlist;
        }

        List<SelectListItem> Educationlist = new List<SelectListItem>();
        private List<SelectListItem> getEducation()
        {
            var objEducation = (from objeducation in DBContext.SingleFieldMaster where objeducation.Type == "Education" select new { id = objeducation.Id, name = objeducation.Name });

            foreach (var obj in objEducation)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Educationlist.Add(objselectlistitem);
            }
            return Educationlist;
        }

        List<SelectListItem> Culturelist = new List<SelectListItem>();
        private List<SelectListItem> getCulture()
        {
            var objCulture = (from objculture in DBContext.SingleFieldMaster where objculture.Type == "Culture" select new { id = objculture.Id, name = objculture.Name });

            foreach (var obj in objCulture)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Culturelist.Add(objselectlistitem);
            }
            return Culturelist;
        }

        List<SelectListItem> Occuptionlist = new List<SelectListItem>();
        private List<SelectListItem> getOccuption()
        {
            var occuption = (from objoccuption in DBContext.SingleFieldMaster where objoccuption.Type == "Occupation" select new { id = objoccuption.Id, name = objoccuption.Name });

            foreach (var obj in occuption)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Occuptionlist.Add(objselectlistitem);
            }
            return Occuptionlist;
        }

        List<SelectListItem> Nationalitylist = new List<SelectListItem>();
        private List<SelectListItem> getNationality()
        {
            var objNationality = (from objnationality in DBContext.SingleFieldMaster where objnationality.Type == "Nationality" select new { id = objnationality.Id, name = objnationality.Name });

            foreach (var obj in objNationality)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Nationalitylist.Add(objselectlistitem);
            }
            return Nationalitylist;
        }

        List<SelectListItem> Passportlist = new List<SelectListItem>();
        private List<SelectListItem> getPassport()
        {
            var objPassport = (from objpassport in DBContext.SingleFieldMaster where objpassport.Type == "Passport" select new { id = objpassport.Id, name = objpassport.Name });

            foreach (var obj in objPassport)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Passportlist.Add(objselectlistitem);
            }
            return Passportlist;
        }

        List<SelectListItem> Incomelist = new List<SelectListItem>();
        private List<SelectListItem> getIncome()
        {
            var objIncome = (from objincome in DBContext.SingleFieldMaster where objincome.Type == "CurrentIncomeLevel" select new { id = objincome.Id, name = objincome.Name });

            foreach (var obj in objIncome)
            {
                SelectListItem objselectlistitem = new SelectListItem();
                objselectlistitem.Text = obj.name;
                objselectlistitem.Value = obj.id.ToString();
                Incomelist.Add(objselectlistitem);
            }
            return Incomelist;
        }

        private IList<Country> getCountry(int countryid)
        {
            return DBContext.Country.Where(m => m.CountryID == countryid).ToList();
        }
        private IList<StatesProvinces> getState(int countryid)
        {
            return DBContext.StatesProvinces.Where(c => c.CountryID == countryid).ToList();
        }


        public JsonResult getStateByCountryId(string countryid)
        {
            var stateList = this.getState(Convert.ToInt32(countryid));
            var stateData = stateList.Select(c => new SelectListItem()
            {
                Text = c.StateName,
                Value = c.StateID.ToString(),
            });
            return Json(stateData, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GeneratePassword()
        {
            var pass = Guid.NewGuid().ToString().Substring(0, 8);


            return Json(new { password = pass });

        }

       
        public ActionResult Registration()
        {
            ViewBag.country = DBContext.Country.ToList();
            ViewBag.states = DBContext.StatesProvinces.ToList();
            ViewData["height"] = new SelectList(getHeight(), "Value", "Text");
            ViewData["weight"] = new SelectList(getWeight(), "Value", "Text");
            ViewData["religion"] = new SelectList(getReligionCast(), "Value", "Text");
            ViewData["education"] = new SelectList(getEducation(), "Value", "Text");
            ViewData["culture"] = new SelectList(getCulture(), "Value", "Text");
            ViewData["occuption"] = new SelectList(getOccuption(), "Value", "Text");
            ViewData["nationality"] = new SelectList(getNationality(), "Value", "Text");
            ViewData["passport"] = new SelectList(getPassport(), "Value", "Text");
            ViewData["income"] = new SelectList(getIncome(), "Value", "Text");

            return View();
        }

        [HttpPost]
        public ActionResult Registration(string countryid, Members objMember)
        {

            DBContext.Members.Add(objMember);
            DBContext.SaveChanges();
            FormsAuthentication.SetAuthCookie(objMember.DisplayName, false, "/");
            return RedirectToAction("Welcome", "Home");
            

        }
        
        public ActionResult Profile(int Id)
        {

            //List<members> detail = new List<members>();
            //detail = (from obj in DBContext.Members select obj).ToList();
            //int Id;
            Members objMember = (from obj in DBContext.Members where obj.id == Id select obj).FirstOrDefault();

            return View(objMember);

            
        }

        public ActionResult Search()
        {

            List<Members> list = new List<Members>();

           var objMembers = (from obj in DBContext.Members select new {firstname = obj.FirstName, middlename = obj.MiddleName, lastname = obj.LastName, email = obj.Email });
            return View(list);
        }

        

        [HttpPost]
        public ActionResult Search(Members objMember)
        {
            List<Members> list = new List<Members>();
            var objSearch = (from obj in DBContext.Members select new { firstname = obj.FirstName, middlename = obj.MiddleName, lastname = obj.LastName, email = obj.Email });

            List<Members> Memberlist;
            if (objMember.FirstName != null)
            {
                Memberlist = (from obj in DBContext.Members
                              where obj.FirstName.StartsWith(objMember.FirstName)
                              select obj).ToList();
            }
            else
            {
                Memberlist = list;
            }
            return PartialView("List", Memberlist);
        }

        public ActionResult Memberlist()
        { 
            List<Members> list = new List<Members>();

            var objMembers = from obj in DBContext.Members select new {Id = obj.id,obj.FirstName,obj.MiddleName,obj.LastName,obj.Email };
            foreach (var obj in objMembers)
            {
                Members mem = new Members();
                mem.id = obj.Id;
                mem.FirstName=obj.FirstName;
                mem.MiddleName=obj.MiddleName;
                mem.LastName=obj.LastName;
                mem.Email=obj.Email;
                list.Add(mem);
            }
            return View(list);
        }

        public ActionResult Myview()
        {
            return View();
        }

        public ActionResult SendMessage()
        {
            return View("SendMessage");
        }

        [HttpPost]
        public ActionResult SendMessage(Messages objMessages, FormCollection Frm)
        {
            if (!ModelState.IsValid)
                return View();
            objMessages.SenderId = Convert.ToInt32(Frm["SenderId"]);
            objMessages.ReciverId = Convert.ToInt32(Frm["ReciverId"]);
            objMessages.Subject = Frm["Subject"];
            objMessages.Message = Frm["Message"];
            objMessages.Status = Convert.ToBoolean(Frm["Status"]);
            objMessages.SentDate = Convert.ToDateTime(Frm["SentDate"]);
            DBContext.Messages.Add(objMessages);
            DBContext.SaveChanges();
            return RedirectToAction("Memberlist","Home");
        }

        public ActionResult Category()
        {
            return View();
        } 
    }
}
