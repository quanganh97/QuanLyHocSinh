using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDoDTO
    {
        private String _MaTrinhDo;

        public String MaTrinhDo
        {
            get { return _MaTrinhDo; }
            set { _MaTrinhDo = value; }
        }
        private String _TenTrinhDo;

        public String TenTrinhDo
        {
            get { return _TenTrinhDo; }
            set { _TenTrinhDo = value; }
        }
        private String _ChuyenNganh;

        public String ChuyenNganh
        {
            get { return _ChuyenNganh; }
            set { _ChuyenNganh = value; }
        }
    }
}
