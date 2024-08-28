using ENV;
using ENV.Data;
using Firefly.Box;
using Firefly.Box.UI.Advanced;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Northwind.TestProduct.Views
{
    partial class TestView : Shared.Theme.Controls.Form
    {
        Test _controller;
        public TestView(Test controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void grid1_Click(object sender, EventArgs e)
        {

        }
    }
}