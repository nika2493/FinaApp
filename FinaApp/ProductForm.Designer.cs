namespace FinaApp
{
    partial class ProductForm
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
            this.AddCountryBtn = new System.Windows.Forms.Button();
            this.RemoveCountryBtn = new System.Windows.Forms.Button();
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
            this.SaveBtn.Text = "შენახვა";
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
            this.ProductStartDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.ProductStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProductStartDateTimePicker.Location = new System.Drawing.Point(12, 149);
            this.ProductStartDateTimePicker.Name = "ProductStartDateTimePicker";
            this.ProductStartDateTimePicker.Size = new System.Drawing.Size(151, 23);
            this.ProductStartDateTimePicker.TabIndex = 8;
            this.ProductStartDateTimePicker.Value = new System.DateTime(2021, 12, 2, 1, 12, 42, 0);
            // 
            // ProductEndDateTimePicker
            // 
            this.ProductEndDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.ProductEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProductEndDateTimePicker.Location = new System.Drawing.Point(259, 149);
            this.ProductEndDateTimePicker.Name = "ProductEndDateTimePicker";
            this.ProductEndDateTimePicker.Size = new System.Drawing.Size(157, 23);
            this.ProductEndDateTimePicker.TabIndex = 9;
            this.ProductEndDateTimePicker.Value = new System.DateTime(2021, 12, 2, 0, 0, 0, 0);
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
            this.ProductCountryComboBox.Size = new System.Drawing.Size(187, 23);
            this.ProductCountryComboBox.TabIndex = 13;
            // 
            // countryModelBindingSource
            // 
            this.countryModelBindingSource.DataSource = typeof(FinaData.Models.CountryModel);
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Location = new System.Drawing.Point(169, 12);
            this.ProductCodeTextBox.Maximum = new decimal(new int[] {
            1294967295,
            0,
            0,
            0});
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(247, 23);
            this.ProductCodeTextBox.TabIndex = 14;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(169, 70);
            this.ProductPriceTextBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(247, 23);
            this.ProductPriceTextBox.TabIndex = 15;
            // 
            // AddCountryBtn
            // 
            this.AddCountryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCountryBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddCountryBtn.BackgroundImage = global::FinaApp.Properties.Resources.AddIcon;
            this.AddCountryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCountryBtn.Location = new System.Drawing.Point(392, 99);
            this.AddCountryBtn.Name = "AddCountryBtn";
            this.AddCountryBtn.Size = new System.Drawing.Size(24, 24);
            this.AddCountryBtn.TabIndex = 16;
            this.AddCountryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddCountryBtn.UseVisualStyleBackColor = true;
            this.AddCountryBtn.Click += new System.EventHandler(this.AddCountryBtn_Click);
            // 
            // RemoveCountryBtn
            // 
            this.RemoveCountryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveCountryBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveCountryBtn.BackgroundImage = global::FinaApp.Properties.Resources.RemoveIcon;
            this.RemoveCountryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveCountryBtn.Location = new System.Drawing.Point(362, 99);
            this.RemoveCountryBtn.Name = "RemoveCountryBtn";
            this.RemoveCountryBtn.Size = new System.Drawing.Size(24, 24);
            this.RemoveCountryBtn.TabIndex = 17;
            this.RemoveCountryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RemoveCountryBtn.UseVisualStyleBackColor = true;
            this.RemoveCountryBtn.Click += new System.EventHandler(this.RemoveCountryBtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 207);
            this.ControlBox = false;
            this.Controls.Add(this.RemoveCountryBtn);
            this.Controls.Add(this.AddCountryBtn);
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
            this.Name = "ProductForm";
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
        private Button AddCountryBtn;
        private Button RemoveCountryBtn;
    }
}