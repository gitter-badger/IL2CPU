using System;


namespace Cosmos.IL2CPU.X86.IL
{
    [Cosmos.IL2CPU.OpCode( ILOpCode.Code.Stind_I8 )]
    public class Stind_I8 : ILOp
    {
        public Stind_I8( XSharp.Assembler.Assembler aAsmblr )
            : base( aAsmblr )
        {
        }

        public override void Execute(_MethodInfo aMethod, ILOpCode aOpCode )
        {
            Stind_I.Assemble(Assembler, 8, DebugEnabled);
        }


        // using System;
        // using System.IO;
        // 
        // 
        // using CPU = XSharp.Assembler.x86;
        // 
        // namespace Cosmos.IL2CPU.IL.X86 {
        // 	[XSharp.Assembler.OpCode(OpCodeEnum.Stind_I8)]
        // 	public class Stind_I8: Op {
        // 		public Stind_I8(ILReader aReader, MethodInformation aMethodInfo)
        // 			: base(aReader, aMethodInfo) {
        // 		}
        // 		public override void DoAssemble() {
        // 			Stind_I.Assemble(Assembler, 8);
        // 		}
        // 	}
        // }

    }
}
