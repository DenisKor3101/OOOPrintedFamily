namespace OOOPrintedFamily.View
{
    partial class Catalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ColumnAtribut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxFilterDiscount = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterCost = new System.Windows.Forms.ComboBox();
            this.comboBoxPol = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.717435F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.85972F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32265F));
            this.tableLayoutPanelTop.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonExit, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1109, 62);
            this.tableLayoutPanelTop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OOOPrintedFamily.Properties.Resources.printer;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(986, 5);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 52);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Возврат";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(100, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Каталог";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 3;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.27412F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.45266F));
            this.tableLayoutPanelBottom.Controls.Add(this.buttonOrder, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.labelCount, 2, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 604);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(1109, 73);
            this.tableLayoutPanelBottom.TabIndex = 2;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrder.Location = new System.Drawing.Point(469, 11);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(100, 11, 100, 11);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(290, 51);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Офрмить заказ";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(100, 11);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(100, 11, 100, 11);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 51);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить товар";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount.Location = new System.Drawing.Point(862, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(244, 73);
            this.labelCount.TabIndex = 2;
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33603F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66397F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 542);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.ColumnHeadersVisible = false;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAtribut,
            this.ColumnPhoto,
            this.ColumnDescription});
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 64);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.Size = new System.Drawing.Size(1103, 475);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMain_CellMouseDown);
            this.dataGridViewMain.DoubleClick += new System.EventHandler(this.dataGridViewMain_DoubleClick);
            // 
            // ColumnAtribut
            // 
            this.ColumnAtribut.HeaderText = "ColumnAtribut";
            this.ColumnAtribut.Name = "ColumnAtribut";
            this.ColumnAtribut.Visible = false;
            // 
            // ColumnPhoto
            // 
            this.ColumnPhoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPhoto.HeaderText = "ColumnPhoto";
            this.ColumnPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnPhoto.Name = "ColumnPhoto";
            this.ColumnPhoto.ReadOnly = true;
            this.ColumnPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPhoto.Width = 21;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDescription.HeaderText = "ColumnDescription";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxFilterDiscount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxFilterCost, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPol, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // comboBoxFilterDiscount
            // 
            this.comboBoxFilterDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterDiscount.FormattingEnabled = true;
            this.comboBoxFilterDiscount.Items.AddRange(new object[] {
            "Все категории",
            "0-10%",
            "11-14%",
            "15% и более"});
            this.comboBoxFilterDiscount.Location = new System.Drawing.Point(297, 11);
            this.comboBoxFilterDiscount.Margin = new System.Windows.Forms.Padding(22, 11, 22, 3);
            this.comboBoxFilterDiscount.Name = "comboBoxFilterDiscount";
            this.comboBoxFilterDiscount.Size = new System.Drawing.Size(231, 31);
            this.comboBoxFilterDiscount.TabIndex = 1;
            this.comboBoxFilterDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDiscount_SelectedIndexChanged);
            // 
            // comboBoxFilterCost
            // 
            this.comboBoxFilterCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterCost.FormattingEnabled = true;
            this.comboBoxFilterCost.Items.AddRange(new object[] {
            "По возрастанию",
            "По убиванию"});
            this.comboBoxFilterCost.Location = new System.Drawing.Point(22, 11);
            this.comboBoxFilterCost.Margin = new System.Windows.Forms.Padding(22, 11, 22, 3);
            this.comboBoxFilterCost.Name = "comboBoxFilterCost";
            this.comboBoxFilterCost.Size = new System.Drawing.Size(231, 31);
            this.comboBoxFilterCost.TabIndex = 0;
            this.comboBoxFilterCost.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterCost_SelectedIndexChanged);
            // 
            // comboBoxPol
            // 
            this.comboBoxPol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPol.FormattingEnabled = true;
            this.comboBoxPol.Location = new System.Drawing.Point(572, 11);
            this.comboBoxPol.Margin = new System.Windows.Forms.Padding(22, 11, 22, 3);
            this.comboBoxPol.Name = "comboBoxPol";
            this.comboBoxPol.Size = new System.Drawing.Size(231, 31);
            this.comboBoxPol.TabIndex = 2;
            this.comboBoxPol.SelectedIndexChanged += new System.EventHandler(this.comboBoxPol_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(847, 8);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(22, 8, 22, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(234, 30);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(161, 26);
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 677);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Catalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxFilterDiscount;
        private System.Windows.Forms.ComboBox comboBoxFilterCost;
        private System.Windows.Forms.ComboBox comboBoxPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtribut;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        public System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
    }
}