namespace FinaApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("პროდუქტები");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GroupTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.AddGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.EditGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.AddProductBtn = new System.Windows.Forms.ToolStripButton();
            this.EditProductBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteProductBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DiagramBtn = new System.Windows.Forms.ToolStripButton();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GroupTreeView);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Panel2.Controls.Add(this.ProductGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // GroupTreeView
            // 
            this.GroupTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupTreeView.Location = new System.Drawing.Point(0, 28);
            this.GroupTreeView.Name = "GroupTreeView";
            treeNode1.Name = "products";
            treeNode1.Tag = "";
            treeNode1.Text = "პროდუქტები";
            this.GroupTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.GroupTreeView.Size = new System.Drawing.Size(265, 420);
            this.GroupTreeView.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGroupBtn,
            this.EditGroupBtn,
            this.DeleteGroupBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(266, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddGroupBtn.Image = global::FinaApp.Properties.Resources.AddIcon;
            this.AddGroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(23, 22);
            this.AddGroupBtn.Text = "ჯგუფის დამატება";
            // 
            // EditGroupBtn
            // 
            this.EditGroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditGroupBtn.Image = global::FinaApp.Properties.Resources.EditIcon;
            this.EditGroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditGroupBtn.Name = "EditGroupBtn";
            this.EditGroupBtn.Size = new System.Drawing.Size(23, 22);
            this.EditGroupBtn.Text = "ჯგუფის ჩასწორება";
            // 
            // DeleteGroupBtn
            // 
            this.DeleteGroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteGroupBtn.Image = global::FinaApp.Properties.Resources.RemoveIcon;
            this.DeleteGroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteGroupBtn.Name = "DeleteGroupBtn";
            this.DeleteGroupBtn.Size = new System.Drawing.Size(23, 22);
            this.DeleteGroupBtn.Text = "ჯგუფის წაშლა";
            this.DeleteGroupBtn.ToolTipText = "ჯგუფი ს წაშლა";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductBtn,
            this.EditProductBtn,
            this.DeleteProductBtn,
            this.toolStripButton1,
            this.DiagramBtn});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(530, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddProductBtn.Image = global::FinaApp.Properties.Resources.AddIcon;
            this.AddProductBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(23, 22);
            this.AddProductBtn.Text = "პროდუქტის დამატება";
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditProductBtn.Image = global::FinaApp.Properties.Resources.EditIcon;
            this.EditProductBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(23, 22);
            this.EditProductBtn.Text = "პროდუქტის ჩასწორება";
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteProductBtn.Image = global::FinaApp.Properties.Resources.RemoveIcon;
            this.DeleteProductBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(23, 22);
            this.DeleteProductBtn.Text = "პროდუქტის წაშლა";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::FinaApp.Properties.Resources.ForwardIcon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "წინ";
            // 
            // DiagramBtn
            // 
            this.DiagramBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DiagramBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DiagramBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DiagramBtn.Name = "DiagramBtn";
            this.DiagramBtn.Size = new System.Drawing.Size(70, 22);
            this.DiagramBtn.Text = "დიაგრამა";
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.AllowUserToResizeRows = false;
            this.ProductGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.ProductGridView.DataSource = this.productModelBindingSource;
            this.ProductGridView.Location = new System.Drawing.Point(0, 28);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.Size = new System.Drawing.Size(528, 420);
            this.ProductGridView.TabIndex = 1;
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(FinaData.Models.ProductModel);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 15F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "კოდი";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 65F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "დასახელება";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 20F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "ფასი";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "პროდუქცია";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip2;
        private ToolStripButton AddGroupBtn;
        private ToolStripButton EditGroupBtn;
        private ToolStripButton DeleteGroupBtn;
        private ToolStrip toolStrip3;
        private ToolStripButton AddProductBtn;
        private ToolStripButton EditProductBtn;
        private ToolStripButton DeleteProductBtn;
        private ToolStripButton toolStripButton1;
        private ToolStripButton DiagramBtn;
        private DataGridView ProductGridView;
        private BindingSource productModelBindingSource;
        private TreeView GroupTreeView; 
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}