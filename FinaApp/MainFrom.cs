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
        PopulateTreeView(null, null);
        ProductGridView.DataSource = _db.Production.ToList();
    }

    private void AddProductBtn_Click(object sender, EventArgs e)
    {
        ProductForm productForm = new(_db, new ProductModel() {StartDate = DateTime.Now, EndDate = DateTime.Now});
        productForm.ShowDialog();
        ProductGridView.DataSource = _db.Production.ToList();
    }

    private void EditProductBtn_Click(object sender, EventArgs e)
    {
        var product = GetSelectedProduct();
        if (product == null) return;
        ProductForm productForm = new(_db, product);
        productForm.ShowDialog();
        ProductGridView.DataSource = _db.Production.ToList();
    }



    private void DeleteProductBtn_Click(object sender, EventArgs e)
    {
        var product = GetSelectedProduct();
        if (product == null) return;
        _db.Remove(product);
        _db.SaveChanges();
        ProductGridView.DataSource = _db.Production.ToList();
    }

    private ProductModel? GetSelectedProduct()
    {
        return (ProductModel?) ProductGridView?.CurrentRow?.DataBoundItem;
    }
    private GroupModel? GetSelectedGrpup()
    {
        return (GroupModel?)GroupTreeView?.SelectedNode?.Tag;
    }

    private void PopulateTreeView(int? parentId, TreeNode? parentNode)
    {
        var children = _db.Groups
            .Include(gr => gr.ParentGroup)
            .Where(gr => (parentId == null && gr.ParentGroup == null) 
                         || (gr.ParentGroup != null && gr.ParentGroup.Id == parentId)).ToList();
            
        foreach (GroupModel gr in children)
        {
            TreeNode? childNode = new() {
                Text = gr.Name,
                Name = gr.Id.ToString()
            };

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

    private void AddGroupBtn_Click(object sender, EventArgs e)
    {
        
    }

    private void DeleteGroupBtn_Click(object sender, EventArgs e)
    {
        var grpup = GetSelectedGrpup();
        if (grpup == null) return;
        _db.Remove(grpup);
        _db.SaveChanges();
        GroupTreeView.SelectedNode.Remove();
        GroupTreeView.Refresh();
        ProductGridView.DataSource = _db.Production.ToList();
    }

    private void DiagramBtn_Click(object sender, EventArgs e)
    {
        DiagramForm diagramForm  = new DiagramForm(_db.Production.ToList());
        diagramForm.ShowDialog();
    }




    private void EditGroupBtn_Click(object sender, EventArgs e)
    {

    }


}