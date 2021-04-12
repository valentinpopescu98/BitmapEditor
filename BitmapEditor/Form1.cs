using System;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace BitmapEditor
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        public struct BITMAPFILEHEADER
        {
            public int bfType;
            public int bfSize;
            public short bfReserved1, bfReserved2;
            public int bfOffBits;
        }

        public struct BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth, biHeight;
            public short biPlanes, biBitCount;
            public int biCompression, biSizeImage;
            public int biXPelsPerMeter, biYPelsPerMeter;
            public int biClrUsed, biClrImportant;
        }

        public struct COLORTABLE
        {
            public int rgbBlue;
            public int rgbGreen;
            public int rgbRed;
            public int rgbReserved;
        }

        BITMAPFILEHEADER bfh = new BITMAPFILEHEADER();
        BITMAPINFOHEADER bih = new BITMAPINFOHEADER();
        COLORTABLE ct = new COLORTABLE();

        byte[] buffer = new byte[100];

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryReader br = null;
            byte[] file = null;

            bfh.bfType = 2;
            bfh.bfSize = 4;
            bfh.bfReserved1 = 2;
            bfh.bfReserved2 = 2;
            bfh.bfOffBits = 4;
            bih.biSize = 4;
            bih.biWidth = 4;
            bih.biHeight = 4;
            bih.biPlanes = 2;
            bih.biBitCount = 2;
            bih.biCompression = 4;
            bih.biSizeImage = 4;
            bih.biXPelsPerMeter = 4;
            bih.biYPelsPerMeter = 4;
            bih.biClrUsed = 4;
            bih.biClrImportant = 4;

            string inFilePath;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                inFilePath = openFileDialog1.FileName;
                try
                {
                    //------------------------------Citim fisierul bmp----------------------------------------
                    br = new BinaryReader(File.OpenRead(inFilePath));

                    //------------------------------Citim in file datele--------------------------------------
                    file = br.ReadBytes((int)br.BaseStream.Length);

                    //------------------------------Copiem datele din fisierul bmp in richTextBox1------------
                    richTextBox1.Clear();
                    for (int i = 0; i < file.Length; i++)
                    {
                        richTextBox1.Text += Convert.ToString(file[i], 16).PadLeft(2, '0') + " ";
                    }
                    //////////////Adaugam cate un caracter blank la fiecare octet pentru parsare.//////////////

                    //------------------------------Impartim fisierul in structuri dupa campuri---------------


                    /*****************************************************************************************
                                                    BITMAPFILEHEADER
                    *****************************************************************************************/

                    txt_bftype.Clear();
                    for (int i = 0; i < bfh.bfType; i++)
                    {
                        txt_bftype.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');            //campul bfType
                    }

                    txt_bfsize.Clear();
                    for (int i = bfh.bfType; i < bfh.bfType + bfh.bfSize; i++)
                    {
                        txt_bfsize.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');            //campul bfType
                    }

                    txt_bfreserved1.Clear();
                    for (int i = bfh.bfType + bfh.bfSize; i < bfh.bfType + bfh.bfSize + bfh.bfReserved1; i++)
                    {
                        txt_bfreserved1.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');       //campul bfReserved1
                    }

                    txt_bfreserved2.Clear();
                    for (int i = bfh.bfType + bfh.bfSize + bfh.bfReserved1; i < bfh.bfType + bfh.bfSize + bfh.bfReserved1 + bfh.bfReserved2; i++)
                    {
                        txt_bfreserved2.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');       //campul bfReserved2
                    }

                    txt_bfoffbits.Clear();
                    for (int i = bfh.bfType + bfh.bfSize + bfh.bfReserved1 + bfh.bfReserved2; i < bfh.bfType + bfh.bfSize + bfh.bfReserved1 + bfh.bfReserved2 + bfh.bfOffBits; i++)
                    {
                        txt_bfoffbits.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');         //campul bfOffBits
                    }

                    /*****************************************************************************************
                                                    BITMAPFILEHEADER
                    *****************************************************************************************/

                    int suma = bfh.bfType + bfh.bfSize + bfh.bfReserved1 + bfh.bfReserved2 + bfh.bfOffBits;
                    
                    txt_bisize.Clear();
                    for (int i = suma; i < suma + bih.biSize; i++)
                    {
                        txt_bisize.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');           //campul biSize
                    }
                    txt_biwidth.Clear();
                    for (int i = suma + bih.biSize; i < suma + bih.biSize + bih.biWidth; i++)
                    {
                        txt_biwidth.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');          //campul biWidth
                    }
                    txt_biheight.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth; i < suma + bih.biSize + bih.biWidth + bih.biHeight; i++)
                    {
                        txt_biheight.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');         //campul biHeight
                    }
                    txt_biplanes.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes; i++)
                    {
                        txt_biplanes.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');         //campul biPlanes
                    }
                    txt_bibitcount.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount; i++)
                    {
                        txt_bibitcount.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');       //campul biBitCount
                    }
                    txt_bicompression.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression; i++)
                    {
                        txt_bicompression.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');    //campul biCompression
                    }
                    txt_bisizeimage.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage; i++)
                    {
                        txt_bisizeimage.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');      //campul biSizeImage
                    }
                    txt_bixpelspermeter.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter; i++)
                    {
                        txt_bixpelspermeter.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');  //campul biXPelsPerMeter
                    }
                    txt_biypelspermeter.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter + bih.biYPelsPerMeter; i++)
                    {
                        txt_biypelspermeter.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');  //campul biYPelsPerMeter
                    }
                    txt_biclrused.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter + bih.biYPelsPerMeter; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter + bih.biYPelsPerMeter + bih.biClrUsed; i++)
                    {
                        txt_biclrused.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');        //campul biClrUsed
                    }
                    txt_biclrimportant.Clear();
                    for (int i = suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter + bih.biYPelsPerMeter + bih.biClrUsed; i < suma + bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter + bih.biYPelsPerMeter + bih.biClrUsed + bih.biClrImportant; i++)
                    {
                        txt_biclrimportant.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');   //campul biClrImportant
                    }

                    /*****************************************************************************************
                                                    COLORTABLE
                    *****************************************************************************************/

                    suma += bih.biSize + bih.biWidth + bih.biHeight + bih.biPlanes + bih.biBitCount + bih.biCompression + bih.biSizeImage + bih.biXPelsPerMeter + bih.biYPelsPerMeter + bih.biClrUsed + bih.biClrImportant + 16 * 4;       //paleta pe 16 culori, 4 octeti de culoare
                    
                    richTextBox2.Clear();
                    for (int i = suma; i < file.Length; i++)
                    {
                        richTextBox2.Text += Convert.ToString(file[i], 16).PadLeft(2, '0');
                    }
                }
                catch (Exception exc)
                {
                    //Afisam message box cu exceptia.
                    MessageBox.Show("Fisierul nu a putut fi deschis sau citit.\n" + "Exception: " + exc.Message);
                }
                finally
                {
                    if (br != null)
                    {
                        //Inchidem
                        br.Close();
                    }
                }
            }
        }

        string outFilePath;
        string outFileExtension;
        private BinaryWriter dataOut;
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] fileOut = new byte[richTextBox1.Text.Length];
            string[] s;
            int j = 0;
            NumberStyles stil = NumberStyles.HexNumber;

            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                outFilePath = saveFileDialog1.FileName;
                outFileExtension = Path.GetExtension(outFilePath);
                //Parsam richTextBox1 in stringuri separate mai sus de blank, apoi convertim in integer hexa si salvam string-ul rezultat in alt fisier ales de utilizator. 
                try
                {
                    s = richTextBox1.Text.Split(' ');

                    foreach (string octet in s)
                    {
                        byte.TryParse(octet, stil, null as IFormatProvider, out fileOut[j]);
                        j++;
                    }

                    dataOut = new BinaryWriter(new FileStream(outFilePath, FileMode.Create));
                    dataOut.Close();

                    dataOut = new BinaryWriter(new FileStream(outFilePath, FileMode.Append));
                    dataOut.Write(fileOut);
                }
                catch (Exception exc)
                {
                    //Afisam message box cu exceptia.
                    MessageBox.Show("Fisierul nu a putut fi salvat.\n" + "Exception: " + exc.Message);
                }
                finally
                {
                    //Inchidem
                    dataOut.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bisize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_biwidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_biheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_biplanes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bibitcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bicompression_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bisizeimage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bixpelspermeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_biypelspermeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_biclrused_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_biclrimportant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bfreserved1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_bfreserved2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bfoffbits_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
