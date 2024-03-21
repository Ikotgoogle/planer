namespace planer {
    public partial class Form1 : Form {
        int count = 0;
        public Form1() {
            InitializeComponent();
            label3.Text += " " + count.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)) {

                string tb = "";

                tb = textBox1.Text + " " + textBox2.Text;
                listBox1.Items.Add(tb);
                count = listBox1.Items.Count;
                label3.Text = "кол.эл: " + count.ToString();

                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
