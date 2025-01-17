namespace DB_WSClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelInput = new Label();
            textBoxInput = new TextBox();
            comboBoxCountries = new ComboBox();
            listBoxResults = new ListBox();
            btnGetAllCountries = new Button();
            btnGetCountryByCode = new Button();
            btnGetCityByName = new Button();
            btnGetCitiesByCountry = new Button();
            btnConvertTemperature = new Button();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(230, 46);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(478, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "SOAP Web Service Client";
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(59, 135);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(75, 32);
            labelInput.TabIndex = 1;
            labelInput.Text = "Input:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(168, 132);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(292, 39);
            textBoxInput.TabIndex = 2;
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.Location = new Point(50, 193);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(410, 40);
            comboBoxCountries.TabIndex = 3;
            // 
            // listBoxResults
            // 
            listBoxResults.Location = new Point(50, 267);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(410, 388);
            listBoxResults.TabIndex = 4;
            // 
            // btnGetAllCountries
            // 
            btnGetAllCountries.Location = new Point(536, 132);
            btnGetAllCountries.Name = "btnGetAllCountries";
            btnGetAllCountries.Size = new Size(298, 71);
            btnGetAllCountries.TabIndex = 5;
            btnGetAllCountries.Text = "Get All Countries";
            btnGetAllCountries.Click += btnGetAllCountries_Click;
            // 
            // btnGetCountryByCode
            // 
            btnGetCountryByCode.Location = new Point(536, 223);
            btnGetCountryByCode.Name = "btnGetCountryByCode";
            btnGetCountryByCode.Size = new Size(298, 80);
            btnGetCountryByCode.TabIndex = 6;
            btnGetCountryByCode.Text = "Get Country By Code";
            btnGetCountryByCode.Click += btnGetCountryByCode_Click;
            // 
            // btnGetCityByName
            // 
            btnGetCityByName.Location = new Point(536, 331);
            btnGetCityByName.Name = "btnGetCityByName";
            btnGetCityByName.Size = new Size(298, 90);
            btnGetCityByName.TabIndex = 7;
            btnGetCityByName.Text = "Get City By Name";
            btnGetCityByName.Click += btnGetCityByName_Click;
            // 
            // btnGetCitiesByCountry
            // 
            btnGetCitiesByCountry.Location = new Point(536, 455);
            btnGetCitiesByCountry.Name = "btnGetCitiesByCountry";
            btnGetCitiesByCountry.Size = new Size(298, 95);
            btnGetCitiesByCountry.TabIndex = 8;
            btnGetCitiesByCountry.Text = "Get Cities By Country";
            btnGetCitiesByCountry.Click += btnGetCitiesByCountry_Click;
            // 
            // btnConvertTemperature
            // 
            btnConvertTemperature.Location = new Point(536, 575);
            btnConvertTemperature.Name = "btnConvertTemperature";
            btnConvertTemperature.Size = new Size(298, 80);
            btnConvertTemperature.TabIndex = 9;
            btnConvertTemperature.Text = "Convert Temperature";
            btnConvertTemperature.Click += btnConvertTemperature_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(502, 186);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(240, 184);
            checkedListBox1.TabIndex = 10;
            // 
            // Form1
            // 
            ClientSize = new Size(936, 711);
            Controls.Add(labelTitle);
            Controls.Add(labelInput);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxCountries);
            Controls.Add(listBoxResults);
            Controls.Add(btnGetAllCountries);
            Controls.Add(btnGetCountryByCode);
            Controls.Add(btnGetCityByName);
            Controls.Add(btnGetCitiesByCountry);
            Controls.Add(btnConvertTemperature);
            Name = "Form1";
            Text = "World DB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelInput;
        private TextBox textBoxInput;
        private ComboBox comboBoxCountries;
        private ListBox listBoxResults;
        private Button btnGetAllCountries;
        private Button btnGetCountryByCode;
        private Button btnGetCityByName;
        private Button btnGetCitiesByCountry;
        private Button btnConvertTemperature;
        private CheckedListBox checkedListBox1;
    }
}
