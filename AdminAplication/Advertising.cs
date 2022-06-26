using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AdminAplication
{
    class Advertising
    {
        private ImageList listaImagenes = new ImageList();
        public void AddAd(ListBox lstboxPublicidad,OpenFileDialog openFileDialog1)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileNames != null)
                {
                    for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    {
                        AddImagen(openFileDialog1.FileNames[i], lstboxPublicidad);
                    }
                }
                else
                {
                    AddImagen(openFileDialog1.FileName, lstboxPublicidad);
                }
            }
        }
        private void AddImagen(string rutaImagen,ListBox lstboxPublicidad)
        {
            if (rutaImagen != "")
            {
                listaImagenes.Images.Add(Image.FromFile(rutaImagen));
                lstboxPublicidad.Items.Add(rutaImagen);
            }
        }
        public void RemoveAd(ListBox lstboxPublicidad,PictureBox pctboxPublicidad)
        {
            if (lstboxPublicidad.SelectedIndex != -1)
            {
                lstboxPublicidad.Items.Remove(lstboxPublicidad.SelectedItem);
                listaImagenes.Images.RemoveAt(lstboxPublicidad.SelectedIndex + 1);
                pctboxPublicidad.Image = null;
            }
        }
    }
}
