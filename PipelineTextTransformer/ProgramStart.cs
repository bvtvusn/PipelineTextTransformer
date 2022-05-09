using PipelineTextTransformer.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PipelineTextTransformer
{
    class ProgramStart
    {
        DAL dal;
        BL bl;
        public ProgramStart()
        {

            dal = new DAL();
            bl = new BL(dal);


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EditForm(bl));
        }
    }
}
