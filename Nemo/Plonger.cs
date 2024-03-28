using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo // loan est moche
{
    public class Plonger
    {
        private int _numPlonger;
        private SitePlonger _leSitePlonger;
        private string _datePlonger;
        private string _durerPlonger;
        private string _typePlonger;


        public Plonger(int numPlonger, SitePlonger leSitePlonger, string datePlonger, string durerPlonger, string typePlonger)
        {
            _numPlonger = numPlonger;
            _leSitePlonger = leSitePlonger;
            _datePlonger = datePlonger;
            _durerPlonger = durerPlonger;
            _typePlonger = typePlonger;
        }

        public int NumPlonger
        {
            get { return _numPlonger; }
            set { _numPlonger = value; }
        }

        public SitePlonger LeSitePlonger
        {
            get { return _leSitePlonger; }
            set { _leSitePlonger = value; }
        }

        public string DatePlonger
        {
            get { return _datePlonger; }
            set { _datePlonger = value; }
        }

        public string DurerPlonger
        {
            get { return _durerPlonger; }
            set { _durerPlonger = value; }
        }

        public string Typeplonger
        {
            get { return _typePlonger; }
            set { _typePlonger = value; }
        }

        public override string ToString()
        {
            return NumPlonger.ToString();
        }
    }
}
