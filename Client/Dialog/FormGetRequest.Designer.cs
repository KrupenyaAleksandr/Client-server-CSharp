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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonRequestOK = new System.Windows.Forms.Button();
            this.buttonRequestCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(284, 156);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey.TabIndex = 0;
            // 
            // buttonRequestOK
            // 
            this.buttonRequestOK.Location = new System.Drawing.Point(568, 415);
            this.buttonRequestOK.Name = "buttonRequestOK";
            this.buttonRequestOK.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestOK.TabIndex = 1;
            this.buttonRequestOK.Text = "OK";
            this.buttonRequestOK.UseVisualStyleBackColor = true;
            this.buttonRequestOK.Click += new System.EventHandler(this.buttonOKRequest_Click);
            // 
            // buttonRequestCancel
            // 
            this.buttonRequestCancel.Location = new System.Drawing.Point(692, 415);
            this.buttonRequestCancel.Name = "buttonRequestCancel";
            this.buttonRequestCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestCancel.TabIndex = 2;
            this.buttonRequestCancel.Text = "Cancel";
            this.buttonRequestCancel.UseVisualStyleBackColor = true;
            this.buttonRequestCancel.Click += new System.EventHandler(this.buttonRequestCancel_Click);
            // 
            // FormGetRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRequestCancel);
            this.Controls.Add(this.buttonRequestOK);
            this.Controls.Add(this.textBoxKey);
            this.Name = "FormGetRequest";
            this.Text = "FormGetRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonRequestOK;
        private System.Windows.Forms.Button buttonRequestCancel;
    }
}