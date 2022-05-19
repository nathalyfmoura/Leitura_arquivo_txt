using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoreFuhro
{

    public partial class Form1 : Form
    {
            public Form1()
            {
                InitializeComponent();
            }

            private void Play_Click(object sender, EventArgs e)
            {
            var data = File.ReadAllText("C:\\pablo\\texto.txt");
            MessageBox.Show(data);

        }
        }
    }

