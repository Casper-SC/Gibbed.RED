﻿/* Copyright (c) 2011 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System;
using System.Collections.Generic;

namespace Gibbed.RED.FileFormats.Save
{
    public interface ISaveStream
    {
        SerializeMode Mode { get; }
        void SerializeValue(string name, ref bool value);
        void SerializeValue(string name, ref sbyte value);
        void SerializeValue(string name, ref byte value);
        void SerializeValue(string name, ref short value);
        void SerializeValue(string name, ref ushort value);
        void SerializeValue(string name, ref int value);
        void SerializeValue(string name, ref uint value);
        void SerializeValue(string name, ref long value);
        void SerializeValue(string name, ref ulong value);
        void SerializeValue(string name, ref float value);
        void SerializeValue(string name, ref string value);
        void SerializeValue(string name, ref Guid value);
        void SerializeValue(string name, ref byte[] value);
        void SerializeBlock<TType>(string name, ref TType value)
            where TType : ISaveBlock, new();
        void SerializeBlocks<TType>(string name, string type, ref List<TType> value)
            where TType : ISaveBlock, new();
        void SerializeObject<TType>(string name, string type, ref TType value)
            where TType : IFileObject, new();
    }
}
