using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinaData.Data;
using FinaData.Models;

namespace FinaApp;
public partial class GroupForm : Form
{
    private readonly ProductionDbContext _db;
    private readonly GroupModel _group;
    private readonly bool _add;
    public GroupForm(ProductionDbContext db, GroupModel group, bool add)
    {
        _db = db;
        _group = group;
        _add = add;
        InitializeComponent();

        if (add)
        {
            _group = new(){ParentGroup = group};
        }
        else GroupTextBox.Text = _group.Name;
        if (_group.ParentGroup == null)
        {
            IsRootCheckBox.Checked = true;
            IsRootCheckBox.Enabled = false;
        }
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(GroupTextBox.Text))
        {
            MessageBox.Show( "სავალდებულო ველი: კატეგორია", "შეცდომა", MessageBoxButtons.OK);
            GroupTextBox.Text = _group.Name;
            return;
        }

        if(IsRootCheckBox.Checked)
            _group.ParentGroup=null;
        _group.Name = GroupTextBox.Text;
        if (_add)
        {
            _db.Groups.Add(_group);
        }
        else
        {
            _db.Groups.Update(_group);
        }
        _db.SaveChanges();
        Close();
    }
}
