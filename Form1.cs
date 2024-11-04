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
                MessageBox.Show("Дата окончания поездки не может быть раньше её начала!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string transport = Plane_RadioBTN.Checked ? "Самолёт" : Train_RadioBTN.Checked ? "Поезд" : Bus_RadioBTN.Checked ? "Автобус" : "Неизвестно";
            string destination = DestinationComboBox.SelectedItem?.ToString() ?? "Не выбрано";
            string services = "";
            
            if (InsuranceCheckBox.Checked) services += "\nСтраховка\n";
            if (ExcursionsCheckBox.Checked) services += "Экскурсии\n";
            if (BaggageCheckBox.Checked) services += "Дополнительный багаж\n";
            
            ResultLabel.Text = $"Информация\nДата начала поездки:{TimePicker_Start.Value};\nДата конца поездки: {TimePicker_End.Value}\n" +
                                $"Транспорт: {transport}\nМесто назначения: {destination}\n" +
                                $"Дополнительные услуги: {services}";
        }
    }
}