﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotnesktRemastered
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe struct MW6GfxSurface
    {
        [FieldOffset(0)]
        public uint posOffset;
        [FieldOffset(4)]
        public uint baseIndex;
        [FieldOffset(8)]
        public uint unkOffset1; //points to unk2Ptr
        [FieldOffset(12)]
        public uint ugbSurfDataIndex;
        [FieldOffset(16)]
        public uint materialIndex;
        [FieldOffset(20)]
        public ushort vertexCount;
        [FieldOffset(22)]
        public ushort indexCount;
        [FieldOffset(24)]
        public uint unk6;
        [FieldOffset(28)]
        public uint unk7;
        [FieldOffset(32)]
        public uint unk8;
        [FieldOffset(36)]
        public uint unkOffset2; //points to unk3Ptr
    }

    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public unsafe struct MW6GfxUgbSurfData
    {
        [FieldOffset(0)]
        public MW6GfxWorldDrawOffset worldDrawOffset;
        [FieldOffset(16)]
        public uint transientZoneIndex;
        [FieldOffset(20)]
        public uint unk0;
        [FieldOffset(24)]
        public uint unk1;
        [FieldOffset(28)]
        public uint layerCount;
        [FieldOffset(32)]
        public uint offsetUnk0;
        [FieldOffset(36)]
        public uint xyzOffset;
        [FieldOffset(40)]
        public uint tangentFrameOffset;
        [FieldOffset(44)]
        public uint lmapOffset;
        [FieldOffset(48)]
        public uint colorOffset;
        [FieldOffset(52)]
        public uint texCoordOffset;
        [FieldOffset(56)]
        public uint offsetUnk1;
        [FieldOffset(60)]
        public uint offsetUnk2;
        [FieldOffset(64)]
        public uint offsetUnk3;
        [FieldOffset(68)]
        public fixed uint normalTransformOffset[7];
        [FieldOffset(96)]
        public fixed uint displacementOffset[8];
    }
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct MW6GfxWorldDrawOffset
    {
        [FieldOffset(0)]
        public float x;
        [FieldOffset(4)]
        public float y;
        [FieldOffset(8)]
        public float z;
        [FieldOffset(12)]
        public float scale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 392)]
    public unsafe struct MW6GfxWorldSurfaces
    {
        [FieldOffset(0)]
        public uint count;
        [FieldOffset(8)]
        public uint ugbSurfDataCount;
        [FieldOffset(12)]
        public uint materialCount;
        [FieldOffset(112)]
        public nint surfaces;
        [FieldOffset(168)]
        public nint ugbSurfData;
        [FieldOffset(176)]
        public nint worldDrawOffsets;
        [FieldOffset(296)]
        public uint btndSurfacesCount;
        [FieldOffset(304)]
        public nint btndSurfaces;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe struct MW6GfxWorldDrawVerts
    {
        [FieldOffset(3)]
        public uint posSize;
        [FieldOffset(4)]
        public uint indexCount;
        [FieldOffset(8)]
        public uint unk2Size;
        [FieldOffset(12)]
        public uint unk3Size;
        [FieldOffset(16)]
        public nint posData;
        [FieldOffset(24)]
        public nint indices;
        [FieldOffset(32)]
        public nint unk2Ptr;
        [FieldOffset(40)]
        public nint unk3Ptr;
    }

    [StructLayout(LayoutKind.Explicit, Size = 376)]
    public unsafe struct MW6GfxWorldTransientZone
    {
        [FieldOffset(0)]
        public ulong Hash;
        [FieldOffset(8)]
        public nint unkPtr0; // 16 bytes of yap
        [FieldOffset(16)]
        public ulong transientZoneIndex;
        [FieldOffset(24)]
        public MW6GfxWorldDrawVerts drawVerts;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct MW6GfxWorld
    {
        [FieldOffset(0)]
        public ulong Hash;
        [FieldOffset(8)]
        public nint baseName;
        [FieldOffset(192)]
        public MW6GfxWorldSurfaces surfaces;
        [FieldOffset(5660)]
        public uint transientZoneCount;
        [FieldOffset(5664)]
        public nint transientZones;
    }
}
