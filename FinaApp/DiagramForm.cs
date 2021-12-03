using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinaData.Models;

namespace FinaApp;
public partial class DiagramForm : Form
{
    private readonly List<ProductModel> _products;
    private readonly DateTime _minDate;
    private readonly DateTime _maxDate;
    public DiagramForm(List<ProductModel> products)
    {
        _products = products;
        _minDate = GetMinDateFromList(_products);
        _maxDate = GetMaxDateFromList(_products);
        InitializeComponent();
        ProductDiagramDataGridView.Columns.Add("product", "პროდუქტი");


        while (_minDate<=_maxDate)
        {
            string columnName = _minDate.Date.ToString("dd/MM/yyyy");
            ProductDiagramDataGridView.Columns.Add(columnName, columnName);
            _minDate=_minDate.AddDays(1);
        }
        _minDate = GetMinDateFromList(_products);
        _maxDate = GetMaxDateFromList(_products);
        int i = 0;
        foreach (ProductModel product in _products)
        {
            var productLifeCycle = (product.EndDate - product.StartDate).Days+1;
            var startColumnIndex = (product.StartDate - _minDate).Days;
            ProductDiagramDataGridView.Rows.Add(product.Name);
            while (productLifeCycle>0)
            {
                ProductDiagramDataGridView.Rows[i].Cells[startColumnIndex + productLifeCycle].Value = "";
                productLifeCycle--;
            }
            i++;
        }

    }

    private DateTime GetMaxDateFromList(IReadOnlyCollection<ProductModel> products)
    {
        DateTime result = products.FirstOrDefault()!.EndDate;
        foreach (ProductModel product in products.Where(product => result < product.EndDate))
        {
            result=product.EndDate;
        }
        return result;
    }
    private DateTime GetMinDateFromList(IReadOnlyCollection<ProductModel> products)
    {
        DateTime result = products.FirstOrDefault()!.StartDate;
        foreach (ProductModel product in products.Where(product => result > product.StartDate))
        {
            result = product.StartDate;
        }
        return result;
    }


    private void ProductDiagramDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        int columnIndex = e.ColumnIndex;
        if (columnIndex == 0) 
            e.CellStyle.BackColor = Color.Blue;
        else if(e.Value!=null)
            e.CellStyle.BackColor=Color.Green;
        else 
            e.CellStyle.BackColor = Color.Red;
    }

    private void ProductDiagramDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        ProductDiagramDataGridView.ClearSelection();
    }
}
