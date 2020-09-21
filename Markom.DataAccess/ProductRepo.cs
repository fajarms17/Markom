using Markom.DataModel;
using Markom.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markom.DataAccess
{
    public class ProductRepo
    {
        public static string generateCode()
        {
            string codeAkhir = "";
            int digit = 4;
            int digitNol = 0;
            string jmlNol = "";
            string strCode = "";
            using (var db = new MarkomContext())
            {
                codeAkhir = db.m_product.OrderByDescending(a => a.code).Select(a => a.code).FirstOrDefault();
                if (codeAkhir == null)
                {
                    codeAkhir = "PR0000";
                }
                strCode = "PR";
                int angka = int.Parse(codeAkhir.Substring(3, 3));
                angka += 1;
                if (angka.ToString().Length <= digit)
                {
                    digitNol = digit - angka.ToString().Length;
                    for (int i = 0; i < digitNol; i++)
                    {
                        jmlNol += "0";
                    }
                }
                codeAkhir = strCode + jmlNol + angka;
            }
            return codeAkhir;
        }

        public static bool NameValidation(ProductViewModel entity)
        {
            bool isValid = true;
            using (var db = new MarkomContext())
            {
                m_product valid = db.m_product
                    .Where(o => o.name == entity.name && o.id != entity.id && o.is_delete == false)
                    .FirstOrDefault();
                if (valid != null)
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public static ResponseResult Update(ProductViewModel entity)
        {

            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new MarkomContext())
                {
                    #region Create New / Insert
                    if (entity.id == 0)
                    {
                        m_product product = new m_product();

                        product.code = generateCode();
                        product.name = entity.name;
                        product.description = entity.description;
                        product.created_by = "Administrator";
                        product.created_date = DateTime.Now;
                        product.is_delete = false;


                        db.m_product.Add(product);
                        db.SaveChanges();

                        result.Entity = entity;

                    }
                    #endregion
                    #region Edit
                    else
                    {
                        m_product product = db.m_product
                            .Where(o => o.id == entity.id)
                            .FirstOrDefault();
                        if (product != null)
                        {

                            product.name = entity.name;
                            product.description = entity.description;
                            product.updated_by = "Administrator";
                            product.updated_date = DateTime.Now;

                            db.SaveChanges();
                            result.Entity = entity;

                        }
                        else
                        {
                            result.Success = false;
                            result.Message = "";
                        }
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                
                result.Success = false;
                result.Message = ex.Message;

            }
            return result;

        }

        public static List<ProductViewModel> All()
        {
            List<ProductViewModel> result = new List<ProductViewModel>();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_product
                          where c.is_delete == false
                          select new ProductViewModel
                          {
                              id = c.id,
                              code = c.code,
                              name = c.name,
                              description = c.description,
                              created_date = c.created_date,
                              created_by = c.created_by
                          }).ToList();

            }
            return result;
        }

        public static ProductViewModel ById(int id)
        {
            ProductViewModel result = new ProductViewModel();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_product

                          where c.id == id
                          select new ProductViewModel
                          {
                              id = c.id,
                              code = c.code,
                              name = c.name,
                              description = c.description



                          }).FirstOrDefault(); ;

            }
            return result != null ? result : new ProductViewModel();
        }

        public static ResponseResult Delete(ProductViewModel entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new MarkomContext())
                {
                    m_product product = db.m_product
                        .Where(o => o.id == entity.id)
                        .FirstOrDefault();
                    if (product != null)
                    {
                        product.updated_by = "Administrator";
                        product.is_delete = true;
                        product.updated_date = DateTime.Now;
                                               
                        db.SaveChanges();
                        result.Entity = entity;
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = "Category not found";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }



    }
}
