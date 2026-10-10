namespace flower_sales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            total_lbl = new Label();
            groupBox1 = new GroupBox();
            sale_btn = new Button();
            pictureBox1 = new PictureBox();
            price_txt = new TextBox();
            price_lbl = new Label();
            count_mask = new MaskedTextBox();
            count_lbl = new Label();
            flower_varieties = new TextBox();
            flover_lbl = new Label();
            flowerColumn = new DataGridViewTextBoxColumn();
            countColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            totalColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flowerColumn, countColumn, priceColumn, totalColumn });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1385, 343);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(total_lbl);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 453);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 409);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1082, 295);
            button2.Name = "button2";
            button2.Size = new Size(97, 33);
            button2.TabIndex = 4;
            button2.Text = "Çıxş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(985, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1212, 20);
            label5.Name = "label5";
            label5.Size = new Size(63, 32);
            label5.TabIndex = 2;
            label5.Text = "0.00";
            label5.Click += label5_Click;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_lbl.ForeColor = Color.White;
            total_lbl.Location = new Point(1044, 20);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(172, 32);
            total_lbl.TabIndex = 1;
            total_lbl.Text = "Toplam gəlir: ";
            total_lbl.Click += total_lbl_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sale_btn);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(price_txt);
            groupBox1.Controls.Add(price_lbl);
            groupBox1.Controls.Add(count_mask);
            groupBox1.Controls.Add(count_lbl);
            groupBox1.Controls.Add(flower_varieties);
            groupBox1.Controls.Add(flover_lbl);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(114, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gül məlumatları";
            // 
            // sale_btn
            // 
            sale_btn.BackColor = Color.Lime;
            sale_btn.ForeColor = Color.Black;
            sale_btn.Location = new Point(413, 166);
            sale_btn.Name = "sale_btn";
            sale_btn.Size = new Size(121, 57);
            sale_btn.TabIndex = 8;
            sale_btn.Text = "Satış et";
            sale_btn.UseVisualStyleBackColor = false;
            sale_btn.Click += sale_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(413, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // price_txt
            // 
            price_txt.Location = new Point(220, 186);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(133, 37);
            price_txt.TabIndex = 6;
            price_txt.TextChanged += price_txt_TextChanged;
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Location = new Point(220, 153);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(89, 30);
            price_lbl.TabIndex = 5;
            price_lbl.Text = "Qiymət";
            price_lbl.Click += price_lbl_Click;
            // 
            // count_mask
            // 
            count_mask.Location = new Point(50, 186);
            count_mask.Mask = "00000";
            count_mask.Name = "count_mask";
            count_mask.Size = new Size(133, 37);
            count_mask.TabIndex = 4;
            count_mask.ValidatingType = typeof(int);
            count_mask.MaskInputRejected += count_mask_MaskInputRejected;
            // 
            // count_lbl
            // 
            count_lbl.AutoSize = true;
            count_lbl.Location = new Point(50, 153);
            count_lbl.Name = "count_lbl";
            count_lbl.Size = new Size(49, 30);
            count_lbl.TabIndex = 3;
            count_lbl.Text = "Say";
            count_lbl.Click += count_lbl_Click;
            // 
            // flower_varieties
            // 
            flower_varieties.Location = new Point(50, 93);
            flower_varieties.Name = "flower_varieties";
            flower_varieties.Size = new Size(221, 37);
            flower_varieties.TabIndex = 1;
            flower_varieties.TextChanged += flower_varieties_TextChanged;
            // 
            // flover_lbl
            // 
            flover_lbl.AutoSize = true;
            flover_lbl.Location = new Point(50, 60);
            flover_lbl.Name = "flover_lbl";
            flover_lbl.Size = new Size(105, 30);
            flover_lbl.TabIndex = 0;
            flover_lbl.Text = "Gül növü";
            flover_lbl.Click += flover_lbl_Click;
            // 
            // flowerColumn
            // 
            flowerColumn.HeaderText = "Gül növü (gül adı)";
            flowerColumn.MinimumWidth = 8;
            flowerColumn.Name = "flowerColumn";
            flowerColumn.Width = 150;
            // 
            // countColumn
            // 
            countColumn.HeaderText = "Satış sayı";
            countColumn.MinimumWidth = 8;
            countColumn.Name = "countColumn";
            countColumn.Width = 150;
            // 
            // priceColumn
            // 
            priceColumn.HeaderText = "Qiyməti";
            priceColumn.MinimumWidth = 8;
            priceColumn.Name = "priceColumn";
            priceColumn.Width = 150;
            // 
            // totalColumn
            // 
            totalColumn.HeaderText = "Yekun qiyməti";
            totalColumn.MinimumWidth = 8;
            totalColumn.Name = "totalColumn";
            totalColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1385, 862);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            ForeColor = Color.FromArgb(0, 0, 64);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button sale_btn;
        private PictureBox pictureBox1;
        private TextBox price_txt;
        private Label price_lbl;
        private MaskedTextBox count_mask;
        private Label count_lbl;
        private TextBox flower_varieties;
        private Label flover_lbl;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label5;
        private Label total_lbl;
        private DataGridViewTextBoxColumn flowerColumn;
        private DataGridViewTextBoxColumn countColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewTextBoxColumn totalColumn;
    }
}
