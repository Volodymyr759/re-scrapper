using Services.SettingsService;
using System;
using System.Windows.Forms;

namespace UI.Views.UserControls
{
    public partial class SettingsUC : UserControl, ISettingsUC
    {
        public event EventHandler<SettingsDto> SaveSettingsButtonClicked;

        public SettingsUC()
        {
            InitializeComponent();
        }

        public void SetUpControls(SettingsDto settingsDto)
        {
            txtBaseUrl.Text = settingsDto.BaseUrl;
            txtGetInTouch.Text = settingsDto.ButtonsGetInTouchSelector;
            txtPropertiesForRent.Text = settingsDto.PropertiesForRentSelector;
            txtPropertiesSold.Text = settingsDto.PropertiesSoldSelector;
            numThreads.Value = settingsDto.ThreadsNumber;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var settingsDto = new SettingsDto
            {
                BaseUrl = txtBaseUrl.Text,
                ButtonsGetInTouchSelector = txtGetInTouch.Text,
                PropertiesForRentSelector = txtPropertiesForRent.Text,
                PropertiesSoldSelector = txtPropertiesSold.Text,
                ThreadsNumber = (int)numThreads.Value
            };

            SaveSettingsButtonClicked(this, settingsDto);
        }
    }
}
