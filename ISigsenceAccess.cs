using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Sigsence.ApplicationFunction;
using Sigsence.ApplicationElements;

namespace Sigsence.ProgrammingInterface
{
    public enum InterfaceControlType
    {
        Sequence,
        Indicator
    }

    public interface ISigsenceAccess
    {
        string ObjectName
        {
            get;
        }

        string Description
        {
            get;
        }

        Form FormInitObject
        {
            get;
        }

        InterfaceControlType IControlType
        {
            get;
        }

        string ResourceImagePath
        {
            get;
        }

        void InitObject(ISigsenceInterface sigsence);
    }
}
