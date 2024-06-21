using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracerCSharp
{
    public partial class PunchInOut : Form
    {
        public PunchInOut()
        {
            InitializeComponent();
        }

        public PunchInOut(int empId)
        {
            InitializeComponent();
            label1.Text = empId.ToString();
        }
    }
}
