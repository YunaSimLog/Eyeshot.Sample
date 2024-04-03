﻿using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyeshot.Sample
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private void CreateModel()
        {
            // 레이어 생성
            design1.Layers.Add(new devDept.Eyeshot.Layer("신규 레이어", Color.Green, "", 2, true));

            // 모서리가 둥근 사각형 커브 생성
            CompositeCurve rrscc = CompositeCurve.CreateRoundedRectangle(Plane.YZ, 60, 120, 12, true);
            
            // 원형 생성
            Circle circle = new Circle(Plane.YZ,400);

            // 디자인에 형상 추가
            design1.Entities.Add(rrscc, design1.Layers[1].Name);
            design1.Entities.Add(circle, Color.Red);

            design1.Refresh();
        }
    }
}
