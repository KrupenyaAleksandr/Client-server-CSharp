namespace Client.Dialog
{
    partial class FormAddRequest
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
            this.buttonRequestOK = new System.Windows.Forms.Button();
            this.buttonRequestCancel = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRequestOK
            // 
            this.buttonRequestOK.Location = new System.Drawing.Point(582, 415);
            this.buttonRequestOK.Name = "buttonRequestOK";
            this.buttonRequestOK.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestOK.TabIndex = 0;
            this.buttonRequestOK.Text = "OK";
            this.buttonRequestOK.UseVisualStyleBackColor = true;
            this.buttonRequestOK.Click += new System.EventHandler(this.buttonRequestOK_Click);
            // 
            // buttonRequestCancel
            // 
            this.buttonRequestCancel.Location = new System.Drawing.Point(691, 415);
            this.buttonRequestCancel.Name = "buttonRequestCancel";
            this.buttonRequestCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonRequestCancel.TabIndex = 1;
            this.buttonRequestCancel.Text = "Cancel";
            this.buttonRequestCancel.UseVisualStyleBackColor = true;
            this.buttonRequestCancel.Click += new System.EventHandler(this.buttonRequestCancel_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(222, 97);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey.TabIndex = 2;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(213, 151);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(100, 20);
            this.textBoxManufacturer.TabIndex = 3;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(213, 213);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 4;
            // 
            // FormAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonRequestCancel);
            this.Controls.Add(this.buttonRequestOK);
            this.Name = "FormAddRequest";
            this.Text = "FormAddRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRequestOK;
        private System.Windows.Forms.Button buttonRequestCancel;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxModel;
    }
}