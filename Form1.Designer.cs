
namespace calculAndChange
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            programmesToolStripMenuItem = new ToolStripMenuItem();
            calculatriceToolStripMenuItem = new ToolStripMenuItem();
            versionStandardToolStripMenuItem = new ToolStripMenuItem();
            versionScientifiqueToolStripMenuItem = new ToolStripMenuItem();
            bureauChangeToolStripMenuItem = new ToolStripMenuItem();
            versionLocalToolStripMenuItem = new ToolStripMenuItem();
            GuichetToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            versionEnLigneToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitterProgrammeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolbarToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            manuelUtilisateurToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { programmesToolStripMenuItem, viewToolStripMenuItem, aideToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            programmesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculatriceToolStripMenuItem, bureauChangeToolStripMenuItem, toolStripSeparator1, quitterProgrammeToolStripMenuItem });
            programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            resources.ApplyResources(programmesToolStripMenuItem, "programmesToolStripMenuItem");
            // 
            // calculatriceToolStripMenuItem
            // 
            calculatriceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { versionStandardToolStripMenuItem, versionScientifiqueToolStripMenuItem });
            resources.ApplyResources(calculatriceToolStripMenuItem, "calculatriceToolStripMenuItem");
            calculatriceToolStripMenuItem.Name = "calculatriceToolStripMenuItem";
            // 
            // versionStandardToolStripMenuItem
            // 
            versionStandardToolStripMenuItem.Name = "versionStandardToolStripMenuItem";
            resources.ApplyResources(versionStandardToolStripMenuItem, "versionStandardToolStripMenuItem");
            versionStandardToolStripMenuItem.Click += versionStandardToolStripMenuItem_Click;
            // 
            // versionScientifiqueToolStripMenuItem
            // 
            versionScientifiqueToolStripMenuItem.Name = "versionScientifiqueToolStripMenuItem";
            resources.ApplyResources(versionScientifiqueToolStripMenuItem, "versionScientifiqueToolStripMenuItem");
            versionScientifiqueToolStripMenuItem.Click += versionScientifiqueToolStripMenuItem_Click;
            // 
            // bureauChangeToolStripMenuItem
            // 
            bureauChangeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { versionLocalToolStripMenuItem, versionEnLigneToolStripMenuItem });
            resources.ApplyResources(bureauChangeToolStripMenuItem, "bureauChangeToolStripMenuItem");
            bureauChangeToolStripMenuItem.Name = "bureauChangeToolStripMenuItem";
            // 
            // versionLocalToolStripMenuItem
            // 
            versionLocalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GuichetToolStripMenuItem, adminToolStripMenuItem });
            versionLocalToolStripMenuItem.Name = "versionLocalToolStripMenuItem";
            resources.ApplyResources(versionLocalToolStripMenuItem, "versionLocalToolStripMenuItem");
            // 
            // GuichetToolStripMenuItem
            // 
            GuichetToolStripMenuItem.Name = "GuichetToolStripMenuItem";
            resources.ApplyResources(GuichetToolStripMenuItem, "GuichetToolStripMenuItem");
            GuichetToolStripMenuItem.Click += bureauChangeToolStripMenuItemLocal_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            resources.ApplyResources(adminToolStripMenuItem, "adminToolStripMenuItem");
            adminToolStripMenuItem.Click += adminManagement_Click;
            // 
            // versionEnLigneToolStripMenuItem
            // 
            versionEnLigneToolStripMenuItem.Name = "versionEnLigneToolStripMenuItem";
            resources.ApplyResources(versionEnLigneToolStripMenuItem, "versionEnLigneToolStripMenuItem");
            versionEnLigneToolStripMenuItem.Click += versionLocaToolStripMenuItem_click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // quitterProgrammeToolStripMenuItem
            // 
            quitterProgrammeToolStripMenuItem.Name = "quitterProgrammeToolStripMenuItem";
            resources.ApplyResources(quitterProgrammeToolStripMenuItem, "quitterProgrammeToolStripMenuItem");
            quitterProgrammeToolStripMenuItem.Click += quitterPrograme_click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolbarToolStripMenuItem, statusBarToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // toolbarToolStripMenuItem
            // 
            toolbarToolStripMenuItem.Checked = true;
            toolbarToolStripMenuItem.CheckState = CheckState.Checked;
            toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            resources.ApplyResources(toolbarToolStripMenuItem, "toolbarToolStripMenuItem");
            toolbarToolStripMenuItem.Click += tool_click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            resources.ApplyResources(statusBarToolStripMenuItem, "statusBarToolStripMenuItem");
            statusBarToolStripMenuItem.Click += status_click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manuelUtilisateurToolStripMenuItem, toolStripSeparator2, aProposToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            resources.ApplyResources(aideToolStripMenuItem, "aideToolStripMenuItem");
            // 
            // manuelUtilisateurToolStripMenuItem
            // 
            resources.ApplyResources(manuelUtilisateurToolStripMenuItem, "manuelUtilisateurToolStripMenuItem");
            manuelUtilisateurToolStripMenuItem.Name = "manuelUtilisateurToolStripMenuItem";
            manuelUtilisateurToolStripMenuItem.Click += manuele_click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            resources.ApplyResources(aProposToolStripMenuItem, "aProposToolStripMenuItem");
            aProposToolStripMenuItem.Click += Apropo_click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator3, toolStripSeparator4, toolStripButton4 });
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Click += calc_stand_click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton2, "toolStripButton2");
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Click += calc_stnf_click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton3, "toolStripButton3");
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Click += bur_local_click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(toolStripButton4, "toolStripButton4");
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Click += bur_ligne_click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Silver;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Form1_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programmesToolStripMenuItem;
        private ToolStripMenuItem calculatriceToolStripMenuItem;
        private ToolStripMenuItem versionStandardToolStripMenuItem;
        private ToolStripMenuItem versionScientifiqueToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem bureauChangeToolStripMenuItem;
        private ToolStripMenuItem versionLocalToolStripMenuItem;
        private ToolStripMenuItem versionEnLigneToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterProgrammeToolStripMenuItem;
        private ToolStripMenuItem toolbarToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem manuelUtilisateurToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem GuichetToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
    }
}
