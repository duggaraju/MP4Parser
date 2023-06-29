﻿using System;

namespace Media.ISO
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class BoxTypeAttribute : Attribute
    {
        public BoxType Type { get; set; }

        public Guid? ExtendedType { get; set; }

        public BoxTypeAttribute(string boxType)
        {
            if (Guid.TryParse(boxType, out var guid))
            {
                Type = BoxType.UuidBox;
                ExtendedType = guid;
            }
            else
            {
                var value = boxType.GetBoxType();
                if (!Enum.IsDefined(typeof(BoxType), value))
                    throw new ArgumentException($"Undefined box {value}", nameof(boxType));
                Type = (BoxType) value;
            }
        }

        public BoxTypeAttribute(BoxType boxType)
        {
            Type = boxType;
        }
    }
}
