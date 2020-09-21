using Markom.DataAccess;
using Markom.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarkomApplication.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            ViewBag.Code = new SelectList(RoleRepo.CodeList(), "id", "code");
            ViewBag.Name = new SelectList(RoleRepo.NameList(), "id", "name");
            return View();
        }

        public ActionResult List(string code, string name, DateTime? createdDate, string createdBy)
        {
            List<RoleViewModel> list = new List<RoleViewModel>();
            list = RoleRepo.All();
            if(code != "-Select Role Code-"|| name != "-Select Role Name-" || createdDate != null || createdBy != "")
            {
                list = list.Where(a => a.code == code || a.name == name || a.created_by.ToLower().Contains(createdBy.ToLower()) || a.created_date == createdDate).ToList();
            }

            return PartialView("_List", list);
        }

        public ActionResult Create()
        {
            Session["code"] = RoleRepo.generateCode();
            //string code = Session["code"].ToString();
            return PartialView("_Create", new RoleViewModel());
        }

        [HttpPost]
        public ActionResult Create(RoleViewModel model)
        {
            
            if (RoleRepo.NameValidation(model))
            {
                ResponseResult result = RoleRepo.Update(model);
                return Json(new
                {
                    
                    success = result.Success,
                    message = result.Message,
                    entity = result.Entity
                }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                
                return Json(new
                {

                    success = false,
                    message = "Role Name Sudah Ada",

                }, JsonRequestBehavior.AllowGet);


            }


        }

        public ActionResult Delete(int id)
        {
            return PartialView("_Delete", RoleRepo.ById(id));
        }

        [HttpPost]
        public ActionResult Delete(RoleViewModel model)
        {
            ResponseResult result = RoleRepo.Delete(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            RoleViewModel model = RoleRepo.ById(id);
            Session["EditCode"] = model.code;
            Session["EditName"] = model.name;
            return PartialView("_Edit", model);

        }

        [HttpPost]
        public ActionResult Edit(RoleViewModel model)
        {
            if (RoleRepo.NameValidation(model))
            {
                ResponseResult result = RoleRepo.Update(model);
                return Json(new
                {

                    success = result.Success,
                    message = result.Message,
                    entity = result.Entity
                }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new
                {
                    success = false,
                    message = "Role Name Sudah Ada",

                }, JsonRequestBehavior.AllowGet);

            }
        }


        public ActionResult Detail(int id)
        {
            RoleViewModel model = RoleRepo.ById(id);
            
            return PartialView("_Detail", model);

        }

    }
}