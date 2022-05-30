namespace WebPreglednik
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pctFoward = new System.Windows.Forms.PictureBox();
            this.ptcBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 378);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(618, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 44);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(745, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(43, 44);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pctFoward
            // 
            this.pctFoward.Image = ((System.Drawing.Image)(resources.GetObject("pctFoward.Image")));
            this.pctFoward.Location = new System.Drawing.Point(61, 12);
            this.pctFoward.Name = "pctFoward";
            this.pctFoward.Size = new System.Drawing.Size(43, 44);
            this.pctFoward.TabIndex = 6;
            this.pctFoward.TabStop = false;
            this.pctFoward.Click += new System.EventHandler(this.pctFoward_Click);
            // 
            // ptcBack
            // 
            this.ptcBack.Image = ((System.Drawing.Image)(resources.GetObject("ptcBack.Image")));
            this.ptcBack.Location = new System.Drawing.Point(12, 12);
            this.ptcBack.Name = "ptcBack";
            this.ptcBack.Size = new System.Drawing.Size(43, 44);
            this.ptcBack.TabIndex = 7;
            this.ptcBack.TabStop = false;
            this.ptcBack.Click += new System.EventHandler(this.ptcBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ptcBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pctFoward);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctFoward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pctFoward;
        private System.Windows.Forms.PictureBox ptcBack;
    }
}

