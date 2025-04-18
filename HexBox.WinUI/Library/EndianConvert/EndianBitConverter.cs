﻿namespace HexBox.WinUI.Library.EndianConvert
{
    using System;

    /// <summary>
    /// Converts integral values to the native endianness of this computer architecture.
    /// </summary>
    public static class EndianBitConverter
    {
        /// <summary>
        /// Gets the native endianness of this computer architecture.
        /// </summary>
        public static readonly Endianness NativeEndianness = BitConverter.IsLittleEndian ? Endianness.LittleEndian : Endianness.BigEndian;

        /// <summary>
        /// Converts a value from the specified endianness to the native endianness.
        /// </summary>
        ///
        /// <param name="value">
        /// The value to convert.
        /// </param>
        ///
        /// <param name="endianness">
        /// The endianness of <paramref name="value"/>.
        /// </param>
        ///
        /// <returns>
        /// The value converted from the specified endianness to the native endianness (<see cref="NativeEndianness"/>).
        /// </returns>
        public static ushort Convert(ushort value, Endianness endianness)
        {
            if (endianness == NativeEndianness)
            {
                return value;
            }
            else
            {
                unchecked
                {
                    return (ushort)((value & 0x00FFU) << 8 |
                                     (value & 0xFF00U) >> 8);
                }
            }
        }

        /// <summary>
        /// Converts a value from the specified endianness to the native endianness.
        /// </summary>
        ///
        /// <param name="value">
        /// The value to convert.
        /// </param>
        ///
        /// <param name="endianness">
        /// The endianness of <paramref name="value"/>.
        /// </param>
        ///
        /// <returns>
        /// The value converted from the specified endianness to the native endianness (<see cref="NativeEndianness"/>).
        /// </returns>
        public static uint Convert(uint value, Endianness endianness)
        {
            if (endianness == NativeEndianness)
            {
                return value;
            }
            else
            {
                unchecked
                {
                    return (value & 0x000000FFU) << 24 |
                           (value & 0xFF000000U) >> 24 |
                           (value & 0x0000FF00U) << 8 |
                           (value & 0x00FF0000U) >> 8;
                }
            }
        }

        /// <summary>
        /// Converts a value from the specified endianness to the native endianness.
        /// </summary>
        ///
        /// <param name="value">
        /// The value to convert.
        /// </param>
        ///
        /// <param name="endianness">
        /// The endianness of <paramref name="value"/>.
        /// </param>
        ///
        /// <returns>
        /// The value converted from the specified endianness to the native endianness (<see cref="NativeEndianness"/>).
        /// </returns>
        public static ulong Convert(ulong value, Endianness endianness)
        {
            if (endianness == NativeEndianness)
            {
                return value;
            }
            else
            {
                unchecked
                {
                    return (value & 0x00000000000000FFUL) << 56 |
                           (value & 0xFF00000000000000UL) >> 56 |
                           (value & 0x000000000000FF00UL) << 40 |
                           (value & 0x00FF000000000000UL) >> 40 |
                           (value & 0x0000000000FF0000UL) << 24 |
                           (value & 0x0000FF0000000000UL) >> 24 |
                           (value & 0x00000000FF000000UL) << 8 |
                           (value & 0x000000FF00000000UL) >> 8;
                }
            }
        }

        /// <summary>
        /// Converts a value from the specified endianness to the native endianness.
        /// </summary>
        ///
        /// <param name="value">
        /// The value to convert.
        /// </param>
        ///
        /// <param name="endianness">
        /// The endianness of <paramref name="value"/>.
        /// </param>
        ///
        /// <returns>
        /// The value converted from the specified endianness to the native endianness (<see cref="NativeEndianness"/>).
        /// </returns>
        public static short Convert(short value, Endianness endianness)
        {
            return (short)Convert((ushort)value, endianness);
        }

        /// <summary>
        /// Converts a value from the specified endianness to the native endianness.
        /// </summary>
        ///
        /// <param name="value">
        /// The value to convert.
        /// </param>
        ///
        /// <param name="endianness">
        /// The endianness of <paramref name="value"/>.
        /// </param>
        ///
        /// <returns>
        /// The value converted from the specified endianness to the native endianness (<see cref="NativeEndianness"/>).
        /// </returns>
        public static int Convert(int value, Endianness endianness)
        {
            return (int)Convert((uint)value, endianness);
        }

        /// <summary>
        /// Converts a value from the specified endianness to the native endianness.
        /// </summary>
        ///
        /// <param name="value">
        /// The value to convert.
        /// </param>
        ///
        /// <param name="endianness">
        /// The endianness of <paramref name="value"/>.
        /// </param>
        ///
        /// <returns>
        /// The value converted from the specified endianness to the native endianness (<see cref="NativeEndianness"/>).
        /// </returns>
        public static long Convert(long value, Endianness endianness)
        {
            return (long)Convert((ulong)value, endianness);
        }
    }
}
