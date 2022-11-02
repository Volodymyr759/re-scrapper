using Services.LocalityService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace UI.Views.UserControls
{
    public partial class LocalityDetailsUC : UserControl, ILocalityDetailsUC
    {
        #region Members

        public event EventHandler<int> DeleteLocalityEventRaised;
        public event EventHandler<LocalityDto> SaveLocalityEventRaised;

        #endregion

        #region Ctor

        public LocalityDetailsUC()
        {
            InitializeComponent();
        }

        #endregion

        public void SetUpControls(LocalityDto localityDto)
        {
            txtId.Text = localityDto.Id.ToString();
            rtxtSuburb.Text = localityDto.Suburb;
            txtPostcode.Text = localityDto.Postcode;
            txtState.Text = localityDto.State;
        }

        #region UC Events

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id)) DeleteLocalityEventRaised(this, id);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveLocalityEventRaised(this, new LocalityDto
            {
                Id = int.Parse(txtId.Text),
                Suburb = rtxtSuburb.Text,
                Postcode = txtPostcode.Text,
                State = txtState.Text,
            });
        }

        #endregion
    }
}
