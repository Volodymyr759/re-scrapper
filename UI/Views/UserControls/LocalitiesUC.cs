using Equin.ApplicationFramework;
using Services.LocalityService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace UI.Views.UserControls
{
    public partial class LocalitiesUC : UserControl, ILocalitiesUC
    {
        #region Members

        private bool IsLoaded = false;

        private readonly BindingListView<LocalityDto> sortableBindingListView;

        public event EventHandler<LocalityDto> LocalityRowChanged;

        #endregion

        #region Ctor

        public LocalitiesUC()
        {
            InitializeComponent();
            if (components == null) components = new Container();
            sortableBindingListView = new BindingListView<LocalityDto>(components);
        }

        #endregion

        public void SetUpControls(IEnumerable<LocalityDto> localityDtos)
        {
            sortableBindingListView.DataSource = localityDtos.ToList();

            dgvLocalities.DataSource = sortableBindingListView;

            List<string> states = localityDtos.Select(a => a.State).Distinct().ToList();
            states.Sort();
            states.Insert(0, "All");
            cmbState.DataSource = states;

            IsLoaded = true;
        }

        public void UpdateControls(LocalityDto localityDto)
        {
            foreach (DataGridViewRow row in dgvLocalities.Rows)
            {
                if (row.Cells[idDataGridViewTextBoxColumn.Index].Value.ToString() == localityDto.Id.ToString())
                {
                    row.Cells[suburbDataGridViewTextBoxColumn.Index].Value = localityDto.Suburb;
                    row.Cells[postcodeDataGridViewTextBoxColumn.Index].Value = localityDto.Postcode;
                    row.Cells[stateDataGridViewTextBoxColumn.Index].Value = localityDto.State;

                    return;
                }
            }
        }

        #region UC Events

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
            }
        }

        private void DgvLocalities_SelectionChanged(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                var dgv = (DataGridView)sender;
                if (dgv.CurrentRow != null)
                {
                    int selectedRow = dgv.CurrentRow.Index;
                    var localityDto = new LocalityDto
                    {
                        Id = int.Parse(dgv.Rows[selectedRow].Cells[idDataGridViewTextBoxColumn.Index].Value.ToString()),
                        Suburb = dgv.Rows[selectedRow].Cells[suburbDataGridViewTextBoxColumn.Index].Value.ToString(),
                        Postcode = dgv.Rows[selectedRow].Cells[postcodeDataGridViewTextBoxColumn.Index].Value.ToString(),
                        State = dgv.Rows[selectedRow].Cells[stateDataGridViewTextBoxColumn.Index].Value?.ToString(),
                    };

                    LocalityRowChanged(this, localityDto);
                }
            }
        }

        #endregion
    }
}
