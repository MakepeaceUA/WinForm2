using System.Numerics;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimePicker_End_ValueChanged(object sender, EventArgs e)
        {
            if (TimePicker_End.Value < TimePicker_Start.Value)
            {
                MessageBox.Show("���� ��������� ������� �� ����� ���� ������ � ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TimePicker_End.Value = TimePicker_Start.Value;
            }
        }

        private void TimePicker_Start_ValueChanged(object sender, EventArgs e)
        {}
        private void Plane_RadioBTN_CheckedChanged(object sender, EventArgs e)
        {}
        private void Train_RadioBTN_CheckedChanged(object sender, EventArgs e)
        {}
        private void Bus_RadioBTN_CheckedChanged(object sender, EventArgs e)
        {}
        private void DestinationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void InsuranceCheckBox_CheckedChanged(object sender, EventArgs e)
        {}
        private void ExcursionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {}
        private void BaggageCheckBox_CheckedChanged(object sender, EventArgs e)
        {}
        private void ResultLabel_Click(object sender, EventArgs e)
        {}
        
        private void CompleteBTN_Click(object sender, EventArgs e)
        {
            string transport = Plane_RadioBTN.Checked ? "������" : Train_RadioBTN.Checked ? "�����" : Bus_RadioBTN.Checked ? "�������" : "����������";
            string destination = DestinationComboBox.SelectedItem?.ToString() ?? "�� �������";
            string services = "";
            
            if (InsuranceCheckBox.Checked) services += "\n���������\n";
            if (ExcursionsCheckBox.Checked) services += "���������\n";
            if (BaggageCheckBox.Checked) services += "�������������� �����\n";
            
            ResultLabel.Text = $"����������\n���� ������ �������:{TimePicker_Start.Value};\n���� ����� �������: {TimePicker_End.Value}\n" +
                                $"���������: {transport}\n����� ����������: {destination}\n" +
                                $"�������������� ������: {services}";
        }
    }
}