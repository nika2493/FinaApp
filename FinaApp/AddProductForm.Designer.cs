namespace FinaApp
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ProductCodeLable = new System.Windows.Forms.Label();
            this.ProductNameLable = new System.Windows.Forms.Label();
            this.ProductPriceLable = new System.Windows.Forms.Label();
            this.ProductCountryLable = new System.Windows.Forms.Label();
            this.ProductStartDateLable = new System.Windows.Forms.Label();
            this.ProductEndDateLable = new System.Windows.Forms.Label();
            this.ProductStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductCountryComboBox = new System.Windows.Forms.ComboBox();
            this.countryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductCodeTextBox = new System.Windows.Forms.NumericUpDown();
            this.ProductPriceTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.countryModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCodeTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(88, 178);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "უკან";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(259, 178);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "დამატება";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ProductCodeLable
            // 
            this.ProductCodeLable.AutoSize = true;
            this.ProductCodeLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductCodeLable.Location = new System.Drawing.Point(105, 14);
            this.ProductCodeLable.Name = "ProductCodeLable";
            this.ProductCodeLable.Size = new System.Drawing.Size(58, 21);
            this.ProductCodeLable.TabIndex = 2;
            this.ProductCodeLable.Text = "კოდი:";
            // 
            // ProductNameLable
            // 
            this.ProductNameLable.AutoSize = true;
            this.ProductNameLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductNameLable.Location = new System.Drawing.Point(49, 43);
            this.ProductNameLable.Name = "ProductNameLable";
            this.ProductNameLable.Size = new System.Drawing.Size(114, 21);
            this.ProductNameLable.TabIndex = 3;
            this.ProductNameLable.Text = "დასახელება:";
            // 
            // ProductPriceLable
            // 
            this.ProductPriceLable.AutoSize = true;
            this.ProductPriceLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductPriceLable.Location = new System.Drawing.Point(109, 72);
            this.ProductPriceLable.Name = "ProductPriceLable";
            this.ProductPriceLable.Size = new System.Drawing.Size(54, 21);
            this.ProductPriceLable.TabIndex = 4;
            this.ProductPriceLable.Text = "ფასი:";
            // 
            // ProductCountryLable
            // 
            this.ProductCountryLable.AutoSize = true;
            this.ProductCountryLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductCountryLable.Location = new System.Drawing.Point(89, 101);
            this.ProductCountryLable.Name = "ProductCountryLable";
            this.ProductCountryLable.Size = new System.Drawing.Size(74, 21);
            this.ProductCountryLable.TabIndex = 5;
            this.ProductCountryLable.Text = "ქვეყანა:";
            // 
            // ProductStartDateLable
            // 
            this.ProductStartDateLable.AutoSize = true;
            this.ProductStartDateLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductStartDateLable.Location = new System.Drawing.Point(18, 125);
            this.ProductStartDateLable.Name = "ProductStartDateLable";
            this.ProductStartDateLable.Size = new System.Drawing.Size(145, 21);
            this.ProductStartDateLable.TabIndex = 6;
            this.ProductStartDateLable.Text = "საწყისი თარიღი";
            // 
            // ProductEndDateLable
            // 
            this.ProductEndDateLable.AutoSize = true;
            this.ProductEndDateLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductEndDateLable.Location = new System.Drawing.Point(259, 125);
            this.ProductEndDateLable.Name = "ProductEndDateLable";
            this.ProductEndDateLable.Size = new System.Drawing.Size(159, 21);
            this.ProductEndDateLable.TabIndex = 7;
            this.ProductEndDateLable.Text = "საბოლოო თარიღი";
            // 
            // ProductStartDateTimePicker
            // 
            this.ProductStartDateTimePicker.Location = new System.Drawing.Point(12, 149);
            this.ProductStartDateTimePicker.Name = "ProductStartDateTimePicker";
            this.ProductStartDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.ProductStartDateTimePicker.TabIndex = 8;
            // 
            // ProductEndDateTimePicker
            // 
            this.ProductEndDateTimePicker.Location = new System.Drawing.Point(218, 149);
            this.ProductEndDateTimePicker.Name = "ProductEndDateTimePicker";
            this.ProductEndDateTimePicker.Size = new System.Drawing.Size(198, 23);
            this.ProductEndDateTimePicker.TabIndex = 9;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(169, 41);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(247, 23);
            this.ProductNameTextBox.TabIndex = 11;
            // 
            // ProductCountryComboBox
            // 
            this.ProductCountryComboBox.DataSource = this.countryModelBindingSource;
            this.ProductCountryComboBox.DisplayMember = "Name";
            this.ProductCountryComboBox.FormattingEnabled = true;
            this.ProductCountryComboBox.Location = new System.Drawing.Point(169, 99);
            this.ProductCountryComboBox.Name = "ProductCountryComboBox";
            this.ProductCountryComboBox.Size = new System.Drawing.Size(247, 23);
            this.ProductCountryComboBox.TabIndex = 13;
            // 
            // countryModelBindingSource
            // 
            this.countryModelBindingSource.DataSource = typeof(FinaData.Models.CountryModel);
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Location = new System.Drawing.Point(169, 12);
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(247, 23);
            this.ProductCodeTextBox.TabIndex = 14;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(169, 70);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(247, 23);
            this.ProductPriceTextBox.TabIndex = 15;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 207);
            this.ControlBox = false;
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductCodeTextBox);
            this.Controls.Add(this.ProductCountryComboBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductEndDateTimePicker);
            this.Controls.Add(this.ProductStartDateTimePicker);
            this.Controls.Add(this.ProductEndDateLable);
            this.Controls.Add(this.ProductStartDateLable);
            this.Controls.Add(this.ProductCountryLable);
            this.Controls.Add(this.ProductPriceLable);
            this.Controls.Add(this.ProductNameLable);
            this.Controls.Add(this.ProductCodeLable);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "პროდუქციის დამატება";
            ((System.ComponentModel.ISupportInitialize)(this.countryModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCodeTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelBtn;
        private Button SaveBtn;
        private Label ProductCodeLable;
        private Label ProductNameLable;
        private Label ProductPriceLable;
        private Label ProductCountryLable;
        private Label ProductStartDateLable;
        private Label ProductEndDateLable;
        private DateTimePicker ProductStartDateTimePicker;
        private DateTimePicker ProductEndDateTimePicker;
        private TextBox ProductNameTextBox;
        private ComboBox ProductCountryComboBox;
        private NumericUpDown ProductCodeTextBox;
        private NumericUpDown ProductPriceTextBox;
        private BindingSource countryModelBindingSource;
    }
}