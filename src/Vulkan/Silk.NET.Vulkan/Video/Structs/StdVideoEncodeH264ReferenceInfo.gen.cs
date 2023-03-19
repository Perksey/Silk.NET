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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoEncodeH264ReferenceInfo")]
    public unsafe partial struct StdVideoEncodeH264ReferenceInfo
    {
        public StdVideoEncodeH264ReferenceInfo
        (
            StdVideoEncodeH264ReferenceInfoFlags? flags = null,
            uint? frameNum = null,
            int? picOrderCnt = null,
            ushort? longTermPicNum = null,
            ushort? longTermFrameIdx = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (frameNum is not null)
            {
                FrameNum = frameNum.Value;
            }

            if (picOrderCnt is not null)
            {
                PicOrderCnt = picOrderCnt.Value;
            }

            if (longTermPicNum is not null)
            {
                LongTermPicNum = longTermPicNum.Value;
            }

            if (longTermFrameIdx is not null)
            {
                LongTermFrameIdx = longTermFrameIdx.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeH264ReferenceInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH264ReferenceInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH264ReferenceInfoFlags Flags;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "FrameNum")]
        public uint FrameNum;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCnt")]
        public int PicOrderCnt;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "long_term_pic_num")]
        public ushort LongTermPicNum;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "long_term_frame_idx")]
        public ushort LongTermFrameIdx;
    }
}
