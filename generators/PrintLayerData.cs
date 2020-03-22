using System.Collections.Generic;
using g3;

namespace gs
{
    /// <summary>
    /// PrintLayerData is set of information for a single print layer
    /// </summary>
    public class PrintLayerData
	{
		public int layer_i;
		public PlanarSlice Slice;
		public SingleMaterialFFFSettings Settings;

		public PrintLayerData PreviousLayer;

		public ToolpathSetBuilder PathAccum;
		public IFillPathScheduler2d Scheduler;

		public List<IShellsFillPolygon> ShellFills;
        public List<GeneralPolygon2d> SupportAreas;

		public TemporalPathHash Spatial;

		public PrintLayerData(int layer_i, PlanarSlice slice, SingleMaterialFFFSettings settings) {
			this.layer_i = layer_i;
			Slice = slice;
			Settings = settings;
			Spatial = new TemporalPathHash();
		}
	}




}
