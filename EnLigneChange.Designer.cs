
namespace calculAndChange
{
    partial class EnLigneChange
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
        /// </sum
        /// mary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnLigneChange));
            panel1 = new Panel();
            label6 = new Label();
            EditionMode = new Label();
            label3 = new Label();
            ReplayModel = new Button();
            CloseModel = new Button();
            panel4 = new Panel();
            label9 = new Label();
            label8 = new Label();
            currencyName = new Label();
            displayOutput = new Label();
            ApplyCalc = new Button();
            calcMontDev = new Label();
            montantInput = new TextBox();
            panel3 = new Panel();
            label7 = new Label();
            radioCurrencyI = new RadioButton();
            radioCurrencyN = new RadioButton();
            panel2 = new Panel();
            currencyMI = new Label();
            currencyMN = new Label();
            label5 = new Label();
            countryList = new ComboBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EditionMode);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ReplayModel);
            panel1.Controls.Add(CloseModel);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(countryList);
            panel1.Location = new Point(12, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 686);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(14, 110);
            label6.Name = "label6";
            label6.Size = new Size(175, 28);
            label6.TabIndex = 17;
            label6.Text = "Choisir Votre Pays";
            // 
            // EditionMode
            // 
            EditionMode.AutoSize = true;
            EditionMode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EditionMode.ForeColor = SystemColors.ControlDarkDark;
            EditionMode.Location = new Point(175, 56);
            EditionMode.Name = "EditionMode";
            EditionMode.Size = new Size(0, 28);
            EditionMode.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(450, 28);
            label3.TabIndex = 14;
            label3.Text = "Programme De Change Avec Le Dollar Canadien";
            // 
            // ReplayModel
            // 
            ReplayModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ReplayModel.ForeColor = SystemColors.ActiveCaptionText;
            ReplayModel.Location = new Point(175, 626);
            ReplayModel.Name = "ReplayModel";
            ReplayModel.Size = new Size(128, 38);
            ReplayModel.TabIndex = 13;
            ReplayModel.Text = "Recomencer";
            ReplayModel.UseVisualStyleBackColor = true;
            ReplayModel.Click += replayModel_click;
            // 
            // CloseModel
            // 
            CloseModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CloseModel.ForeColor = SystemColors.ActiveCaptionText;
            CloseModel.Location = new Point(495, 626);
            CloseModel.Name = "CloseModel";
            CloseModel.Size = new Size(128, 38);
            CloseModel.TabIndex = 12;
            CloseModel.Text = "Fermer";
            CloseModel.UseVisualStyleBackColor = true;
            CloseModel.Click += CloseModel_click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(currencyName);
            panel4.Controls.Add(displayOutput);
            panel4.Controls.Add(ApplyCalc);
            panel4.Controls.Add(calcMontDev);
            panel4.Controls.Add(montantInput);
            panel4.Location = new Point(14, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(846, 168);
            panel4.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(63, 46);
            label9.Name = "label9";
            label9.Size = new Size(177, 28);
            label9.TabIndex = 18;
            label9.Text = "Entrer Le Montant";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(12, 14);
            label8.Name = "label8";
            label8.Size = new Size(235, 28);
            label8.TabIndex = 17;
            label8.Text = "Appliquer La Conversion";
            // 
            // currencyName
            // 
            currencyName.AutoSize = true;
            currencyName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 238);
            currencyName.ForeColor = SystemColors.ActiveCaptionText;
            currencyName.Location = new Point(407, 44);
            currencyName.Name = "currencyName";
            currencyName.Size = new Size(0, 31);
            currencyName.TabIndex = 10;
            // 
            // displayOutput
            // 
            displayOutput.AutoSize = true;
            displayOutput.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            displayOutput.ForeColor = SystemColors.ActiveCaptionText;
            displayOutput.Location = new Point(257, 101);
            displayOutput.Name = "displayOutput";
            displayOutput.Size = new Size(0, 31);
            displayOutput.TabIndex = 9;
            displayOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ApplyCalc
            // 
            ApplyCalc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ApplyCalc.ForeColor = SystemColors.ActiveCaptionText;
            ApplyCalc.Location = new Point(63, 101);
            ApplyCalc.Name = "ApplyCalc";
            ApplyCalc.Size = new Size(128, 38);
            ApplyCalc.TabIndex = 8;
            ApplyCalc.Text = "Convertir >>";
            ApplyCalc.UseVisualStyleBackColor = true;
            ApplyCalc.Click += ApplyCalc_Click;
            // 
            // calcMontDev
            // 
            calcMontDev.Location = new Point(0, 0);
            calcMontDev.Name = "calcMontDev";
            calcMontDev.Size = new Size(100, 23);
            calcMontDev.TabIndex = 19;
            // 
            // montantInput
            // 
            montantInput.ForeColor = Color.Red;
            montantInput.Location = new Point(268, 44);
            montantInput.Name = "montantInput";
            montantInput.PlaceholderText = "Montant";
            montantInput.Size = new Size(133, 30);
            montantInput.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(radioCurrencyI);
            panel3.Controls.Add(radioCurrencyN);
            panel3.Location = new Point(14, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(846, 125);
            panel3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 17);
            label7.Name = "label7";
            label7.Size = new Size(203, 28);
            label7.TabIndex = 18;
            label7.Text = "Types De Conversion";
            // 
            // radioCurrencyI
            // 
            radioCurrencyI.AutoSize = true;
            radioCurrencyI.Font = new Font("Segoe UI", 12F);
            radioCurrencyI.ForeColor = Color.Red;
            radioCurrencyI.Location = new Point(42, 76);
            radioCurrencyI.Name = "radioCurrencyI";
            radioCurrencyI.Size = new Size(17, 16);
            radioCurrencyI.TabIndex = 5;
            radioCurrencyI.TabStop = true;
            radioCurrencyI.UseVisualStyleBackColor = true;
            // 
            // radioCurrencyN
            // 
            radioCurrencyN.AutoSize = true;
            radioCurrencyN.Font = new Font("Segoe UI", 12F);
            radioCurrencyN.ForeColor = Color.Red;
            radioCurrencyN.Location = new Point(42, 43);
            radioCurrencyN.Name = "radioCurrencyN";
            radioCurrencyN.Size = new Size(17, 16);
            radioCurrencyN.TabIndex = 4;
            radioCurrencyN.TabStop = true;
            radioCurrencyN.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(currencyMI);
            panel2.Controls.Add(currencyMN);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(368, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 125);
            panel2.TabIndex = 6;
            // 
            // currencyMI
            // 
            currencyMI.AutoSize = true;
            currencyMI.Font = new Font("Segoe UI", 13.8F);
            currencyMI.ForeColor = Color.FromArgb(192, 0, 0);
            currencyMI.Location = new Point(143, 83);
            currencyMI.Name = "currencyMI";
            currencyMI.Size = new Size(0, 31);
            currencyMI.TabIndex = 18;
            // 
            // currencyMN
            // 
            currencyMN.AutoSize = true;
            currencyMN.Font = new Font("Segoe UI", 13.8F);
            currencyMN.ForeColor = Color.FromArgb(192, 0, 0);
            currencyMN.Location = new Point(143, 52);
            currencyMN.Name = "currencyMN";
            currencyMN.Size = new Size(0, 31);
            currencyMN.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(14, 12);
            label5.Name = "label5";
            label5.Size = new Size(202, 28);
            label5.TabIndex = 16;
            label5.Text = "Les Valeurs Actuelles";
            // 
            // countryList
            // 
            countryList.FormattingEnabled = true;
            countryList.Location = new Point(14, 148);
            countryList.Name = "countryList";
            countryList.Size = new Size(245, 31);
            countryList.TabIndex = 4;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(210, 18);
            label1.Name = "label1";
            label1.Size = new Size(497, 60);
            label1.TabIndex = 5;
            label1.Text = "BANQUE DE TORONTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 78);
            label2.Name = "label2";
            label2.Size = new Size(450, 34);
            label2.TabIndex = 6;
            label2.Text = "Bureau De Changes International";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(109, 414);
            label4.Name = "label4";
            label4.Size = new Size(648, 23);
            label4.TabIndex = 7;
            label4.Text = "Note : Utilisez une virgule (,) pour les décimales. Un point (.) provoquera une erreur.";
            label4.Click += label4_Click;
            // 
            // EnLigneChange
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Green;
            ClientSize = new Size(900, 843);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 238);
            ForeColor = SystemColors.ButtonFace;
            MaximizeBox = false;
            Name = "EnLigneChange";
            Text = "Guichet Automatique Bancaire";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Panel panel1;
        private ComboBox countryList;
        private Panel panel2;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel3;
        private Panel panel4;
        private RadioButton radioCurrencyI;
        private RadioButton radioCurrencyN;
        private TextBox montantInput;
        private Button ApplyCalc;
        private Label calcMontDev;
        private Label displayOutput;
        private Button ReplayModel;
        private Button CloseModel;
        private Label currencyName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label EditionMode;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label currencyMI;
        private Label currencyMN;
        private Label label4;
    }
}