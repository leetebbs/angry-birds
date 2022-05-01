using System;
using System.Collections.Generic;

namespace Moralis.Platform.Utilities
{
    /// <summary>
    /// A reimplementation of Xamarin's PreserveAttribute.
    /// This allows us to support AOT and linking for Xamarin platforms.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    internal class PreserveAttribute : Attribute
    {
        public bool AllMembers;
        public bool Conditional;
    }

    [AttributeUsage(AttributeTargets.All)]
    internal class LinkerSafeAttribute : Attribute
    {
        public LinkerSafeAttribute() { }
    }

    [Preserve(AllMembers = true)]
    internal class PreserveWrapperTypes
    {
        /// <summary>
        /// Exists to ensure that generic types are AOT-compiled for the conversions we support.
        /// Any new value types that we add support for will need to be registered here.
        /// The method itself is never called, but by virtue of the Preserve attribute being set
        /// on the class, these types will be AOT-compiled.
        ///
        /// This also applies to Unity.
        /// </summary>
        static List<object> AOTPreservations => new List<object>
        {
            typeof(FlexibleListWrapper<object, object>),
            typeof(FlexibleListWrapper<object, bool>),
            typeof(FlexibleListWrapper<object, byte>),
            typeof(FlexibleListWrapper<object, sbyte>),
            typeof(FlexibleListWrapper<object, short>),
            typeof(FlexibleListWrapper<object, ushort>),
            typeof(FlexibleListWrapper<object, int>),
            typeof(FlexibleListWrapper<object, uint>),
            typeof(FlexibleListWrapper<object, long>),
            typeof(FlexibleListWrapper<object, ulong>),
            typeof(FlexibleListWrapper<object, char>),
            typeof(FlexibleListWrapper<object, double>),
            typeof(FlexibleListWrapper<object, float>),

            typeof(FlexibleListWrapper<bool, object>),
            typeof(FlexibleListWrapper<bool, bool>),
            typeof(FlexibleListWrapper<bool, byte>),
            typeof(FlexibleListWrapper<bool, sbyte>),
            typeof(FlexibleListWrapper<bool, short>),
            typeof(FlexibleListWrapper<bool, ushort>),
            typeof(FlexibleListWrapper<bool, int>),
            typeof(FlexibleListWrapper<bool, uint>),
            typeof(FlexibleListWrapper<bool, long>),
            typeof(FlexibleListWrapper<bool, ulong>),
            typeof(FlexibleListWrapper<bool, char>),
            typeof(FlexibleListWrapper<bool, double>),
            typeof(FlexibleListWrapper<bool, float>),

            typeof(FlexibleListWrapper<byte, object>),
            typeof(FlexibleListWrapper<byte, bool>),
            typeof(FlexibleListWrapper<byte, byte>),
            typeof(FlexibleListWrapper<byte, sbyte>),
            typeof(FlexibleListWrapper<byte, short>),
            typeof(FlexibleListWrapper<byte, ushort>),
            typeof(FlexibleListWrapper<byte, int>),
            typeof(FlexibleListWrapper<byte, uint>),
            typeof(FlexibleListWrapper<byte, long>),
            typeof(FlexibleListWrapper<byte, ulong>),
            typeof(FlexibleListWrapper<byte, char>),
            typeof(FlexibleListWrapper<byte, double>),
            typeof(FlexibleListWrapper<byte, float>),

            typeof(FlexibleListWrapper<sbyte, object>),
            typeof(FlexibleListWrapper<sbyte, bool>),
            typeof(FlexibleListWrapper<sbyte, byte>),
            typeof(FlexibleListWrapper<sbyte, sbyte>),
            typeof(FlexibleListWrapper<sbyte, short>),
            typeof(FlexibleListWrapper<sbyte, ushort>),
            typeof(FlexibleListWrapper<sbyte, int>),
            typeof(FlexibleListWrapper<sbyte, uint>),
            typeof(FlexibleListWrapper<sbyte, long>),
            typeof(FlexibleListWrapper<sbyte, ulong>),
            typeof(FlexibleListWrapper<sbyte, char>),
            typeof(FlexibleListWrapper<sbyte, double>),
            typeof(FlexibleListWrapper<sbyte, float>),

            typeof(FlexibleListWrapper<short, object>),
            typeof(FlexibleListWrapper<short, bool>),
            typeof(FlexibleListWrapper<short, byte>),
            typeof(FlexibleListWrapper<short, sbyte>),
            typeof(FlexibleListWrapper<short, short>),
            typeof(FlexibleListWrapper<short, ushort>),
            typeof(FlexibleListWrapper<short, int>),
            typeof(FlexibleListWrapper<short, uint>),
            typeof(FlexibleListWrapper<short, long>),
            typeof(FlexibleListWrapper<short, ulong>),
            typeof(FlexibleListWrapper<short, char>),
            typeof(FlexibleListWrapper<short, double>),
            typeof(FlexibleListWrapper<short, float>),

            typeof(FlexibleListWrapper<ushort, object>),
            typeof(FlexibleListWrapper<ushort, bool>),
            typeof(FlexibleListWrapper<ushort, byte>),
            typeof(FlexibleListWrapper<ushort, sbyte>),
            typeof(FlexibleListWrapper<ushort, short>),
            typeof(FlexibleListWrapper<ushort, ushort>),
            typeof(FlexibleListWrapper<ushort, int>),
            typeof(FlexibleListWrapper<ushort, uint>),
            typeof(FlexibleListWrapper<ushort, long>),
            typeof(FlexibleListWrapper<ushort, ulong>),
            typeof(FlexibleListWrapper<ushort, char>),
            typeof(FlexibleListWrapper<ushort, double>),
            typeof(FlexibleListWrapper<ushort, float>),

            typeof(FlexibleListWrapper<int, object>),
            typeof(FlexibleListWrapper<int, bool>),
            typeof(FlexibleListWrapper<int, byte>),
            typeof(FlexibleListWrapper<int, sbyte>),
            typeof(FlexibleListWrapper<int, short>),
            typeof(FlexibleListWrapper<int, ushort>),
            typeof(FlexibleListWrapper<int, int>),
            typeof(FlexibleListWrapper<int, uint>),
            typeof(FlexibleListWrapper<int, long>),
            typeof(FlexibleListWrapper<int, ulong>),
            typeof(FlexibleListWrapper<int, char>),
            typeof(FlexibleListWrapper<int, double>),
            typeof(FlexibleListWrapper<int, float>),

            typeof(FlexibleListWrapper<uint, object>),
            typeof(FlexibleListWrapper<uint, bool>),
            typeof(FlexibleListWrapper<uint, byte>),
            typeof(FlexibleListWrapper<uint, sbyte>),
            typeof(FlexibleListWrapper<uint, short>),
            typeof(FlexibleListWrapper<uint, ushort>),
            typeof(FlexibleListWrapper<uint, int>),
            typeof(FlexibleListWrapper<uint, uint>),
            typeof(FlexibleListWrapper<uint, long>),
            typeof(FlexibleListWrapper<uint, ulong>),
            typeof(FlexibleListWrapper<uint, char>),
            typeof(FlexibleListWrapper<uint, double>),
            typeof(FlexibleListWrapper<uint, float>),

            typeof(FlexibleListWrapper<long, object>),
            typeof(FlexibleListWrapper<long, bool>),
            typeof(FlexibleListWrapper<long, byte>),
            typeof(FlexibleListWrapper<long, sbyte>),
            typeof(FlexibleListWrapper<long, short>),
            typeof(FlexibleListWrapper<long, ushort>),
            typeof(FlexibleListWrapper<long, int>),
            typeof(FlexibleListWrapper<long, uint>),
            typeof(FlexibleListWrapper<long, long>),
            typeof(FlexibleListWrapper<long, ulong>),
            typeof(FlexibleListWrapper<long, char>),
            typeof(FlexibleListWrapper<long, double>),
            typeof(FlexibleListWrapper<long, float>),

            typeof(FlexibleListWrapper<ulong, object>),
            typeof(FlexibleListWrapper<ulong, bool>),
            typeof(FlexibleListWrapper<ulong, byte>),
            typeof(FlexibleListWrapper<ulong, sbyte>),
            typeof(FlexibleListWrapper<ulong, short>),
            typeof(FlexibleListWrapper<ulong, ushort>),
            typeof(FlexibleListWrapper<ulong, int>),
            typeof(FlexibleListWrapper<ulong, uint>),
            typeof(FlexibleListWrapper<ulong, long>),
            typeof(FlexibleListWrapper<ulong, ulong>),
            typeof(FlexibleListWrapper<ulong, char>),
            typeof(FlexibleListWrapper<ulong, double>),
            typeof(FlexibleListWrapper<ulong, float>),

            typeof(FlexibleListWrapper<char, object>),
            typeof(FlexibleListWrapper<char, bool>),
            typeof(FlexibleListWrapper<char, byte>),
            typeof(FlexibleListWrapper<char, sbyte>),
            typeof(FlexibleListWrapper<char, short>),
            typeof(FlexibleListWrapper<char, ushort>),
            typeof(FlexibleListWrapper<char, int>),
            typeof(FlexibleListWrapper<char, uint>),
            typeof(FlexibleListWrapper<char, long>),
            typeof(FlexibleListWrapper<char, ulong>),
            typeof(FlexibleListWrapper<char, char>),
            typeof(FlexibleListWrapper<char, double>),
            typeof(FlexibleListWrapper<char, float>),

            typeof(FlexibleListWrapper<double, object>),
            typeof(FlexibleListWrapper<double, bool>),
            typeof(FlexibleListWrapper<double, byte>),
            typeof(FlexibleListWrapper<double, sbyte>),
            typeof(FlexibleListWrapper<double, short>),
            typeof(FlexibleListWrapper<double, ushort>),
            typeof(FlexibleListWrapper<double, int>),
            typeof(FlexibleListWrapper<double, uint>),
            typeof(FlexibleListWrapper<double, long>),
            typeof(FlexibleListWrapper<double, ulong>),
            typeof(FlexibleListWrapper<double, char>),
            typeof(FlexibleListWrapper<double, double>),
            typeof(FlexibleListWrapper<double, float>),

            typeof(FlexibleListWrapper<float, object>),
            typeof(FlexibleListWrapper<float, bool>),
            typeof(FlexibleListWrapper<float, byte>),
            typeof(FlexibleListWrapper<float, sbyte>),
            typeof(FlexibleListWrapper<float, short>),
            typeof(FlexibleListWrapper<float, ushort>),
            typeof(FlexibleListWrapper<float, int>),
            typeof(FlexibleListWrapper<float, uint>),
            typeof(FlexibleListWrapper<float, long>),
            typeof(FlexibleListWrapper<float, ulong>),
            typeof(FlexibleListWrapper<float, char>),
            typeof(FlexibleListWrapper<float, double>),
            typeof(FlexibleListWrapper<float, float>),

            typeof(FlexibleListWrapper<object, DateTime>),
            typeof(FlexibleListWrapper<DateTime, object>),

            typeof(FlexibleDictionaryWrapper<object, object>),
            typeof(FlexibleDictionaryWrapper<object, bool>),
            typeof(FlexibleDictionaryWrapper<object, byte>),
            typeof(FlexibleDictionaryWrapper<object, sbyte>),
            typeof(FlexibleDictionaryWrapper<object, short>),
            typeof(FlexibleDictionaryWrapper<object, ushort>),
            typeof(FlexibleDictionaryWrapper<object, int>),
            typeof(FlexibleDictionaryWrapper<object, uint>),
            typeof(FlexibleDictionaryWrapper<object, long>),
            typeof(FlexibleDictionaryWrapper<object, ulong>),
            typeof(FlexibleDictionaryWrapper<object, char>),
            typeof(FlexibleDictionaryWrapper<object, double>),
            typeof(FlexibleDictionaryWrapper<object, float>),

            typeof(FlexibleDictionaryWrapper<bool, object>),
            typeof(FlexibleDictionaryWrapper<bool, bool>),
            typeof(FlexibleDictionaryWrapper<bool, byte>),
            typeof(FlexibleDictionaryWrapper<bool, sbyte>),
            typeof(FlexibleDictionaryWrapper<bool, short>),
            typeof(FlexibleDictionaryWrapper<bool, ushort>),
            typeof(FlexibleDictionaryWrapper<bool, int>),
            typeof(FlexibleDictionaryWrapper<bool, uint>),
            typeof(FlexibleDictionaryWrapper<bool, long>),
            typeof(FlexibleDictionaryWrapper<bool, ulong>),
            typeof(FlexibleDictionaryWrapper<bool, char>),
            typeof(FlexibleDictionaryWrapper<bool, double>),
            typeof(FlexibleDictionaryWrapper<bool, float>),

            typeof(FlexibleDictionaryWrapper<byte, object>),
            typeof(FlexibleDictionaryWrapper<byte, bool>),
            typeof(FlexibleDictionaryWrapper<byte, byte>),
            typeof(FlexibleDictionaryWrapper<byte, sbyte>),
            typeof(FlexibleDictionaryWrapper<byte, short>),
            typeof(FlexibleDictionaryWrapper<byte, ushort>),
            typeof(FlexibleDictionaryWrapper<byte, int>),
            typeof(FlexibleDictionaryWrapper<byte, uint>),
            typeof(FlexibleDictionaryWrapper<byte, long>),
            typeof(FlexibleDictionaryWrapper<byte, ulong>),
            typeof(FlexibleDictionaryWrapper<byte, char>),
            typeof(FlexibleDictionaryWrapper<byte, double>),
            typeof(FlexibleDictionaryWrapper<byte, float>),

            typeof(FlexibleDictionaryWrapper<sbyte, object>),
            typeof(FlexibleDictionaryWrapper<sbyte, bool>),
            typeof(FlexibleDictionaryWrapper<sbyte, byte>),
            typeof(FlexibleDictionaryWrapper<sbyte, sbyte>),
            typeof(FlexibleDictionaryWrapper<sbyte, short>),
            typeof(FlexibleDictionaryWrapper<sbyte, ushort>),
            typeof(FlexibleDictionaryWrapper<sbyte, int>),
            typeof(FlexibleDictionaryWrapper<sbyte, uint>),
            typeof(FlexibleDictionaryWrapper<sbyte, long>),
            typeof(FlexibleDictionaryWrapper<sbyte, ulong>),
            typeof(FlexibleDictionaryWrapper<sbyte, char>),
            typeof(FlexibleDictionaryWrapper<sbyte, double>),
            typeof(FlexibleDictionaryWrapper<sbyte, float>),

            typeof(FlexibleDictionaryWrapper<short, object>),
            typeof(FlexibleDictionaryWrapper<short, bool>),
            typeof(FlexibleDictionaryWrapper<short, byte>),
            typeof(FlexibleDictionaryWrapper<short, sbyte>),
            typeof(FlexibleDictionaryWrapper<short, short>),
            typeof(FlexibleDictionaryWrapper<short, ushort>),
            typeof(FlexibleDictionaryWrapper<short, int>),
            typeof(FlexibleDictionaryWrapper<short, uint>),
            typeof(FlexibleDictionaryWrapper<short, long>),
            typeof(FlexibleDictionaryWrapper<short, ulong>),
            typeof(FlexibleDictionaryWrapper<short, char>),
            typeof(FlexibleDictionaryWrapper<short, double>),
            typeof(FlexibleDictionaryWrapper<short, float>),

            typeof(FlexibleDictionaryWrapper<ushort, object>),
            typeof(FlexibleDictionaryWrapper<ushort, bool>),
            typeof(FlexibleDictionaryWrapper<ushort, byte>),
            typeof(FlexibleDictionaryWrapper<ushort, sbyte>),
            typeof(FlexibleDictionaryWrapper<ushort, short>),
            typeof(FlexibleDictionaryWrapper<ushort, ushort>),
            typeof(FlexibleDictionaryWrapper<ushort, int>),
            typeof(FlexibleDictionaryWrapper<ushort, uint>),
            typeof(FlexibleDictionaryWrapper<ushort, long>),
            typeof(FlexibleDictionaryWrapper<ushort, ulong>),
            typeof(FlexibleDictionaryWrapper<ushort, char>),
            typeof(FlexibleDictionaryWrapper<ushort, double>),
            typeof(FlexibleDictionaryWrapper<ushort, float>),

            typeof(FlexibleDictionaryWrapper<int, object>),
            typeof(FlexibleDictionaryWrapper<int, bool>),
            typeof(FlexibleDictionaryWrapper<int, byte>),
            typeof(FlexibleDictionaryWrapper<int, sbyte>),
            typeof(FlexibleDictionaryWrapper<int, short>),
            typeof(FlexibleDictionaryWrapper<int, ushort>),
            typeof(FlexibleDictionaryWrapper<int, int>),
            typeof(FlexibleDictionaryWrapper<int, uint>),
            typeof(FlexibleDictionaryWrapper<int, long>),
            typeof(FlexibleDictionaryWrapper<int, ulong>),
            typeof(FlexibleDictionaryWrapper<int, char>),
            typeof(FlexibleDictionaryWrapper<int, double>),
            typeof(FlexibleDictionaryWrapper<int, float>),

            typeof(FlexibleDictionaryWrapper<uint, object>),
            typeof(FlexibleDictionaryWrapper<uint, bool>),
            typeof(FlexibleDictionaryWrapper<uint, byte>),
            typeof(FlexibleDictionaryWrapper<uint, sbyte>),
            typeof(FlexibleDictionaryWrapper<uint, short>),
            typeof(FlexibleDictionaryWrapper<uint, ushort>),
            typeof(FlexibleDictionaryWrapper<uint, int>),
            typeof(FlexibleDictionaryWrapper<uint, uint>),
            typeof(FlexibleDictionaryWrapper<uint, long>),
            typeof(FlexibleDictionaryWrapper<uint, ulong>),
            typeof(FlexibleDictionaryWrapper<uint, char>),
            typeof(FlexibleDictionaryWrapper<uint, double>),
            typeof(FlexibleDictionaryWrapper<uint, float>),

            typeof(FlexibleDictionaryWrapper<long, object>),
            typeof(FlexibleDictionaryWrapper<long, bool>),
            typeof(FlexibleDictionaryWrapper<long, byte>),
            typeof(FlexibleDictionaryWrapper<long, sbyte>),
            typeof(FlexibleDictionaryWrapper<long, short>),
            typeof(FlexibleDictionaryWrapper<long, ushort>),
            typeof(FlexibleDictionaryWrapper<long, int>),
            typeof(FlexibleDictionaryWrapper<long, uint>),
            typeof(FlexibleDictionaryWrapper<long, long>),
            typeof(FlexibleDictionaryWrapper<long, ulong>),
            typeof(FlexibleDictionaryWrapper<long, char>),
            typeof(FlexibleDictionaryWrapper<long, double>),
            typeof(FlexibleDictionaryWrapper<long, float>),

            typeof(FlexibleDictionaryWrapper<ulong, object>),
            typeof(FlexibleDictionaryWrapper<ulong, bool>),
            typeof(FlexibleDictionaryWrapper<ulong, byte>),
            typeof(FlexibleDictionaryWrapper<ulong, sbyte>),
            typeof(FlexibleDictionaryWrapper<ulong, short>),
            typeof(FlexibleDictionaryWrapper<ulong, ushort>),
            typeof(FlexibleDictionaryWrapper<ulong, int>),
            typeof(FlexibleDictionaryWrapper<ulong, uint>),
            typeof(FlexibleDictionaryWrapper<ulong, long>),
            typeof(FlexibleDictionaryWrapper<ulong, ulong>),
            typeof(FlexibleDictionaryWrapper<ulong, char>),
            typeof(FlexibleDictionaryWrapper<ulong, double>),
            typeof(FlexibleDictionaryWrapper<ulong, float>),

            typeof(FlexibleDictionaryWrapper<char, object>),
            typeof(FlexibleDictionaryWrapper<char, bool>),
            typeof(FlexibleDictionaryWrapper<char, byte>),
            typeof(FlexibleDictionaryWrapper<char, sbyte>),
            typeof(FlexibleDictionaryWrapper<char, short>),
            typeof(FlexibleDictionaryWrapper<char, ushort>),
            typeof(FlexibleDictionaryWrapper<char, int>),
            typeof(FlexibleDictionaryWrapper<char, uint>),
            typeof(FlexibleDictionaryWrapper<char, long>),
            typeof(FlexibleDictionaryWrapper<char, ulong>),
            typeof(FlexibleDictionaryWrapper<char, char>),
            typeof(FlexibleDictionaryWrapper<char, double>),
            typeof(FlexibleDictionaryWrapper<char, float>),

            typeof(FlexibleDictionaryWrapper<double, object>),
            typeof(FlexibleDictionaryWrapper<double, bool>),
            typeof(FlexibleDictionaryWrapper<double, byte>),
            typeof(FlexibleDictionaryWrapper<double, sbyte>),
            typeof(FlexibleDictionaryWrapper<double, short>),
            typeof(FlexibleDictionaryWrapper<double, ushort>),
            typeof(FlexibleDictionaryWrapper<double, int>),
            typeof(FlexibleDictionaryWrapper<double, uint>),
            typeof(FlexibleDictionaryWrapper<double, long>),
            typeof(FlexibleDictionaryWrapper<double, ulong>),
            typeof(FlexibleDictionaryWrapper<double, char>),
            typeof(FlexibleDictionaryWrapper<double, double>),
            typeof(FlexibleDictionaryWrapper<double, float>),

            typeof(FlexibleDictionaryWrapper<float, object>),
            typeof(FlexibleDictionaryWrapper<float, bool>),
            typeof(FlexibleDictionaryWrapper<float, byte>),
            typeof(FlexibleDictionaryWrapper<float, sbyte>),
            typeof(FlexibleDictionaryWrapper<float, short>),
            typeof(FlexibleDictionaryWrapper<float, ushort>),
            typeof(FlexibleDictionaryWrapper<float, int>),
            typeof(FlexibleDictionaryWrapper<float, uint>),
            typeof(FlexibleDictionaryWrapper<float, long>),
            typeof(FlexibleDictionaryWrapper<float, ulong>),
            typeof(FlexibleDictionaryWrapper<float, char>),
            typeof(FlexibleDictionaryWrapper<float, double>),
            typeof(FlexibleDictionaryWrapper<float, float>),

            typeof(FlexibleDictionaryWrapper<object, DateTime>),
            typeof(FlexibleDictionaryWrapper<DateTime, object>)
        };
    }
}
