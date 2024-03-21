using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class NiveauPlonger
    {
        private int _numNiveauPlonger;
        private string _descriptionNiveauPlonger;


        public NiveauPlonger(int numNiveauPlonger, string descriptionNiveauPlonger)
        {
            _numNiveauPlonger = numNiveauPlonger;
            _descriptionNiveauPlonger = descriptionNiveauPlonger;

        }

        public int NumNiveauPlonger
        {
            get { return _numNiveauPlonger; }
            set { _numNiveauPlonger = value; }
        }

        public string DescriptionNiveauPlonger
        {
            get { return _descriptionNiveauPlonger; }
            set { _descriptionNiveauPlonger = value; }
        }

        public override string ToString()
        {
            return NumNiveauPlonger.ToString();
        }
    }
}
