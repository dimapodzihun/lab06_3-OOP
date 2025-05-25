using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonSize = 9 * btnAdd.Width + 3 * tsSeparator1.Width;
            btnExit.Margin = new Padding(Width - buttonSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPhotoAparats.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Brand";
            column.Name = "Бренд";
            column.Width = 80;
            gvPhotoAparats.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            column.Width = 80;
            gvPhotoAparats.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "megapixels";
            column.Name = "Кількість мегапікселів";
            column.Width = 80;
            gvPhotoAparats.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "zoomLevel";
            column.Name = "Рівень зуму";
            column.Width = 100;
            gvPhotoAparats.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "memoryCapacity";
            column.Name = "Обсяг пам'яті у ГБ";
            column.Width = 100;
            gvPhotoAparats.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "photoSizeMB";
            column.Name = "Розмір одного фото у МБ";
            column.Width = 100;
            gvPhotoAparats.Columns.Add(column);

          

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "hasFlash";
            column.Name = "Спалах";
            column.Width = 80;
            gvPhotoAparats.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "hasAutofokus";
            column.Name = "Автофокус";
            column.Width = 80;
            gvPhotoAparats.Columns.Add(column);

            bindSrcPhotoAparats.Add(new PhotoAparat("Canon", "EOS R5", 45, 10.0, 128, 20.0,true, false));
            bindSrcPhotoAparats.Add(new PhotoAparat("Sony", "Alpha 7 IV", 33, 5.0,256, 15.0, false, true));
            bindSrcPhotoAparats.Add(new PhotoAparat("Nikon", "Z7 II", 45, 4.0, 128, 18.0, true, true));
            bindSrcPhotoAparats.Add(new PhotoAparat("Fujifilm", "X-T5", 40, 3.5, 64, 12.5, true, true));
            bindSrcPhotoAparats.Add(new PhotoAparat("Panasonic", "Lumix S5", 24, 6.0, 64, 10.0, true, true));
            bindSrcPhotoAparats.Add(new PhotoAparat("Olympus", "OM-D E-M1", 20, 4.5, 32, 8.5, true, true));
            bindSrcPhotoAparats.Add(new PhotoAparat("Leica", "Q2", 47, 3.0, 64, 22.0, false, true));
            bindSrcPhotoAparats.Add(new PhotoAparat("Pentax", "K-3 III", 26, 5.0, 128, 14.0, true, false));
            bindSrcPhotoAparats.Add(new PhotoAparat("GoPro", "Hero 12", 27, 2.0, 32, 6.0, false, true));
            bindSrcPhotoAparats.Add(new PhotoAparat("Samsung", "NX1", 28, 4.0, 64, 13.0, true, true));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ICamera photoAparat = new PhotoAparat();
            fPhotoAparat ft = new fPhotoAparat(photoAparat);
            if(ft.ShowDialog()==DialogResult.OK)
            {
                bindSrcPhotoAparats.Add(photoAparat);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ICamera photoAparat=(ICamera)bindSrcPhotoAparats.List[bindSrcPhotoAparats.Position];
            fPhotoAparat ft=new fPhotoAparat(photoAparat);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcPhotoAparats.List[bindSrcPhotoAparats.Position]=photoAparat;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Видалити поточний запис?","Видалення запис",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                bindSrcPhotoAparats.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені","Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPhotoAparats.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory=Application.StartupPath;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    try
                    {
                        foreach (ICamera photoAparat in bindSrcPhotoAparats.List)
                        {
                            sw.Write(photoAparat.Brand + "\t" + photoAparat.Model + "\t" +
                                photoAparat.Megapixels + "\t" + photoAparat.ZoomLevel + "\t" +
                                photoAparat.MemoryCapacity + "\t" + photoAparat.PhotoSizeMB + "\t" +
                                photoAparat.HasFlash + "\t" + photoAparat.HasAutofokus + "\t\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Сталася помилка: \n{0}", ex.Message,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        sw.Close();
                    }
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.PhotoAparats)|*.PhotoAparats|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (ICamera photoAparat in bindSrcPhotoAparats.List)
                    {
                        bw.Write(photoAparat.Brand);
                        bw.Write(photoAparat.Model);
                        bw.Write(photoAparat.Megapixels);
                        bw.Write(photoAparat.ZoomLevel);
                        bw.Write(photoAparat.MemoryCapacity);
                        bw.Write(photoAparat.PhotoSizeMB);
                        bw.Write(photoAparat.HasFlash);
                        bw.Write(photoAparat.HasAutofokus);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFormText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcPhotoAparats.Clear();
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        PhotoAparat photo = new PhotoAparat(split[0], split[1], int.Parse(split[2]),
                            double.Parse(split[3]), int.Parse(split[4]), double.Parse(split[5]), 
                            bool.Parse(split[6]), bool.Parse(split[7]));
                        bindSrcPhotoAparats.List.Add(photo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
               }
        }

        private void btnOpenFormBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.PhotoAparats)|*.PhotoAparats|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory=Application.StartupPath;
            BinaryReader br;
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                bindSrcPhotoAparats.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    ICamera photoAparat;
                    while(br.BaseStream.Position<br.BaseStream.Length)
                    {
                        photoAparat = new PhotoAparat();
                        for (int i = 1; i <= 8; i++)
                        {
                            switch(i)
                            {
                                case 1:
                                    photoAparat.Brand=br.ReadString();
                                    break;
                                case 2:
                                    photoAparat.Model=br.ReadString();
                                    break;
                                case 3:
                                    photoAparat.Megapixels=br.ReadInt32();
                                    break;
                                case 4:
                                    photoAparat.ZoomLevel=br.ReadDouble();
                                    break;
                                case 5:
                                    photoAparat.MemoryCapacity=br.ReadInt32();
                                    break;
                                case 6:
                                    photoAparat.PhotoSizeMB = br.ReadDouble();
                                    break;
                                case 7:
                                    photoAparat.HasFlash=br.ReadBoolean();
                                    break;
                                case 8:
                                    photoAparat.HasAutofokus=br.ReadBoolean();
                                    break;

                            }
                        }
                        bindSrcPhotoAparats.Add(photoAparat);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    br.Close();
                }
            }

        }
    }
}
