using FinaData.Data;

namespace FinaApp;

    public partial class MainForm : Form
    {
        private readonly ProductionDbContext _db = new();
        public MainForm()
        {
            InitializeComponent();
        }

    private void AddProductBtn_Click(object sender, EventArgs e)
    {
        AddProductForm addProduct = new(_db);
        addProduct.ShowDialog();
    }
}
