using Markom.DataAccess;
using Markom.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarkomApplication.Controllers
{
    public class UnitController : Controller
    {
        // GET: Unit
        public ActionResult Index()
        {
            ViewBag.Code = new SelectList(UnitRepo.CodeList(), "id", "code");
            ViewBag.Name = new SelectList(UnitRepo.NameList(), "id", "name");
            return View();
        }

        public ActionResult Create()
        {
            Session["code"] = UnitRepo.generateCode();
            
            return PartialView("_Create", new UnitViewModel());
        }

        [HttpPost]
        public ActionResult Create(UnitViewModel model)
        {
            if (UnitRepo.NameValidation(model))
            {
                ResponseResult result = UnitRepo.Update(model);
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
                    message = "Unit Name Sudah Ada",

                }, JsonRequestBehavior.AllowGet);

            }

        }

        public ActionResult List(string code, string name, DateTime? createdDate, string createdBy)
        {
            List<UnitViewModel> list = new List<UnitViewModel>();
            list = UnitRepo.All();
            if (code != "-Select Unit Code-" || name != "-Select Unit Name-" || createdDate != null || createdBy != "")
            {
                list = list.Where(a => a.code == code || a.name == name || a.created_by == createdBy || a.created_date == createdDate).ToList();
            }

            return PartialView("_List", list);
        }

        public ActionResult Edit(int id)
        {
            UnitViewModel model = UnitRepo.ById(id);
            Session["EditCode"] = model.code;
            Session["EditName"] = model.name;
            return PartialView("_Edit", model);

        }

        [HttpPost]
        public ActionResult Edit(UnitViewModel model)
        {
            if (UnitRepo.NameValidation(model))
            {
                ResponseResult result = UnitRepo.Update(model);
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
                    message = "Code Name Sudah Ada",

                }, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult Detail(int id)
        {
            UnitViewModel model = UnitRepo.ById(id);

            return PartialView("_Detail", model);

        }

        public ActionResult Delete(int id)
        {
            return PartialView("_Delete", UnitRepo.ById(id));
        }

        [HttpPost]
        public ActionResult Delete(UnitViewModel model)
        {
            ResponseResult result = UnitRepo.Delete(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }


    }
}