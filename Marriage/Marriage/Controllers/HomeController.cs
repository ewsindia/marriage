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
        
        MarriageexpDBContext db = new MarriageexpDBContext();


     

        public ActionResult UserLogin()
        {
            return View();
        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult UserLogin(LogIn log)
        {
            var objmem = (from obj in db.members select new { obj.email, obj.password,obj.id });
            if (ModelState.IsValid)
            {
                foreach (var rec in objmem)
                {
                    if (log.UserName == rec.email && log.Password == rec.password)
                    {
                        Session["Name"] = rec.id;
                        FormsAuthentication.SetAuthCookie(log.UserName, false);
                        return RedirectToAction("Welcome", "Home");

                    }
                }
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
            }

            return View();

        }

       
       





        //
        // GET: /Account/LogOff

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("UserLogin", "Home");
        }

       
        public ActionResult Welcome()
        {
            return View();
        }

        List<SelectListItem> heightlst = new List<SelectListItem>();
        private List<SelectListItem> getheight()
        {
            var height = (from objheight in db.singlefieldmaster where objheight.type == "Height" select new { objheight.id, objheight.name });

            foreach (var he in height)
            {
                SelectListItem st = new SelectListItem();
                st.Text = he.name;
                st.Value = he.id.ToString();
                heightlst.Add(st);
            }
            return heightlst;
        }

        List<SelectListItem> weightlst = new List<SelectListItem>();
        private List<SelectListItem> getweight()
        {
            var weight = (from objweight in db.singlefieldmaster where objweight.type == "Weight" select new { objweight.id, objweight.name });

            foreach (var we in weight)
            {
                SelectListItem st = new SelectListItem();
                st.Text = we.name;
                st.Value = we.id.ToString();
                weightlst.Add(st);
            }
            return weightlst;
        }

        List<SelectListItem> religinlst = new List<SelectListItem>();
        private List<SelectListItem> getreligin()
        {
            var religin = (from objreligin in db.singlefieldmaster where objreligin.type == "ReligionCast" select new { objreligin.id, objreligin.name });

            foreach (var we in religin)
            {
                SelectListItem st = new SelectListItem();
                st.Text = we.name;
                st.Value = we.id.ToString();
                religinlst.Add(st);
            }
            return religinlst;
        }

        List<SelectListItem> Educationlst = new List<SelectListItem>();
        private List<SelectListItem> geteducation()
        {
            var education = (from objeducation in db.singlefieldmaster where objeducation.type == "Education" select new { objeducation.id, objeducation.name });

            foreach (var edu in education)
            {
                SelectListItem st = new SelectListItem();
                st.Text = edu.name;
                st.Value = edu.id.ToString();
                Educationlst.Add(st);
            }
            return Educationlst;
        }

        List<SelectListItem> culturelst = new List<SelectListItem>();
        private List<SelectListItem> getculture()
        {
            var culture = (from objculture in db.singlefieldmaster where objculture.type == "Culture" select new { objculture.id, objculture.name });

            foreach (var cul in culture)
            {
                SelectListItem st = new SelectListItem();
                st.Text = cul.name;
                st.Value = cul.id.ToString();
                culturelst.Add(st);
            }
            return culturelst;
        }

        List<SelectListItem> occuptionlst = new List<SelectListItem>();
        private List<SelectListItem> getoccuption()
        {
            var occuption = (from objoccuption in db.singlefieldmaster where objoccuption.type == "Occupation" select new { objoccuption.id, objoccuption.name });

            foreach (var occ in occuption)
            {
                SelectListItem st = new SelectListItem();
                st.Text = occ.name;
                st.Value = occ.id.ToString();
                occuptionlst.Add(st);
            }
            return occuptionlst;
        }

        List<SelectListItem> nationalitylst = new List<SelectListItem>();
        private List<SelectListItem> getnationality()
        {
            var nationality = (from objnationality in db.singlefieldmaster where objnationality.type == "Nationality" select new { objnationality.id, objnationality.name });

            foreach (var nat in nationality)
            {
                SelectListItem st = new SelectListItem();
                st.Text = nat.name;
                st.Value = nat.id.ToString();
                nationalitylst.Add(st);
            }
            return nationalitylst;
        }

        List<SelectListItem> passportlst = new List<SelectListItem>();
        private List<SelectListItem> getpassport()
        {
            var passport = (from objpassport in db.singlefieldmaster where objpassport.type == "Passport" select new { objpassport.id, objpassport.name });

            foreach (var pass in passport)
            {
                SelectListItem st = new SelectListItem();
                st.Text = pass.name;
                st.Value = pass.id.ToString();
                passportlst.Add(st);
            }
            return passportlst;
        }

        List<SelectListItem> incomelst = new List<SelectListItem>();
        private List<SelectListItem> getincome()
        {
            var income = (from objincome in db.singlefieldmaster where objincome.type == "CurrentIncomeLevel" select new { objincome.id, objincome.name });

            foreach (var incom in income)
            {
                SelectListItem st = new SelectListItem();
                st.Text = incom.name;
                st.Value = incom.id.ToString();
                incomelst.Add(st);
            }
            return incomelst;
        }

        List<SelectListItem> agntlst = new List<SelectListItem>();
        private List<SelectListItem> getagnt()
        {
            var agt = (from objagt in db.agent_master select new { objagt.id, objagt.name });

            foreach (var r in agt)
            {
                SelectListItem st = new SelectListItem();
                st.Text = r.name;
                st.Value = r.id.ToString();
                agntlst.Add(st);
            }
            return agntlst;
        }


        private IList<country> getcountry(int countryid)
        {
            return db.country.Where(m => m.CountryID == countryid).ToList();
        }
        private IList<statesprovinces> getstate(int countryid)
        {
            return db.statesprovinces.Where(c => c.CountryID == countryid).ToList();
        }


        public JsonResult getstateByCountryId(string countryid)
        {
            var stateList = this.getstate(Convert.ToInt32(countryid));
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

       
        public ActionResult Registration(agent_master am)
        {
            ViewBag.country = db.country.ToList();
            ViewBag.states = db.statesprovinces.ToList();
            ViewData["height"] = new SelectList(getheight(), "Value", "Text");
            ViewData["weight"] = new SelectList(getweight(), "Value", "Text");
            ViewData["religion"] = new SelectList(getreligin(), "Value", "Text");
            ViewData["education"] = new SelectList(geteducation(), "Value", "Text");
            ViewData["culture"] = new SelectList(getculture(), "Value", "Text");
            ViewData["occuption"] = new SelectList(getoccuption(), "Value", "Text");
            ViewData["nationality"] = new SelectList(getnationality(), "Value", "Text");
            ViewData["passport"] = new SelectList(getpassport(), "Value", "Text");
            ViewData["income"] = new SelectList(getincome(), "Value", "Text");

            return View();
        }

        [HttpPost]
        public ActionResult Registration(string countryid, members m, agent_master am)
        {
           
            db.members.Add(m);
            db.SaveChanges();
            FormsAuthentication.SetAuthCookie(m.displayname, false, "/");
            return RedirectToAction("Welcome", "Home");
            

        }

        public ActionResult profile(int Id)
        {
            Session["Name"] = Id;
            var detail = (from obj in db.members where obj.id.Equals(Id) select obj).Single();
            return View("profile", detail);
        }

        public ActionResult Search()
        {

            List<members> list = new List<members>();

            var rules = from m in db.members select new { m.firstname, m.middlename, m.lastname, m.email };
            return View(list);
           
        }

        [HttpPost]
        public ActionResult Search(members objmember)
        {
            List<members> list = new List<members>();
            var rules = (from m in db.members select new { m.firstname, m.middlename, m.lastname, m.email });
           
            List<members> member;
            if (objmember.firstname != null)
            {
                member = (from obj in db.members
                          where obj.firstname.StartsWith(objmember.firstname)
                          select obj).ToList();
            }
            else
            {
                member = list;
            }
            return PartialView("List", member);
        }

       

       
        public ActionResult Memberlist()
        {
            

            List<members> list = new List<members>();

            var rules = from m in db.members select new {m.firstname,m.middlename,m.lastname,m.email };
            foreach (var rec in rules)
            {
                members mem = new members();
                mem.firstname=rec.firstname;
                mem.middlename=rec.middlename;
                mem.lastname=rec.lastname;
                mem.email=rec.email;
                list.Add(mem);
            }
            return View(list);
        }

        public ActionResult Myview()
        {
            return View();
        }

        public ActionResult selectrecord(int Id,members objmem)
        {
            var rec = (from obj in db.members where obj.id == Id select obj);
            Session["newId"] = Id;
            return View();
        }

        //public ActionResult SendMessages()
        //{
        //    return PartialView("_SendMessages");
        //}

       
        public ActionResult SendMessages(messages objmessages, FormCollection frm)
        {
            if (!ModelState.IsValid)
                return View();
            objmessages.senderid = Convert.ToInt32(Session["Name"]);
            objmessages.reciverid = Convert.ToInt32(Session["newId"]);
            objmessages.subject = frm["subject"];
            objmessages.message = frm["message"];
            objmessages.status = frm["status"];
            objmessages.sentdate = frm["sentdate"];
            db.messages.Add(objmessages);
            db.SaveChanges();

            return View("SendMessages");
        }

        public ActionResult Messages()
        {
            return View();
        }
       
    }
}
