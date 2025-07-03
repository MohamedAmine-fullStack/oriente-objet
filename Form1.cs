using System;
using System.Windows.Forms;

namespace calculAndChange
{
    public partial class Form1 : Form
    {
        // Déclaration des variables pour les calculatrices
        private Standard calculatriceStandard = null;
        private Scientifique versionScientifique = null;
        private EnLigneChange currencyChange = null;
        private adminChange adminChangeManagement = null;
        private LocalChange localChangeMaps = null;

        // Déclaration d'un ToolStripStatusLabel pour afficher les messages dans le StatusStrip
        private ToolStripStatusLabel statusLabel;
        private Standard versionStandard;

        public Form1()
        {
            InitializeComponent();
            // Initialisation du ToolStripStatusLabel
            statusLabel = new ToolStripStatusLabel();
            statusStrip1.Items.Add(statusLabel);  // Ajout du label au StatusStrip
        }

        // Méthode pour ouvrir la calculatrice standard
        private void versionStandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Effacer le texte précédent (le texte initial par exemple)
            statusLabel.Text = string.Empty; // Vide le texte précédent

            // Vérifier si l'instance de la calculatrice est déjà ouverte
            if (calculatriceStandard != null && !calculatriceStandard.IsDisposed)
            {
                MessageBox.Show("La calculatrice standard est déjà ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                calculatriceStandard = new Standard();
                calculatriceStandard.Show();
                statusLabel.Text = "Calculatrice Standard Ouverte";  // Mise à jour du status
            }
        }

        // Méthode pour ouvrir la calculatrice scientifique
        private void versionScientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            statusLabel.Text = string.Empty;

            // Vérifier si l'instance de la calculatrice est déjà ouverte
            if (versionScientifique != null && !versionScientifique.IsDisposed)
            {
                MessageBox.Show("La calculatrice scientifique est déjà ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                versionScientifique = new Scientifique();
                versionScientifique.Show();
                statusLabel.Text = "Calculatrice Scientifique Ouverte";  // Mise à jour du status
            }
        }

        // Méthode pour ouvrir le bureau de change local
        private void bureauChangeToolStripMenuItemLocal_Click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            statusLabel.Text = string.Empty;

            // Vérifier si l'instance de la calculatrice est déjà ouverte
            if (currencyChange != null && !currencyChange.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change est déjà ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                currencyChange = new EnLigneChange();
                currencyChange.Show();
                statusLabel.Text = "Bureau de change Ouvert";  // Mise à jour du status
            }
        }
        private void versionLocaToolStripMenuItem_click(object sender, EventArgs e)
        {
            statusLabel.Text = string.Empty;

            // Vérifier si l'instance de la calculatrice est déjà ouverte
            if (localChangeMaps != null && !localChangeMaps.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change local est déjà ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                localChangeMaps = new LocalChange();
                localChangeMaps.Show();
                statusLabel.Text = "Bureau de change local est  Ouvert";  // Mise à jour du status
            }
        }
        private void adminManagement_Click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            statusLabel.Text = string.Empty;

            // Vérifier si l'instance de la calculatrice est déjà ouverte
            if (adminChangeManagement != null && !adminChangeManagement.IsDisposed)
            {
                MessageBox.Show(" Gestion des pays est déjà ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                adminChangeManagement = new adminChange();
                adminChangeManagement.Show();
                statusLabel.Text = "Gestion des pays  ouvert";  // Mise à jour du status
            }
        }


        // Méthode pour fermer l'application
        private void quitterPrograme_click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            statusLabel.Text = string.Empty;

            statusLabel.Text = "Fermeture de l'application";  // Mise à jour du status
            Application.Exit();  // Fermer l'application
        }

        // Méthode pour afficher/masquer la ToolStrip
        private void tool_click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            statusLabel.Text = string.Empty;

            if (toolbarToolStripMenuItem.Checked)
            {
                toolbarToolStripMenuItem.Checked = false;
                toolStrip1.Visible = false;
                statusLabel.Text = "Toolbar Fermée";  // Mise à jour du status
            }
            else
            {
                toolbarToolStripMenuItem.Checked = true;
                toolStrip1.Visible = true;
                statusLabel.Text = "Toolbar Active";  // Mise à jour du status
            }
        }

        // Méthode pour afficher/masquer la StatusStrip
        private void status_click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            statusLabel.Text = string.Empty;

            if (statusBarToolStripMenuItem.Checked)
            {
                statusBarToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
                statusLabel.Text = "Status Bar Fermée";  // Mise à jour du status
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
                statusLabel.Text = "Status Bar Active";  // Mise à jour du status
            }
        }
        private void calc_stand_click(object sender, EventArgs e)
        {
            if (versionStandard != null && !versionStandard.IsDisposed)
            {
                MessageBox.Show("La calculatrice scientifique est déjà ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                versionStandard = new Standard();
                versionStandard.Show();
                statusLabel.Text = "Calculatrice Scientifique Ouverte";  // Mise à jour du status
            }
        }
        private void calc_stnf_click(object sender, EventArgs e)
        {
            if (versionScientifique != null && !versionScientifique.IsDisposed)
            {
                MessageBox.Show("La calculatrice scientifique est déjà ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                versionScientifique = new Scientifique();
                versionScientifique.Show();
                statusLabel.Text = "Calculatrice Scientifique Ouverte";  // Mise à jour du status
            }
        }
        private void bur_local_click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            statusLabel.Text = string.Empty;
            if(localChangeMaps != null && !localChangeMaps.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change est déjà ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                localChangeMaps = new LocalChange();
                localChangeMaps.Show();
                statusLabel.Text = "Bureau de Change Version Local Ouvert";  // Mise à jour du status
            }


        }

        // Méthode pour ouvrir le bureau de change en ligne
        private void bur_ligne_click(object sender, EventArgs e)
        {
            // Effacer le texte précédent
            if (currencyChange != null && !currencyChange.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change est déjà ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Créer et afficher une nouvelle instance
                currencyChange = new EnLigneChange();
                currencyChange.Show();
                statusLabel.Text = "Bureau de change Ouvert";  // Mise à jour du status
            }
        }

        private void manuele_click(object sender, EventArgs e)
        {
            MessageBox.Show("Manuel d'utilisateur\r\n Pour Accéder à la calculatrice\r\n1 : Ouvrez le menu Program.\r\n2: Cliquez sur Calculatrice.\r\n 3: Sélectionnez la version souhaitée : Standard ou Scientifique.\r\nPour Accéder au bureau de change\r\n1: Ouvrez le menu Program.\r\n2: Cliquez sur Bureau de change.\r\n3: Sélectionnez la version désirée : En ligne ou Locale.\r\nPour Quitter le programme\r\nPour quitter l'application, vous pouvez soit :\r\nAppuyer sur CTRL + X,\r\nOu aller dans Program et cliquer sur le bouton Quitter Program.\r\nSection des Views\r\nDans cette section, vous pouvez personnaliser votre interface :\r\n\r\nVous pouvez cocher ou décocher la toolbar.\r\nAllez dans le bouton View pour sélectionner les options que vous souhaitez.\r\nDans la toolbar, vous trouverez plusieurs outils :\r\n\r\nCalculatrice : Accédez à la version Standard ou Scientifique.\r\nBureau de change : Sélectionnez la version Locale ou En ligne.");
        }
        private void Apropo_click(object sender, EventArgs e)
        {
            MessageBox.Show("À propos\r\nBienvenue dans l'application AIDD. Ce programme est conçu pour offrir des outils pratiques à ses utilisateurs, comprenant une calculatrice scientifique et une calculatrice standard. De plus, nous proposons un bureau de change avec deux versions : locale et en ligne. Ces outils sont à votre disposition dans des versions adaptées à différents besoins, et peuvent être facilement accessibles à partir du menu principal.\r\nCopyright Collège.");
        }
        // Méthode de chargement du formulaire
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialiser le texte à vide, pour éviter de garder le texte initial une fois que l'application est lancée.
            statusLabel.Text = string.Empty;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
