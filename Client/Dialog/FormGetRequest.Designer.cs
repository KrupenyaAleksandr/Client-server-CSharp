namespace Client.Dialog
{
    partial class FormGetRequest
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
            this.buttonRequestCancel = new System.Windows.Forms.Button();
            this.buttonRequestOK = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRequestCancel
            // 
            this.buttonRequestCancel.Location = new System.Drawing.Point(155, 145);
            this.buttonRequestCancel.Name = "buttonRequestCancel";
            this.buttonRequestCancel.Size = new System.Drawing.Size(55, 24);
            this.buttonRequestCancel.TabIndex = 13;
            this.buttonRequestCancel.Text = "Cancel";
            this.buttonRequestCancel.UseVisualStyleBackColor = true;
            this.buttonRequestCancel.Click += new System.EventHandler(this.buttonRequestCancel_Click);
            // 
            // buttonRequestOK
            // 
            this.buttonRequestOK.Location = new System.Drawing.Point(90, 145);
            this.buttonRequestOK.Name = "buttonRequestOK";
            this.buttonRequestOK.Size = new System.Drawing.Size(55, 24);
            this.buttonRequestOK.TabIndex = 12;
            this.buttonRequestOK.Text = "OK";
            this.buttonRequestOK.UseVisualStyleBackColor = true;
            this.buttonRequestOK.Click += new System.EventHandler(this.buttonRequestOK_Click);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(40, 66);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(25, 13);
            this.labelKey.TabIndex = 11;
            this.labelKey.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(90, 64);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(120, 20);
            this.textBoxKey.TabIndex = 10;
            // 
            // FormGetRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 181);
            this.Controls.Add(this.buttonRequestCancel);
            this.Controls.Add(this.buttonRequestOK);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGetRequest";
            this.Text = "Получить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRequestCancel;
        private System.Windows.Forms.Button buttonRequestOK;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}