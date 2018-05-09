using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest
{
    
    public partial class FormaAgregarRamo : Form
    {
        public event AgregarRamoDelegate AREvent;
        public FormaAgregarRamo()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            AREvent(TBNombre.Text, TBHora.Text);
        }
    }
}
