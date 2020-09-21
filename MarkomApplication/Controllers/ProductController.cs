using Markom.ViewModel;
using Markom.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarkomApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            Session["code"] = ProductRepo.generateCode();
            //string code = Session["code"].ToString();
            return PartialView("_Create", new ProductViewModel());
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel model)
        {

            if (ProductRepo.NameValidation(model))
            {
                ResponseResult result = ProductRepo.Update(model);
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

        public ActionResult List(string code, string name, string description, DateTime? createdDate, string createdBy)
        {
            List<ProductViewModel> list = new List<ProductViewModel>();
            list = ProductRepo.All();
            if (code != "" || name != "" || createdDate != null || createdBy != "" || description!="")
            {
                list = list.Where(a => a.code.ToLower().Contains(code.ToLower()) || a.name.ToLower().Contains(name.ToLower())|| a.description.ToLower().Contains(description.ToLower()) || a.created_by.ToLower().Contains(createdBy.ToLower()) || a.created_date == createdDate).ToList();
            }

            return PartialView("_List", list);
        }

        public ActionResult Edit(int id)
        {
            ProductViewModel model = ProductRepo.ById(id);
            Session["EditCode"] = model.code;
            Session["EditName"] = model.name;
            return PartialView("_Edit", model);

        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel model)
        {
            if (ProductRepo.NameValidation(model))
            {
                ResponseResult result = ProductRepo.Update(model);
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
            return PartialView("_Delete", ProductRepo.ById(id));
        }

        [HttpPost]
        public ActionResult Delete(ProductViewModel model)
        {
            ResponseResult result = ProductRepo.Delete(model);
            return Json(new
            {
                success = result.Success,
                message = result.Message,
                entity = result.Entity
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Detail(int id)
        {
            ProductViewModel model = ProductRepo.ById(id);

            return PartialView("_Detail", model);

        }


    }
}