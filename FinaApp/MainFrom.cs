using FinaData.Data;

namespace FinaApp;

    public partial class MainForm : Form
    {
        private readonly ProductionDbContext _db = new();

        public MainForm()
        {
            InitializeComponent();
            ProductGridView.DataSource = _db.Production.ToList();

        }

    private void AddProductBtn_Click(object sender, EventArgs e)
    {
        AddProductForm addProduct = new(_db);
        addProduct.ShowDialog();
        ProductGridView.DataSource = _db.Production.ToList();
    }
}
