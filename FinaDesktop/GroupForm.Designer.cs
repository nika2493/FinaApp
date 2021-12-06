namespace FinaDesktop;

partial class GroupForm
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
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.GroupLable = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.IsRootCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(120, 58);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(148, 23);
            this.GroupTextBox.TabIndex = 0;
            // 
            // GroupLable
            // 
            this.GroupLable.AutoSize = true;
            this.GroupLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupLable.Location = new System.Drawing.Point(12, 60);
            this.GroupLable.Name = "GroupLable";
            this.GroupLable.Size = new System.Drawing.Size(102, 21);
            this.GroupLable.TabIndex = 1;
            this.GroupLable.Text = "კატეგორია:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(12, 122);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "უკან";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(193, 122);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "დამატება";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // IsRootCheckBox
            // 
            this.IsRootCheckBox.AutoSize = true;
            this.IsRootCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsRootCheckBox.Location = new System.Drawing.Point(12, 12);
            this.IsRootCheckBox.Name = "IsRootCheckBox";
            this.IsRootCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IsRootCheckBox.Size = new System.Drawing.Size(195, 25);
            this.IsRootCheckBox.TabIndex = 4;
            this.IsRootCheckBox.Text = ":მთავარი კატეგორია";
            this.IsRootCheckBox.UseVisualStyleBackColor = true;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 157);
            this.ControlBox = false;
            this.Controls.Add(this.IsRootCheckBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.GroupLable);
            this.Controls.Add(this.GroupTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "კატეგორია";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox GroupTextBox;
    private Label GroupLable;
    private Button CancelBtn;
    private Button SaveBtn;
    private CheckBox IsRootCheckBox;
}
