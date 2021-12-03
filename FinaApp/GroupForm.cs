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
    private readonly string _inputName;
#pragma warning disable CS8618
    public GroupForm(ProductionDbContext db, GroupModel group, bool add)
#pragma warning restore CS8618
    {
        _db = db;
        _group = group;
        _add = add;
        InitializeComponent();

        if (add)
        {
            _group = new GroupModel {ParentGroup = group};
        }
        else
        {
            _inputName = group.Name;
            GroupTextBox.Text = _group.Name;
        }

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
            MessageBox.Show( "სავალდებულო ველი: კატეგორია", "შეცდომა!", MessageBoxButtons.OK);
            GroupTextBox.Text = _group.Name;
            return;
        }
        if (CheckName(GroupTextBox.Text))
        {
            MessageBox.Show("კატეგორია უკვე არსებობს", "შეცდომა!", MessageBoxButtons.OK);
            return;
        }

        if (IsRootCheckBox.Checked)
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
    private bool CheckName(string name)
    {
        var names = _db.Groups.Select(x => x.Name).ToList();
        names.Sort();
        if (!_add && name == _inputName) return false;
        if (names.Contains(name)) return true;
        return false;
    }
}
