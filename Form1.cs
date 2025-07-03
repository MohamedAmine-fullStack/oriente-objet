using System;
using System.Windows.Forms;

namespace calculAndChange
{
    public partial class Form1 : Form
    {
        // D�claration des variables pour les calculatrices
        private Standard calculatriceStandard = null;
        private Scientifique versionScientifique = null;
        private EnLigneChange currencyChange = null;
        private adminChange adminChangeManagement = null;
        private LocalChange localChangeMaps = null;

        // D�claration d'un ToolStripStatusLabel pour afficher les messages dans le StatusStrip
        private ToolStripStatusLabel statusLabel;
        private Standard versionStandard;

        public Form1()
        {
            InitializeComponent();
            // Initialisation du ToolStripStatusLabel
            statusLabel = new ToolStripStatusLabel();
            statusStrip1.Items.Add(statusLabel);  // Ajout du label au StatusStrip
        }

        // M�thode pour ouvrir la calculatrice standard
        private void versionStandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent (le texte initial par exemple)
            statusLabel.Text = string.Empty; // Vide le texte pr�c�dent

            // V�rifier si l'instance de la calculatrice est d�j� ouverte
            if (calculatriceStandard != null && !calculatriceStandard.IsDisposed)
            {
                MessageBox.Show("La calculatrice standard est d�j� ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                calculatriceStandard = new Standard();
                calculatriceStandard.Show();
                statusLabel.Text = "Calculatrice Standard Ouverte";  // Mise � jour du status
            }
        }

        // M�thode pour ouvrir la calculatrice scientifique
        private void versionScientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            statusLabel.Text = string.Empty;

            // V�rifier si l'instance de la calculatrice est d�j� ouverte
            if (versionScientifique != null && !versionScientifique.IsDisposed)
            {
                MessageBox.Show("La calculatrice scientifique est d�j� ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                versionScientifique = new Scientifique();
                versionScientifique.Show();
                statusLabel.Text = "Calculatrice Scientifique Ouverte";  // Mise � jour du status
            }
        }

        // M�thode pour ouvrir le bureau de change local
        private void bureauChangeToolStripMenuItemLocal_Click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            statusLabel.Text = string.Empty;

            // V�rifier si l'instance de la calculatrice est d�j� ouverte
            if (currencyChange != null && !currencyChange.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change est d�j� ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                currencyChange = new EnLigneChange();
                currencyChange.Show();
                statusLabel.Text = "Bureau de change Ouvert";  // Mise � jour du status
            }
        }
        private void versionLocaToolStripMenuItem_click(object sender, EventArgs e)
        {
            statusLabel.Text = string.Empty;

            // V�rifier si l'instance de la calculatrice est d�j� ouverte
            if (localChangeMaps != null && !localChangeMaps.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change local est d�j� ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                localChangeMaps = new LocalChange();
                localChangeMaps.Show();
                statusLabel.Text = "Bureau de change local est  Ouvert";  // Mise � jour du status
            }
        }
        private void adminManagement_Click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            statusLabel.Text = string.Empty;

            // V�rifier si l'instance de la calculatrice est d�j� ouverte
            if (adminChangeManagement != null && !adminChangeManagement.IsDisposed)
            {
                MessageBox.Show(" Gestion des pays est d�j� ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                adminChangeManagement = new adminChange();
                adminChangeManagement.Show();
                statusLabel.Text = "Gestion des pays  ouvert";  // Mise � jour du status
            }
        }


        // M�thode pour fermer l'application
        private void quitterPrograme_click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            statusLabel.Text = string.Empty;

            statusLabel.Text = "Fermeture de l'application";  // Mise � jour du status
            Application.Exit();  // Fermer l'application
        }

        // M�thode pour afficher/masquer la ToolStrip
        private void tool_click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            statusLabel.Text = string.Empty;

            if (toolbarToolStripMenuItem.Checked)
            {
                toolbarToolStripMenuItem.Checked = false;
                toolStrip1.Visible = false;
                statusLabel.Text = "Toolbar Ferm�e";  // Mise � jour du status
            }
            else
            {
                toolbarToolStripMenuItem.Checked = true;
                toolStrip1.Visible = true;
                statusLabel.Text = "Toolbar Active";  // Mise � jour du status
            }
        }

        // M�thode pour afficher/masquer la StatusStrip
        private void status_click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            statusLabel.Text = string.Empty;

            if (statusBarToolStripMenuItem.Checked)
            {
                statusBarToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
                statusLabel.Text = "Status Bar Ferm�e";  // Mise � jour du status
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
                statusLabel.Text = "Status Bar Active";  // Mise � jour du status
            }
        }
        private void calc_stand_click(object sender, EventArgs e)
        {
            if (versionStandard != null && !versionStandard.IsDisposed)
            {
                MessageBox.Show("La calculatrice scientifique est d�j� ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                versionStandard = new Standard();
                versionStandard.Show();
                statusLabel.Text = "Calculatrice Scientifique Ouverte";  // Mise � jour du status
            }
        }
        private void calc_stnf_click(object sender, EventArgs e)
        {
            if (versionScientifique != null && !versionScientifique.IsDisposed)
            {
                MessageBox.Show("La calculatrice scientifique est d�j� ouverte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                versionScientifique = new Scientifique();
                versionScientifique.Show();
                statusLabel.Text = "Calculatrice Scientifique Ouverte";  // Mise � jour du status
            }
        }
        private void bur_local_click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            statusLabel.Text = string.Empty;
            if(localChangeMaps != null && !localChangeMaps.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change est d�j� ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                localChangeMaps = new LocalChange();
                localChangeMaps.Show();
                statusLabel.Text = "Bureau de Change Version Local Ouvert";  // Mise � jour du status
            }


        }

        // M�thode pour ouvrir le bureau de change en ligne
        private void bur_ligne_click(object sender, EventArgs e)
        {
            // Effacer le texte pr�c�dent
            if (currencyChange != null && !currencyChange.IsDisposed)
            {
                MessageBox.Show(" le Bureau de change est d�j� ouvert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cr�er et afficher une nouvelle instance
                currencyChange = new EnLigneChange();
                currencyChange.Show();
                statusLabel.Text = "Bureau de change Ouvert";  // Mise � jour du status
            }
        }

        private void manuele_click(object sender, EventArgs e)
        {
            MessageBox.Show("Manuel d'utilisateur\r\n Pour Acc�der � la calculatrice\r\n1 : Ouvrez le menu Program.\r\n2: Cliquez sur Calculatrice.\r\n 3: S�lectionnez la version souhait�e : Standard ou Scientifique.\r\nPour Acc�der au bureau de change\r\n1: Ouvrez le menu Program.\r\n2: Cliquez sur Bureau de change.\r\n3: S�lectionnez la version d�sir�e : En ligne ou Locale.\r\nPour Quitter le programme\r\nPour quitter l'application, vous pouvez soit :\r\nAppuyer sur CTRL + X,\r\nOu aller dans Program et cliquer sur le bouton Quitter Program.\r\nSection des Views\r\nDans cette section, vous pouvez personnaliser votre interface :\r\n\r\nVous pouvez cocher ou d�cocher la toolbar.\r\nAllez dans le bouton View pour s�lectionner les options que vous souhaitez.\r\nDans la toolbar, vous trouverez plusieurs outils :\r\n\r\nCalculatrice : Acc�dez � la version Standard ou Scientifique.\r\nBureau de change : S�lectionnez la version Locale ou En ligne.");
        }
        private void Apropo_click(object sender, EventArgs e)
        {
            MessageBox.Show("� propos\r\nBienvenue dans l'application AIDD. Ce programme est con�u pour offrir des outils pratiques � ses utilisateurs, comprenant une calculatrice scientifique et une calculatrice standard. De plus, nous proposons un bureau de change avec deux versions : locale et en ligne. Ces outils sont � votre disposition dans des versions adapt�es � diff�rents besoins, et peuvent �tre facilement accessibles � partir du menu principal.\r\nCopyright Coll�ge.");
        }
        // M�thode de chargement du formulaire
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialiser le texte � vide, pour �viter de garder le texte initial une fois que l'application est lanc�e.
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
