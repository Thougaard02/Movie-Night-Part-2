using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_Part_2
{
    class Contributing
    {
        #region Properties

        private int fid;

        public int FID
        {
            get { return fid; }
            set { fid = value; }
        }

        private int sid;

        public int SID
        {
            get { return sid; }
            set { sid = value; }
        }
        #endregion

        #region Constructor

        public Contributing()
        {

        }
        public Contributing(int _fid, int _sid)
        {
            this.FID = _fid;
            this.SID = _sid;
        }
        #endregion
    }
}
