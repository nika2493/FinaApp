using FinaApp.Services.Abstraction;
using FinaData.Models;

namespace FinaDesktop;

public partial class ProductForm : Form
{
    private readonly IProductionService _productionService;
    private readonly ProductModel _product;
    private readonly bool _add;
    private readonly int? _inputCode;
    private readonly string? _inputName;
    public ProductForm(IProductionService productionService, ProductModel product, bool add)
    {
        _productionService = productionService;
        _product = product;
        _add = add;
        InitializeComponent();
        if (_add)
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
        Initialize();

    }

    private  void Initialize()
    {
        ProductStartDateTimePicker.Value = _product.StartDate;
        ProductEndDateTimePicker.Value = _product.EndDate;
        ProductCountryComboBox.DataSource = _productionService.GetAllCountries();
        ProductCountryComboBox.DisplayMember = "Name";
        ProductCountryComboBox.ValueMember = "Id";
        if (_product?.Country != null)
            ProductCountryComboBox.SelectedValue = _product.Country.Id;
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private  void SaveBtn_Click(object sender, EventArgs e)
    {
        if (ProductCountryComboBox.SelectedItem == null && !string.IsNullOrEmpty(ProductCountryComboBox.Text) &&
            _productionService.GetCountryByName(ProductCountryComboBox.Text) == null)
        {
            CountryModel country = new() {Name = ProductCountryComboBox.Text.ToString()};
            _productionService.CreateCountry(country);
            ProductCountryComboBox.DataSource = _productionService.GetAllCountries();
            ProductCountryComboBox.SelectedItem = country;
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
            _productionService.CreateProduct(_product);
        }
        else
        {
            _productionService.UpdateProduct(_product);
        }
        Close();
    }

    private  void AddCountryBtn_Click(object sender, EventArgs e)
    {
        string countryText = ProductCountryComboBox.Text;
        if (string.IsNullOrEmpty(countryText)) return;
        if (_productionService.GetCountryByName(countryText)!=null) return;
        CountryModel country = new() { Name = countryText };
        _productionService.CreateCountry(country);
        ProductCountryComboBox.DataSource = _productionService.GetAllCountries();
        ProductCountryComboBox.SelectedItem = country;
    }

    private  void RemoveCountryBtn_Click(object sender, EventArgs e)
    {
        if (ProductCountryComboBox.SelectedItem == null) return;
        CountryModel country = (CountryModel)ProductCountryComboBox.SelectedItem;
        _productionService.DeleteCountry(country);
        ProductCountryComboBox.DataSource = _productionService.GetAllCountries();
        if (ProductCountryComboBox.SelectedItem == null)
            ProductCountryComboBox.Text = "";
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
        List<int> codes = _productionService.GetAllProductCodes();
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
        List<int> codes = _productionService.GetAllProductCodes();
        codes.Sort();
        if (!_add && code == _inputCode) return false;
        if (codes.Contains(code)) return true;
        return false;
    }

    private bool CheckName(string name)
    {
        List<string> names = _productionService.GetAllProductNames();
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