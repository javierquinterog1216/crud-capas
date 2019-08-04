using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Model;

namespace Dal
{
    public class TemplateDal
    {

        public static DataTable Get(int Id)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("NombreProcedimiento");
            db.AddInParameter(command, "@Id", DbType.Int32, Id);
            var result = db.ExecuteDataSet(command).Tables[0];
            return result;


        }
        public static int Add(TemplateModel model)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("NombreProcedimiento");
            db.AddInParameter(command, "@Codigo", DbType.String, model.Codigo);
            db.AddInParameter(command, "@Descripcion", DbType.String, model.Descripcion);
            db.AddInParameter(command, "@Observacion", DbType.String, model.Observacion);
            return db.ExecuteNonQuery(command);
        }
        public static int Modify(TemplateModel model)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("NombreProcedimiento");
            db.AddInParameter(command, "@Id", DbType.Int32, model.Id);
            db.AddInParameter(command, "@Codigo", DbType.String, model.Codigo);
            db.AddInParameter(command, "@Descripcion", DbType.String, model.Descripcion);
            db.AddInParameter(command, "@Observacion", DbType.String, model.Observacion);
            return db.ExecuteNonQuery(command);
        }
        public static int Delete(int Id)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("NombreProcedimiento");
            db.AddInParameter(command, "@Id", DbType.Int32, Id);
            return db.ExecuteNonQuery(command);
        }
    }
}
