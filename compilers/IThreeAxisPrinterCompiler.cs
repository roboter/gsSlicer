using System;
using g3;

namespace gs
{
    // [TODO] be able to not hardcode this type?
    public interface IThreeAxisPrinterCompiler : ICNCCompiler
    {
        // current nozzle position
        Vector3d NozzlePosition { get; }

        // compiler will call this to emit status messages / etc
        Action<string> EmitMessageF { get; set; }

        void Begin();
        
        void AppendPaths(ToolpathSet paths, SingleMaterialFFFSettings pathSettings);
        
        void AppendComment(string comment);

        void AppendCommand(string command);

        void End();
    }
}
