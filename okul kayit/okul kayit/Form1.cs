using Microsoft.EntityFrameworkCore;
using okul_kayit.modelller;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace okul_kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veritaban vt = new veritaban();

            vt.ogrencilerr.Load();
            vt.siniflar.Load();
            dataGridView1.DataSource = vt.ogrencilerr.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
        }
    }
}
