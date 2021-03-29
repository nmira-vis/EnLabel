using Matrox.MatroxImagingLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace EnLabel
{
    public partial class MainForm : Form
    {
        private const string DIGITIZER_FILE = @"C:\Users\nmira\OneDrive - Grupo Alava Ingenieros\Clientes\Noel\Dataset\Bad\Images";
        private FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        private int counter = -1;
        private int nFiles = 0;
        private string[] fileEntries;
        private string fileName = "";
        private MIL_ID MilApplication = MIL.M_NULL;
        private MIL_ID MilSystem = MIL.M_NULL;
        private MIL_ID Display = MIL.M_NULL;
        private MIL_ID BufferDisplay = MIL.M_NULL;
        private string folderPath;
        private CSVManager csvMng;
        private LabelManagerFrm labelManagerFrm;
        private List<string> labels;
        private string[] csv_files;

        //private LabelPicture[] labelPictures;
        private Dictionary<string, LabelPicture> dictImage = new Dictionary<string, LabelPicture>();

        public FolderBrowserDialog FolderBrowserDialog1
        {
            get => folderBrowserDialog1;
            set
            {  // Set the help text description for the FolderBrowserDialog.
                folderBrowserDialog1.Description = "Select the directory that you want to use as the default.";

                // Do not allow the user to create new files via the FolderBrowserDialog.
                folderBrowserDialog1.ShowNewFolderButton = false;

                // Default to the My Documents folder.
                folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            csvMng = new CSVManager();

            MIL.MappAlloc(MIL.M_NULL, MIL.M_DEFAULT, ref MilApplication);
            MIL.MsysAlloc(MIL.M_DEFAULT, "M_SYSTEM_HOST", MIL.M_DEFAULT, MIL.M_DEFAULT, ref MilSystem);
            MIL.MdispAlloc(MilSystem, MIL.M_DEFAULT, "M_DEFAULT", MIL.M_DEFAULT, ref Display);

            // Control Block for Display
            MIL.MdispControl(Display, MIL.M_TITLE, "Display");
            MIL.MdispControl(Display, MIL.M_VIEW_MODE, MIL.M_AUTO_SCALE);
            MIL.MdispControl(Display, MIL.M_SCALE_DISPLAY, MIL.M_ENABLE);
            MIL.MdispControl(Display, MIL.M_UPDATE, MIL.M_ENABLE);
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = this.FolderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (BufferDisplay != MIL.M_NULL)
                    MIL.MbufFree(BufferDisplay);

                /*Iniciamos contador y guardamos el path*/
                counter = 0;
                folderPath = this.FolderBrowserDialog1.SelectedPath;
                lblFolder.Text = folderPath;

                /*Obetenemos los archivos*/
                fileEntries = Directory.GetFiles(folderPath); //tenemos que obtener solo los del tipo imagen

                //labelPictures = new LabelPicture[nFiles];

                csv_files = Directory.GetFiles(folderPath, "Labels.csv", SearchOption.TopDirectoryOnly);
                nFiles = fileEntries.Length - csv_files.Length;
                if (csv_files.Length == 0) //no hay csv
                {
                    if (MessageBox.Show("La carpeta seleccionada no contiene Dataset asociado.\nPor favor, indique las etiquetas que vaya a utilizar", "Nuevo Dataset", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        labelManagerFrm = new LabelManagerFrm();
                        labelManagerFrm.ShowDialog();
                        labels = labelManagerFrm.labels;

                        for (int i = 0; i < nFiles; i++)
                        {
                            if (!dictImage.ContainsKey(fileEntries[i]))
                                dictImage.Add(fileEntries[i], new LabelPicture(i));
                            string fileName = Path.GetFileName(fileEntries[i]);
                            imgLblLstView.Items.Add(new ListViewItem(new string[] {(i+1).ToString(), fileName, "" }));
                            //csvMng.WriteInCsv(folderPath + "\\Labels.csv", fileName, "");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La carpeta seleccionada contiene el Dataset " + csv_files[0] + ".\nSe procederá a cargarlo y a verificar sus etiquetas.", "Carga de Dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StreamReader reader = File.OpenText(csv_files[0]);
                    if (labels == null)
                    {
                        labels = new List<string>();
                    }
                    else
                    {
                        labels.Clear();
                    }

                    int nElementsCSV = System.IO.File.ReadAllLines(csv_files[0]).Length;
                    for (int i = 0; i < nElementsCSV; i++)
                    {
                        string[] line = (reader.ReadLine().Split(';'));

                        string nameImage = line[0];
                        string labelImage = line[1];

                        /*Creamos primero el diccionario*/
                        string key = folderPath + "\\" + nameImage;
                        if (!dictImage.ContainsKey(fileEntries[i]))
                            dictImage.Add(key, new LabelPicture(i, labelImage, folderPath + "\\" + nameImage));
                        /*Obtenemos las etiquetas diferentes*/
                        if (!labels.Contains(labelImage) && labelImage != "")
                            labels.Add(labelImage);

                        ListViewItem item = new ListViewItem(new string[] { (i+1).ToString(), nameImage, labelImage })
                        {
                            Checked = labelImage != ""
                        };
                        imgLblLstView.Items.Add(item);
                    }
                    labelManagerFrm = new LabelManagerFrm(labels);
                    labelManagerFrm.ShowDialog();
                    labels = labelManagerFrm.labels;
                }

                foreach (string lbl in labels)
                {
                    labelCmbBox.Items.Add(lbl);
                }

                imgLblLstView.Items[0].Selected = true;

                if (MIL.MdispInquire(Display, MIL.M_SELECTED) == MIL.M_NULL)

                    MIL.MdispSelectWindow(Display, BufferDisplay, pnlVisor.Handle);

                nextBtn.Enabled = true;
                prevBtn.Enabled = true;
                labelBtn.Enabled = true;
                removeBtn.Enabled = true;
                generateDSbtn.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BufferDisplay != MIL.M_NULL)
                MIL.MbufFree(BufferDisplay);
            MIL.MdispFree(Display);
            MIL.MsysFree(MilSystem);
            MIL.MappFree(MilApplication);
        }

        private void NextBtn_Click(object sender, EventArgs e) => Next();

        protected void UpdateInfo(bool changeSelectedItem = true)
        {
            if (changeSelectedItem)
                imgLblLstView.Items[counter].Selected = true;
            fileName = Path.GetFileName(fileEntries[counter]);
            fileLbl.Text = fileName;
            lblCount.Text = (counter + 1) + "/" + nFiles;
            MIL.MbufFree(BufferDisplay);
            MIL.MbufRestore(fileEntries[counter], MilSystem, ref BufferDisplay);
            MIL.MdispSelectWindow(Display, BufferDisplay, pnlVisor.Handle);
            MIL.MdispControl(Display, MIL.M_UPDATE, MIL.M_NOW);
        }

        private void PrevBtn_Click(object sender, EventArgs e) => Previous();

        private void LabelBtn_Click(object sender, EventArgs e)
        {
            if (labelCmbBox.Text != "")
                LabelImage(fileEntries[counter]);
            else
                MessageBox.Show("El campo de la etiqueta está vacío.\nPor favor, seleccione una de las opciones.", "Etiqueta vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void LabelImage(string file)
        {
            if (dictImage[file].Label != "")
                if (MessageBox.Show("La imagen ya está etiquetada. \n ¿Desea cambiar la etiqueta actual por otra?", "Imagen ya etiquetada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            SetLabel(labelCmbBox.Text);
        }

        protected void Previous()
        {
            if (counter != 0)
            {
                counter--;
                UpdateInfo();
            }
            else
                MessageBox.Show(fileName + " es el primer elemento.", "No hay imágenes previas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void Next()
        {
            if (counter != nFiles - 1)
            {
                counter++;
                UpdateInfo();
            }
            else
                MessageBox.Show(fileName + " es el último elemento.", "No hay más imágenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void SetLabel(string label)
        {
            int currentIndex = imgLblLstView.SelectedItems[0].Index;
            dictImage[fileEntries[counter]].Label = label;
            dictImage[fileEntries[counter]].NewPathPicture = folderPath + "\\" + label + "\\" + imgLblLstView.Items[currentIndex].SubItems[1].Text;
            imgLblLstView.Items[currentIndex].SubItems[2].Text = label;
            Next();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            dictImage[fileEntries[counter]].Label = "";
            //MessageBox.Show("Etiqueta eliminada.\nEl archivo " + fileEntries[counter] + " ya no contiene etiqueta.", "Etiqueta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dictImage[fileEntries[counter]].NewPathPicture = "";
            SetLabel("");
        }

        private void ImgLblLstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imgLblLstView.SelectedItems.Count == 0)
                return;

            string namn = imgLblLstView.SelectedItems[0].Text;
            counter = imgLblLstView.SelectedItems[0].Index;
            UpdateInfo(false);
        }

        private void GenerateDSbtn_Click(object sender, EventArgs e) => GenerateDataset();

        private void GenerateDataset()
        {
            if (csv_files.Length > 0)
                if (MessageBox.Show("El dataset (.csv) se va a sustituir.\n¿Desea continuar?", "DataSet existente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

            File.Delete(folderPath + "\\Labels.csv");
            //Creamos las carpetas
            foreach (string lbl in labels)
                if (!Directory.Exists(folderPath + "\\" + lbl))
                    System.IO.Directory.CreateDirectory(folderPath + "\\" + lbl);

            //copiamos las imágenes
            for (int i = 0; i < dictImage.Values.Count; i++)
            {
                if (!File.Exists(dictImage[fileEntries[i]].NewPathPicture))
                    File.Copy(fileEntries[i], dictImage[fileEntries[i]].NewPathPicture);
                csvMng.WriteInCsv(folderPath + "\\Labels.csv", Path.GetFileName(fileEntries[i]), dictImage[fileEntries[i]].Label);
            }

            MessageBox.Show("Se ha generado el Dataset y se ha dividido en las carpetas de las etiquetas.", "Dataset generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}