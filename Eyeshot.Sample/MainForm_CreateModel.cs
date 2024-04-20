using devDept.Eyeshot.Entities;
using devDept.Geometry;

using System.Drawing;

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
            Circle circle = new Circle(Plane.YZ, 40);
            circle.Rotate(10, new Vector3D(new Point3D(0, 0, 0), new Point3D(0, 1, 0)));

            // 디자인에 형상 추가
            design1.Entities.Add(rrscc, design1.Layers[1].Name);
            design1.Entities.Add(circle, Color.Red);

            design1.Refresh();
        }

        private void CreateStar()
        {
            LinearPath starLinePath = new LinearPath(new Point3D(0, 0, 0), new Point3D(10, 0, 0),
                                                     new Point3D(2, -10, 0), new Point3D(5, 5, 0),
                                                     new Point3D(8, -10, 0), new Point3D(0, 0, 0));

            design1.Entities.Add(starLinePath, Color.Yellow);
            design1.Refresh();
        }

        private void CreateRectangle()
        {
            _Rectangle = devDept.Eyeshot.Entities.Region.CreateRectangle(Plane.ZX, 100, 20);
            design1.Entities.Add(_Rectangle, Color.Salmon);
            design1.Refresh();
        }
    }
}
