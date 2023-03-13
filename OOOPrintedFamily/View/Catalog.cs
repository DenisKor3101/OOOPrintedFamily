using OOOPrintedFamily.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OOOPrintedFamily.View
{
    public partial class Catalog : Form
    {
        Autorisation au;
        Bitmap bmp;
        Bitmap bmpSize;
        double countAmount = 0;

        public List<FillCart> listcart = new List<FillCart>();
        public Catalog(Autorisation au)
        {
            InitializeComponent();
            this.au = au;
        }

        public class FillCart
        {
            public int id;
            public List<Product> cart = new List<Product>();
            public int count;
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = ColorTranslator.FromHtml("#34C6CD");
            tableLayoutPanelBottom.BackColor = ColorTranslator.FromHtml("#34C6CD");
            loadinfo();
            comboBoxFilterCost.SelectedIndex = 0;
            comboBoxFilterDiscount.SelectedIndex = 0;
            buttonOrder.Visible = false;
            buttonAdd.Visible = false;

            if(Helper.roleID == 1)
            {
                buttonAdd.Visible = true;
            }

            if(Helper.roleID == 1 || Helper.roleID == 2 || Helper.roleID == 3)
                dataGridViewMain.ContextMenuStrip = contextMenuStripMain;

            var newPol = new Pol()
            {
                PolId = 0,
                PolName = "Все категории"

            };

            var pol = Helper.DBContext.Pol.ToList();
            pol.Insert(0, newPol);
            comboBoxPol.DataSource = pol;
            comboBoxPol.ValueMember = "PolId";
            comboBoxPol.DisplayMember = "PolName";

            comboBoxPol.SelectedIndex = 0;
        }
        int countAll;
      
        public void loadinfo()
        {

          

            dataGridViewMain.Rows.Clear();

            int i = 0;
            

            var product = Helper.DBContext.Product.ToList();

            countAll = product.Count;

          

            if (!String.IsNullOrEmpty(textBoxSearch.Text))
            {
                product = product.Where(x => x.Name.NameName.Contains(textBoxSearch.Text)).ToList();
            }

            if (comboBoxPol.SelectedIndex != 0 && comboBoxPol.SelectedIndex != -1 && comboBoxPol.SelectedValue != null)
                product = product.Where(x => x.PolId == (int)comboBoxPol.SelectedValue).ToList();

            switch (comboBoxFilterCost.SelectedIndex)
            {
                case 0: product = product.OrderBy(x => x.ProductCost).ToList(); break;
                case 1: product = product.OrderByDescending(x => x.ProductCost).ToList(); break;
            }

            switch (comboBoxFilterDiscount.SelectedIndex)
            {
                case 1: product = product.Where(x => x.ProductDiscount >= 0 && x.ProductDiscount <= 10).ToList(); break;
                case 2: product = product.Where(x => x.ProductDiscount >= 11 && x.ProductDiscount <= 14).ToList(); break;
                case 3: product = product.Where(x => x.ProductDiscount > 15).ToList(); break;
            }
            int countEnd;
            countEnd = product.Count;
            labelCount.Text = countEnd + " из " + countAll;

            foreach (var item in product)
            {

                dataGridViewMain.Rows.Add();

                dataGridViewMain.Rows[i].Cells[0].Value = item.ProductArticul;

                if (item.ProductImage == null)
                {
                    bmp = OOOPrintedFamily.Properties.Resources.picture;
                    bmpSize = new Bitmap(bmp, new Size(100, 100));
                    dataGridViewMain.Rows[i].Cells[1].Value = bmpSize;
                }
                else
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(item.ProductImage);
                    MemoryStream mem = new MemoryStream(data);
                    Bitmap bmp = new Bitmap(100, 100);
                    Image image = Image.FromStream(mem);
                    Bitmap img = new Bitmap(image, bmp.Size);
                    dataGridViewMain.Rows[i].Cells[1].Value = img;
                }

                countAmount = Convert.ToDouble(item.ProductCost) - (Convert.ToDouble(item.ProductCost) * (Convert.ToDouble(item.ProductDiscount) / 100));

                dataGridViewMain.Rows[i].Cells[2].Value = "Название товара: " + item.Name.NameName + '\n' + "Описание товара: " + item.ProductDiscription + '\n' + "Пол: " + item.Pol.PolName + '\n' + "Поставщик: " + item.Provider.ProviderName + '\n' + "Цена: " + item.ProductCost + " руб." + '\n' + "Скидка: " + item.ProductDiscount + " %" + '\n' + "Цена со скидкой: " + countAmount + " руб.";

                i++;

            }


        }

        private void comboBoxFilterCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadinfo();
        }

        private void comboBoxPol_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadinfo();
        }

        private void comboBoxFilterDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadinfo();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            loadinfo();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddEdit(this).ShowDialog();
        }

        public int curtentSell;

        private void dataGridViewMain_DoubleClick(object sender, EventArgs e)
        {
            if(Helper.roleID == 1)
            { 
                this.Hide();
                curtentSell = dataGridViewMain.CurrentRow.Index;
                string art = dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells[0].Value.ToString();
                new AddEdit(art, this).ShowDialog();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы дейтвительно хотите перейти обратно к авторизации?", "Возврат к товарам", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                au.Show();
                au.textBoxLogin.Clear();
                au.textBoxPassword.Clear();
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order(this, listcart).ShowDialog();

        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridViewMain.SelectedRows;
            if (selectedRow != null)
            {
                string articul = dataGridViewMain.Rows[selectedRow[0].Index].Cells[0].Value.ToString();
                var addProduct = Helper.DBContext.Product.Where(x => x.ProductArticul == articul).ToList().FirstOrDefault();
                if (addProduct != null)
                {
                    FillCart fillCart = new FillCart();
                    if (listcart.Where(x => x.cart.Contains(addProduct)).ToList().FirstOrDefault() == null)
                    {
                        fillCart.cart.Add(addProduct);
                        fillCart.count++;
                        listcart.Add(fillCart);
                        buttonOrder.Visible = true;
                    }
                    else
                    {
                        listcart.Where(x => x.cart.Contains(addProduct)).ToList().FirstOrDefault().count++;
                    }



                }
            }
        }

        private void dataGridViewMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewMain.ClearSelection();
            if (e.Button == MouseButtons.Right)
            {
                dataGridViewMain.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
