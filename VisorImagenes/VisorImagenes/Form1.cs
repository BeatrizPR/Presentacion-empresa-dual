using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisorImagenes
{
    public partial class PictureViewer : Form
    {
        // Constructor
        public PictureViewer()
        {
            InitializeComponent();
        }

        #region Eventos

        private void btnShow_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();

            abrirArchivo.FileName = "Selecciona una imagen";
            abrirArchivo.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp";

            // Show the Open File dialog. Si el usuario clicka OK,
            // se carga la imagen que ha elegido

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(abrirArchivo.FileName);
            }

        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void checkBoxStretch_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBoxStretch.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }

        }

        #endregion Eventos

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
