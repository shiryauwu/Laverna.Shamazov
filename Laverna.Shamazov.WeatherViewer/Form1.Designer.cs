namespace Laverna.Shamazov.WeatherViewer
{
    partial class WeatherViewerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.WindSpeedTextBox = new System.Windows.Forms.TextBox();
            this.EnterCityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GetInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость \r\nветра";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Enabled = false;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(163, 67);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(120, 24);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.Enabled = false;
            this.TemperatureTextBox.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureTextBox.Location = new System.Drawing.Point(24, 67);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.Size = new System.Drawing.Size(100, 24);
            this.TemperatureTextBox.TabIndex = 4;
            // 
            // WindSpeedTextBox
            // 
            this.WindSpeedTextBox.Enabled = false;
            this.WindSpeedTextBox.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedTextBox.Location = new System.Drawing.Point(296, 67);
            this.WindSpeedTextBox.Name = "WindSpeedTextBox";
            this.WindSpeedTextBox.Size = new System.Drawing.Size(100, 24);
            this.WindSpeedTextBox.TabIndex = 5;
            // 
            // EnterCityTextBox
            // 
            this.EnterCityTextBox.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCityTextBox.Location = new System.Drawing.Point(140, 167);
            this.EnterCityTextBox.Name = "EnterCityTextBox";
            this.EnterCityTextBox.Size = new System.Drawing.Size(143, 22);
            this.EnterCityTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите название города";
            // 
            // GetInfoButton
            // 
            this.GetInfoButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetInfoButton.Location = new System.Drawing.Point(146, 195);
            this.GetInfoButton.Name = "GetInfoButton";
            this.GetInfoButton.Size = new System.Drawing.Size(123, 23);
            this.GetInfoButton.TabIndex = 8;
            this.GetInfoButton.Text = "Узнать погоду!";
            this.GetInfoButton.UseVisualStyleBackColor = true;
            this.GetInfoButton.Click += new System.EventHandler(this.GetInfoButton_Click);
            // 
            // WeatherViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 230);
            this.Controls.Add(this.GetInfoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterCityTextBox);
            this.Controls.Add(this.WindSpeedTextBox);
            this.Controls.Add(this.TemperatureTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WeatherViewerForm";
            this.Text = "Просмотрщик погоды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox TemperatureTextBox;
        private System.Windows.Forms.TextBox WindSpeedTextBox;
        private System.Windows.Forms.TextBox EnterCityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetInfoButton;
    }
}

