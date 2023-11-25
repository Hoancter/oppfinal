namespace oppfinal
{
    partial class GameMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.PictureBox();
            this.btnoption = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnoption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::oppfinal.Properties.Resources.testlogomn1;
            this.pictureBox1.Location = new System.Drawing.Point(154, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Transparent;
            this.btnstart.Image = global::oppfinal.Properties.Resources.start_normal;
            this.btnstart.Location = new System.Drawing.Point(275, 243);
            this.btnstart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(100, 43);
            this.btnstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnstart.TabIndex = 1;
            this.btnstart.TabStop = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            this.btnstart.MouseLeave += new System.EventHandler(this.btnstart_MouseLeave_1);
            this.btnstart.MouseHover += new System.EventHandler(this.btnstart_MouseHover);
            // 
            // btnoption
            // 
            this.btnoption.BackColor = System.Drawing.Color.Transparent;
            this.btnoption.Image = global::oppfinal.Properties.Resources.option_normal;
            this.btnoption.Location = new System.Drawing.Point(275, 291);
            this.btnoption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnoption.Name = "btnoption";
            this.btnoption.Size = new System.Drawing.Size(100, 43);
            this.btnoption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnoption.TabIndex = 2;
            this.btnoption.TabStop = false;
            this.btnoption.Click += new System.EventHandler(this.btnoption_Click);
            this.btnoption.MouseLeave += new System.EventHandler(this.btnoption_MouseLeave);
            this.btnoption.MouseHover += new System.EventHandler(this.btnoption_MouseHover);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Image = global::oppfinal.Properties.Resources.exit_normal;
            this.btnexit.Location = new System.Drawing.Point(275, 338);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 43);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnexit.TabIndex = 3;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::oppfinal.Properties.Resources._255067;
            this.ClientSize = new System.Drawing.Size(707, 496);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnoption);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnoption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnstart;
        private System.Windows.Forms.PictureBox btnoption;
        private System.Windows.Forms.PictureBox btnexit;
    }
}