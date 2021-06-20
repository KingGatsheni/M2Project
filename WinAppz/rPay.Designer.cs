namespace WinAppz
{
    partial class rPay
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
            this.groupCardPay = new System.Windows.Forms.GroupBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtExpiry = new System.Windows.Forms.MaskedTextBox();
            this.lbInvalidCardInfo = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.Label();
            this.ltnount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lbRepId = new MetroSet_UI.Controls.MetroSetLabel();
            this.groupCardPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCardPay
            // 
            this.groupCardPay.Controls.Add(this.txtCardNo);
            this.groupCardPay.Controls.Add(this.metroSetLabel4);
            this.groupCardPay.Controls.Add(this.txtExpiry);
            this.groupCardPay.Controls.Add(this.lbInvalidCardInfo);
            this.groupCardPay.Controls.Add(this.metroSetLabel5);
            this.groupCardPay.Controls.Add(this.metroSetLabel3);
            this.groupCardPay.Controls.Add(this.txtCVC);
            this.groupCardPay.ForeColor = System.Drawing.Color.White;
            this.groupCardPay.Location = new System.Drawing.Point(23, 264);
            this.groupCardPay.Name = "groupCardPay";
            this.groupCardPay.Size = new System.Drawing.Size(459, 344);
            this.groupCardPay.TabIndex = 21;
            this.groupCardPay.TabStop = false;
            // 
            // txtCardNo
            // 
            this.txtCardNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCardNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.Location = new System.Drawing.Point(23, 57);
            this.txtCardNo.Multiline = true;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(415, 45);
            this.txtCardNo.TabIndex = 5;
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(34, 233);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(130, 36);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 0;
            this.metroSetLabel4.Text = "Expiry Date";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            // 
            // txtExpiry
            // 
            this.txtExpiry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtExpiry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiry.Location = new System.Drawing.Point(23, 185);
            this.txtExpiry.Mask = "00 /00";
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(150, 35);
            this.txtExpiry.TabIndex = 11;
            this.txtExpiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbInvalidCardInfo
            // 
            this.lbInvalidCardInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvalidCardInfo.IsDerivedStyle = true;
            this.lbInvalidCardInfo.Location = new System.Drawing.Point(166, 18);
            this.lbInvalidCardInfo.Name = "lbInvalidCardInfo";
            this.lbInvalidCardInfo.Size = new System.Drawing.Size(130, 36);
            this.lbInvalidCardInfo.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbInvalidCardInfo.StyleManager = null;
            this.lbInvalidCardInfo.TabIndex = 0;
            this.lbInvalidCardInfo.Text = "*";
            this.lbInvalidCardInfo.ThemeAuthor = "Narwin";
            this.lbInvalidCardInfo.ThemeName = "MetroDark";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(166, 125);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(130, 36);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 0;
            this.metroSetLabel5.Text = "Card Number";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(330, 233);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(73, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 0;
            this.metroSetLabel3.Text = "CVC";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // txtCVC
            // 
            this.txtCVC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCVC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.Location = new System.Drawing.Point(288, 185);
            this.txtCVC.Multiline = true;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(150, 35);
            this.txtCVC.TabIndex = 5;
            this.txtCVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.BackColor = System.Drawing.Color.Gray;
            this.txtAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountDue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.ForeColor = System.Drawing.Color.White;
            this.txtAmountDue.Location = new System.Drawing.Point(213, 22);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(269, 45);
            this.txtAmountDue.TabIndex = 18;
            this.txtAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ltnount
            // 
            this.ltnount.AutoSize = true;
            this.ltnount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltnount.ForeColor = System.Drawing.Color.White;
            this.ltnount.Location = new System.Drawing.Point(22, 22);
            this.ltnount.Name = "ltnount";
            this.ltnount.Size = new System.Drawing.Size(124, 25);
            this.ltnount.TabIndex = 19;
            this.ltnount.Text = "Total Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Paid Amount";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Blue;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Location = new System.Drawing.Point(23, 625);
            this.btnPay.Name = "btnPay";
            this.btnPay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPay.Size = new System.Drawing.Size(164, 65);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(318, 625);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(164, 65);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPaidAmount.Location = new System.Drawing.Point(213, 86);
            this.txtPaidAmount.Multiline = true;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(269, 45);
            this.txtPaidAmount.TabIndex = 15;
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCard.ForeColor = System.Drawing.Color.White;
            this.rbCard.Location = new System.Drawing.Point(301, 178);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(181, 36);
            this.rbCard.TabIndex = 13;
            this.rbCard.Text = "Card Payment";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged_1);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.ForeColor = System.Drawing.Color.White;
            this.rbCash.Location = new System.Drawing.Point(22, 178);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(183, 36);
            this.rbCash.TabIndex = 14;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash Payment";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged_1);
            // 
            // lbRepId
            // 
            this.lbRepId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepId.IsDerivedStyle = true;
            this.lbRepId.Location = new System.Drawing.Point(27, 225);
            this.lbRepId.Name = "lbRepId";
            this.lbRepId.Size = new System.Drawing.Size(130, 36);
            this.lbRepId.Style = MetroSet_UI.Enums.Style.Dark;
            this.lbRepId.StyleManager = null;
            this.lbRepId.TabIndex = 0;
            this.lbRepId.Text = "*";
            this.lbRepId.ThemeAuthor = "Narwin";
            this.lbRepId.ThemeName = "MetroDark";
            // 
            // rPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(504, 712);
            this.Controls.Add(this.groupCardPay);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.ltnount);
            this.Controls.Add(this.lbRepId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rPay";
            this.Load += new System.EventHandler(this.rPay_Load);
            this.Shown += new System.EventHandler(this.rPay_Shown);
            this.groupCardPay.ResumeLayout(false);
            this.groupCardPay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCardPay;
        private System.Windows.Forms.TextBox txtCardNo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.MaskedTextBox txtExpiry;
        private MetroSet_UI.Controls.MetroSetLabel lbInvalidCardInfo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private System.Windows.Forms.TextBox txtCVC;
        public System.Windows.Forms.Label txtAmountDue;
        public System.Windows.Forms.Label ltnount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCash;
        public MetroSet_UI.Controls.MetroSetLabel lbRepId;
    }
}