using Markom.DataModel;
using Markom.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markom.DataAccess
{
    public class UnitRepo
    {
        public static List<UnitViewModel> CodeList()
        {
            List<UnitViewModel> result = new List<UnitViewModel>();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_unit
                          
                          where c.is_delete == false
                          select new UnitViewModel
                          {
                              id = c.id,
                              code = c.code
                          }).ToList();

            }
            return result;
        }

        public static List<UnitViewModel> NameList()
        {
            List<UnitViewModel> result = new List<UnitViewModel>();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_unit
                          where c.is_delete == false
                          select new UnitViewModel
                          {
                              id = c.id,
                              name = c.name
                          }).ToList();

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
                codeAkhir = db.m_unit.OrderByDescending(a => a.code).Select(a => a.code).FirstOrDefault();
                if (codeAkhir == null)
                {
                    codeAkhir = "UN0000";
                }
                strCode = "UN";
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

        public static bool NameValidation(UnitViewModel entity)
        {
            bool isValid = true;
            using (var db = new MarkomContext())
            {
                m_unit valid = db.m_unit
                    .Where(o => o.name == entity.name && o.id == entity.id)
                    .FirstOrDefault();
                if (valid != null)
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public static ResponseResult Update(UnitViewModel entity)
        {

            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new MarkomContext())
                {
                    #region Create New / Insert
                    if (entity.id == 0)
                    {
                        m_unit unit = new m_unit();

                        unit.code = generateCode();
                        unit.name = entity.name;
                        unit.description = entity.description;
                        unit.created_by = "Administrator";
                        unit.created_date = DateTime.Now;
                        unit.is_delete = false;


                        db.m_unit.Add(unit);
                        db.SaveChanges();

                        result.Entity = entity;

                    }
                    #endregion
                    #region Edit
                    else
                    {
                        m_unit unit = db.m_unit
                            .Where(o => o.id == entity.id)
                            .FirstOrDefault();
                        if (unit != null)
                        {

                            unit.name = entity.name;
                            unit.description = entity.description;
                            unit.updated_by = "Administrator";
                            unit.updated_date = DateTime.Now;

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

        public static List<UnitViewModel> All()
        {
            List<UnitViewModel> result = new List<UnitViewModel>();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_unit
                          where c.is_delete == false
                          select new UnitViewModel
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

        public static UnitViewModel ById(int id)
        {
            UnitViewModel result = new UnitViewModel();
            using (var db = new MarkomContext())
            {
                result = (from c in db.m_unit

                          where c.id == id
                          select new UnitViewModel
                          {
                              id = c.id,
                              code = c.code,
                              name = c.name,
                              description = c.description


                          }).FirstOrDefault(); ;

            }
            return result != null ? result : new UnitViewModel();
        }

        public static ResponseResult Delete(UnitViewModel entity)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                using (var db = new MarkomContext())
                {
                    m_unit unit = db.m_unit
                        .Where(o => o.id == entity.id)
                        .FirstOrDefault();
                    if (unit != null)
                    {
                        unit.updated_by = "Administrator";
                        unit.is_delete = true;
                        unit.updated_date = DateTime.Now;



                        db.SaveChanges();
                        result.Entity = entity;
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = "";
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
