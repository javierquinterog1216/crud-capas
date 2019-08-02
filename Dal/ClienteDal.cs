using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Helper;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Dal
{
    public class ClienteDal
    {

        /// <summary>
        /// usando Sql library
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static ClienteModel Get(int Id)
        {
            ClienteModel model = new ClienteModel();
            try
            {
                using (SqlConnection con = new SqlConnection(Helper.Constantes.cadenaConexion))
                {
                    using (SqlCommand command = new SqlCommand("GetCliente", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("IdCliente", Id);
                        con.Open();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var idCliente = reader.GetInt32(reader.GetOrdinal("idCliente"));
                            model.IdCliente = idCliente;
                            var nombres = reader.GetString(reader.GetOrdinal("NombresCliente"));
                            model.NombresCliente = nombres;
                            var apellidos = reader.GetString(reader.GetOrdinal("ApellidosCliente"));
                            model.ApellidosCliente = apellidos;
                            var identificacion = reader.GetString(reader.GetOrdinal("IdentificacionCliente"));
                            model.IdentificacionCliente = identificacion;
                        }
                        return model;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.Write(ex.ToString());
                throw;
            }
        }
        /// <summary>
        /// usando Enterpriselibrary
        /// </summary>
        /// <param name="idCliente"></param>
        public static DataTable GetCliente(int idCliente)
        {
            DataTable result;
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("GetCliente");
            db.AddInParameter(command, "@IdCliente", DbType.Int32, idCliente);
            result = db.ExecuteDataSet(command).Tables[0];
            return result;
        }

        public static int Add(ClienteModel model)
        {
            DataTable result;
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("AddCliente");
            db.AddInParameter(command, "@NombresCliente", DbType.String, model.NombresCliente);
            db.AddInParameter(command, "@ApellidosCliente", DbType.String, model.ApellidosCliente);
            db.AddInParameter(command, "@IdentificacionCliente", DbType.String, model.IdentificacionCliente);
            result = db.ExecuteDataSet(command).Tables[0];
            return int.Parse(result.Rows[0][0].ToString());
        }
        public static void Modify(ClienteModel model)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("ModifyCliente");
            db.AddInParameter(command, "@IdCliente", DbType.Int32, model.IdCliente);
            db.AddInParameter(command, "@NombresCliente", DbType.String, model.NombresCliente);
            db.AddInParameter(command, "@ApellidosCliente", DbType.String, model.ApellidosCliente);
            db.AddInParameter(command, "@IdentificacionCliente", DbType.String, model.IdentificacionCliente);
            db.ExecuteNonQuery(command);
        }
        public static void Delete(int idCliente)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Helper.Constantes.cadenaConexion);
            var command = db.GetStoredProcCommand("DeleteCliente");
            db.AddInParameter(command, "@IdCliente", DbType.Int32, idCliente);
            db.ExecuteDataSet(command);
        }
    }
}
