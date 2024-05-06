using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class LigneFacture
    {
        #region Champs
        private int _idlignefac;
        private int _idfac;
        private int _idprod;
        private int _qte;
        #endregion

        #region Constructeurs
        public LigneFacture(int p_idlignefac, int p_idfac, int p_idprod, int p_qte)
        {
            _idlignefac = p_idlignefac;
            _idfac = p_idfac;
            _idprod = p_idprod;
            _qte = p_qte;
        }
        #endregion

        #region Accesseurs/Mutateurs
        public int Qte
        {
            get { return _qte; }
            set { _qte = value; }
        }


        public int IdProd
        {
            get { return _idprod; }
            set { _idprod = value; }
        }


        public int IdFac
        {
            get { return _idfac; }
            set { _idfac = value; }
        }
        public int IdLigneFac
        {
            get { return _idlignefac; }
            set { _idlignefac = value; }
        }
        #endregion
    }
}
