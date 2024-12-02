using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class karyawan
    {

        private string _id;
        private string _name;
        private int _id_departemen;
        private int _id_jabatan;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Departemen
        {
            get { return _id_departemen; }
            set { _id_departemen = value; }
        }

        public int ID_jabatan
        {
            get { return _id_jabatan; }
            set { _id_jabatan = value; }
        }
    }
}
