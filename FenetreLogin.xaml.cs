using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CRM
{
    /// <summary>
    /// Logique d'interaction pour FenêtreLogin.xaml
    /// </summary>
    public partial class FenetreLogin : Window
    {
        //string server = "";
        string server = "127.0.0.1";
        public FenetreLogin()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtMdp.Password;

            //DirectoryEntry entry = new DirectoryEntry(server, username, password);
            try
            {
                // Vérifier que la connexion est établie
                //DirectorySearcher search = new DirectorySearcher(entry);
                //SearchResultCollection result = search.FindAll();
                FenetrePrincipale fenetre = new FenetrePrincipale();
                fenetre.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect");
                Console.WriteLine("Erreur lors de la connexion : " + ex.Message);
            }
        }
    }
}
