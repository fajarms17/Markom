using Markom.DataModel;
using Markom.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markom.DataAccess
{
    public class RoleRepo
    {
        public static ResponseResult Update(RoleViewModel entity)
        {

            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new MarkomContext())
                {
                    #region Create New / Insert
                    if (entity.id == 0)
                    {
                        m_role role = new m_role();

                        role.code = generateCode();
                        role.name = entity.name;
                        role.description = entity.description;
                        role.created_by = "Administrator";
                        role.created_date = DateTime.Now;
                        role.is_delete = false;
                        
                        
                        db.m_role.Add(role);
                        db.SaveChanges();
                        
                        result.Entity = entity;

                    }
                    #endregion
                    #region Edit
                    else
                    {
                        m_role role = db.m_role
                            .Where(o => o.id == entity.id)
                            .FirstOrDefault();
                        if (role != null)
                        {

                            role.name = entity.name;
                            role.description = entity.description;
                            role.updated_by = "Administrator";
                            role.updated_date = DateTime.Now;

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
        public static string generateCode()
        {
            string codeAkhir = "";
            int digit = 4;
            int digitNol = 0;
            string jmlNol = "";
            string strCode = "";
            using (var db = new MarkomContext())
            {
                codeAkhir = db.m_role.OrderByDescending(a => a.code).Select(a => a.code).FirstOrDefault();
                if (codeAkhir == null)
                {
                    codeAkhir = "RO0000";
                }
                strCode = "RO";
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

        public static bool NameValidation(RoleViewModel entity)
        {
            bool isValid = true;
            using (var db = new MarkomContext())
            {
                m_role valid = db.m_role
                    .Where(o => o.name == entity.name && o.id != entity.id && o.is_delete == false)
                    .FirstOrDefault();
                if (valid != null)
                {
                    isValid = false;
                } 
            }
            return isValid;
        }

        public static List<RoleViewModel> CodeList()
        {
            List<RoleViewModel> result = new List<RoleViewModel>();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_role


                          where c.is_delete == false
                          select new RoleViewModel
                          {
                              id = c.id,
                              code = c.code
                          }).ToList();

            }
            return result;
        }

        public static List<RoleViewModel> NameList()
        {
            List<RoleViewModel> result = new List<RoleViewModel>();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_role


                          where c.is_delete == false
                          select new RoleViewModel
                          {
                              id = c.id,
                              name = c.name
                          }).ToList();

            }
            return result;
        }

        public static List<RoleViewModel> All()
        {
            List<RoleViewModel> result = new List<RoleViewModel>();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_role
                          where c.is_delete == false
                          select new RoleViewModel
                          {
                              id = c.id,
                              code = c.code,
                              name = c.name,
                              created_date = c.created_date,
                              created_by = c.created_by
                          }).ToList();

            }
            return result;
        }

        public static RoleViewModel ById(int id)
        {
            RoleViewModel result = new RoleViewModel();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_role
                          
                          where c.id == id
                          select new RoleViewModel
                          {
                              id = c.id,
                              code = c.code,
                              name = c.name,
                              description = c.description
                              


                          }).FirstOrDefault(); ;

            }
            return result != null ? result : new RoleViewModel();
        }

        public static ResponseResult Delete(RoleViewModel entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new MarkomContext())
                {
                    m_role role = db.m_role
                        .Where(o => o.id == entity.id)
                        .FirstOrDefault();
                    if (role != null)
                    {
                        role.updated_by = "Administrator";
                        role.is_delete = true;
                        role.updated_date = DateTime.Now;



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
