using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;
using Newtonsoft.Json;

namespace Core
{
    public class TemplateCore
    {
        public TemplateModel Get(int Id)
        {
            try
            {
                var tabla = TemplateDal.Get(Id);
                TemplateModel model = Helper.Utilidades.ToList<TemplateModel>(tabla).FirstOrDefault();
                return model;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<TemplateModel> GetAll()
        {
            try
            {
                var tabla = TemplateDal.Get(Helper.Constantes.all);
                var lista = Helper.Utilidades.ToList<TemplateModel>(tabla);
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Add(TemplateModel model)
        {
            try
            {
                TemplateDal.Add(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Modify(TemplateModel model)
        {
            try
            {
                TemplateDal.Modify(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Delete(int Id)
        {
            try
            {
                TemplateDal.Delete(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
