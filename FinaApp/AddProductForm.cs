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
using Microsoft.EntityFrameworkCore;

namespace FinaApp;

public partial class AddProductForm : Form
{
    private readonly ProductionDbContext _db;
    private ProductModel _product = new();
    public AddProductForm(ProductionDbContext db)
    {
        _db = db;

        InitializeComponent();

        ProductCountryComboBox.DataSource = _db.Countries.ToList();
        ProductCountryComboBox.DisplayMember = "Name";
        ProductCountryComboBox.ValueMember = "Id";
        ProductCountryComboBox.SelectedIndex = 0;
        ProductCountryComboBox.Invalidate();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        _product.Code = (int)ProductCodeTextBox.Value;
        _product.Name = (string)ProductNameTextBox.Text;
        _product.Price = (decimal)ProductPriceTextBox.Value;
        _product.Country = (CountryModel)ProductCountryComboBox.SelectedItem;
        _product.StarDate = ProductStartDateTimePicker.Value;
        _product.EndDate = ProductEndDateTimePicker.Value;
        _db.Production.Add(_product);
        _db.SaveChanges();
        Close();
    }
}