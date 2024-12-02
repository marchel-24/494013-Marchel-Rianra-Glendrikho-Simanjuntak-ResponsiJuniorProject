using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public DataTable table;
        public DataGridViewRow row;
        private karyawanrepository _karyawanrepository;
        public Form1()
        {
            InitializeComponent();
            _karyawanrepository = new karyawanrepository(dgvData);
            _karyawanrepository.Load();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = tbNama.Text;
            int id_dep = 0;
            int id_jabatan = 0;
            if (cbDep.Text == "HR")
            {
                id_dep = 1;
            }
            else if (cbDep.Text == "ENG")
            {
                id_dep = 2;
            }
            else if (cbDep.Text == "DEV")
            {
                id_dep = 3;
            }
            else if (cbDep.Text == "PM")
            {
                id_dep = 4;
            }
            else if (cbDep.Text == "FIN")
            {
                id_dep = 5;
            }

            if (cbJabatan.Text == "Admin")
            {
                id_jabatan = 2;
            }
            else if (cbJabatan.Text == "Pettingi")
            {
                id_jabatan = 1;
            }
            else { id_jabatan = 3; }

            karyawan Karyawan = new karyawan
            {
                Name = name,
                Departemen = id_dep,
                ID_jabatan = id_jabatan
            };

            _karyawanrepository.Add(Karyawan);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dgvData.Rows[e.RowIndex];
                LbEmpID.Text = row.Cells["id_karyawan"].Value.ToString();
                tbNama.Text = row.Cells["nama"].Value.ToString();
                int id_dep = (int)row.Cells["id_dep"].Value;
                int id_jabatan = (int)row.Cells["id_jabatan"].Value;

                if (id_dep == 1)
                {
                    cbDep.Text = "HR";
                }
                else if (id_dep == 2)
                {
                    cbDep.Text = "ENG";
                }
                else if (id_dep == 3)
                {
                    cbDep.Text = "DEV";
                }
                else if (id_dep == 4)
                {
                    cbDep.Text = "PM";
                }
                else if (id_dep == 5)
                {
                    cbDep.Text = "FIN";
                }

                if (id_jabatan == 1)
                {
                    cbJabatan.Text = "Pettingi";
                }
                else if (id_dep == 2)
                {
                    cbJabatan.Text = "Admin";
                }
                else if (id_dep == 3)
                {
                    cbJabatan.Text = "Manager";
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string IDEmp = LbEmpID.Text;
            string name = tbNama.Text;
            int id_dep = 0;
            int id_jabatan = 0;
            if (cbDep.Text == "HR")
            {
                id_dep = 1;
            }
            else if (cbDep.Text == "ENG")
            {
                id_dep = 2;
            }
            else if (cbDep.Text == "DEV")
            {
                id_dep = 3;
            }
            else if (cbDep.Text == "PM")
            {
                id_dep = 4;
            }
            else if (cbDep.Text == "FIN")
            {
                id_dep = 5;
            }

            if (cbJabatan.Text == "Admin")
            {
                id_jabatan = 2;
            }
            else if (cbJabatan.Text == "Pettingi")
            {
                id_jabatan = 1;
            }
            else { id_jabatan = 3; }

            karyawan Karyawan = new karyawan
            {
                Id = IDEmp,
                Name = name,
                Departemen = id_dep,
                ID_jabatan = id_jabatan
            };

            _karyawanrepository.Update(Karyawan);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string IDEmp = LbEmpID.Text;

            karyawan Karyawan = new karyawan
            {
                Id = IDEmp
            };

            _karyawanrepository.Delete(Karyawan);
        }
    }
}
