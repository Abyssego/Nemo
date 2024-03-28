using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class SitePlonger
    {
        private int _numSitePlonger;
        private string _nomSitePlonger;
        private int _profondeurMaxSitePlonger;

        public SitePlonger(int numPlongeur, string nomPlongeur, int profondeurMaxSitePlonger)
        {
            _numSitePlonger = numPlongeur;
            _nomSitePlonger = nomPlongeur;
            _profondeurMaxSitePlonger = profondeurMaxSitePlonger;
        }

        public int NumSitePlonger
        {
            get { return _numSitePlonger; }
            set { _numSitePlonger = value; }
        }

        public string NomSitePlonger
        {
            get { return _nomSitePlonger; }
            set { _nomSitePlonger = value; }
        }


        public int ProfondeurMaxSitePlonger
        {
            get { return _profondeurMaxSitePlonger; }
            set { _profondeurMaxSitePlonger = value; }
        }


        public override string ToString()
        {
            return NumSitePlonger.ToString();
        }
    }
}