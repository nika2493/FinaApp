namespace FinaApp;

partial class DiagramForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductDiagramDataGridView = new System.Windows.Forms.DataGridView();
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDiagramDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDiagramDataGridView
            // 
            this.ProductDiagramDataGridView.AllowUserToAddRows = false;
            this.ProductDiagramDataGridView.AllowUserToDeleteRows = false;
            this.ProductDiagramDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDiagramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDiagramDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDiagramDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductDiagramDataGridView.Name = "ProductDiagramDataGridView";
            this.ProductDiagramDataGridView.ReadOnly = true;
            this.ProductDiagramDataGridView.RowTemplate.Height = 25;
            this.ProductDiagramDataGridView.Size = new System.Drawing.Size(784, 561);
            this.ProductDiagramDataGridView.TabIndex = 0;
            this.ProductDiagramDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductDiagramDataGridView_CellFormatting);
            this.ProductDiagramDataGridView.SelectionChanged += new System.EventHandler(this.ProductDiagramDataGridView_SelectionChanged);
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(FinaData.Models.ProductModel);
            // 
            // DiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ProductDiagramDataGridView);
            this.Name = "DiagramForm";
            this.Text = "დიაგრამა";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDiagramDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private DataGridView ProductDiagramDataGridView;
    private BindingSource productModelBindingSource;
}
