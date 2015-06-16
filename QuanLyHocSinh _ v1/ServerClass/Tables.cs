using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServerClass
{
    abstract class Tables
    {
        protected string TableName;

        abstract public void Load(Control GridView);

        abstract public void Add(Control GridView, HocVien hocVien);
    }
}
