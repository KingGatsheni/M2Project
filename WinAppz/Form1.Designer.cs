namespace WinAppz
{
    partial class ContainerForm
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnRepairs = new System.Windows.Forms.Button();
            this.panelManager = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.panelSide.Controls.Add(this.btnLogout);
            this.panelSide.Controls.Add(this.panelAdmin);
            this.panelSide.Controls.Add(this.panelManager);
            this.panelSide.Controls.Add(this.btnManager);
            this.panelSide.Controls.Add(this.panelImage);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 966);
            this.panelSide.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(0, 921);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.btnInventory);
            this.panelAdmin.Controls.Add(this.btnRepairs);
            this.panelAdmin.Location = new System.Drawing.Point(3, 147);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(191, 147);
            this.panelAdmin.TabIndex = 6;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventory.Location = new System.Drawing.Point(0, 57);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(191, 45);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnRepairs
            // 
            this.btnRepairs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRepairs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRepairs.Location = new System.Drawing.Point(0, 6);
            this.btnRepairs.Name = "btnRepairs";
            this.btnRepairs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRepairs.Size = new System.Drawing.Size(191, 45);
            this.btnRepairs.TabIndex = 5;
            this.btnRepairs.Text = "Repairs";
            this.btnRepairs.UseVisualStyleBackColor = false;
            // 
            // panelManager
            // 
            this.panelManager.Controls.Add(this.button3);
            this.panelManager.Controls.Add(this.button2);
            this.panelManager.Location = new System.Drawing.Point(0, 383);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(191, 151);
            this.panelManager.TabIndex = 5;
            this.panelManager.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 75);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(197, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reports";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 14);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(197, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnManager
            // 
            this.btnManager.Enabled = false;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManager.Location = new System.Drawing.Point(0, 332);
            this.btnManager.Name = "btnManager";
            this.btnManager.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManager.Size = new System.Drawing.Size(197, 45);
            this.btnManager.TabIndex = 4;
            this.btnManager.Text = "Management";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.DarkOrange;
            this.panelImage.Controls.Add(this.label1);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(200, 128);
            this.panelImage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pc Wizard POS";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBody.Location = new System.Drawing.Point(200, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(935, 966);
            this.panelBody.TabIndex = 1;
            // 
            // ContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 966);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "ContainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ContainerForm_Load);
            this.panelSide.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelManager.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.Panel panelAdmin;
        public System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnRepairs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}

