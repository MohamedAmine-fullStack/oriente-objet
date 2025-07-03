namespace calculAndChange
{
    partial class LocalChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalChange));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            GetDirection = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 103);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 477);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(797, 103);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(477, 363);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // GetDirection
            // 
            GetDirection.BackColor = Color.Silver;
            GetDirection.Cursor = Cursors.Hand;
            GetDirection.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetDirection.ForeColor = SystemColors.Highlight;
            GetDirection.Location = new Point(849, 494);
            GetDirection.Name = "GetDirection";
            GetDirection.Size = new Size(355, 63);
            GetDirection.TabIndex = 2;
            GetDirection.Text = "Obtenir l’itinéraire";
            GetDirection.UseVisualStyleBackColor = false;
            GetDirection.Click += GetDirection_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(149, 33);
            label1.Name = "label1";
            label1.Size = new Size(983, 27);
            label1.TabIndex = 3;
            label1.Text = "Bienvenue sur votre itinéraire ! Suivez votre parcours et explorez chaque étape avec nous. Bonne route !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(172, 620);
            label2.Name = "label2";
            label2.Size = new Size(960, 48);
            label2.TabIndex = 4;
            label2.Text = "Trouvez-nous au : 3030 Rue Hochelaga, Montréal, QC H1W 1G2.";
            label2.Click += label2_Click;
            // 
            // LocalChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1296, 689);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GetDirection);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LocalChange";
            Text = "LocalChange";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button GetDirection;
        private Label label1;
        private Label label2;
    }
}