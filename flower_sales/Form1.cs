namespace flower_sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sale_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(flower_varieties.Text) ||
                string.IsNullOrWhiteSpace(count_mask.Text) ||
                string.IsNullOrWhiteSpace(price_txt.Text))
            {
                MessageBox.Show("Butun xanalari doldurun!");
                return;
            }

            if (!int.TryParse(count_mask.Text, out int count) ||
                !double.TryParse(price_txt.Text, out double price))
            {
                MessageBox.Show("Say ve qiymeti duzgun daxil edin!");
                return;
            }

            if (count <= 0 || price <= 0)
            {
                MessageBox.Show("Say ve qiymet sifirdan boyuk olmalidir!");
                return;
            }

            double result = count * price;

            dataGridView1.Rows.Add(flower_varieties.Text, count.ToString(), price.ToString(), result.ToString("F2"));

            double income = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    income += Convert.ToDouble(row.Cells["totalColumn"].Value);
                }
            }

            label5.Text = income.ToString("F2");

            flower_varieties.Clear();
            count_mask.Clear();
            price_txt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıxış edilsinmi?", "Məlumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flower_varieties_TextChanged(object sender, EventArgs e)
        {

        }

        private void flover_lbl_Click(object sender, EventArgs e)
        {

        }

        private void count_lbl_Click(object sender, EventArgs e)
        {

        }

        private void count_mask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void price_lbl_Click(object sender, EventArgs e)
        {

        }

        private void price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void total_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
