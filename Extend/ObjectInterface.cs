using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigsence.ApplicationElements;

namespace Sigsence.ProgrammingInterface.Extend
{
    public class ObjDataUpdateEventArgsInf: EventArgs
    {
        public ObjDataUpdateEventArgsInf(double[] _data)
        {
            dataUpdate = _data;
        }

        private double[] dataUpdate;
        public double[] DataUpdate
        {
            get
            {
                return dataUpdate;
            }
            set
            {
                dataUpdate = value;
            }
        }
    }
}
