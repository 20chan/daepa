using daepa.Renders.Primitives2D;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daepa.Renders.Samples {
	public class LineDrawer {
		private Renderer r;
		private Line cursorLine;

		public LineDrawer(Renderer r) {
			this.r = r;

			var line0 = new Line(
				new VertexPositionColor(new Vector3(100, 100, 0), Color.White),
				new VertexPositionColor(new Vector3(800, 100, 0), Color.White));
			var line1 = new Line(
				new VertexPositionColor(new Vector3(800, 100, 0), Color.White),
				new VertexPositionColor(new Vector3(400, 500, 0), Color.White));
			var line2 = new Line(
				new VertexPositionColor(new Vector3(400, 500, 0), Color.White),
				new VertexPositionColor(new Vector3(100, 100, 0), Color.White));

			cursorLine = new Line(
				new VertexPositionColor(new Vector3(400, 200, 0), Color.White),
				new VertexPositionColor(new Vector3(0, 0, 0), Color.White));

			r.Objects.Add(line0);
			r.Objects.Add(line1);
			r.Objects.Add(line2);
			r.Objects.Add(cursorLine);
		}

		public void Update() {
			var input = Mouse.GetState();

			if (input.LeftButton == ButtonState.Pressed) {
				if (!r.Objects.Contains(cursorLine)) {
					r.Objects.Add(cursorLine);
				}
			}
			if (input.RightButton == ButtonState.Pressed) {
				if (r.Objects.Contains(cursorLine)) {
					r.Objects.Remove(cursorLine);
				}
			}

			cursorLine.Point1.Position = new Vector3(input.X, input.Y, 0);
		}
	}
}
