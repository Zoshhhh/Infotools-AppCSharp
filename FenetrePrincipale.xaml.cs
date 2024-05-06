using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class FenetrePrincipale : Window
    {
        List<Produit> lesProduit = new List<Produit>(); // collection des produits
        List<Employe> lesEmploye = new List<Employe>(); // collection des employés
        List<Client> lesClient = new List<Client>(); // collection des clients
        List<Rdv> lesRdv = new List<Rdv>(); // collection des rdv
        List<Facture> lesFacture = new List<Facture>(); // collection des factures
        List<LigneFacture> lesLigneFacture = new List<LigneFacture>(); // collection des factures



        public FenetrePrincipale()
        {
            InitializeComponent();
            bdd.Initialize();

            //Trie de chaque collection par ordre croissant de l'id
            lesProduit = bdd.SelectProduit();
            lesProduit.Sort((x, y) => 1 * x.IdProd.CompareTo(y.IdProd));
            dtgProduit.ItemsSource = lesProduit;

            lesEmploye = bdd.SelectEmploye();
            lesEmploye.Sort((x, y) => 1 * x.IdEmp.CompareTo(y.IdEmp));
            dtgEmp.ItemsSource = lesEmploye;

            lesClient = bdd.SelectClient();
            lesClient.Sort((x, y) => 1 * x.IdCli.CompareTo(y.IdCli));
            dtgClient.ItemsSource = lesClient;

            lesFacture = bdd.SelectFac();
            lesFacture.Sort((x, y) => 1 * x.IdFac.CompareTo(y.IdFac));
            dtgFac.ItemsSource = lesFacture;

            lesLigneFacture = bdd.SelectLigneFac();
            lesLigneFacture.Sort((x, y) => 1 * x.IdLigneFac.CompareTo(y.IdLigneFac));
            dtgLigneFac.ItemsSource = lesLigneFacture;

            //Trie par date
            lesRdv = bdd.SelectRdv();
            lesRdv.Sort((x, y) => 1 * x.DateRdv.CompareTo(y.DateRdv));
            dtgRdv.ItemsSource = lesRdv;

            CboClientFac.ItemsSource = lesClient; // Lie la combobox avec la collection
            CboClientFac.SelectedValuePath = "IdCli"; // Spécifie la propriété à utiliser comme valeur

            CboIdCliRdv.ItemsSource = lesClient; // Lie la combobox avec la collection
            CboIdCliRdv.SelectedValuePath = "IdCli"; // Spécifie la propriété à utiliser comme valeur

            CboIdEmpRdv.ItemsSource = lesEmploye; // Lie la combobox avec la collection
            CboIdEmpRdv.SelectedValuePath = "IdEmp"; // Spécifie la propriété à utiliser comme valeur

            CboFactureLigneFac.ItemsSource = lesFacture; // Lie la combobox avec la collection
            CboFactureLigneFac.DisplayMemberPath = "IdFac"; // Spécifie la propriété à afficher
            CboFactureLigneFac.SelectedValuePath = "IdFac"; // Spécifie la propriété à utiliser comme valeur

            CboProduitLigneFac.ItemsSource = lesProduit; // Lie la combobox avec la collection
            CboProduitLigneFac.DisplayMemberPath = "NomProd"; // Spécifie la propriété à afficher
            CboProduitLigneFac.SelectedValuePath = "IdProd"; // Spécifie la propriété à utiliser comme valeur

        }

        private void BtnRdv_Click(object sender, RoutedEventArgs e)
        {
            TabC1.SelectedItem = TabIRdv; //Changement de page

            lesEmploye = bdd.SelectEmploye();
            lesEmploye.Sort((x, y) => 1 * x.IdEmp.CompareTo(y.IdEmp));
            dtgEmp.ItemsSource = lesEmploye;

            lesClient = bdd.SelectClient();
            lesClient.Sort((x, y) => 1 * x.IdCli.CompareTo(y.IdCli));
            dtgClient.ItemsSource = lesClient;

            CboIdCliRdv.ItemsSource = lesClient; // Lie la combobox avec la collection
            CboIdCliRdv.SelectedValuePath = "IdCli"; // Spécifie la propriété à utiliser comme valeur

            CboIdEmpRdv.ItemsSource = lesEmploye; // Lie la combobox avec la collection
            CboIdEmpRdv.SelectedValuePath = "IdEmp"; // Spécifie la propriété à utiliser comme valeur
        }
        private void BtnCRM_Click(object sender, RoutedEventArgs e)
        {
            TabC1.SelectedItem = TabICRM; //Changement de page
        }

        private void BtnGestionProd_Click(object sender, RoutedEventArgs e)
        {
            TabC1.SelectedItem = TabIGestionProd; //Changement de page
        }

        private void BtnFacProd_Click(object sender, RoutedEventArgs e)
        {
            TabC1.SelectedItem = TabIFacProd;

            lesProduit = bdd.SelectProduit();
            lesProduit.Sort((x, y) => 1 * x.IdProd.CompareTo(y.IdProd));
            dtgProduit.ItemsSource = lesProduit;

            lesClient = bdd.SelectClient();
            lesClient.Sort((x, y) => 1 * x.IdCli.CompareTo(y.IdCli));
            dtgClient.ItemsSource = lesClient;

            lesFacture = bdd.SelectFac();
            lesFacture.Sort((x, y) => 1 * x.IdFac.CompareTo(y.IdFac));
            dtgFac.ItemsSource = lesFacture;

            CboClientFac.ItemsSource = lesClient; // Lie la combobox avec la collection
            CboClientFac.SelectedValuePath = "IdCli"; // Spécifie la propriété à utiliser comme valeur

            CboFactureLigneFac.ItemsSource = lesFacture; // Lie la combobox avec la collection
            CboFactureLigneFac.DisplayMemberPath = "IdFac"; // Spécifie la propriété à afficher
            CboFactureLigneFac.SelectedValuePath = "IdFac"; // Spécifie la propriété à utiliser comme valeur

            CboProduitLigneFac.ItemsSource = lesProduit; // Lie la combobox avec la collection
            CboProduitLigneFac.DisplayMemberPath = "NomProd"; // Spécifie la propriété à afficher
            CboProduitLigneFac.SelectedValuePath = "IdProd"; // Spécifie la propriété à utiliser comme valeur
        }
        private void dtgProduit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Stockage dans l'objet selectedProduit le Pigiste selectionné dans le datagrid dtgProduit
            Produit selectedProduit = dtgProduit.SelectedItem as Produit;

            if (selectedProduit != null)
            {
                try
                {
                    //Remplissage des Textboxs avec les données de l'objet Pigiste selectedProduit récupéré dans le Datagrid dtgProduit
                    TxtIdProd.Text = Convert.ToString(selectedProduit.IdProd);
                    TxtTypeProd.Text = Convert.ToString(selectedProduit.TypeProd);
                    TxtPrixProd.Text = Convert.ToString(selectedProduit.PrixProd);
                    TxtNomProd.Text = Convert.ToString(selectedProduit.NomProd);
                    TxtDescProd.Text = Convert.ToString(selectedProduit.DescProd);
                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur sur la mise à jour du formulaire lors du changement dans le Datagrid dtgProduit");
                }
            }
            
        }
        private void BtnAjouterProd_Click(object sender, RoutedEventArgs e)
        {
            //Ajout d'un produit dans la bdd
            bdd.InsertProduit(TxtTypeProd.Text, Convert.ToInt32(TxtPrixProd.Text), TxtNomProd.Text, TxtDescProd.Text) ;

            //Actualisation du dtgProduit
            lesProduit.Clear();
            lesProduit = bdd.SelectProduit();
            lesProduit.Sort((x, y) => 1 * x.IdProd.CompareTo(y.IdProd));
            dtgProduit.ItemsSource = lesProduit;
        }
        private void BtnModifierProd_Click(object sender, RoutedEventArgs e)
        {
            //Si aucun produit sélectionné
            if (dtgProduit.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un produit");
            }

            else
            {
                //Sinon update des informations dans la bdd
                bdd.UpdateProduit(Convert.ToInt32(TxtIdProd.Text), TxtTypeProd.Text, Convert.ToInt32(TxtPrixProd.Text), TxtNomProd.Text, TxtDescProd.Text);

                //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
                int indice = lesProduit.IndexOf((Produit)dtgProduit.SelectedItem);

                // On change les propritétés de l'objet à l'indice trouvé. On ne change pas le numéro de magazine via l'interface, trop de risques d'erreurs en base de données
                lesProduit.ElementAt(indice).TypeProd = TxtTypeProd.Text;
                lesProduit.ElementAt(indice).PrixProd = Convert.ToInt32(TxtPrixProd.Text);
                lesProduit.ElementAt(indice).NomProd = TxtNomProd.Text;
                lesProduit.ElementAt(indice).DescProd = TxtDescProd.Text;

                dtgProduit.Items.Refresh();
            }
        }
        private void BtnSupprimerProd_Click(object sender, RoutedEventArgs e)
        {
            //Si aucun produit sélectionné
            if (dtgProduit.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un produit");
            }

            else
            {
                //Delete du produit dans la bdd puis dans le dtgProduit
                bdd.DeleteProduit(Convert.ToInt32(TxtIdProd.Text));
                lesProduit.Remove((Produit)dtgProduit.SelectedItem);

                //On préselectionne par défaut le premier élément du Datagrid après la suppression
                dtgProduit.SelectedIndex = 0;
                dtgProduit.Items.Refresh();
            }
        }

        private void dtgRdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Stockage dans l'objet selectedRdv le Pigiste selectionné dans le datagrid dtgRdv
            Rdv selectedRdv = dtgRdv.SelectedItem as Rdv;

            if (selectedRdv != null)
            {
                try
                {
                    //Remplissage des Textboxs avec les données de l'objet Rdv selectedRdv récupéré dans le Datagrid dtgRdv
                    TxtIdRdv.Text = Convert.ToString(selectedRdv.IdRdv);
                    CboIdCliRdv.SelectedValue = selectedRdv.LeClient;
                    CboIdEmpRdv.SelectedValue = selectedRdv.LeEmploye;
                    DateRdv.SelectedDate = Convert.ToDateTime(selectedRdv.DateRdv);
                    CboHeureRdv.Text = selectedRdv.HeureRdv;
                }
                catch (Exception)
                {
                    Console.WriteLine("Erreur sur la mise à jour du formulaire lors du changement dans le Datagrid dtgRdv");
                }
            }
        }

        private void BtnAjouterRdv_Click(object sender, RoutedEventArgs e)
        {
            bdd.InsertRdv(Convert.ToInt32(CboIdCliRdv.SelectedValue), Convert.ToInt32(CboIdEmpRdv.SelectedValue), DateRdv.SelectedDate.Value.ToString("dd/MM/yyyy"), CboHeureRdv.Text);

            lesRdv.Clear();
            lesRdv = bdd.SelectRdv();
            lesRdv.Sort((x, y) => 1 * x.DateRdv.CompareTo(y.DateRdv));
            dtgRdv.ItemsSource = lesRdv;
        }

        private void BtnModifierRdv_Click(object sender, RoutedEventArgs e)
        {
            //Si aucun Rdv sélectionné
            if (dtgRdv.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un Rdv");
            }

            else
            {
                //Sinon update des informations dans la bdd
                bdd.UpdateRdv(Convert.ToInt32(TxtIdRdv.Text), Convert.ToInt32(CboIdCliRdv.SelectedValue), Convert.ToInt32(CboIdEmpRdv.SelectedValue), DateRdv.SelectedDate.Value.ToString("dd/MM/yyyy"), CboHeureRdv.Text);

                //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
                int indice = lesRdv.IndexOf((Rdv)dtgRdv.SelectedItem);

                // On change les propritétés de l'objet à l'indice trouvé. On ne change pas le numéro de rdv via l'interface, trop de risques d'erreurs en base de données
                lesRdv.ElementAt(indice).LeClient = Convert.ToInt32(CboIdCliRdv.SelectedValue);
                lesRdv.ElementAt(indice).LeEmploye = Convert.ToInt32(CboIdEmpRdv.SelectedValue);
                lesRdv.ElementAt(indice).DateRdv = DateRdv.SelectedDate.Value.ToString("dd/MM/yyyy");
                lesRdv.ElementAt(indice).HeureRdv = CboHeureRdv.Text;

                dtgRdv.Items.Refresh();
            }
        }

        private void BtnSupprimerRdv_Click(object sender, RoutedEventArgs e)
        {
            //Si aucun rdv sélectionné
            if (dtgRdv.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un Rdv");
            }

            else
            {
                //Delete du Rdv dans la bdd puis dans le dtgRdv
                bdd.DeleteRdv(Convert.ToInt32(TxtIdRdv.Text));
                lesRdv.Remove((Rdv)dtgRdv.SelectedItem);

                //On préselectionne par défaut le premier élément du Datagrid après la suppression
                dtgRdv.SelectedIndex = 0;
                dtgRdv.Items.Refresh();
            }
        }



        private void dtgEmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Employe selectedEmploye = dtgEmp.SelectedItem as Employe;

            if (selectedEmploye != null)
            {
                try
                {
                    string idemp = Convert.ToString(selectedEmploye.IdEmp);
                    TxtIdEmp.Text = idemp;
                    TxtNomEmp.Text = Convert.ToString(selectedEmploye.NomEmp);
                    TxtPrenomEmp.Text = Convert.ToString(selectedEmploye.PrenomEmp);
                    TxtTelEmp.Text = Convert.ToString(selectedEmploye.TelEmp);
                    TxtMailEmp.Text = Convert.ToString(selectedEmploye.MailEmp);
                    TxtPosteEmp.Text = Convert.ToString(selectedEmploye.PosteEmp);
                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur sur la mise à jour du formulaire lors du changement dans le Datagrid dtgEmp");
                }
            }
        }
        private void BtnAjouterEmp_Click(object sender, RoutedEventArgs e)
        {
            bdd.InsertEmploye(TxtNomEmp.Text, TxtPrenomEmp.Text, TxtTelEmp.Text, TxtMailEmp.Text, TxtPosteEmp.Text);

            lesEmploye.Clear();
            lesEmploye = bdd.SelectEmploye();
            lesEmploye.Sort((x, y) => 1 * x.IdEmp.CompareTo(y.IdEmp));
            dtgEmp.ItemsSource = lesEmploye;
        }

        private void BtnModifierEmp_Click(object sender, RoutedEventArgs e)
        {
            if (dtgEmp.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un employe");
            }

            else
            {
                bdd.UpdateEmploye(Convert.ToInt32(TxtIdEmp.Text), TxtNomEmp.Text, TxtPrenomEmp.Text, TxtTelEmp.Text, TxtMailEmp.Text, TxtPosteEmp.Text);

                //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
                int indice = lesEmploye.IndexOf((Employe)dtgEmp.SelectedItem);

                // On change les propritétés de l'objet à l'indice trouvé. On ne change pas le numéro de magazine via l'interface, trop de risques d'erreurs en base de données
                lesEmploye.ElementAt(indice).NomEmp = TxtNomEmp.Text;
                lesEmploye.ElementAt(indice).PrenomEmp = TxtPrenomEmp.Text;
                lesEmploye.ElementAt(indice).TelEmp = TxtTelEmp.Text;
                lesEmploye.ElementAt(indice).MailEmp = TxtMailEmp.Text;
                lesEmploye.ElementAt(indice).PosteEmp = TxtPosteEmp.Text;

                dtgEmp.Items.Refresh();
            }
        }

        private void BtnSupprimerEmp_Click(object sender, RoutedEventArgs e)
        {
            if (dtgEmp.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un employé");
            }

            else
            {
                bdd.DeleteEmploye(Convert.ToInt32(TxtIdEmp.Text));
                lesEmploye.Remove((Employe)dtgEmp.SelectedItem);
                //On préselectionne par défaut le premier élément du Datagrid après la suppression
                dtgEmp.SelectedIndex = 0;
                dtgEmp.Items.Refresh();
            }
        }




        private void dtgCli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Client selectedClient = dtgClient.SelectedItem as Client;

            if (selectedClient != null)
            {
                try
                {
                    TxtIdCli.Text = Convert.ToString(selectedClient.IdCli);
                    TxtNomCli.Text = Convert.ToString(selectedClient.NomCli);
                    TxtPrenomCli.Text = Convert.ToString(selectedClient.PrenomCli);
                    TxtMailCli.Text = Convert.ToString(selectedClient.MailCli);
                    TxtVilleCli.Text = Convert.ToString(selectedClient.VilleCli);
                    TxtAdresseCli.Text = Convert.ToString(selectedClient.NomRueCli);
                    TxtCPCli.Text = Convert.ToString(selectedClient.CPCli);
                    if (selectedClient.IdProspect == 1) { ChkProspect.IsChecked = true; }
                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur sur la mise à jour du formulaire lors du changement dans le Datagrid dtgCli");
                }
            }
        }

        private void BtnAjouterCli_Click(object sender, RoutedEventArgs e)
        {
            int idprospect = 0;
            if (ChkProspect.IsChecked == true) { idprospect = 1; }

            bdd.InsertClient(TxtNomCli.Text, TxtPrenomCli.Text, TxtMailCli.Text, TxtVilleCli.Text, TxtAdresseCli.Text, Convert.ToInt32(TxtCPCli.Text), idprospect);

            lesClient.Clear();
            lesClient = bdd.SelectClient();
            lesClient.Sort((x, y) => 1 * x.IdCli.CompareTo(y.IdCli));
            dtgClient.ItemsSource = lesClient;
        }

        private void BtnModifierCli_Click(object sender, RoutedEventArgs e)
        {
            if (dtgClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client");
            }

            else
            {   
                int idprospect = 0;
                if (ChkProspect.IsChecked == true) { idprospect = 1; }

                bdd.UpdateClient(Convert.ToInt32(TxtIdCli.Text), TxtNomCli.Text, TxtPrenomCli.Text, TxtMailCli.Text, TxtVilleCli.Text, TxtAdresseCli.Text, Convert.ToInt32(TxtCPCli.Text), idprospect);

                //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
                int indice = lesClient.IndexOf((Client)dtgClient.SelectedItem);

                // On change les propritétés de l'objet à l'indice trouvé. On ne change pas le numéro de magazine via l'interface, trop de risques d'erreurs en base de données
                lesClient.ElementAt(indice).NomCli = TxtNomCli.Text;
                lesClient.ElementAt(indice).PrenomCli = TxtPrenomCli.Text;
                lesClient.ElementAt(indice).MailCli = TxtMailCli.Text;
                lesClient.ElementAt(indice).VilleCli = TxtVilleCli.Text;
                lesClient.ElementAt(indice).NomRueCli = TxtAdresseCli.Text;
                lesClient.ElementAt(indice).CPCli = Convert.ToInt32(TxtCPCli.Text);
                lesClient.ElementAt(indice).IdProspect = idprospect;

                dtgClient.Items.Refresh();
            }
        }

        private void BtnSupprimerCli_Click(object sender, RoutedEventArgs e)
        {
            if (dtgClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client");
            }

            else
            {
                bdd.DeleteClient(Convert.ToInt32(TxtIdCli.Text));
                lesClient.Remove((Client)dtgClient.SelectedItem);
                //On préselectionne par défaut le premier élément du Datagrid après la suppression
                dtgClient.SelectedIndex = 0;
                dtgClient.Items.Refresh();
            }
        }

        private void dtgFac_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Facture selectedFacture = dtgFac.SelectedItem as Facture;

            if (selectedFacture != null)
            {
                lesLigneFacture = bdd.SelectLigneFacById(selectedFacture.IdFac);
                lesLigneFacture.Sort((x, y) => 1 * x.IdLigneFac.CompareTo(y.IdLigneFac));
                dtgLigneFac.ItemsSource = lesLigneFacture;

                try
                {
                    CboFactureLigneFac.SelectedValue = selectedFacture.IdFac;
                    TxtIdFac.Text = Convert.ToString(selectedFacture.IdFac);
                    CboClientFac.SelectedValue = selectedFacture.IdCli;
                    DateFac.Text = selectedFacture.DateFac;
                    TxtPrixFac.Text = Convert.ToString(selectedFacture.Total);
                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur sur la mise à jour du formulaire lors du changement dans le Datagrid dtgFac");
                }
            }
        }

        private void BtnAjouterFac_Click(object sender, RoutedEventArgs e)
        {
            bdd.InsertFac(Convert.ToInt32(CboClientFac.SelectedValue), DateFac.SelectedDate.Value.ToString("dd/MM/yyyy"));

            lesFacture.Clear();
            lesFacture = bdd.SelectFac();
            lesFacture.Sort((x, y) => 1 * x.IdFac.CompareTo(y.IdFac));
            dtgFac.ItemsSource = lesFacture;
        }

        private void BtnModifierFac_Click(object sender, RoutedEventArgs e)
        {
            if (dtgFac.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un Facture");
            }

            else
            {
                bdd.UpdateFac(Convert.ToInt32(TxtIdFac.Text), Convert.ToInt32(CboClientFac.SelectedValue), DateFac.SelectedDate.Value.ToString("dd/MM/yyyy"));

                //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
                int indice = lesFacture.IndexOf((Facture)dtgFac.SelectedItem);

                // On change les propritétés de l'objet à l'indice trouvé.
                lesFacture.ElementAt(indice).IdCli = Convert.ToInt32(CboClientFac.SelectedValue);
                lesFacture.ElementAt(indice).DateFac = DateFac.Text;

                dtgFac.Items.Refresh();
            }
        }

        private void BtnSupprimerFac_Click(object sender, RoutedEventArgs e)
        {
            if (dtgFac.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une facture");
            }

            else
            {
                bdd.DeleteFac(Convert.ToInt32(TxtIdFac.Text));
                lesFacture.Remove((Facture)dtgFac.SelectedItem);
                //On préselectionne par défaut le premier élément du Datagrid après la suppression
                dtgFac.SelectedIndex = 0;
                dtgFac.Items.Refresh();
            }
        }

        private void dtgLigneFac_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LigneFacture selectedLigneFacture = dtgLigneFac.SelectedItem as LigneFacture;

            if (selectedLigneFacture != null)
            {
                try
                {
                    TxtIdLigneFac.Text = Convert.ToString(selectedLigneFacture.IdLigneFac);
                    CboProduitLigneFac.SelectedValue = selectedLigneFacture.IdProd;
                    CboFactureLigneFac.SelectedValue = selectedLigneFacture.IdFac;
                    TxtQteLigneFac.Text = Convert.ToString(selectedLigneFacture.Qte);
                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur sur la mise à jour du formulaire lors du changement dans le Datagrid dtgLigneFac");
                }
            }
        }

        private void BtnAjouterLigneFac_Click(object sender, RoutedEventArgs e)
        {

            Facture selectedFacture = dtgFac.SelectedItem as Facture;

            if(selectedFacture != null)
            {
                if (CboProduitLigneFac.SelectedIndex != -1)
                {
                    try
                    {
                        bdd.InsertLigneFac(Convert.ToInt32(selectedFacture.IdFac), Convert.ToInt32(CboProduitLigneFac.SelectedValue), Convert.ToInt32(TxtQteLigneFac.Text));

                        lesLigneFacture.Clear();
                        lesLigneFacture = bdd.SelectLigneFacById(selectedFacture.IdFac);
                        lesLigneFacture.Sort((x, y) => 1 * x.IdLigneFac.CompareTo(y.IdLigneFac));
                        dtgLigneFac.ItemsSource = lesLigneFacture;
                        dtgFac.Items.Refresh();

                        lesFacture.Clear();
                        lesFacture = bdd.SelectFac();
                        lesFacture.Sort((x, y) => 1 * x.IdFac.CompareTo(y.IdFac));
                        dtgFac.ItemsSource = lesFacture;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Veuillez sélectionner une quantitée valide");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un produit");
                }
                
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une facture");
            }
            
        }

        private void BtnModifierLigneFac_Click(object sender, RoutedEventArgs e)
        {
            if (dtgLigneFac.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un LigneFacture");
            }

            else
            {
                bdd.UpdateLigneFac(Convert.ToInt32(TxtIdLigneFac.Text), Convert.ToInt32(CboFactureLigneFac.SelectedValue), Convert.ToInt32(CboProduitLigneFac.SelectedValue), Convert.ToInt32(TxtQteLigneFac.Text));

                //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
                int indice = lesLigneFacture.IndexOf((LigneFacture)dtgLigneFac.SelectedItem);

                // On change les propritétés de l'objet à l'indice trouvé.
                lesLigneFacture.ElementAt(indice).IdProd = Convert.ToInt32(CboProduitLigneFac.SelectedValue);
                lesLigneFacture.ElementAt(indice).Qte = Convert.ToInt32(TxtQteLigneFac.Text);

                dtgLigneFac.Items.Refresh();

                lesFacture.Clear();
                lesFacture = bdd.SelectFac();
                lesFacture.Sort((x, y) => 1 * x.IdFac.CompareTo(y.IdFac));
                dtgFac.ItemsSource = lesFacture;
            }
        }

        private void BtnSupprimerLigneFac_Click(object sender, RoutedEventArgs e)
        {
            if (dtgLigneFac.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne facture");
            }

            else
            {
                bdd.DeleteLigneFac(Convert.ToInt32(TxtIdLigneFac.Text));
                lesLigneFacture.Remove((LigneFacture)dtgLigneFac.SelectedItem);
                //On préselectionne par défaut le premier élément du Datagrid après la suppression
                dtgLigneFac.SelectedIndex = 0;
                dtgLigneFac.Items.Refresh();

                lesFacture.Clear();
                lesFacture = bdd.SelectFac();
                lesFacture.Sort((x, y) => 1 * x.IdFac.CompareTo(y.IdFac));
                dtgFac.ItemsSource = lesFacture;
            }
        }
    }
}
