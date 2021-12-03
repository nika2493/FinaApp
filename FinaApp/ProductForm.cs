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
    private readonly ProductModel _product;
    private readonly bool _add;
    private readonly int _inputCode;
    private readonly string _inputName;


#pragma warning disable CS8618
    public ProductForm(ProductionDbContext db, ProductModel product, bool add)
#pragma warning restore CS8618
    {
        _db = db;
        _product = product;
        _add = add;
        InitializeComponent();
        if (add)
        {
            ProductCodeTextBox.Value = GetFreeCode();
            AutoRadioButton.Checked = true;
        }
        else
        {
            _inputName = _product.Name;
            _inputCode = _product.Code;
            ManualRadioButton.Checked = true;
            ProductCodeTextBox.Value = _product.Code;
            ProductNameTextBox.Text = _product.Name;
            ProductPriceTextBox.Value = _product.Price;
            ProductCountryComboBox.SelectedItem = _product.Country;
        }

        ProductStartDateTimePicker.Value = _product.StartDate;
        ProductEndDateTimePicker.Value = _product.EndDate;

        ProductCountryComboBox.DataSource = _db.Countries.ToList();
        ProductCountryComboBox.DisplayMember = "Name";
        ProductCountryComboBox.ValueMember = "Id";
        if (_product?.Country != null)
            ProductCountryComboBox.SelectedValue = _product.Country.Id;
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
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



        if (CheckName(ProductNameTextBox.Text))
        {
            MessageBox.Show("პროდუქტი უკვე არსებობს", "შეცდომა!", MessageBoxButtons.OK);
            return;
        }
        if (ProductStartDateTimePicker.Value > ProductEndDateTimePicker.Value)
        {
            MessageBox.Show("დაწყება/დასრულების თარიღი არასწორია", "შეცდომა!", MessageBoxButtons.OK);
            return;
        }
        if(ProductPriceTextBox.Value<0.01m)
        {
            MessageBox.Show("ფასი არასწორია", "შეცდომა", MessageBoxButtons.OK);
            return;
        }
        if (CheckCode((int)ProductCodeTextBox.Value))
        {
            MessageBox.Show((int)ProductCodeTextBox.Value + " კოდი უკვე გამოყენებულია", "შეცდომა!", MessageBoxButtons.OK);
            AutoRadioButton.Checked=true;
            return;
        }
        if (string.IsNullOrEmpty(ProductNameTextBox.Text))
        {
            MessageBox.Show("სავალდებულო ველი: დასახელება", "შეცდომა!", MessageBoxButtons.OK);
            return;
        }
        _product.StartDate = ProductStartDateTimePicker.Value;
        _product.EndDate = ProductEndDateTimePicker.Value;
        _product.Code = (int)ProductCodeTextBox.Value;
        _product.Name = ProductNameTextBox.Text;
        _product.Price = ProductPriceTextBox.Value+0.00m;
        if (_add)
        {
            _db.Products.Add(_product);
            
        }
        else
        {
            _db.Products.Update(_product);
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

    private void AutoRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        ProductCodeTextBox.Value = GetFreeCode();
        ProductCodeTextBox.Enabled = false;
    }


    private void ManualRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        ProductCodeTextBox.Enabled = true;
    }

    private int GetFreeCode()
    {
        int freeCode = 1;
        var codes = _db.Products.Select(x => x.Code).ToList();
        codes.Sort();
        if (!_add)
            codes.Remove(_product.Code);
        foreach (int code in codes)
        {
            freeCode = code + 1;
            if (!codes.Contains(freeCode))
                return freeCode;
        }
        return freeCode;
    }

    private bool CheckCode(int code)
    {
        var codes = _db.Products.Select(x => x.Code).ToList();
        codes.Sort();
        if (!_add && code == _inputCode) return false;
        if (codes.Contains(code)) return true;
        return false;
    }

    private bool CheckName(string name)
    {
        var names = _db.Products.Select(x => x.Name).ToList();
        names.Sort();
        if (!_add && name == _inputName) return false;
        if (names.Contains(name)) return true;
        return false;
    }

    private void ProductPriceTextBox_Leave(object sender, EventArgs e)
    {
        ProductPriceTextBox.Value += 0.00m;
    }
}