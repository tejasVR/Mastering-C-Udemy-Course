using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var s in shapes)
            {
                s.Draw();
            }
        }
    }
}
