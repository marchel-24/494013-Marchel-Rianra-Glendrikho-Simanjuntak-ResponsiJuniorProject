using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class karyawanrepository:karyawan
    {
        private const string conn = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;
        private static DataTable table;
        private DataGridView dgvData;
        private DataGridViewRow _row;

        public DataGridViewRow Row { set { _row = value; } }

        public karyawanrepository(DataGridView _dgvData)
        {
            dgvData = _dgvData;
        }

        public void Load()
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                table = new DataTable();

                string sql = "SELECT * FROM karyawan";
                command = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader r = command.ExecuteReader();
                table.Load(r);
                dgvData.DataSource = table;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Add(karyawan akun) 
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                table = new DataTable();

                string sql = "SELECT * FROM add_karyawan(:_nama, :_id_dep, :_id_jabatan)";
                command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("_nama", akun.Name);
                command.Parameters.AddWithValue("_id_dep", akun.Departemen);
                command.Parameters.AddWithValue("_id_jabatan", akun.ID_jabatan);
                int status = (int)command.ExecuteScalar();
                if (status == 1)
                {
                    MessageBox.Show("Berhasil");
                    Load();
                }
                else { MessageBox.Show("Error"); }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update(karyawan akun)
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                table = new DataTable();

                string sql = "SELECT * FROM update_karyawan(:_id_emp, :_nama, :_id_dep, :_id_jabatan)";
                command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("_id_emp", akun.Id);
                command.Parameters.AddWithValue("_nama", akun.Name);
                command.Parameters.AddWithValue("_id_dep", akun.Departemen);
                command.Parameters.AddWithValue("_id_jabatan", akun.ID_jabatan);
                int status = (int)command.ExecuteScalar();
                if (status == 1)
                {
                    MessageBox.Show("Berhasil Update" + akun.Id);
                    Load();
                }
                else { MessageBox.Show("Error"); }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(karyawan akun) 
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                table = new DataTable();

                string sql = "SELECT * FROM delete_karyawan(:_id_emp)";
                command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("_id_emp", akun.Id);
                int status = (int)command.ExecuteScalar();
                if (status == 1)
                {
                    MessageBox.Show("Berhasil Delete " + akun.Id);
                    Load();
                }
                else { MessageBox.Show("Error"); }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
