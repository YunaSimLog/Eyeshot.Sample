using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eyeshot.Sample
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        Entity _Rectangle = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateModel();
        }

        private void btnCreateStar_Click(object sender, EventArgs e)
        {
            CreateStar();
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            CreateRectangle();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (_Rectangle == null)
                return;

            _Rectangle.Rotate(-Math.PI / 4, Vector3D.AxisZ);
            _Rectangle.Translate(100, 200, 0);
            //_Rectangle.Scale(2);

            //_Rectangle.Translate(1000, 290, 0);
            design1.Refresh();
            design1.Invalidate();
        }
    }
}
