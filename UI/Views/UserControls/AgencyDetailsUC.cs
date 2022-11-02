using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace UI.Views.UserControls
{
    public partial class AgencyDetailsUC : UserControl, IAgencyDetailsUC
    {
        #region Members

        public event EventHandler<int> DeleteAgencyEventRaised;
        public event EventHandler<AgencyDto> SaveAgencyEventRaised;

        #endregion

        #region Ctor

        public AgencyDetailsUC()
        {
            InitializeComponent();
        }

        #endregion

        public void SetUpControls(AgencyDto agencyDto)
        {
            if (agencyDto != null)
            {
                txtId.Text = agencyDto.Id.ToString();
                txtName.Text = agencyDto.Name;
                txtAddress.Text = agencyDto.FullAddress;
                txtWeb.Text = agencyDto.WebSite;
                txtFacebook.Text = agencyDto.FacebookPage;
                txtPhone.Text = agencyDto.Phone;
                rtxtNotes.Text = agencyDto.Notes;
                dtpUpdated.Value = agencyDto.LastUpdatedOn;
            }
        }

        #region UC Events

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id)) DeleteAgencyEventRaised(this, id);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveAgencyEventRaised(this, new AgencyDto
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                FullAddress = txtAddress.Text,
                WebSite = txtWeb.Text,
                FacebookPage = txtFacebook.Text,
                Phone = txtPhone.Text,
                Notes = rtxtNotes.Text,
                LastUpdatedOn = DateTime.TryParse(dtpUpdated.Value.ToShortDateString(), out DateTime dt) ? dt : DateTime.UtcNow
            });
        }

        #endregion
    }
}
