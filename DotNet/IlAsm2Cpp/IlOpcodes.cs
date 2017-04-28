using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Emit;

namespace IL2CPP
{
    public class IlOpcodes
    {
        static IlOpcodes()
        {
            OpCode[] opCodes = {
                                   OpCodes.Nop,
                                   OpCodes.Break,
                                   OpCodes.Ldarg_0,
                                   OpCodes.Ldarg_1,
                                   OpCodes.Ldarg_2,
                                   OpCodes.Ldarg_3,
                                   OpCodes.Ldloc_0,
                                   OpCodes.Ldloc_1,
                                   OpCodes.Ldloc_2,
                                   OpCodes.Ldloc_3,
                                   OpCodes.Stloc_0,
                                   OpCodes.Stloc_1,
                                   OpCodes.Stloc_2,
                                   OpCodes.Stloc_3,
                                   OpCodes.Ldarg_S,
                                   OpCodes.Ldarga_S,
                                   OpCodes.Starg_S,
                                   OpCodes.Ldloc_S,
                                   OpCodes.Ldloca_S,
                                   OpCodes.Stloc_S,
                                   OpCodes.Ldnull,
                                   OpCodes.Ldc_I4_M1,
                                   OpCodes.Ldc_I4_0,
                                   OpCodes.Ldc_I4_1,
                                   OpCodes.Ldc_I4_2,
                                   OpCodes.Ldc_I4_3,
                                   OpCodes.Ldc_I4_4,
                                   OpCodes.Ldc_I4_5,
                                   OpCodes.Ldc_I4_6,
                                   OpCodes.Ldc_I4_7,
                                   OpCodes.Ldc_I4_8,
                                   OpCodes.Ldc_I4_S,
                                   OpCodes.Ldc_I4,
                                   OpCodes.Ldc_I8,
                                   OpCodes.Ldc_R4,
                                   OpCodes.Ldc_R8,
                                   OpCodes.Dup,
                                   OpCodes.Pop,
                                   OpCodes.Jmp,
                                   OpCodes.Call,
                                   OpCodes.Calli,
                                   OpCodes.Ret,
                                   OpCodes.Br_S,
                                   OpCodes.Brfalse_S,
                                   OpCodes.Brtrue_S,
                                   OpCodes.Beq_S,
                                   OpCodes.Bge_S,
                                   OpCodes.Bgt_S,
                                   OpCodes.Ble_S,
                                   OpCodes.Blt_S,
                                   OpCodes.Bne_Un_S,
                                   OpCodes.Bge_Un_S,
                                   OpCodes.Bgt_Un_S,
                                   OpCodes.Ble_Un_S,
                                   OpCodes.Blt_Un_S,
                                   OpCodes.Br,
                                   OpCodes.Brfalse,
                                   OpCodes.Brtrue,
                                   OpCodes.Beq,
                                   OpCodes.Bge,
                                   OpCodes.Bgt,
                                   OpCodes.Ble,
                                   OpCodes.Blt,
                                   OpCodes.Bne_Un,
                                   OpCodes.Bge_Un,
                                   OpCodes.Bgt_Un,
                                   OpCodes.Ble_Un,
                                   OpCodes.Blt_Un,
                                   OpCodes.Switch,
                                   OpCodes.Ldind_I1,
                                   OpCodes.Ldind_U1,
                                   OpCodes.Ldind_I2,
                                   OpCodes.Ldind_U2,
                                   OpCodes.Ldind_I4,
                                   OpCodes.Ldind_U4,
                                   OpCodes.Ldind_I8,
                                   OpCodes.Ldind_I,
                                   OpCodes.Ldind_R4,
                                   OpCodes.Ldind_R8,
                                   OpCodes.Ldind_Ref,
                                   OpCodes.Stind_Ref,
                                   OpCodes.Stind_I1,
                                   OpCodes.Stind_I2,
                                   OpCodes.Stind_I4,
                                   OpCodes.Stind_I8,
                                   OpCodes.Stind_R4,
                                   OpCodes.Stind_R8,
                                   OpCodes.Add,
                                   OpCodes.Sub,
                                   OpCodes.Mul,
                                   OpCodes.Div,
                                   OpCodes.Div_Un,
                                   OpCodes.Rem,
                                   OpCodes.Rem_Un,
                                   OpCodes.And,
                                   OpCodes.Or,
                                   OpCodes.Xor,
                                   OpCodes.Shl,
                                   OpCodes.Shr,
                                   OpCodes.Shr_Un,
                                   OpCodes.Neg,
                                   OpCodes.Not,
                                   OpCodes.Conv_I1,
                                   OpCodes.Conv_I2,
                                   OpCodes.Conv_I4,
                                   OpCodes.Conv_I8,
                                   OpCodes.Conv_R4,
                                   OpCodes.Conv_R8,
                                   OpCodes.Conv_U4,
                                   OpCodes.Conv_U8,
                                   OpCodes.Callvirt,
                                   OpCodes.Cpobj,
                                   OpCodes.Ldobj,
                                   OpCodes.Ldstr,
                                   OpCodes.Newobj,
                                   OpCodes.Castclass,
                                   OpCodes.Isinst,
                                   OpCodes.Conv_R_Un,
                                   OpCodes.Unbox,
                                   OpCodes.Throw,
                                   OpCodes.Ldfld,
                                   OpCodes.Ldflda,
                                   OpCodes.Stfld,
                                   OpCodes.Ldsfld,
                                   OpCodes.Ldsflda,
                                   OpCodes.Stsfld,
                                   OpCodes.Stobj,
                                   OpCodes.Conv_Ovf_I1_Un,
                                   OpCodes.Conv_Ovf_I2_Un,
                                   OpCodes.Conv_Ovf_I4_Un,
                                   OpCodes.Conv_Ovf_I8_Un,
                                   OpCodes.Conv_Ovf_U1_Un,
                                   OpCodes.Conv_Ovf_U2_Un,
                                   OpCodes.Conv_Ovf_U4_Un,
                                   OpCodes.Conv_Ovf_U8_Un,
                                   OpCodes.Conv_Ovf_I_Un,
                                   OpCodes.Conv_Ovf_U_Un,
                                   OpCodes.Box,
                                   OpCodes.Newarr,
                                   OpCodes.Ldlen,
                                   OpCodes.Ldelema,
                                   OpCodes.Ldelem_I1,
                                   OpCodes.Ldelem_U1,
                                   OpCodes.Ldelem_I2,
                                   OpCodes.Ldelem_U2,
                                   OpCodes.Ldelem_I4,
                                   OpCodes.Ldelem_U4,
                                   OpCodes.Ldelem_I8,
                                   OpCodes.Ldelem_I,
                                   OpCodes.Ldelem_R4,
                                   OpCodes.Ldelem_R8,
                                   OpCodes.Ldelem_Ref,
                                   OpCodes.Stelem_I,
                                   OpCodes.Stelem_I1,
                                   OpCodes.Stelem_I2,
                                   OpCodes.Stelem_I4,
                                   OpCodes.Stelem_I8,
                                   OpCodes.Stelem_R4,
                                   OpCodes.Stelem_R8,
                                   OpCodes.Stelem_Ref,
                                   OpCodes.Ldelem,
                                   OpCodes.Stelem,
                                   OpCodes.Unbox_Any,
                                   OpCodes.Conv_Ovf_I1,
                                   OpCodes.Conv_Ovf_U1,
                                   OpCodes.Conv_Ovf_I2,
                                   OpCodes.Conv_Ovf_U2,
                                   OpCodes.Conv_Ovf_I4,
                                   OpCodes.Conv_Ovf_U4,
                                   OpCodes.Conv_Ovf_I8,
                                   OpCodes.Conv_Ovf_U8,
                                   OpCodes.Refanyval,
                                   OpCodes.Ckfinite,
                                   OpCodes.Mkrefany,
                                   OpCodes.Ldtoken,
                                   OpCodes.Conv_U2,
                                   OpCodes.Conv_U1,
                                   OpCodes.Conv_I,
                                   OpCodes.Conv_Ovf_I,
                                   OpCodes.Conv_Ovf_U,
                                   OpCodes.Add_Ovf,
                                   OpCodes.Add_Ovf_Un,
                                   OpCodes.Mul_Ovf,
                                   OpCodes.Mul_Ovf_Un,
                                   OpCodes.Sub_Ovf,
                                   OpCodes.Sub_Ovf_Un,
                                   OpCodes.Endfinally,
                                   OpCodes.Leave,
                                   OpCodes.Leave_S,
                                   OpCodes.Stind_I,
                                   OpCodes.Conv_U,
                                   OpCodes.Prefix7,
                                   OpCodes.Prefix6,
                                   OpCodes.Prefix5,
                                   OpCodes.Prefix4,
                                   OpCodes.Prefix3,
                                   OpCodes.Prefix2,
                                   OpCodes.Prefix1,
                                   OpCodes.Prefixref
                               };
            OpCode[] opCodesFE = {
                                     OpCodes.Arglist,
                                     OpCodes.Ceq,
                                     OpCodes.Cgt,
                                     OpCodes.Cgt_Un,
                                     OpCodes.Clt,
                                     OpCodes.Clt_Un,
                                     OpCodes.Ldftn,
                                     OpCodes.Ldvirtftn,
                                     OpCodes.Ldarg,
                                     OpCodes.Ldarga,
                                     OpCodes.Starg,
                                     OpCodes.Ldloc,
                                     OpCodes.Ldloca,
                                     OpCodes.Stloc,
                                     OpCodes.Localloc,
                                     OpCodes.Endfilter,
                                     OpCodes.Unaligned,
                                     OpCodes.Volatile,
                                     OpCodes.Tailcall,
                                     OpCodes.Initobj,
                                     OpCodes.Constrained,
                                     OpCodes.Cpblk,
                                     OpCodes.Initblk,
                                     OpCodes.Rethrow,
                                     OpCodes.Sizeof,
                                     OpCodes.Refanytype,
                                     OpCodes.Readonly
                                 };
            foreach (OpCode op in opCodes)
            {
                opcodes[op.Name.ToLower()] = op;
            }
            foreach (OpCode op in opCodesFE)
            {
                opcodes[op.Name.ToLower()] = op;
            }
            ehOpcodes[".try"] = IlOpcode.TRY;
            ehOpcodes[".endtry"] = IlOpcode.ENDTRY;
            ehOpcodes[".catch"] = IlOpcode.CATCH;
            ehOpcodes[".endcatch"] = IlOpcode.ENDCATCH;
            ehOpcodes[".filter"] = IlOpcode.FILTER;
            ehOpcodes[".endfilter"] = IlOpcode.ENDFILTER;
            ehOpcodes[".fault"] = IlOpcode.FAULT;
            ehOpcodes[".endfault"] = IlOpcode.ENDFAULT;
            ehOpcodes[".finally"] = IlOpcode.FINALLY;
            ehOpcodes[".endfinally"] = IlOpcode.ENDFINALLY;
        }
        public static OpCode Get(string s)
        {
            if (opcodes.ContainsKey(s))
                return opcodes[s];
            return OpCodes.Prefixref;
        }
        public static IlOpcode GetEH(string s)
        {
            if(ehOpcodes.ContainsKey(s))
                return ehOpcodes[s];
            return IlOpcode.Prefixref;
        }
        
        private static Dictionary<string,OpCode> opcodes=new Dictionary<string, OpCode>();
        private static Dictionary<string, IlOpcode> ehOpcodes = new Dictionary<string, IlOpcode>();
    }
    public enum IlOpcode : ushort
    {
        Nop = 0x0000,
        Break = 0x0001,
        Ldarg_0 = 0x0002,
        Ldarg_1 = 0x0003,
        Ldarg_2 = 0x0004,
        Ldarg_3 = 0x0005,
        Ldloc_0 = 0x0006,
        Ldloc_1 = 0x0007,
        Ldloc_2 = 0x0008,
        Ldloc_3 = 0x0009,
        Stloc_0 = 0x000A,
        Stloc_1 = 0x000B,
        Stloc_2 = 0x000C,
        Stloc_3 = 0x000D,
        Ldarg_S = 0x000E,
        Ldarga_S = 0x000F,
        Starg_S = 0x0010,
        Ldloc_S = 0x0011,
        Ldloca_S = 0x0012,
        Stloc_S = 0x0013,
        Ldnull = 0x0014,
        Ldc_I4_M1 = 0x0015,
        Ldc_I4_0 = 0x0016,
        Ldc_I4_1 = 0x0017,
        Ldc_I4_2 = 0x0018,
        Ldc_I4_3 = 0x0019,
        Ldc_I4_4 = 0x001A,
        Ldc_I4_5 = 0x001B,
        Ldc_I4_6 = 0x001C,
        Ldc_I4_7 = 0x001D,
        Ldc_I4_8 = 0x001E,
        Ldc_I4_S = 0x001F,
        Ldc_I4 = 0x0020,
        Ldc_I8 = 0x0021,
        Ldc_R4 = 0x0022,
        Ldc_R8 = 0x0023,
        Dup = 0x0025,
        Pop = 0x0026,
        Jmp = 0x0027,
        Call = 0x0028,
        Calli = 0x0029,
        Ret = 0x002A,
        Br_S = 0x002B,
        Brfalse_S = 0x002C,
        Brtrue_S = 0x002D,
        Beq_S = 0x002E,
        Bge_S = 0x002F,
        Bgt_S = 0x0030,
        Ble_S = 0x0031,
        Blt_S = 0x0032,
        Bne_Un_S = 0x0033,
        Bge_Un_S = 0x0034,
        Bgt_Un_S = 0x0035,
        Ble_Un_S = 0x0036,
        Blt_Un_S = 0x0037,
        Br = 0x0038,
        Brfalse = 0x0039,
        Brtrue = 0x003A,
        Beq = 0x003B,
        Bge = 0x003C,
        Bgt = 0x003D,
        Ble = 0x003E,
        Blt = 0x003F,
        Bne_Un = 0x0040,
        Bge_Un = 0x0041,
        Bgt_Un = 0x0042,
        Ble_Un = 0x0043,
        Blt_Un = 0x0044,
        Switch = 0x0045,
        Ldind_I1 = 0x0046,
        Ldind_U1 = 0x0047,
        Ldind_I2 = 0x0048,
        Ldind_U2 = 0x0049,
        Ldind_I4 = 0x004A,
        Ldind_U4 = 0x004B,
        Ldind_I8 = 0x004C,
        Ldind_I = 0x004D,
        Ldind_R4 = 0x004E,
        Ldind_R8 = 0x004F,
        Ldind_Ref = 0x0050,
        Stind_Ref = 0x0051,
        Stind_I1 = 0x0052,
        Stind_I2 = 0x0053,
        Stind_I4 = 0x0054,
        Stind_I8 = 0x0055,
        Stind_R4 = 0x0056,
        Stind_R8 = 0x0057,
        Add = 0x0058,
        Sub = 0x0059,
        Mul = 0x005A,
        Div = 0x005B,
        Div_Un = 0x005C,
        Rem = 0x005D,
        Rem_Un = 0x005E,
        And = 0x005F,
        Or = 0x0060,
        Xor = 0x0061,
        Shl = 0x0062,
        Shr = 0x0063,
        Shr_Un = 0x0064,
        Neg = 0x0065,
        Not = 0x0066,
        Conv_I1 = 0x0067,
        Conv_I2 = 0x0068,
        Conv_I4 = 0x0069,
        Conv_I8 = 0x006A,
        Conv_R4 = 0x006B,
        Conv_R8 = 0x006C,
        Conv_U4 = 0x006D,
        Conv_U8 = 0x006E,
        Callvirt = 0x006F,
        Cpobj = 0x0070,
        Ldobj = 0x0071,
        Ldstr = 0x0072,
        Newobj = 0x0073,
        Castclass = 0x0074,
        Isinst = 0x0075,
        Conv_R_Un = 0x0076,
        Unbox = 0x0079,
        Throw = 0x007A,
        Ldfld = 0x007B,
        Ldflda = 0x007C,
        Stfld = 0x007D,
        Ldsfld = 0x007E,
        Ldsflda = 0x007F,
        Stsfld = 0x0080,
        Stobj = 0x0081,
        Conv_Ovf_I1_Un = 0x0082,
        Conv_Ovf_I2_Un = 0x0083,
        Conv_Ovf_I4_Un = 0x0084,
        Conv_Ovf_I8_Un = 0x0085,
        Conv_Ovf_U1_Un = 0x0086,
        Conv_Ovf_U2_Un = 0x0087,
        Conv_Ovf_U4_Un = 0x0088,
        Conv_Ovf_U8_Un = 0x0089,
        Conv_Ovf_I_Un = 0x008A,
        Conv_Ovf_U_Un = 0x008B,
        Box = 0x008C,
        Newarr = 0x008D,
        Ldlen = 0x008E,
        Ldelema = 0x008F,
        Ldelem_I1 = 0x0090,
        Ldelem_U1 = 0x0091,
        Ldelem_I2 = 0x0092,
        Ldelem_U2 = 0x0093,
        Ldelem_I4 = 0x0094,
        Ldelem_U4 = 0x0095,
        Ldelem_I8 = 0x0096,
        Ldelem_I = 0x0097,
        Ldelem_R4 = 0x0098,
        Ldelem_R8 = 0x0099,
        Ldelem_Ref = 0x009A,
        Stelem_I = 0x009B,
        Stelem_I1 = 0x009C,
        Stelem_I2 = 0x009D,
        Stelem_I4 = 0x009E,
        Stelem_I8 = 0x009F,
        Stelem_R4 = 0x00A0,
        Stelem_R8 = 0x00A1,
        Stelem_Ref = 0x00A2,
        Ldelem = 0x00A3,
        Stelem = 0x00A4,
        Unbox_Any = 0x00A5,
        Conv_Ovf_I1 = 0x00B3,
        Conv_Ovf_U1 = 0x00B4,
        Conv_Ovf_I2 = 0x00B5,
        Conv_Ovf_U2 = 0x00B6,
        Conv_Ovf_I4 = 0x00B7,
        Conv_Ovf_U4 = 0x00B8,
        Conv_Ovf_I8 = 0x00B9,
        Conv_Ovf_U8 = 0x00BA,
        Refanyval = 0x00C2,
        Ckfinite = 0x00C3,
        Mkrefany = 0x00C6,
        Ldtoken = 0x00D0,
        Conv_U2 = 0x00D1,
        Conv_U1 = 0x00D2,
        Conv_I = 0x00D3,
        Conv_Ovf_I = 0x00D4,
        Conv_Ovf_U = 0x00D5,
        Add_Ovf = 0x00D6,
        Add_Ovf_Un = 0x00D7,
        Mul_Ovf = 0x00D8,
        Mul_Ovf_Un = 0x00D9,
        Sub_Ovf = 0x00DA,
        Sub_Ovf_Un = 0x00DB,
        Endfinally = 0x00DC,
        Leave = 0x00DD,
        Leave_S = 0x00DE,
        Stind_I = 0x00DF,
        Conv_U = 0x00E0,
        Prefix7 = 0x00F8,
        Prefix6 = 0x00F9,
        Prefix5 = 0x00FA,
        Prefix4 = 0x00FB,
        Prefix3 = 0x00FC,
        Prefix2 = 0x00FD,
        Prefix1 = 0x00FE,
        Prefixref = 0x00FF,
        Arglist = 0x0FE00,
        Ceq = 0x0FE01,
        Cgt = 0x0FE02,
        Cgt_Un = 0x0FE03,
        Clt = 0x0FE04,
        Clt_Un = 0x0FE05,
        Ldftn = 0x0FE06,
        Ldvirtftn = 0x0FE07,
        Ldarg = 0x0FE09,
        Ldarga = 0x0FE0A,
        Starg = 0x0FE0B,
        Ldloc = 0x0FE0C,
        Ldloca = 0x0FE0D,
        Stloc = 0x0FE0E,
        Localloc = 0x0FE0F,
        Endfilter = 0x0FE11,
        Unaligned = 0x0FE12,
        Volatile = 0x0FE13,
        Tailcall = 0x0FE14,
        Initobj = 0x0FE15,
        Constrained = 0x0FE16,
        Cpblk = 0x0FE17,
        Initblk = 0x0FE18,
        Rethrow = 0x0FE1A,
        Sizeof = 0x0FE1C,
        Refanytype = 0x0FE1D,
        Readonly = 0x0FE1E,
        TRY = 0x0FFFF,
        ENDTRY = 0x0FFFE,
        CATCH = 0x0FFFD,
        ENDCATCH = 0x0FFFC,
        FINALLY = 0x0FFFB,
        ENDFINALLY = 0x0FFFA,
        FILTER = 0x0FFF9,
        ENDFILTER = 0x0FFF8,
        FAULT = 0x0FFF7,
        ENDFAULT = 0x0FFF6
    }
}