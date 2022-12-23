using System;
namespace IntermediateCsharp_part2
{
	public class Canvas
	{
		public void DrawShapes(List<Shape> shapes)
		{
			foreach (var shape in shapes)
			{
				shape.Draw();
			}
		}
	}
}

