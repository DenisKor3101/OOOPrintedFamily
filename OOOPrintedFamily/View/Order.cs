using OOOPrintedFamily.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace OOOPrintedFamily.View
{
    public partial class Order : Form
    {
        Catalog catalog;
        List<Catalog.FillCart> listProduct;
        public Order(Catalog catalog, List<Catalog.FillCart> listProduct)
        {
            InitializeComponent();
            this.catalog = catalog;
            this.listProduct = listProduct;
        }

        DateTime dateOrder;
        DateTime dateDeliver;
        int codeDeliver;
        double cost ;
        double sum ;
        int orderID;
        int countProduct;
        double discount;
        int count;

        private void Order_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = ColorTranslator.FromHtml("#34C6CD");
            tableLayoutPanelBottom.BackColor = ColorTranslator.FromHtml("#34C6CD");

            if (Helper.roleID == 3)
                labelFIO.Text = Helper.fullName;

            comboBoxPointInIssue.DataSource = Helper.DBContext.PointInIssue.ToList();
            comboBoxPointInIssue.DisplayMember = "PointInIssueName";
            comboBoxPointInIssue.ValueMember = "PointInIssueId";

          
            info();




        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы дейтвительно хотите перейти обратно к товарам?", "Возврат к товарам", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                catalog.Show();
                catalog.textBoxSearch.Clear();
                catalog.loadinfo();
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dataGridViewMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void info()
        {
            dataGridViewMain.Rows.Clear();

            int i = 0;
            foreach (var c in listProduct)
            {
                foreach (var item in c.cart)
                {
                    dataGridViewMain.Rows.Add();

                    countProduct += c.count;

                    dataGridViewMain.Rows[i].Cells[0].Value = item.ProductArticul;
                    if (item.ProductImage != null)
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])(item.ProductImage);
                        MemoryStream mem = new MemoryStream(data);
                        Image image = Image.FromStream(mem);
                        Bitmap img = new Bitmap(image, 100, 100);
                        dataGridViewMain.Rows[i].Cells[1].Value = img;
                    }
                    else
                    {
                        Bitmap bmp = Properties.Resources.picture;
                        Bitmap bmpSize = new Bitmap(bmp, new Size(100, 100));
                        dataGridViewMain.Rows[i].Cells[1].Value = bmpSize;
                    }
                    if (item.ProductDiscount != 0)
                    {
                        discount = (double)item.ProductCost - ((double)item.ProductCost / (100 / item.ProductDiscount));
                    }
                    else
                        discount = (double)item.ProductCost;

                    dataGridViewMain.Rows[i].Cells[2].Value = "Название: " + item.Name.NameName + "\n" + "Описание: " + item.ProductDiscription + "\n" + "Цена: " + item.ProductCost + "\n" + "Скидка: " + item.ProductDiscount + "\n" + "Цена со скидкой: " + discount;

                    if (item.ProductCountInStoke == 0)
                        dataGridViewMain.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(73, 140, 81);

                    dataGridViewMain.Rows[i].Cells[3].Value = "Количество на складе: " + item.ProductCountInStoke;
                    dataGridViewMain.Rows[i].Cells[4].Value = "Количество товара: " + c.count;

                    cost += Convert.ToDouble(item.ProductCost) * c.count;

                    sum += Convert.ToDouble(item.ProductCost) - (Convert.ToDouble(item.ProductCost) * (Convert.ToDouble(item.ProductDiscount) / 100)) * c.count;
                    if (item.ProductCountInStoke <= 3)
                        dateDeliver = DateTime.Now.AddDays(6);
                    else dateDeliver = DateTime.Now.AddDays(3);


                    i++;
                }

            }
            richTextBoxMain.Text = "Количество товаров в заказе: " + listProduct.Count + "\n" + "Количество позиций в заказе: " + countProduct + "\n" + "Сумма заказа: " + cost.ToString() + "\n" + "Сумма заказа со скидкой: " + sum.ToString();

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            codeDeliver = random.Next(100, 1000);
            dateOrder = DateTime.Now;
            string fio;
            if (Helper.fullName != null)
                fio = Helper.fullName;
            else fio = null;
            orderID = Helper.DBContext.Order.ToList().Last().OrderId + 1;


            var order = new Entity.Order()
            {
                OrderId = orderID,
                OrderDate = Convert.ToDateTime(dateOrder.ToShortDateString()),
                OrderDeliveryDate = Convert.ToDateTime(dateDeliver.ToShortDateString()),
                PointInIssueId = (int)comboBoxPointInIssue.SelectedValue,
                OrderFIOClient = fio,
                OrderCode = codeDeliver,
                StatusId = 1

            };

            try
            {
                Helper.DBContext.Order.Add(order);
                Helper.DBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            foreach (var c in listProduct)
            {
                foreach (var item in c.cart)
                {
                    var orderProduct = new Entity.CompositionOrder()
                    {
                        OrderID = orderID,
                        ProductArticul = item.ProductArticul,
                        OrderProductCount = c.count
                    };
                    Helper.DBContext.CompositionOrder.Add(orderProduct);

                }
            }

            try
            {
                Helper.DBContext.SaveChanges();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message); 
                return; 
            }

            MessageBox.Show("Заказ оформлен!");


        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция еще не реализована!");
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
           
                DialogResult dialogResult = MessageBox.Show("Вы дейтвительно хотите удилить товар?", "Удаленик товара", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    listProduct.RemoveAt(e.RowIndex);
                    dataGridViewMain.Rows.RemoveAt(e.RowIndex);
                }
                else
                {

                }
               
            }
        }
    }
}
