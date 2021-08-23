using NpSharp.Contracts.Pos;
using System.ComponentModel.Composition;



namespace NpSharp.Extension.Pos.MicroFrontEnds
{
    [Export(typeof(IPosExtension))]
    public class MicroFrontEndsExtension : PosExtensionBase
    {
        public override void OnLoad()
        {


        }
    }
}
