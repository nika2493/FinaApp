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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GroupTreeView = new System.Windows.Forms.TreeView();
            this.groupModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrouopToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.EditGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.ProductToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddProductBtn = new System.Windows.Forms.ToolStripButton();
            this.EditProductBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteProductBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DiagramBtn = new System.Windows.Forms.ToolStripButton();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupModelBindingSource)).BeginInit();
            this.GrouopToolStrip.SuspendLayout();
            this.ProductToolStrip.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrouopToolStrip);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProductToolStrip);
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
            this.GroupTreeView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.groupModelBindingSource, "Id", true));
            this.GroupTreeView.Location = new System.Drawing.Point(0, 28);
            this.GroupTreeView.Name = "GroupTreeView";
            this.GroupTreeView.Size = new System.Drawing.Size(265, 420);
            this.GroupTreeView.TabIndex = 1;
            this.GroupTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.GroupTreeView_NodeMouseClick);
            // 
            // groupModelBindingSource
            // 
            this.groupModelBindingSource.DataSource = typeof(FinaData.Models.GroupModel);
            // 
            // GrouopToolStrip
            // 
            this.GrouopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGroupBtn,
            this.EditGroupBtn,
            this.DeleteGroupBtn});
            this.GrouopToolStrip.Location = new System.Drawing.Point(0, 0);
            this.GrouopToolStrip.Name = "GrouopToolStrip";
            this.GrouopToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.GrouopToolStrip.Size = new System.Drawing.Size(266, 25);
            this.GrouopToolStrip.TabIndex = 0;
            this.GrouopToolStrip.Text = "GrouopToolStrip";
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddGroupBtn.Image = global::FinaApp.Properties.Resources.AddIcon;
            this.AddGroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(23, 22);
            this.AddGroupBtn.Text = "ჯგუფის დამატება";
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // EditGroupBtn
            // 
            this.EditGroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditGroupBtn.Image = global::FinaApp.Properties.Resources.EditIcon;
            this.EditGroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditGroupBtn.Name = "EditGroupBtn";
            this.EditGroupBtn.Size = new System.Drawing.Size(23, 22);
            this.EditGroupBtn.Text = "ჯგუფის ჩასწორება";
            this.EditGroupBtn.Click += new System.EventHandler(this.EditGroupBtn_Click);
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
            this.DeleteGroupBtn.Click += new System.EventHandler(this.DeleteGroupBtn_Click);
            // 
            // ProductToolStrip
            // 
            this.ProductToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductBtn,
            this.EditProductBtn,
            this.DeleteProductBtn,
            this.toolStripButton1,
            this.DiagramBtn});
            this.ProductToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductToolStrip.Name = "ProductToolStrip";
            this.ProductToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.ProductToolStrip.Size = new System.Drawing.Size(530, 25);
            this.ProductToolStrip.TabIndex = 0;
            this.ProductToolStrip.Text = "ProductToolStrip";
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
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteProductBtn.Image = global::FinaApp.Properties.Resources.RemoveIcon;
            this.DeleteProductBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(23, 22);
            this.DeleteProductBtn.Text = "პროდუქტის წაშლა";
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
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
            this.DiagramBtn.Click += new System.EventHandler(this.DiagramBtn_Click);
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
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(528, 420);
            this.ProductGridView.TabIndex = 1;
            this.ProductGridView.VirtualMode = true;
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
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(FinaData.Models.ProductModel);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupModelBindingSource)).EndInit();
            this.GrouopToolStrip.ResumeLayout(false);
            this.GrouopToolStrip.PerformLayout();
            this.ProductToolStrip.ResumeLayout(false);
            this.ProductToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip GrouopToolStrip;
        private ToolStripButton AddGroupBtn;
        private ToolStripButton EditGroupBtn;
        private ToolStripButton DeleteGroupBtn;
        private ToolStrip ProductToolStrip;
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
        private BindingSource groupModelBindingSource;
    }
}