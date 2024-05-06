using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Produit
    {
        #region Champs
        private int _idprod;
        private string _typeprod;
        private decimal _prixprod;
        private string _nomprod;
        private string _descprod;

        #endregion

        #region Constructeur
        public Produit(int p_idprod, string p_typeprod, decimal p_prixprod, string p_nomprod, string p_descprod)
        {
            _idprod = p_idprod;
            _typeprod = p_typeprod;
            _prixprod = p_prixprod;
            _nomprod = p_nomprod;
            _descprod = p_descprod;
        }
        #endregion

        #region Accesseurs/Mutateurs
        public int IdProd
        {
            get { return _idprod; }
            set { _idprod = value; }
        }
        public string TypeProd
        {
            get { return _typeprod; }
            set { _typeprod = value; }
        }
        public decimal PrixProd
        {
            get { return _prixprod; }
            set { _prixprod = value; }
        }
        public string NomProd
        {
            get { return _nomprod; }
            set { _nomprod = value; }
        }
        public string DescProd
        {
            get { return _descprod; }
            set { _descprod = value; }
        }

        #endregion
    }
}
