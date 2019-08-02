using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClienteModel
    {
        #region "Propiedades Privadas"
        private int _IdCliente;
        private string _NombresCliente;
        private string _ApellidosCliente;
        private string _IdentificacionCliente;
        #endregion
        #region "Propiedades Publicas"
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        public string NombresCliente
        {
            get { return _NombresCliente; }
            set { _NombresCliente = value; }
        }
        public string ApellidosCliente
        {
            get { return _ApellidosCliente; }
            set { _ApellidosCliente = value; }
        }
        public string IdentificacionCliente
        {
            get { return _IdentificacionCliente; }
            set { _IdentificacionCliente = value; }
        }
        #endregion





    }
}
