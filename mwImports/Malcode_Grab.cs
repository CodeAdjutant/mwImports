using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace mwImports
{
    class Malcode_Grab:PageGrab
    {
        public Malcode_Grab(Form1 topForm)
        {
            mainForm = topForm;
        }



        public void setDates(DateTime startDatePicked,DateTime endDatePicked)
        {
            startDate = startDatePicked;
            endDate = endDatePicked;
        }
    }
}
