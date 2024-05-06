using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Facture
    {
        #region Champs
        private int _idfac;
        private int _idcli;
        private string _datefac;
        private int _total;
        #endregion

        #region Constructeurs
        public Facture(int p_idfac, int p_idcli, string p_datefac, int p_total)
        {
            _idfac = p_idfac;
            _idcli = p_idcli;
            _datefac = p_datefac;
            _total = p_total;
        }
        #endregion

        #region Accesseurs/Mutateurs
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }


        public string DateFac
        {
            get { return _datefac; }
            set { _datefac = value; }
        }


        public int IdCli
        {
            get { return _idcli; }
            set { _idcli = value; }
        }


        public int IdFac
        {
            get { return _idfac; }
            set { _idfac = value; }
        }

        #endregion
    }
}
