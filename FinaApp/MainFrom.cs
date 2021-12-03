using System.Security.Cryptography.X509Certificates;
using FinaData.Data;
using FinaData.Models;
using Microsoft.EntityFrameworkCore;

namespace FinaApp;

public partial class MainForm : Form
{
    private readonly ProductionDbContext _db = new();

    public MainForm()
    {
        InitializeComponent();
        UpdateTreeView();
        GroupTreeView.SelectedNode = null;
    }

    /// <summary>
    /// Utility
    /// </summary>
    /// <returns></returns>
    private ProductModel? GetSelectedProduct()
    {
        return (ProductModel?) ProductGridView?.CurrentRow?.DataBoundItem;
    }

    private GroupModel? GetSelectedGroup()
    {
        return (GroupModel?) GroupTreeView?.SelectedNode?.Tag;
    }

    private TreeNode? GetSelectedNode()
    {
        return GroupTreeView?.SelectedNode;
    }

    private void UpdateDataGrid()
    {
        ProductGridView.DataSource = GetProductsFromSelectedGroup(GetSelectedGroup());
        if(GetProductsFromSelectedGroup(GetSelectedGroup()).Count==0)
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

    private List<ProductModel> GetProductsFromSelectedGroup(GroupModel? groupModel)
    {
        List<ProductModel> products =new();
        foreach (GroupModel group in GetAllChildGroup(groupModel?.Id)!)
        {
            products.AddRange(GetProductsFromSelectedGroup(group));
        }

        if (groupModel?.Production != null)
        {
            products.AddRange(groupModel?.Production!);
        }

        return products;
    }

    private List<GroupModel>? GetAllChildGroup(int? parentId)
    {
        return _db.Groups.Include(gr=>gr.Production)
            .Include(gr => gr.ParentGroup)
            .Where(gr => (parentId == null && gr.ParentGroup == null)
                         || (gr.ParentGroup != null && gr.ParentGroup.Id == parentId)).ToList();
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
        List<GroupModel>? children = GetAllChildGroup(parentId);

        if (children == null) return;

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

    /// <summary>
    /// Diagram
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DiagramBtn_Click(object sender, EventArgs e)
    {
        DiagramForm diagramForm = new(GetProductsFromSelectedGroup(GetSelectedGroup()));
        diagramForm.ShowDialog();
    }

    /// <summary>
    /// ProductGridView
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddProductBtn_Click(object sender, EventArgs e)
    {
        if(GetSelectedGroup()==null) return;
        ProductForm productForm = new(_db, new ProductModel() {StartDate = DateTime.Now, EndDate = DateTime.Now, Group = GetSelectedGroup()} );
        productForm.ShowDialog();
        UpdateDataGrid();
    }

    private void EditProductBtn_Click(object sender, EventArgs e)
    {
        ProductModel? product = GetSelectedProduct();
        if (product == null) return;
        ProductForm productForm = new(_db, product);
        productForm.ShowDialog();
        UpdateDataGrid();
    }

    private void DeleteProductBtn_Click(object sender, EventArgs e)
    {
        ProductModel? product = GetSelectedProduct();
        if (product == null) return;
        _db.Products.Remove(product);
        _db.SaveChanges();
        UpdateDataGrid();
    }


    /// <summary>
    /// GroupTreeView
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddGroupBtn_Click(object sender, EventArgs e)
    {
        GroupForm groupForm = new(_db, GetSelectedGroup(),true);
        groupForm.ShowDialog();
        UpdateTreeView();
    }

    private void EditGroupBtn_Click(object sender, EventArgs e)
    {
        GroupModel? group = GetSelectedGroup();
        if (group == null) return;
        GroupForm groupForm = new(_db, group, false);
        groupForm.ShowDialog();
        UpdateTreeView();
    }

    private void DeleteGroupBtn_Click(object sender, EventArgs e)
    {
        GroupModel? group = GetSelectedGroup();
        if (group == null) return;
        foreach (GroupModel gr in _db.Groups)
        {
            if (gr.ParentGroup != null&&gr.ParentGroup.Id == group.Id)
            {
                gr.ParentGroup = group.ParentGroup;
                _db.Groups.Update(gr);
            }
        }
        var list = _db.Products.Where(x => x.Group == group).ToList();
        _db.Products.RemoveRange(list);
        _db.Groups.Remove(group);
        _db.SaveChanges();
        UpdateTreeView();
    }

    private void GroupTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        GroupTreeView.SelectedNode =e.Node;
        UpdateDataGrid();
    }
}