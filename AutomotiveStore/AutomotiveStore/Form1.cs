using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotiveStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void OilLubeCharges()
        {

        }
        public void FlushCharges()
        {

        }

        public void MiscCharges()
        {

        }

        public void OtherCharges()
        {

        }

        public void TaxCharges()
        {

        }

        public void TotalCharges()
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OilCheckBox.CheckState = CheckState.Unchecked;
            LubeCheckBox.CheckState = CheckState.Unchecked;
            RadiatorCheckBox.CheckState = CheckState.Unchecked;
            TransmissionCheckBox.CheckState = CheckState.Unchecked;
            InspectionCheckBox.CheckState = CheckState.Unchecked;
            ReplaceCheckBox.CheckState = CheckState.Unchecked;
            TireCheckBox.CheckState = CheckState.Unchecked;
            PartsPriceTextBox.Clear();
            LaborPriceTextBox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
