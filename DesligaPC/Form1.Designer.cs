namespace DesligaPC
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btNaoDesligue = new System.Windows.Forms.Button();
            this.lbTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo para desligar...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNaoDesligue
            // 
            this.btNaoDesligue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btNaoDesligue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNaoDesligue.Location = new System.Drawing.Point(0, 82);
            this.btNaoDesligue.Name = "btNaoDesligue";
            this.btNaoDesligue.Size = new System.Drawing.Size(433, 39);
            this.btNaoDesligue.TabIndex = 1;
            this.btNaoDesligue.Text = "Não desligue!";
            this.btNaoDesligue.UseVisualStyleBackColor = true;
            this.btNaoDesligue.Click += new System.EventHandler(this.btNaoDesligue_Click);
            // 
            // lbTempo
            // 
            this.lbTempo.BackColor = System.Drawing.Color.Black;
            this.lbTempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTempo.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTempo.Location = new System.Drawing.Point(0, 22);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(433, 50);
            this.lbTempo.TabIndex = 2;
            this.lbTempo.Text = "00:00:00:000";
            this.lbTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 121);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.btNaoDesligue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Desligar o PC";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNaoDesligue;
        private System.Windows.Forms.Label lbTempo;
    }
}

