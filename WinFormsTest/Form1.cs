using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace WinFormsTest
{
    public delegate void Pene(string st);

    public delegate void AgregarRamoDelegate(string nombre, string hora);

    public partial class Form1 : Form
    {
        
        List<string> Nombres = new List<string>();
        BindingList<Ramo> Ramos = new BindingList<Ramo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = File.Open("Guardado.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Ramos = (BindingList<Ramo>)bf.Deserialize(fs);
                
            }
            catch { }
            dataGridView1.DataSource = Ramos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelCuliao.Text = TB.Text;
            Form2 formaCulia = new Form2();
            Pene pn = new Pene(UpdateText);

            formaCulia.EventHandler += pn;

            formaCulia.EventHandler += new Pene(UpdateText2);
            formaCulia.Show();
        }

        private void UpdateText(string n)
        {
            LabelCuliao.Text = n;
        }

        private void UpdateText2(string m)
        {
            Label2.Text = m.ToUpper();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormaAgregarRamo FAR = new FormaAgregarRamo();
            FAR.AREvent += new AgregarRamoDelegate(addRamo);
            FAR.Show();
        }

        private void addRamo(string nombre, string hora)
        {
            Ramos.Add(new Ramo(nombre, hora));
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("Guardado.bin", FileMode.OpenOrCreate);
            bf.Serialize(fs, Ramos);
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ramos.Clear();
        }
    }
}
