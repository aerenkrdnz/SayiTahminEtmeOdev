namespace FormsOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rastgele;
        int sayac = 3;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Tahmin Etme Oyunu";
            Random rnd = new Random();
            rastgele = rnd.Next(1, 10);
            btnTahminEt.Text = "Tahmin Et";
            MessageBox.Show("Bu oyunda sadece 3 can hakk�n�z var!");
            MessageBox.Show("Tahmin edece�iniz say� 1 ile 10 aras�nda olmal�. (1 say�s� dahildir.)");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(txtTahmin.Text);
            if (sayac != 1)
            {

                if (tahmin == rastgele)
                {
                   
                    MessageBox.Show("Tebriklerr!");
                    btnTahminEt.Enabled = false;
                }
                else if (tahmin != rastgele)
                {
                    sayac--;
                    MessageBox.Show("Do�ru bilemediniz. "+ sayac +"  hakk�n�z kald�");
                    
                }

            }
            else
            {
                MessageBox.Show("Oyunu kaybettiniz :( ");
                btnTahminEt.Enabled = false;
            }

           
     
      
        }
    }
}