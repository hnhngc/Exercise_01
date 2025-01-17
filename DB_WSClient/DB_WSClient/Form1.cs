using System;
using System.Windows.Forms;
using WS_SR;

namespace DB_WSClient
{
    public partial class Form1 : Form
    {

        private CityWSSoapClient client = new CityWSSoapClient(CityWSSoapClient.EndpointConfiguration.CityWSSoap);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                var countries = client.GetAllCountries();
                listBoxResults.Items.Clear();
                foreach (var country in countries)
                {
                    listBoxResults.Items.Add(country);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnGetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBoxInput.Text.Trim();
                string country = client.GetCountryByCode(code);
                MessageBox.Show($"Country: {country}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGetCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = textBoxInput.Text.Trim();
                string city = client.GetCityByName(cityName);
                MessageBox.Show($"City: {city}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGetCitiesByCountry_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBoxInput.Text.Trim();
                var cities = client.GetCitiesByCountry(code);
                listBoxResults.Items.Clear();
                foreach (var city in cities)
                {
                    listBoxResults.Items.Add(city);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnConvertTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị nhập từ TextBox
                string input = textBoxInput.Text;

                if (string.IsNullOrEmpty(input) || !double.TryParse(input, out double temperature))
                {
                    MessageBox.Show("Vui lòng nhập nhiệt độ hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi giữa Fahrenheit và Celsius
                string selectedConversion = comboBoxCountries.SelectedItem?.ToString();
                double convertedValue;

                if (selectedConversion == "Fahrenheit to Celsius")
                {
                    convertedValue = (temperature - 32) * 5 / 9;
                    MessageBox.Show($"{temperature} °F = {convertedValue:F2} °C", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedConversion == "Celsius to Fahrenheit")
                {
                    convertedValue = (temperature * 9 / 5) + 32;
                    MessageBox.Show($"{temperature} °C = {convertedValue:F2} °F", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn kiểu chuyển đổi trong ComboBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
