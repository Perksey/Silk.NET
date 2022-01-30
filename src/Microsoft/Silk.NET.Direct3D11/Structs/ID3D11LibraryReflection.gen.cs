// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Guid("54384f1b-5b3e-4bb7-ae01-60ba3097cbb6")]
    [NativeName("Name", "ID3D11LibraryReflection")]
    public unsafe partial struct ID3D11LibraryReflection
    {
        public static readonly Guid Guid = new("54384f1b-5b3e-4bb7-ae01-60ba3097cbb6");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11LibraryReflection val)
            => Unsafe.As<ID3D11LibraryReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11LibraryReflection
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11LibraryReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(LibraryDesc* pDesc)
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref LibraryDesc pDesc)
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LibraryDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11LibraryReflection*, LibraryDesc*, int>)LpVtbl[3])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex)
        {
            var @this = (ID3D11LibraryReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11FunctionReflection* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)LpVtbl[4])(@this, FunctionIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)LpVtbl[4])(@this, FunctionIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)LpVtbl[4])(@this, FunctionIndex);
            }
            #endif
            return ret;
        }

    }
}
