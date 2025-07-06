using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro
{
    public partial class order : Component
    {
        public order()
        {
            InitializeComponent();
        }

        public order(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
