﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Akhir_PBO.View.Admin
{
    public partial class UserControlAdmin : UserControl
    {
        Form1 FormParent;
        public UserControlAdmin(Form1 FormParent)
        {
            this.FormParent = FormParent;
            InitializeComponent();
        }
    }
}
