namespace Client
{
    partial class UserControlAirplaneOutput
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(20, 30);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(200, 20);
            this.textBoxManufacturer.TabIndex = 0;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(20, 80);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(200, 20);
            this.textBoxModel.TabIndex = 1;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(20, 10);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(70, 13);
            this.labelManufacturer.TabIndex = 2;
            this.labelManufacturer.Text = "Manufacturer";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(20, 60);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Model";
            // 
            // UserControlAirplaneOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxManufacturer);
            this.Name = "UserControlAirplaneOutput";
            this.Size = new System.Drawing.Size(240, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelModel;
    }
}
