
namespace calculAndChange
{
    partial class adminChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            CountryList = new ListBox();
            label3 = new Label();
            panel2 = new Panel();
            NumberCoun = new Label();
            Ann = new Button();
            Delete = new Button();
            Sauv = new Button();
            Edite = new Button();
            Add = new Button();
            textVal = new Label();
            Val = new TextBox();
            Curren = new TextBox();
            CountryName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 69);
            label2.Name = "label2";
            label2.Size = new Size(450, 34);
            label2.TabIndex = 8;
            label2.Text = "Bureau De Changes International";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(497, 60);
            label1.TabIndex = 7;
            label1.Text = "BANQUE DE TORONTO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(CountryList);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 394);
            panel1.TabIndex = 9;
            // 
            // CountryList
            // 
            CountryList.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CountryList.FormattingEnabled = true;
            CountryList.ItemHeight = 23;
            CountryList.Location = new Point(12, 75);
            CountryList.Name = "CountryList";
            CountryList.Size = new Size(244, 280);
            CountryList.TabIndex = 1;
            CountryList.SelectedIndexChanged += CountryList_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(190, 31);
            label3.TabIndex = 0;
            label3.Text = "Choisir Un Pays :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(NumberCoun);
            panel2.Controls.Add(Ann);
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(Sauv);
            panel2.Controls.Add(Edite);
            panel2.Controls.Add(Add);
            panel2.Controls.Add(textVal);
            panel2.Controls.Add(Val);
            panel2.Controls.Add(Curren);
            panel2.Controls.Add(CountryName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(316, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 394);
            panel2.TabIndex = 10;
            // 
            // NumberCoun
            // 
            NumberCoun.AutoSize = true;
            NumberCoun.BorderStyle = BorderStyle.FixedSingle;
            NumberCoun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumberCoun.ForeColor = Color.Blue;
            NumberCoun.Location = new Point(185, 320);
            NumberCoun.Name = "NumberCoun";
            NumberCoun.Padding = new Padding(16, 4, 16, 4);
            NumberCoun.Size = new Size(259, 38);
            NumberCoun.TabIndex = 14;
            NumberCoun.Text = "Pays 3 sur un Total de 60";
            // 
            // Ann
            // 
            Ann.BackColor = Color.Black;
            Ann.BackgroundImageLayout = ImageLayout.None;
            Ann.FlatStyle = FlatStyle.Flat;
            Ann.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ann.ForeColor = Color.FromArgb(0, 192, 0);
            Ann.Location = new Point(616, 320);
            Ann.Margin = new Padding(0);
            Ann.Name = "Ann";
            Ann.Size = new Size(192, 33);
            Ann.TabIndex = 13;
            Ann.Text = "Annuler";
            Ann.UseVisualStyleBackColor = false;
            Ann.Click += Ann_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Black;
            Delete.BackgroundImageLayout = ImageLayout.None;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.FromArgb(0, 192, 0);
            Delete.Location = new Point(616, 222);
            Delete.Margin = new Padding(0);
            Delete.Name = "Delete";
            Delete.Size = new Size(192, 33);
            Delete.TabIndex = 12;
            Delete.Text = "Supprimer";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Sauv
            // 
            Sauv.BackColor = Color.Black;
            Sauv.BackgroundImageLayout = ImageLayout.None;
            Sauv.FlatStyle = FlatStyle.Flat;
            Sauv.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sauv.ForeColor = Color.FromArgb(0, 192, 0);
            Sauv.Location = new Point(616, 269);
            Sauv.Margin = new Padding(0);
            Sauv.Name = "Sauv";
            Sauv.Size = new Size(192, 33);
            Sauv.TabIndex = 11;
            Sauv.Text = "Sauvegarder";
            Sauv.UseVisualStyleBackColor = false;
            Sauv.Click += Sauv_Click;
            // 
            // Edite
            // 
            Edite.BackColor = Color.Black;
            Edite.BackgroundImageLayout = ImageLayout.None;
            Edite.FlatStyle = FlatStyle.Flat;
            Edite.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edite.ForeColor = Color.FromArgb(0, 192, 0);
            Edite.Location = new Point(616, 174);
            Edite.Margin = new Padding(0);
            Edite.Name = "Edite";
            Edite.Size = new Size(192, 33);
            Edite.TabIndex = 10;
            Edite.Text = "Modifier";
            Edite.UseVisualStyleBackColor = false;
            Edite.Click += Edite_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.Black;
            Add.BackgroundImageLayout = ImageLayout.None;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.FromArgb(0, 192, 0);
            Add.Location = new Point(616, 131);
            Add.Margin = new Padding(0);
            Add.Name = "Add";
            Add.Size = new Size(192, 33);
            Add.TabIndex = 9;
            Add.Text = "Ajouter";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // textVal
            // 
            textVal.AutoSize = true;
            textVal.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic);
            textVal.ForeColor = SystemColors.ActiveCaptionText;
            textVal.Location = new Point(277, 233);
            textVal.Name = "textVal";
            textVal.Size = new Size(181, 22);
            textVal.TabIndex = 8;
            textVal.Text = "par rapport a 1 can dollar";
            // 
            // Val
            // 
            Val.Font = new Font("Arial", 10.8F);
            Val.ForeColor = Color.Red;
            Val.Location = new Point(139, 227);
            Val.Name = "Val";
            Val.Size = new Size(132, 28);
            Val.TabIndex = 7;
            Val.Text = "gf";
            // 
            // Curren
            // 
            Curren.Font = new Font("Arial", 10.8F);
            Curren.ForeColor = Color.Red;
            Curren.Location = new Point(139, 179);
            Curren.Name = "Curren";
            Curren.Size = new Size(441, 28);
            Curren.TabIndex = 6;
            Curren.Text = "gf";
            // 
            // CountryName
            // 
            CountryName.Font = new Font("Arial", 10.8F);
            CountryName.ForeColor = Color.Red;
            CountryName.Location = new Point(139, 131);
            CountryName.Name = "CountryName";
            CountryName.Size = new Size(441, 28);
            CountryName.TabIndex = 5;
            CountryName.Text = "gf";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(24, 131);
            label7.Name = "label7";
            label7.Size = new Size(109, 22);
            label7.TabIndex = 4;
            label7.Text = "Nom De Pays :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(24, 179);
            label6.Name = "label6";
            label6.Size = new Size(82, 22);
            label6.TabIndex = 3;
            label6.Text = "Monnaie  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(24, 233);
            label5.Name = "label5";
            label5.Size = new Size(62, 22);
            label5.TabIndex = 2;
            label5.Text = "Valeur :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(24, 12);
            label4.Name = "label4";
            label4.Size = new Size(303, 31);
            label4.TabIndex = 1;
            label4.Text = "Information Sur pays Choisi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(86, 75);
            label8.Name = "label8";
            label8.Size = new Size(667, 25);
            label8.TabIndex = 15;
            label8.Text = "Note : Utilisez une virgule (,) pour les décimales. Un point (.) provoquera une erreur.";
            // 
            // adminChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(1150, 547);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "adminChange";
            Text = "Gestion Bureau De Change";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private ListBox CountryList;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox CountryName;
        private Label textVal;
        private TextBox Val;
        private TextBox Curren;
        private Button Add;
        private Button Ann;
        private Button Delete;
        private Button Sauv;
        private Button Edite;
        private Label NumberCoun;
        private Label label8;
    }
}