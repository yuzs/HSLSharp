﻿using HSLSharp.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSLSharp.NodeSettings
{
    public partial class FormNodeClass : Form
    {
        public FormNodeClass( )
        {
            InitializeComponent( );
        }

        private void FormNodeClass_Load( object sender, EventArgs e )
        {

        }

        private void userButton1_Click( object sender, EventArgs e )
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show( "节点名称不能为空" );
                return;
            }

            SelectedNodeClass = new NodeClass( )
            {
                Name = textBox1.Text,
                Description = textBox2.Text,
            };
            DialogResult = DialogResult.OK;
        }


        public NodeClass SelectedNodeClass { get; set; }
    }
}
