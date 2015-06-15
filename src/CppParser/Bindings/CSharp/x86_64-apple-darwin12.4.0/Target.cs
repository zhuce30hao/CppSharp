//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace Parser
    {
        public enum ParserIntType
        {
            NoInt = 0,
            SignedChar = 1,
            UnsignedChar = 2,
            SignedShort = 3,
            UnsignedShort = 4,
            SignedInt = 5,
            UnsignedInt = 6,
            SignedLong = 7,
            UnsignedLong = 8,
            SignedLongLong = 9,
            UnsignedLongLong = 10
        }

        public unsafe partial class ParserTargetInfo : IDisposable
        {
            [StructLayout(LayoutKind.Explicit, Size = 176)]
            public partial struct Internal
            {
                [FieldOffset(24)]
                public CppSharp.Parser.ParserIntType Char16Type;

                [FieldOffset(28)]
                public CppSharp.Parser.ParserIntType Char32Type;

                [FieldOffset(32)]
                public CppSharp.Parser.ParserIntType Int64Type;

                [FieldOffset(36)]
                public CppSharp.Parser.ParserIntType IntMaxType;

                [FieldOffset(40)]
                public CppSharp.Parser.ParserIntType IntPtrType;

                [FieldOffset(44)]
                public CppSharp.Parser.ParserIntType SizeType;

                [FieldOffset(48)]
                public CppSharp.Parser.ParserIntType UIntMaxType;

                [FieldOffset(52)]
                public CppSharp.Parser.ParserIntType WCharType;

                [FieldOffset(56)]
                public CppSharp.Parser.ParserIntType WIntType;

                [FieldOffset(60)]
                public uint BoolAlign;

                [FieldOffset(64)]
                public uint BoolWidth;

                [FieldOffset(68)]
                public uint CharAlign;

                [FieldOffset(72)]
                public uint CharWidth;

                [FieldOffset(76)]
                public uint Char16Align;

                [FieldOffset(80)]
                public uint Char16Width;

                [FieldOffset(84)]
                public uint Char32Align;

                [FieldOffset(88)]
                public uint Char32Width;

                [FieldOffset(92)]
                public uint HalfAlign;

                [FieldOffset(96)]
                public uint HalfWidth;

                [FieldOffset(100)]
                public uint FloatAlign;

                [FieldOffset(104)]
                public uint FloatWidth;

                [FieldOffset(108)]
                public uint DoubleAlign;

                [FieldOffset(112)]
                public uint DoubleWidth;

                [FieldOffset(116)]
                public uint ShortAlign;

                [FieldOffset(120)]
                public uint ShortWidth;

                [FieldOffset(124)]
                public uint IntAlign;

                [FieldOffset(128)]
                public uint IntWidth;

                [FieldOffset(132)]
                public uint IntMaxTWidth;

                [FieldOffset(136)]
                public uint LongAlign;

                [FieldOffset(140)]
                public uint LongWidth;

                [FieldOffset(144)]
                public uint LongDoubleAlign;

                [FieldOffset(148)]
                public uint LongDoubleWidth;

                [FieldOffset(152)]
                public uint LongLongAlign;

                [FieldOffset(156)]
                public uint LongLongWidth;

                [FieldOffset(160)]
                public uint PointerAlign;

                [FieldOffset(164)]
                public uint PointerWidth;

                [FieldOffset(168)]
                public uint WCharAlign;

                [FieldOffset(172)]
                public uint WCharWidth;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfoC2Ev")]
                internal static extern void ctor_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfoC2ERKS1_")]
                internal static extern void cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfoD2Ev")]
                internal static extern void dtor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfo6getABIEv")]
                internal static extern global::System.IntPtr getABI_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="_ZN8CppSharp9CppParser16ParserTargetInfo6setABIEPKc")]
                internal static extern void setABI_0(global::System.IntPtr instance, global::System.IntPtr s);
            }

            public global::System.IntPtr __Instance { get; protected set; }
            public static readonly System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ParserTargetInfo> NativeToManagedMap = new System.Collections.Concurrent.ConcurrentDictionary<IntPtr, ParserTargetInfo>();

            private readonly bool __ownsNativeInstance;

            public static ParserTargetInfo __CreateInstance(global::System.IntPtr native)
            {
                return new ParserTargetInfo((ParserTargetInfo.Internal*) native);
            }

            public static ParserTargetInfo __CreateInstance(ParserTargetInfo.Internal native)
            {
                return new ParserTargetInfo(native);
            }

            private static ParserTargetInfo.Internal* __CopyValue(ParserTargetInfo.Internal native)
            {
                var ret = Marshal.AllocHGlobal(176);
                CppSharp.Parser.ParserTargetInfo.Internal.cctor_2(ret, new global::System.IntPtr(&native));
                return (ParserTargetInfo.Internal*) ret;
            }

            private ParserTargetInfo(ParserTargetInfo.Internal native)
                : this(__CopyValue(native))
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected ParserTargetInfo(ParserTargetInfo.Internal* native, bool isInternalImpl = false)
            {
                __Instance = new global::System.IntPtr(native);
            }

            public ParserTargetInfo()
            {
                __Instance = Marshal.AllocHGlobal(176);
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                Internal.ctor_1(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
            }

            protected virtual void Dispose(bool disposing)
            {
                DestroyNativeInstance(false);
            }

            public virtual void DestroyNativeInstance()
            {
                DestroyNativeInstance(true);
            }

            private void DestroyNativeInstance(bool force)
            {
                CppSharp.Parser.ParserTargetInfo __dummy;
                NativeToManagedMap.TryRemove(__Instance, out __dummy);
                if (__ownsNativeInstance || force)
                    Internal.dtor_0(__Instance);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
            }

            public string ABI
            {
                get
                {
                    var __ret = Internal.getABI_0(__Instance);
                    return Marshal.PtrToStringAnsi(__ret);
                }

                set
                {
                    var arg0 = Marshal.StringToHGlobalAnsi(value);
                    Internal.setABI_0(__Instance, arg0);
                    Marshal.FreeHGlobal(arg0);
                }
            }

            public CppSharp.Parser.ParserIntType Char16Type
            {
                get
                {
                    return ((Internal*) __Instance)->Char16Type;
                }

                set
                {
                    ((Internal*) __Instance)->Char16Type = value;
                }
            }

            public CppSharp.Parser.ParserIntType Char32Type
            {
                get
                {
                    return ((Internal*) __Instance)->Char32Type;
                }

                set
                {
                    ((Internal*) __Instance)->Char32Type = value;
                }
            }

            public CppSharp.Parser.ParserIntType Int64Type
            {
                get
                {
                    return ((Internal*) __Instance)->Int64Type;
                }

                set
                {
                    ((Internal*) __Instance)->Int64Type = value;
                }
            }

            public CppSharp.Parser.ParserIntType IntMaxType
            {
                get
                {
                    return ((Internal*) __Instance)->IntMaxType;
                }

                set
                {
                    ((Internal*) __Instance)->IntMaxType = value;
                }
            }

            public CppSharp.Parser.ParserIntType IntPtrType
            {
                get
                {
                    return ((Internal*) __Instance)->IntPtrType;
                }

                set
                {
                    ((Internal*) __Instance)->IntPtrType = value;
                }
            }

            public CppSharp.Parser.ParserIntType SizeType
            {
                get
                {
                    return ((Internal*) __Instance)->SizeType;
                }

                set
                {
                    ((Internal*) __Instance)->SizeType = value;
                }
            }

            public CppSharp.Parser.ParserIntType UIntMaxType
            {
                get
                {
                    return ((Internal*) __Instance)->UIntMaxType;
                }

                set
                {
                    ((Internal*) __Instance)->UIntMaxType = value;
                }
            }

            public CppSharp.Parser.ParserIntType WCharType
            {
                get
                {
                    return ((Internal*) __Instance)->WCharType;
                }

                set
                {
                    ((Internal*) __Instance)->WCharType = value;
                }
            }

            public CppSharp.Parser.ParserIntType WIntType
            {
                get
                {
                    return ((Internal*) __Instance)->WIntType;
                }

                set
                {
                    ((Internal*) __Instance)->WIntType = value;
                }
            }

            public uint BoolAlign
            {
                get
                {
                    return ((Internal*) __Instance)->BoolAlign;
                }

                set
                {
                    ((Internal*) __Instance)->BoolAlign = value;
                }
            }

            public uint BoolWidth
            {
                get
                {
                    return ((Internal*) __Instance)->BoolWidth;
                }

                set
                {
                    ((Internal*) __Instance)->BoolWidth = value;
                }
            }

            public uint CharAlign
            {
                get
                {
                    return ((Internal*) __Instance)->CharAlign;
                }

                set
                {
                    ((Internal*) __Instance)->CharAlign = value;
                }
            }

            public uint CharWidth
            {
                get
                {
                    return ((Internal*) __Instance)->CharWidth;
                }

                set
                {
                    ((Internal*) __Instance)->CharWidth = value;
                }
            }

            public uint Char16Align
            {
                get
                {
                    return ((Internal*) __Instance)->Char16Align;
                }

                set
                {
                    ((Internal*) __Instance)->Char16Align = value;
                }
            }

            public uint Char16Width
            {
                get
                {
                    return ((Internal*) __Instance)->Char16Width;
                }

                set
                {
                    ((Internal*) __Instance)->Char16Width = value;
                }
            }

            public uint Char32Align
            {
                get
                {
                    return ((Internal*) __Instance)->Char32Align;
                }

                set
                {
                    ((Internal*) __Instance)->Char32Align = value;
                }
            }

            public uint Char32Width
            {
                get
                {
                    return ((Internal*) __Instance)->Char32Width;
                }

                set
                {
                    ((Internal*) __Instance)->Char32Width = value;
                }
            }

            public uint HalfAlign
            {
                get
                {
                    return ((Internal*) __Instance)->HalfAlign;
                }

                set
                {
                    ((Internal*) __Instance)->HalfAlign = value;
                }
            }

            public uint HalfWidth
            {
                get
                {
                    return ((Internal*) __Instance)->HalfWidth;
                }

                set
                {
                    ((Internal*) __Instance)->HalfWidth = value;
                }
            }

            public uint FloatAlign
            {
                get
                {
                    return ((Internal*) __Instance)->FloatAlign;
                }

                set
                {
                    ((Internal*) __Instance)->FloatAlign = value;
                }
            }

            public uint FloatWidth
            {
                get
                {
                    return ((Internal*) __Instance)->FloatWidth;
                }

                set
                {
                    ((Internal*) __Instance)->FloatWidth = value;
                }
            }

            public uint DoubleAlign
            {
                get
                {
                    return ((Internal*) __Instance)->DoubleAlign;
                }

                set
                {
                    ((Internal*) __Instance)->DoubleAlign = value;
                }
            }

            public uint DoubleWidth
            {
                get
                {
                    return ((Internal*) __Instance)->DoubleWidth;
                }

                set
                {
                    ((Internal*) __Instance)->DoubleWidth = value;
                }
            }

            public uint ShortAlign
            {
                get
                {
                    return ((Internal*) __Instance)->ShortAlign;
                }

                set
                {
                    ((Internal*) __Instance)->ShortAlign = value;
                }
            }

            public uint ShortWidth
            {
                get
                {
                    return ((Internal*) __Instance)->ShortWidth;
                }

                set
                {
                    ((Internal*) __Instance)->ShortWidth = value;
                }
            }

            public uint IntAlign
            {
                get
                {
                    return ((Internal*) __Instance)->IntAlign;
                }

                set
                {
                    ((Internal*) __Instance)->IntAlign = value;
                }
            }

            public uint IntWidth
            {
                get
                {
                    return ((Internal*) __Instance)->IntWidth;
                }

                set
                {
                    ((Internal*) __Instance)->IntWidth = value;
                }
            }

            public uint IntMaxTWidth
            {
                get
                {
                    return ((Internal*) __Instance)->IntMaxTWidth;
                }

                set
                {
                    ((Internal*) __Instance)->IntMaxTWidth = value;
                }
            }

            public uint LongAlign
            {
                get
                {
                    return ((Internal*) __Instance)->LongAlign;
                }

                set
                {
                    ((Internal*) __Instance)->LongAlign = value;
                }
            }

            public uint LongWidth
            {
                get
                {
                    return ((Internal*) __Instance)->LongWidth;
                }

                set
                {
                    ((Internal*) __Instance)->LongWidth = value;
                }
            }

            public uint LongDoubleAlign
            {
                get
                {
                    return ((Internal*) __Instance)->LongDoubleAlign;
                }

                set
                {
                    ((Internal*) __Instance)->LongDoubleAlign = value;
                }
            }

            public uint LongDoubleWidth
            {
                get
                {
                    return ((Internal*) __Instance)->LongDoubleWidth;
                }

                set
                {
                    ((Internal*) __Instance)->LongDoubleWidth = value;
                }
            }

            public uint LongLongAlign
            {
                get
                {
                    return ((Internal*) __Instance)->LongLongAlign;
                }

                set
                {
                    ((Internal*) __Instance)->LongLongAlign = value;
                }
            }

            public uint LongLongWidth
            {
                get
                {
                    return ((Internal*) __Instance)->LongLongWidth;
                }

                set
                {
                    ((Internal*) __Instance)->LongLongWidth = value;
                }
            }

            public uint PointerAlign
            {
                get
                {
                    return ((Internal*) __Instance)->PointerAlign;
                }

                set
                {
                    ((Internal*) __Instance)->PointerAlign = value;
                }
            }

            public uint PointerWidth
            {
                get
                {
                    return ((Internal*) __Instance)->PointerWidth;
                }

                set
                {
                    ((Internal*) __Instance)->PointerWidth = value;
                }
            }

            public uint WCharAlign
            {
                get
                {
                    return ((Internal*) __Instance)->WCharAlign;
                }

                set
                {
                    ((Internal*) __Instance)->WCharAlign = value;
                }
            }

            public uint WCharWidth
            {
                get
                {
                    return ((Internal*) __Instance)->WCharWidth;
                }

                set
                {
                    ((Internal*) __Instance)->WCharWidth = value;
                }
            }
        }
    }
}