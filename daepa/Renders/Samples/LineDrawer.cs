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
		private int cursorLineIndex;

		public LineDrawer(Renderer r) {
			this.r = r;

			var line0 = r.CreateLine(out _);
			var line1 = r.CreateLine(out _);
			var line2 = r.CreateLine(out _);

			line0[0].Position = new Vector3(100, 100, 0);
			line0[1].Position = new Vector3(300, 100, 0);
			line1[0].Position = new Vector3(300, 100, 0);
			line1[1].Position = new Vector3(200, 60, 0);
			line2[0].Position = new Vector3(200, 60, 0);
			line2[1].Position = new Vector3(100, 100, 0);

			var line3 = r.CreateLine(out cursorLineIndex);
			line3[0].Position = new Vector3(100, 100, 0);
		}

		public void Update() {
			var input = Mouse.GetState();

			ref var line = ref r.Lines[cursorLineIndex + 1];
			line.Position = new Vector3(input.X, input.Y, 0);
		}
	}
}
