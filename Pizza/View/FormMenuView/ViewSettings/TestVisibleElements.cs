using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza.View.FormMenuView.ViewSettings
{
    public abstract class TestVisibleElements
    {
        public bool AddButton { get; protected set; }
        public bool QTextbox { get; protected set; }
        public bool ButtonRemoveAll { get; protected set; }
        public bool ButtonRemoveOne { get; protected set; }
    }
}
