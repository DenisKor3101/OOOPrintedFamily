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

namespace OOOPrintedFamily.View
{
    public partial class AddEdit : Form
    {
        Catalog prodcat;
        Bitmap bmp;
        public AddEdit(Catalog prodcat)
        {
            InitializeComponent();
            this.prodcat = prodcat;
            labelMain.Text = "Добавление товара";
            buttonAddEdit.Text = "Добавить товар";
            this.Text = "Добавление товара";
            buttonAddEdit.Tag = "add";
            textBoxArticul.ReadOnly = false;
            buttonDelete.Visible = false;

            fillCombo();
        }
        string arrticul;

        public AddEdit(string articul, Catalog param)
        {
            InitializeComponent();
            arrticul = articul;
            this.prodcat = param;

            labelMain.Text = "Редактирование товара";
            buttonAddEdit.Text = "Редактировать товар";
            this.Text = "Редактирование товара";
            buttonAddEdit.Tag = "edit";
            textBoxArticul.ReadOnly = true;
            buttonDelete.Visible = true;

            fillCombo();
            infLoad(articul);
        }

        private void AddEdit_Load(object sender, EventArgs e)
        {
            tableLayoutPanelTop.BackColor = ColorTranslator.FromHtml("#34C6CD");
            tableLayoutPanelBottom.BackColor = ColorTranslator.FromHtml("#34C6CD");
        }

        public void fillCombo()
        {
            comboBoxName.DataSource = Helper.DBContext.Name.ToList();
            comboBoxName.DisplayMember = "NameName";
            comboBoxName.ValueMember = "NameId";

            comboBoxPol.DataSource = Helper.DBContext.Pol.ToList();
            comboBoxPol.DisplayMember = "PolName";
            comboBoxPol.ValueMember = "PolId";

            comboBoxSostav.DataSource = Helper.DBContext.Composition.ToList();
            comboBoxSostav.DisplayMember = "CompositionName";
            comboBoxSostav.ValueMember = "CompositionId";
        }

        public void infLoad(string articul)
        {
            var info = Helper.DBContext.Product.Where(x => x.ProductArticul == articul).ToList().FirstOrDefault();

            bmp = Properties.Resources.picture;


            textBoxArticul.Text = info.ProductArticul;
            comboBoxName.SelectedValue = info.NameId;
            comboBoxPol.SelectedValue = info.PolId;
            comboBoxSostav.SelectedValue = info.CompositionId;
            numericUpDownCost.Value = info.ProductCost;
            numericUpDownDiscount.Value = (int)info.ProductDiscount;
            numericUpDownCountInStoke.Value = info.ProductCountInStoke;
            richTextBoxDiscription.Text = info.ProductDiscription;
            if (info.ProductImage == null)
                pictureBoxMain.Image = bmp;
            else
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(info.ProductImage);
                MemoryStream mem = new MemoryStream(data);
                pictureBoxMain.Image = Image.FromStream(mem);
            }


        }
        string iLoc = "";
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png| jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                iLoc = dialog.FileName.ToString();
                pictureBoxMain.ImageLocation = iLoc;
            }
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = null;
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            switch (buttonAddEdit.Tag)
            {
                case "add": addTovar(); break;
                case "edit": editTovar(); break;
            }
        }

        public void addTovar()
        {

            if (Helper.DBContext.Product.Select(x => x.ProductArticul == textBoxArticul.Text).FirstOrDefault())
            {
                MessageBox.Show("Товар с таким артикулем уже сущетвует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(textBoxArticul.Text) || String.IsNullOrEmpty(richTextBoxDiscription.Text))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] arr;
            if (pictureBoxMain.Image == null)
            {
                arr = null;
            }
            else
            {
                Image img = pictureBoxMain.Image;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            }

            var product = new Entity.Product()
            {
                ProductArticul = textBoxArticul.Text,
                ProductCost = numericUpDownCost.Value,
                ProductCountInStoke = (int)numericUpDownCountInStoke.Value,
                ProductDiscount = (byte)numericUpDownDiscount.Value,
                ProductDiscription = richTextBoxDiscription.Text,
                NameId = (int)comboBoxName.SelectedValue,
                PolId = (int)comboBoxPol.SelectedValue,
                CompositionId = (int)comboBoxSostav.SelectedValue,
                ProductImage = arr,
            };

            try
            {
                Helper.DBContext.Product.Add(product);
                Helper.DBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



            prodcat.loadinfo();
            prodcat.Show();
            this.Close();

            MessageBox.Show("Товар добавлен!");

        }



        public void editTovar()
        {

            if (String.IsNullOrEmpty(textBoxArticul.Text) || String.IsNullOrEmpty(richTextBoxDiscription.Text))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bmp = Properties.Resources.picture;

            Image img = pictureBoxMain.Image;
            byte[] imagI;
            ImageConverter converter = new ImageConverter();
            imagI = (byte[])converter.ConvertTo(img, typeof(byte[]));

            var edit = Helper.DBContext.Product.Find(arrticul);

            edit.ProductArticul = textBoxArticul.Text;
            edit.ProductCost = numericUpDownCost.Value;
            edit.ProductCountInStoke = (int)numericUpDownCountInStoke.Value;
            edit.ProductDiscount = (byte)numericUpDownDiscount.Value;
            edit.ProductDiscription = richTextBoxDiscription.Text;
            edit.NameId = (int)comboBoxName.SelectedValue;
            edit.PolId = (int)comboBoxPol.SelectedValue;
            edit.CompositionId = (int)comboBoxSostav.SelectedValue;


            if (pictureBoxMain.Image == null)
            {
                edit.ProductImage = null;
            }
            else
            {
                edit.ProductImage = imagI;
            }

            try
            {
                Helper.DBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("Информация о товаре изменена!");
            prodcat.textBoxSearch.Clear();
            prodcat.loadinfo();
            prodcat.Show();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var delete = Helper.DBContext.Product.Where(x => x.ProductArticul == arrticul).ToList().FirstOrDefault();
            if (delete != null)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить товар?", "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    Helper.DBContext.Product.Remove(delete);
                    Helper.DBContext.SaveChanges();
                    MessageBox.Show("Товар удален!");
                    prodcat.Show();
                    prodcat.loadinfo();
                    this.Close();

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            else
                MessageBox.Show("ошибка!");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы дейтвительно хотите перейти обратно к товарам?", "Возврат к товарам", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                prodcat.Show();
                prodcat.textBoxSearch.Clear();
                prodcat.loadinfo();
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
