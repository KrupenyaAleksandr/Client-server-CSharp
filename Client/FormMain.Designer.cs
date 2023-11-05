namespace Client
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRequestAdd = new System.Windows.Forms.Button();
            this.buttonRequestGet = new System.Windows.Forms.Button();
            this.buttonRequestDelete = new System.Windows.Forms.Button();
            this.buttonRequestUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(121, 109);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(138, 42);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(332, 109);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(138, 42);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(121, 222);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(411, 168);
            this.textBoxResponse.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 495);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(411, 154);
            this.textBox2.TabIndex = 3;
            // 
            // buttonRequestAdd
            // 
            this.buttonRequestAdd.Enabled = false;
            this.buttonRequestAdd.Location = new System.Drawing.Point(576, 109);
            this.buttonRequestAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRequestAdd.Name = "buttonRequestAdd";
            this.buttonRequestAdd.Size = new System.Drawing.Size(138, 42);
            this.buttonRequestAdd.TabIndex = 4;
            this.buttonRequestAdd.Text = "Add";
            this.buttonRequestAdd.UseVisualStyleBackColor = true;
            this.buttonRequestAdd.Click += new System.EventHandler(this.buttonRequestAdd_Click);
            // 
            // buttonRequestGet
            // 
            this.buttonRequestGet.Enabled = false;
            this.buttonRequestGet.Location = new System.Drawing.Point(748, 109);
            this.buttonRequestGet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRequestGet.Name = "buttonRequestGet";
            this.buttonRequestGet.Size = new System.Drawing.Size(138, 42);
            this.buttonRequestGet.TabIndex = 5;
            this.buttonRequestGet.Text = "Get";
            this.buttonRequestGet.UseVisualStyleBackColor = true;
            this.buttonRequestGet.Click += new System.EventHandler(this.buttonRequestGet_Click);
            // 
            // buttonRequestDelete
            // 
            this.buttonRequestDelete.Enabled = false;
            this.buttonRequestDelete.Location = new System.Drawing.Point(937, 109);
            this.buttonRequestDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRequestDelete.Name = "buttonRequestDelete";
            this.buttonRequestDelete.Size = new System.Drawing.Size(138, 42);
            this.buttonRequestDelete.TabIndex = 6;
            this.buttonRequestDelete.Text = "Delete";
            this.buttonRequestDelete.UseVisualStyleBackColor = true;
            this.buttonRequestDelete.Click += new System.EventHandler(this.buttonRequestDelete_Click);
            // 
            // buttonRequestUpdate
            // 
            this.buttonRequestUpdate.Enabled = false;
            this.buttonRequestUpdate.Location = new System.Drawing.Point(1128, 109);
            this.buttonRequestUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRequestUpdate.Name = "buttonRequestUpdate";
            this.buttonRequestUpdate.Size = new System.Drawing.Size(138, 42);
            this.buttonRequestUpdate.TabIndex = 7;
            this.buttonRequestUpdate.Text = "Update";
            this.buttonRequestUpdate.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.buttonRequestUpdate);
            this.Controls.Add(this.buttonRequestDelete);
            this.Controls.Add(this.buttonRequestGet);
            this.Controls.Add(this.buttonRequestAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonRequestAdd;
        private System.Windows.Forms.Button buttonRequestGet;
        private System.Windows.Forms.Button buttonRequestDelete;
        private System.Windows.Forms.Button buttonRequestUpdate;
    }
}

