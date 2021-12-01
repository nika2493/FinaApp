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

public partial class ProductForm : Form
{
    private readonly ProductionDbContext _db;
    private readonly ProductModel? _product;
    public ProductForm(ProductionDbContext db, ProductModel product)
    {
        _db = db;
        _product = product;
        InitializeComponent();


        ProductCodeTextBox.Value = _product.Code;
        ProductNameTextBox.Text = _product.Name;
        ProductPriceTextBox.Value = _product.Price;
        ProductCountryComboBox.SelectedItem = _product.Country;
        ProductStartDateTimePicker.Value = _product.StartDate;
        ProductEndDateTimePicker.Value = _product.EndDate;
        ProductCountryComboBox.DataSource = _db.Countries.ToList();
        ProductCountryComboBox.DisplayMember = "Name";
        ProductCountryComboBox.ValueMember = "Id";
        if (_product?.Country != null)
            ProductCountryComboBox.SelectedValue = _product.Country.Id;
        ProductCountryComboBox.Invalidate();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        if (_product != null)
        {
            _product.Code = (int)ProductCodeTextBox.Value;
            _product.Name = (string)ProductNameTextBox.Text;
            _product.Price = (decimal)ProductPriceTextBox.Value;
            if (ProductCountryComboBox.SelectedItem == null && !string.IsNullOrEmpty(ProductCountryComboBox.Text) &&
                _db.Countries.FirstOrDefault(x => x.Name == ProductCountryComboBox.Text) == null)
            {
                CountryModel countryModel = new() {Name = ProductCountryComboBox.Text.ToString()};
                _db.Countries.Add(countryModel);
                _db.SaveChanges();
                ProductCountryComboBox.DataSource = _db.Countries.ToList();
                ProductCountryComboBox.SelectedItem = countryModel;
            }

            _product.Country = ProductCountryComboBox.SelectedItem as CountryModel;
            _product.StartDate = ProductStartDateTimePicker.Value;
            _product.EndDate = ProductEndDateTimePicker.Value;

            if (_db.Production.FirstOrDefault(x => x.Id == _product.Id) == null)
            {
                _db.Production.Add(_product);
            }
            else
            {
                _db.Production.Update(_product);
            }
        }

        _db.SaveChanges();
        Close();
    }

    private void AddCountryBtn_Click(object sender, EventArgs e)
    {
        string countryText = ProductCountryComboBox.Text;
        if (string.IsNullOrEmpty(countryText)) return;
        if (_db.Countries.FirstOrDefault(x => x.Name == countryText)!=null) return;
        CountryModel countryModel = new() { Name = countryText };
        _db.Countries.Add(countryModel);
        _db.SaveChanges();
        ProductCountryComboBox.DataSource =_db.Countries.ToList();
        ProductCountryComboBox.SelectedItem = countryModel;

    }

    private void RemoveCountryBtn_Click(object sender, EventArgs e)
    {
        if(ProductCountryComboBox.SelectedItem == null) return;
        CountryModel country = (CountryModel)ProductCountryComboBox.SelectedItem;
        _db.Countries.Remove(country);
        _db.SaveChanges();
        ProductCountryComboBox.DataSource = _db.Countries.ToList();
        if (ProductCountryComboBox.SelectedItem == null)
            ProductCountryComboBox.Text="";
    }
}