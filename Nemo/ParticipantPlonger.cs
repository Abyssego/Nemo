using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class ParticipantPlonger
    {
        private string _datePlonger;
        private int _numParticipantPlonger;
        private Plongeur _lePlongeur;
        private Plonger _lePlonger;
        private Personnel _lePersonnel;
        private string _materielLouerParticipantPlonger;
        private int _presentParticipantPlonger;

        public ParticipantPlonger(string datePlonger, int numParticipantPlonger, Plongeur lePlongeur, Plonger lePlonger, Personnel lePersonnel, string materielLouerParticipantPlonger, int presentParticipantPlonger)
        {
            _datePlonger = datePlonger;
            _numParticipantPlonger = numParticipantPlonger;
            _lePlongeur = lePlongeur;
            _lePlonger = lePlonger;
            _lePersonnel = lePersonnel;
            _materielLouerParticipantPlonger = materielLouerParticipantPlonger;
            _presentParticipantPlonger= presentParticipantPlonger;
        }

        public string DatePlonger
        {
            get { return _datePlonger; }
            set { _datePlonger= value; }
        }

        public int NumParticipantPlonger
        {
            get { return _numParticipantPlonger; }
            set { _numParticipantPlonger = value; }
        }

        public Plongeur LePlongeur
        {
            get { return _lePlongeur; }
            set { _lePlongeur = value; }
        }

        public Plonger LePlonger
        {
            get { return _lePlonger; }
            set { _lePlonger = value; }
        }

        public Personnel LePersonnel
        {
            get { return _lePersonnel; }
            set { _lePersonnel = value; }
        }

        public string MaterielLouerParticipantPlonger
        {
            get { return _materielLouerParticipantPlonger; }
            set { _materielLouerParticipantPlonger = value; }
        }

        public int PresentParticipantPlonger
        {
            get { return _presentParticipantPlonger; }
            set { _presentParticipantPlonger = value; }
        }

        public override string ToString()
        {
            return NumParticipantPlonger.ToString();
        }
    }
}
