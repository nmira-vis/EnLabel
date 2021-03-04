using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EnLabel
{
    public partial class LabelManagerFrm : Form
    {
        public List<string> labels;

        public LabelManagerFrm()
        {
            InitializeComponent();
            labels = new List<string>();
        }

        public LabelManagerFrm(List<string> diferentLabels)
        {
            InitializeComponent();
            if (diferentLabels.Count() > 0)
            {
                customRadBtn.Checked = true;
                RefreshTexts();
                labels = diferentLabels;

                IEnumerable<TextBox> txtBoxes = this.Controls.OfType<TextBox>();
                if (txtBoxes.Count() == labels.Count())
                {
                    int cnt = 0;
                    foreach (TextBox txtBox in txtBoxes)
                    {
                        txtBox.Text = labels[cnt];
                        cnt++;
                    }
                }

                RefreshTexts();
            }else
                labels = new List<string>();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            labels.Clear();
            if (!defaultRadBtn.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        labels.Add(control.Text.ToString());
                    }
                }
            }
            else
            {
                AddDefaultLabels();
            }
            Close();
        }

        private void AddDefaultLabels()
        {
            labels.Add("OK");
            labels.Add("NotOK");
        }

        private void DefaultRadBtn_CheckedChanged(object sender, EventArgs e) => RefreshTexts();

        private void RefreshTexts()
        {
            okLbl.Visible = defaultRadBtn.Checked;
            NotOkLbl.Visible = defaultRadBtn.Checked;
            lbl1TxtBox.Visible = !defaultRadBtn.Checked;
            lbl2TxtBox.Visible = !defaultRadBtn.Checked;
            binBtn.Visible = !defaultRadBtn.Checked;
            addLabelBtn.Visible = !defaultRadBtn.Checked;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("No se guardarán los cambios realizados.\n¿Seguro que desea cancelar?", "No ha guardado la información", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                Close();
        }

        private void CustomRadBtn_CheckedChanged(object sender, EventArgs e) => RefreshTexts();

        private void LabelManagerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (labels.Count == 0)
            {

                if (MessageBox.Show("Las etiquetas están en vacío. Se aplicarán las etiquetas por defecto OK/NotOK.", "Etiquetas vacías", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    AddDefaultLabels();
                //else
                    //e.Cancel() = true;

            }
        }
    }
}