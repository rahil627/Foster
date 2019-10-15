﻿namespace Foster.Framework
{
    public enum UniformType
    {
        Unknown = 0,

        Int = 0x100,
        Int2,
        Int3,
        Int4,

        Float = 0x200,
        Float2,
        Float3,
        Float4,

        Matrix3x2 = 0x300,
        Matrix4x4,

        Texture2D = 0x400
    }
}