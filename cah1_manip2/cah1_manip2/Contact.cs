using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cah1_manip2
{
    public partial class Contact : Component
    {
        public Contact()
        {
            InitializeComponent();
        }

        public Contact(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
