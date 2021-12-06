using FinaApp.Services.Abstraction;
using FinaData.Models;

namespace FinaDesktop;

public partial class MainForm : Form
{
    private readonly IProductionService _productionService;
    public MainForm(IProductionService productionService)
    {
        _productionService = productionService;
        InitializeComponent();
        UpdateTreeView();
        GroupTreeView.SelectedNode = null;
    }

    // Utility
    private ProductModel? GetSelectedProduct()
    {
        return (ProductModel?) ProductGridView?.CurrentRow?.DataBoundItem;
    }

    private GroupModel? GetSelectedGroup()
    {
        return (GroupModel?) GroupTreeView?.SelectedNode?.Tag;
    }

    private void UpdateDataGrid()
    {
        ProductGridView.DataSource = GetProductsFromGroup(GetSelectedGroup());
        if(GetProductsFromGroup(GetSelectedGroup()).Count==0)
        {
            EditProductBtn.Enabled = false;
            DeleteProductBtn.Enabled = false;
            DiagramBtn.Enabled = false;
        }
        else
        {
            EditProductBtn.Enabled = true;
            DeleteProductBtn.Enabled = true;
            DiagramBtn.Enabled = true;
        }
    }

    private List<ProductModel> GetProductsFromGroup(GroupModel? groupModel)
    {
        List<ProductModel> products =new();
        if (groupModel != null) 
            foreach (GroupModel group in _productionService.GetAllChildGroupById(groupModel.Id))
            {
                products.AddRange(GetProductsFromGroup(group));
            }

        if (groupModel?.Production != null)
        {
            products.AddRange(groupModel?.Production!);
        }

        products.Sort((x, y) => x.Id.CompareTo(y.Id));
        return products;
    }


    private void UpdateTreeView()
    {
        GroupTreeView.Nodes.Clear();
        PopulateTreeView(null,null);
        GroupTreeView.ExpandAll();
        GroupTreeView.SelectedNode=GroupTreeView.TopNode;
        if(GroupTreeView.Nodes.Count==0)
        {
            EditGroupBtn.Enabled = false;
            DeleteGroupBtn.Enabled = false;
            AddProductBtn.Enabled = false;
            DiagramBtn.Enabled = false;
        }
        else
        {
            EditGroupBtn.Enabled = true;
            DeleteGroupBtn.Enabled = true;
            AddProductBtn.Enabled = true;
            DiagramBtn.Enabled = true;
        }
        UpdateDataGrid();
    }

    private void PopulateTreeView(int? parentId, TreeNode? parentNode)
    {
        List<GroupModel>? children = _productionService.GetAllChildGroupById(parentId);

        //if (children == null) return;

        foreach (GroupModel? gr in children)
        {
            TreeNode? childNode = new() { Text = gr.Name, Name = gr.Id.ToString(), Tag = gr };
            if (parentNode == null)
            {
                GroupTreeView.Nodes.Add(childNode);
            }
            else
            {
                parentNode.Nodes.Add(childNode);
            }
            PopulateTreeView(gr.Id, childNode);
        }
    }


    // Diagram
    private void DiagramBtn_Click(object sender, EventArgs e)
    {
        DiagramForm diagramForm = new(GetProductsFromGroup(GetSelectedGroup()));
        diagramForm.ShowDialog();
    }


    // ProductGridView
    private void AddProductBtn_Click(object sender, EventArgs e)
    {
        if(GetSelectedGroup()==null) return;
        ProductForm productForm = new(_productionService, new ProductModel() {StartDate = DateTime.Today, EndDate = DateTime.Today, Group = GetSelectedGroup()}, true );
        productForm.ShowDialog();
        UpdateDataGrid();
    }

    private void EditProductBtn_Click(object sender, EventArgs e)
    {
        ProductModel? product = GetSelectedProduct();
        if (product == null) return;
        ProductForm productForm = new(_productionService, product, false);
        productForm.ShowDialog();
        UpdateDataGrid();
    }

    private  void DeleteProductBtn_Click(object sender, EventArgs e)
    {
        ProductModel? product = GetSelectedProduct();
        if (product == null) return;
        DialogResult result = MessageBox.Show("გსურთ პროდუქტის წაშლა?", "გაფრთხილება!", MessageBoxButtons.YesNo);
        if (result == DialogResult.No) return;
        _productionService.DeleteProduct(product);
        UpdateDataGrid();
    }


    // GroupTreeView
    private void AddGroupBtn_Click(object sender, EventArgs e)
    {
        GroupForm groupForm = new(_productionService, GetSelectedGroup()!,true);
        groupForm.ShowDialog();
        UpdateTreeView();
    }

    private void EditGroupBtn_Click(object sender, EventArgs e)
    {
        GroupModel? group = GetSelectedGroup();
        if (group == null) return;
        GroupForm groupForm = new(_productionService, group, false);
        groupForm.ShowDialog();
        UpdateTreeView();
    }

    private  void DeleteGroupBtn_Click(object sender, EventArgs e)
    {
        GroupModel? group = GetSelectedGroup();
        if (group == null) return;
        var result = MessageBox.Show("გსურთ კატეგორიის და შემავალი პროდუქციის წაშლა?", "გაფრთხილება!", MessageBoxButtons.YesNo);
        if (result == DialogResult.No ) return;
        if (_productionService.GroupHasChildGroup(group))
        {
            result = MessageBox.Show("კატეგორია შეიცავს ქვე კატეგორიებს გსურთ მათი წაშლა?", "გაფრთხილება!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<GroupModel>? groups = _productionService.GetAllChildGroupById(group.Id);
                groups?.Add(group);
                _productionService.DeleteGroupRange(groups!);
                List<ProductModel> products = GetProductsFromGroup(GetSelectedGroup());
                _productionService.DeleteProductRange(products);
                UpdateTreeView();
                return;
            }
        }

        foreach (GroupModel gr in _productionService.GetAllGroup())
        {
            if (gr.ParentGroup != null && gr.ParentGroup.Id == group.Id)
            {
                gr.ParentGroup = group.ParentGroup;
                _productionService.UpdateGroup(gr);
            }
        }

        var list = _productionService.GetProductsByGroup(group);
        _productionService.DeleteProductRange(list);
        _productionService.DeleteGroup(group);
        UpdateTreeView();
    }

    private void GroupTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        GroupTreeView.SelectedNode = e.Node;
        UpdateDataGrid();
    }
}