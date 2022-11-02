using Equin.ApplicationFramework;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI.Views.UserControls
{
    public partial class AgenciesUC : UserControl, IAgenciesUC
    {
        #region Members

        bool IsLoaded = false;
        readonly BindingListView<AgencyDto> sortableBindingListView;

        public event EventHandler<AgencyDto> AgencyRowChanged;
        public event EventHandler<string> ParseAgenciesOptionClicked;
        public event EventHandler<string> ShowWebSiteOptionClicked;
        public event EventHandler<string> ShowFacebookPageOptionClicked;

        #endregion

        #region Ctor

        public AgenciesUC()
        {
            InitializeComponent();
            if (components == null) components = new Container();
            sortableBindingListView = new BindingListView<AgencyDto>(components);
        }

        #endregion

        public void SetUpControls(IEnumerable<AgencyDto> agencyDtos)
        {
            sortableBindingListView.DataSource = agencyDtos.ToList();

            dgvAgencies.DataSource = sortableBindingListView;

            List<string> states = agencyDtos.Select(a => a.State).Distinct().ToList();
            states.Sort();
            states.Insert(0, "All");
            cmbState.DataSource = states;
            cmbOptions.Enabled = true;
            lblInfo.Text = agencyDtos.Count() + " agencies.";

            IsLoaded = true;
        }

        public void UpdateControls(AgencyDto agencyDto)
        {
            foreach (DataGridViewRow row in dgvAgencies.Rows)
            {
                if (row.Cells[idDataGridViewTextBoxColumn.Index].Value.ToString() == agencyDto.Id.ToString())
                {
                    row.Cells[nameDataGridViewTextBoxColumn.Index].Value = agencyDto.Name;
                    row.Cells[fullAddressDataGridViewTextBoxColumn.Index].Value = agencyDto.FullAddress;
                    row.Cells[stateDataGridViewTextBoxColumn.Index].Value = agencyDto.State;
                    row.Cells[webSiteDataGridViewTextBoxColumn.Index].Value = agencyDto.WebSite;
                    row.Cells[facebookPageDataGridViewTextBoxColumn.Index].Value = agencyDto.FacebookPage;
                    row.Cells[propertiesSoldDataGridViewTextBoxColumn.Index].Value = agencyDto.PropertiesSold;
                    row.Cells[propertiesForRentDataGridViewTextBoxColumn.Index].Value = agencyDto.PropertiesForRent;
                    row.Cells[phoneDataGridViewTextBoxColumn.Index].Value = agencyDto.Phone;
                    row.Cells[lastUpdatedOnDataGridViewTextBoxColumn.Index].Value = agencyDto.LastUpdatedOn;
                    row.Cells[notesDataGridViewTextBoxColumn.Index].Value = agencyDto.Notes;

                    return;
                }
            }
        }

        #region UC Events

        private void CmbOptions_SelectedValueChanged(object sender, EventArgs e)
        {
            var optionsComboBox = (ComboBox)sender;

            if (string.IsNullOrEmpty(optionsComboBox.Text))
            {
                MessageBox.Show("Please select the required option.");
                return;
            }

            switch (optionsComboBox.SelectedItem)
            {
                case "Parse agencies":
                    cmbOptions.Enabled = false;
                    ParseAgenciesOptionClicked(this, cmbState.Text);
                    break;

                case "Show Facebook page":
                    if (dgvAgencies.CurrentRow != null)
                    {
                        ShowFacebookPageOptionClicked(this, dgvAgencies.CurrentRow.Cells[facebookPageDataGridViewTextBoxColumn.Index].Value.ToString());
                    }
                    break;

                case "Show website":
                    if (dgvAgencies.CurrentRow != null)
                    {
                        ShowWebSiteOptionClicked(this, dgvAgencies.CurrentRow.Cells[webSiteDataGridViewTextBoxColumn.Index].Value.ToString());
                    }
                    break;

                default:
                    break;
            }
        }

        private void CmbState_SelectedValueChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                var comboBox = (ComboBox)sender;

                if (comboBox.Text == "All")
                {
                    sortableBindingListView.RemoveFilter();
                }
                else
                {
                    sortableBindingListView.ApplyFilter(a => a.State == comboBox.Text);
                }

                lblInfo.Text = sortableBindingListView.Count.ToString() + " agencies.";
            }
        }

        private void DgvAgencies_SelectionChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                var dgv = (DataGridView)sender;

                if (dgv.CurrentRow != null)
                {
                    int selectedRow = dgv.CurrentRow.Index;
                    var agencyDto = new AgencyDto
                    {
                        Id = int.Parse(dgv.Rows[selectedRow].Cells[idDataGridViewTextBoxColumn.Index].Value.ToString()),
                        Name = dgv.Rows[selectedRow].Cells[nameDataGridViewTextBoxColumn.Index].Value.ToString(),
                        FullAddress = dgv.Rows[selectedRow].Cells[fullAddressDataGridViewTextBoxColumn.Index].Value.ToString(),
                        WebSite = dgv.Rows[selectedRow].Cells[webSiteDataGridViewTextBoxColumn.Index].Value?.ToString(),
                        FacebookPage = dgv.Rows[selectedRow].Cells[facebookPageDataGridViewTextBoxColumn.Index].Value?.ToString(),
                        Phone = dgv.Rows[selectedRow].Cells[phoneDataGridViewTextBoxColumn.Index].Value?.ToString(),
                        LastUpdatedOn = DateTime.Parse(dgv.Rows[selectedRow].Cells[lastUpdatedOnDataGridViewTextBoxColumn.Index].Value.ToString()),
                        Notes = dgv.Rows[selectedRow].Cells[notesDataGridViewTextBoxColumn.Index].Value?.ToString(),
                    };

                    AgencyRowChanged(this, agencyDto);
                }
            }
        }

        public void UpdateStatus(string currentStatus) => lblInfo.Text = currentStatus;

        #endregion
    }
}
