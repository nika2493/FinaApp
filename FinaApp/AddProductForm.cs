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

public partial class AddProductForm : Form
{
    private readonly ProductionDbContext _db;
    private ProductModel Product { get; set; } = new();
    public AddProductForm(ProductionDbContext db)
    {
        _db = db;
        InitializeComponent();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        Product.Code = (int)ProductCodeTextBox.Value;
        Product.Name = (string)ProductNameTextBox.Text;
        Product.Price = (decimal)ProductPriceTextBox.Value;
        Product.Country = (CountryModel)ProductCountryComboBox.SelectedItem;
        Product.StarDate = ProductStartDateTimePicker.Value;
        Product.EndDate = ProductEndDateTimePicker.Value;
        _db.AddAsync(Product);
        _db.SaveChangesAsync();
        Close();
    }
}