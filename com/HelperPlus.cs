using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace filter_value.com
{
    public static partial class Helper
    {
        /// <summary>将指定对象的值转换为等效的布尔值。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   <see langword="true" /> 或 <see langword="false" />，它将反映通过对 <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> 的基础类型调用 <paramref name="value" /> 方法而返回的值。
        ///    如果 <paramref name="value" /> 为 <see langword="null" />，则此方法返回 <see langword="false" />。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 是一个不等于 <see cref="F:System.Boolean.TrueString" /> 或 <see cref="F:System.Boolean.FalseString" />的字符串。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持 <paramref name="value" /> 到 <see cref="T:System.Boolean" /> 的转换。
        /// </exception>

        public static bool ToBoolean(this object value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定对象的值转换为等效的布尔值。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <see langword="true" /> 或 <see langword="false" />，它将反映通过对 <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> 的基础类型调用 <paramref name="value" /> 方法而返回的值。
        ///    如果 <paramref name="value" /> 为 <see langword="null" />，则此方法返回 <see langword="false" />。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 是一个不等于 <see cref="F:System.Boolean.TrueString" /> 或 <see cref="F:System.Boolean.FalseString" />的字符串。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持 <paramref name="value" /> 到 <see cref="T:System.Boolean" /> 的转换。
        /// </exception>

        public static bool ToBoolean(this object value, IFormatProvider provider)
        {
            return Convert.ToBoolean(value, provider);
        }

        /// <summary>返回指定的布尔值；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的布尔值。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static bool ToBoolean(this bool value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 8 位有符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this sbyte value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static bool ToBoolean(this char value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>.
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this byte value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this short value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this ushort value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this int value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this uint value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this long value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this ulong value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将逻辑值的指定字符串表示形式转换为其等效的布尔值。</summary>
        /// <param name="value">
        ///   包含 <see cref="F:System.Boolean.TrueString" /> 或 <see cref="F:System.Boolean.FalseString" /> 值的字符串。
        /// </param>
        /// <returns>
        ///   如果 <see langword="true" /> 等于 <paramref name="value" />，则为 <see cref="F:System.Boolean.TrueString" />；如果 <see langword="false" /> 等于 <paramref name="value" /> 或 <see cref="F:System.Boolean.FalseString" />，则为 <see langword="null" />。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不等于 <see cref="F:System.Boolean.TrueString" /> 或 <see cref="F:System.Boolean.FalseString" />。
        /// </exception>

        public static bool ToBoolean(this string value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将逻辑值的指定字符串表示形式转换为其等效的布尔值。</summary>
        /// <param name="value">
        ///   包含 <see cref="F:System.Boolean.TrueString" /> 或 <see cref="F:System.Boolean.FalseString" /> 值的字符串。
        /// </param>
        /// <param name="provider">
        ///   一个提供区域性特定的格式设置信息的对象。
        ///    忽略此参数。
        /// </param>
        /// <returns>
        ///   如果 <see langword="true" /> 等于 <paramref name="value" />，则为 <see cref="F:System.Boolean.TrueString" />；如果 <see langword="false" /> 等于 <paramref name="value" /> 或 <see cref="F:System.Boolean.FalseString" />，则为 <see langword="null" />。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不等于 <see cref="F:System.Boolean.TrueString" /> 或 <see cref="F:System.Boolean.FalseString" />。
        /// </exception>

        public static bool ToBoolean(this string value, IFormatProvider provider)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this float value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this double value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定的十进制数字的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的数字。</param>
        /// <returns>
        ///   如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。
        /// </returns>

        public static bool ToBoolean(this decimal value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static bool ToBoolean(this DateTime value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>将指定对象的值转换为 Unicode 字符。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <returns>
        ///   与 value 等效的 Unicode 字符，或者如果 <see cref="F:System.Char.MinValue" /> 为 <paramref name="value" />，则为 <see langword="null" />。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="value" /> 是一个 null 字符串。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持 <paramref name="value" /> 到 <see cref="T:System.Char" /> 的转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" /> 或大于 <see cref="F:System.Char.MaxValue" />。
        /// </exception>

        public static char ToChar(this object value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>使用指定的区域性特定格式设置信息将指定对象的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的 Unicode 字符，或者如果 <see cref="F:System.Char.MinValue" /> 为 <paramref name="value" />，则为 <see langword="null" />。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="value" /> 是一个 null 字符串。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持 <paramref name="value" /> 到 <see cref="T:System.Char" /> 的转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" /> 或大于 <see cref="F:System.Char.MaxValue" />。
        /// </exception>

        public static char ToChar(this object value, IFormatProvider provider)
        {
            return Convert.ToChar(value);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static char ToChar(this bool value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>返回指定的 Unicode 字符值；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的 Unicode 字符。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>
        public static char ToChar(this char value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 8 位有符号整数的值转换为它的等效 Unicode 字符。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" />。
        /// </exception>

        public static char ToChar(this sbyte value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>

        public static char ToChar(this byte value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为它的等效 Unicode 字符。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" />。
        /// </exception>

        public static char ToChar(this short value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>

        public static char ToChar(this ushort value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为它的等效 Unicode 字符。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" /> 或大于 <see cref="F:System.Char.MaxValue" />。
        /// </exception>

        public static char ToChar(this int value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Char.MaxValue" />。
        /// </exception>

        public static char ToChar(this uint value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 64 位有符号整数的值转换为它的等效 Unicode 字符。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" /> 或大于 <see cref="F:System.Char.MaxValue" />。
        /// </exception>

        public static char ToChar(this long value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Char.MaxValue" />。
        /// </exception>

        public static char ToChar(this ulong value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>将指定字符串的第一个字符转换为 Unicode 字符。</summary>
        /// <param name="value">长度为 1 的字符串。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中第一个且仅有的字符等效的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="value" /> 为 <see langword="null" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的长度不是 1。
        /// </exception>

        public static char ToChar(this string value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定字符串的第一个字符转换为 Unicode 字符。</summary>
        /// <param name="value">
        ///   长度为 1 或 <see langword="null" /> 的字符串。
        /// </param>
        /// <param name="provider">
        ///   一个提供区域性特定的格式设置信息的对象。
        ///    忽略此参数。
        /// </param>
        /// <returns>
        ///   与 <paramref name="value" /> 中第一个且仅有的字符等效的 Unicode 字符。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="value" /> 为 <see langword="null" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的长度不是 1。
        /// </exception>

        public static char ToChar(this string value, IFormatProvider provider)
        {
            return Convert.ToChar(value, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static char ToChar(this float value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static char ToChar(this double value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static char ToChar(this decimal value)
        {
            return Convert.ToChar(value);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static char ToChar(this DateTime value)
        {
            return ((IConvertible)value).ToChar(null);
        }

        /// <summary>将指定对象的值转换为 8 位带符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.SByte.MinValue" /> 或大于 <see cref="F:System.SByte.MaxValue" /> 的数字。
        /// </exception>

        public static sbyte ToSByte(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToSByte(null);
            return 0;
        }

        /// <summary>使用指定的区域性特定格式信息，将指定对象的值转换为 8 位带符号整数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.SByte.MinValue" /> 或大于 <see cref="F:System.SByte.MaxValue" /> 的数字。
        /// </exception>

        public static sbyte ToSByte(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToSByte(provider);
            return 0;
        }

        /// <summary>将指定的布尔值转换为等效的 8 位带符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static sbyte ToSByte(this bool value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>返回指定的 8 位有符号整数；不执行实际的转换。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static sbyte ToSByte(this sbyte value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 Unicode 字符的值转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" />。
        /// </exception>

        public static sbyte ToSByte(this char value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" />。
        /// </exception>

        public static sbyte ToSByte(this byte value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 16 位带符号整数的值转换为等效的 8 位带符号整数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this short value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" />。
        /// </exception>

        public static sbyte ToSByte(this ushort value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this int value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this uint value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this long value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this ulong value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 8 位带符号整数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 8 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this float value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 8 位带符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 8 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this double value)
        {
            return Convert.ToSByte(Convert.ToInt32(value));
        }

        /// <summary>将指定的十进制数的值转换为等效的 8 位带符号整数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 8 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" /> 或小于 <see cref="F:System.SByte.MinValue" />。
        /// </exception>

        public static sbyte ToSByte(this decimal value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 8 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的 8 位带符号整数，如果值为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.SByte.MinValue" /> 或大于 <see cref="F:System.SByte.MaxValue" /> 的数字。
        /// </exception>

        public static sbyte ToSByte(this string value)
        {
            return Convert.ToSByte(value);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 8 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="value" /> 为 <see langword="null" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.SByte.MinValue" /> 或大于 <see cref="F:System.SByte.MaxValue" /> 的数字。
        /// </exception>

        public static sbyte ToSByte(this string value, IFormatProvider provider)
        {
            return sbyte.Parse(value, NumberStyles.Integer, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static sbyte ToSByte(this DateTime value)
        {
            return ((IConvertible)value).ToSByte(null);
        }

        /// <summary>将指定对象的值转换为 8 位无符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 未采用 <see cref="T:System.Byte" /> 值的属性格式。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" />。
        ///
        ///   - 或 -
        ///
        ///   不支持从 <paramref name="value" /> 转换为 <see cref="T:System.Byte" /> 类型。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" /> 的数字。
        /// </exception>

        public static byte ToByte(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToByte(null);
            return 0;
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定对象的值转换为 8 位无符号整数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 未采用 <see cref="T:System.Byte" /> 值的属性格式。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" />。
        ///
        ///   - 或 -
        ///
        ///   不支持从 <paramref name="value" /> 转换为 <see cref="T:System.Byte" /> 类型。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" /> 的数字。
        /// </exception>

        public static byte ToByte(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToByte(provider);
            return 0;
        }

        /// <summary>将指定的布尔值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static byte ToByte(this bool value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>返回指定的 8 位无符号整数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的 8 位无符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static byte ToByte(this byte value)
        {
            return value;
        }

        /// <summary>将指定 Unicode 字符的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个大于 <see cref="F:System.Byte.MaxValue" /> 的数字。
        /// </exception>

        public static byte ToByte(this char value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的 8 位有符号整数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位有符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Byte.MinValue" />。
        /// </exception>

        public static byte ToByte(this sbyte value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" />。
        /// </exception>

        public static byte ToByte(this short value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Byte.MaxValue" />。
        /// </exception>

        public static byte ToByte(this ushort value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" />。
        /// </exception>

        public static byte ToByte(this int value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Byte.MaxValue" />。
        /// </exception>

        public static byte ToByte(this uint value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" />。
        /// </exception>

        public static byte ToByte(this long value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Byte.MaxValue" />。
        /// </exception>

        public static byte ToByte(this ulong value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 8 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Byte.MaxValue" /> 或小于 <see cref="F:System.Byte.MinValue" />。
        /// </exception>

        public static byte ToByte(this float value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 8 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Byte.MaxValue" /> 或小于 <see cref="F:System.Byte.MinValue" />。
        /// </exception>

        public static byte ToByte(this double value)
        {
            return Convert.ToByte(Convert.ToInt32(value));
        }

        /// <summary>将指定的十进制数的值转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">要转换的数字。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 8 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Byte.MaxValue" /> 或小于 <see cref="F:System.Byte.MinValue" />。
        /// </exception>

        public static byte ToByte(this decimal value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" /> 的数字。
        /// </exception>

        public static byte ToByte(this string value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" /> 的数字。
        /// </exception>

        public static byte ToByte(this string value, IFormatProvider provider)
        {
            return Convert.ToByte(value, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static byte ToByte(this DateTime value)
        {
            return Convert.ToByte(value);
        }

        /// <summary>将指定对象的值转换为 16 位带符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   对于 <see cref="T:System.Int16" /> 类型，<paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" /> 的数字。
        /// </exception>

        public static short ToInt16(this object value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>使用指定的区域性特定格式信息，将指定对象的值转换为 16 位带符号整数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   对于 <see cref="T:System.Int16" /> 类型，<paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" />。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" /> 的数字。
        /// </exception>

        public static short ToInt16(this object value, IFormatProvider provider)
        {
            return Convert.ToInt16(value, provider);
        }

        /// <summary>将指定的布尔值转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static short ToInt16(this bool value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的 Unicode 字符的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" />。
        /// </exception>

        public static short ToInt16(this char value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的 8 位带符号整数的值转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>

        public static short ToInt16(this sbyte value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数。
        /// </returns>

        public static short ToInt16(this byte value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" />。
        /// </exception>

        public static short ToInt16(this ushort value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的 16 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" /> 或小于 <see cref="F:System.Int16.MinValue" />。
        /// </exception>

        public static short ToInt16(this int value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" />。
        /// </exception>

        public static short ToInt16(this uint value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>返回指定的 16 位有符号整数；不执行实际的转换。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static short ToInt16(this short value)
        {
            return value;
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" /> 或小于 <see cref="F:System.Int16.MinValue" />。
        /// </exception>

        public static short ToInt16(this long value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" />。
        /// </exception>

        public static short ToInt16(this ulong value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 16 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" /> 或小于 <see cref="F:System.Int16.MinValue" />。
        /// </exception>

        public static short ToInt16(this float value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 16 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" /> 或小于 <see cref="F:System.Int16.MinValue" />。
        /// </exception>

        public static short ToInt16(this double value)
        {
            return Convert.ToInt16(Convert.ToInt32(value));
        }

        /// <summary>将指定的十进制数的值转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 16 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int16.MaxValue" /> 或小于 <see cref="F:System.Int16.MinValue" />。
        /// </exception>

        public static short ToInt16(this decimal value)
        {
            return Convert.ToInt16(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 16 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" /> 的数字。
        /// </exception>

        public static short ToInt16(this string value)
        {
            if (value == null)
                return 0;
            return short.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 16 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" /> 的数字。
        /// </exception>

        public static short ToInt16(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0;
            return short.Parse(value, NumberStyles.Integer, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static short ToInt16(this DateTime value)
        {
            return ((IConvertible)value).ToInt16(null);
        }

        /// <summary>将指定对象的值转换为 16 位无符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" /> 的数字。
        /// </exception>

        public static ushort ToUInt16(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToUInt16(null);
            return 0;
        }

        /// <summary>使用指定的区域性特定格式信息，将指定对象的值转换为 16 位无符号整数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" /> 的数字。
        /// </exception>

        public static ushort ToUInt16(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToUInt16(provider);
            return 0;
        }

        /// <summary>将指定的布尔值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static ushort ToUInt16(this bool value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定 Unicode 字符的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>

        public static ushort ToUInt16(this char value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的 8 位有符号整数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static ushort ToUInt16(this sbyte value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>

        public static ushort ToUInt16(this byte value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static ushort ToUInt16(this short value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt16.MaxValue" />。
        /// </exception>

        public static ushort ToUInt16(this int value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>返回指定的 16 位无符号整数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的 16 位无符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static ushort ToUInt16(this ushort value)
        {
            return value;
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.UInt16.MaxValue" />。
        /// </exception>

        public static ushort ToUInt16(this uint value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt16.MaxValue" />。
        /// </exception>

        public static ushort ToUInt16(this long value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 16 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.UInt16.MaxValue" />。
        /// </exception>

        public static ushort ToUInt16(this ulong value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 16 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt16.MaxValue" />。
        /// </exception>

        public static ushort ToUInt16(this float value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 16 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt16.MaxValue" />。
        /// </exception>

        public static ushort ToUInt16(this double value)
        {
            return Convert.ToUInt16(Convert.ToInt32(value));
        }

        /// <summary>将指定的十进制数的值转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 16 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt16.MaxValue" />。
        /// </exception>

        public static ushort ToUInt16(this decimal value)
        {
            return Convert.ToUInt16(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 16 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" /> 的数字。
        /// </exception>

        public static ushort ToUInt16(this string value)
        {
            if (value == null)
                return 0;
            return ushort.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 16 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" /> 的数字。
        /// </exception>

        public static ushort ToUInt16(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0;
            return ushort.Parse(value, NumberStyles.Integer, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static ushort ToUInt16(this DateTime value)
        {
            return ((IConvertible)value).ToUInt16(null);
        }

        /// <summary>将指定对象的值转换为 32 位带符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个等效于 <paramref name="value" /> 的 32 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int32.MinValue" /> 或大于 <see cref="F:System.Int32.MaxValue" /> 的数字。
        /// </exception>

        public static int ToInt32(this object value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>使用指定的区域性特定格式信息，将指定对象的值转换为 32 位带符号整数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" />。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int32.MinValue" /> 或大于 <see cref="F:System.Int32.MaxValue" /> 的数字。
        /// </exception>

        public static int ToInt32(this object value, IFormatProvider provider)
        {
            return Convert.ToInt32(value, provider);
        }

        /// <summary>将指定的布尔值转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static int ToInt32(this bool value)
        {
            return !value ? 0 : 1;
        }

        /// <summary>将指定的 Unicode 字符的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数。
        /// </returns>

        public static int ToInt32(this char value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的 8 位带符号整数的值转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>

        public static int ToInt32(this sbyte value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数。
        /// </returns>

        public static int ToInt32(this byte value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数。
        /// </returns>

        public static int ToInt32(this short value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数。
        /// </returns>

        public static int ToInt32(this ushort value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int32.MaxValue" />。
        /// </exception>

        public static int ToInt32(this uint value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>返回指定的 32 位有符号整数；不执行实际的转换。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static int ToInt32(this int value)
        {
            return value;
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int32.MaxValue" /> 或小于 <see cref="F:System.Int32.MinValue" />。
        /// </exception>

        public static int ToInt32(this long value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int32.MaxValue" />。
        /// </exception>

        public static int ToInt32(this ulong value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 32 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int32.MaxValue" /> 或小于 <see cref="F:System.Int32.MinValue" />。
        /// </exception>

        public static int ToInt32(this float value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 32 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int32.MaxValue" /> 或小于 <see cref="F:System.Int32.MinValue" />。
        /// </exception>

        public static int ToInt32(this double value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将指定的十进制数的值转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 32 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int32.MaxValue" /> 或小于 <see cref="F:System.Int32.MinValue" />。
        /// </exception>
        [SecuritySafeCritical]
        public static int ToInt32(this decimal value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 32 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int32.MinValue" /> 或大于 <see cref="F:System.Int32.MaxValue" /> 的数字。
        /// </exception>

        public static int ToInt32(this string value)
        {
            if (value == null)
                return 0;
            return int.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 32 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int32.MinValue" /> 或大于 <see cref="F:System.Int32.MaxValue" /> 的数字。
        /// </exception>

        public static int ToInt32(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0;
            return int.Parse(value, NumberStyles.Integer, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static int ToInt32(this DateTime value)
        {
            return ((IConvertible)value).ToInt32(null);
        }

        /// <summary>将指定对象的值转换为 32 位无符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个等效于 <paramref name="value" /> 的 32 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt32.MinValue" /> 或大于 <see cref="F:System.UInt32.MaxValue" /> 的数字。
        /// </exception>

        public static uint ToUInt32(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToUInt32(null);
            return 0;
        }

        /// <summary>使用指定的区域性特定格式信息，将指定对象的值转换为 32 位无符号整数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt32.MinValue" /> 或大于 <see cref="F:System.UInt32.MaxValue" /> 的数字。
        /// </exception>

        public static uint ToUInt32(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToUInt32(provider);
            return 0;
        }

        /// <summary>将指定的布尔值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static uint ToUInt32(this bool value)
        {
            return !value ? 0U : 1U;
        }

        /// <summary>将指定 Unicode 字符的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>

        public static uint ToUInt32(this char value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的 8 位有符号整数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static uint ToUInt32(this sbyte value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>

        public static uint ToUInt32(this byte value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static uint ToUInt32(this short value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>

        public static uint ToUInt32(this ushort value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static uint ToUInt32(this int value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>返回指定的 32 位无符号整数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的 32 位无符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static uint ToUInt32(this uint value)
        {
            return value;
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt32.MaxValue" />。
        /// </exception>

        public static uint ToUInt32(this long value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 32 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.UInt32.MaxValue" />。
        /// </exception>

        public static uint ToUInt32(this ulong value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 32 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt32.MaxValue" />。
        /// </exception>

        public static uint ToUInt32(this float value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 32 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt32.MaxValue" />。
        /// </exception>

        public static uint ToUInt32(this double value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将指定的十进制数的值转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 32 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt32.MaxValue" />。
        /// </exception>

        public static uint ToUInt32(this decimal value)
        {
            return Convert.ToUInt32(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 32 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt32.MinValue" /> 或大于 <see cref="F:System.UInt32.MaxValue" /> 的数字。
        /// </exception>

        public static uint ToUInt32(this string value)
        {
            if (value == null)
                return 0;
            return uint.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 32 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt32.MinValue" /> 或大于 <see cref="F:System.UInt32.MaxValue" /> 的数字。
        /// </exception>

        public static uint ToUInt32(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0;
            return uint.Parse(value, NumberStyles.Integer, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static uint ToUInt32(this DateTime value)
        {
            return ((IConvertible)value).ToUInt32(null);
        }

        /// <summary>将指定对象的值转换为 64 位带符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" /> 的数字。
        /// </exception>

        public static long ToInt64(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToInt64(null);
            return 0;
        }

        /// <summary>使用指定的区域性特定格式信息，将指定对象的值转换为 64 位带符号整数。</summary>
        /// <param name="value">
        ///   实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" /> 的数字。
        /// </exception>

        public static long ToInt64(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToInt64(provider);
            return 0;
        }

        /// <summary>将指定的布尔值转换为等效的 64 位带符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static long ToInt64(this bool value)
        {
            return value ? 1L : 0L;
        }

        /// <summary>将指定的 Unicode 字符的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static long ToInt64(this char value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的 8 位带符号整数的值转换为等效的 64 位带符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static long ToInt64(this sbyte value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static long ToInt64(this byte value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static long ToInt64(this short value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static long ToInt64(this ushort value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static long ToInt64(this int value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static long ToInt64(this uint value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int64.MaxValue" />。
        /// </exception>

        public static long ToInt64(this ulong value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>返回指定的 64 位有符号整数；不执行实际的转换。</summary>
        /// <param name="value">64 位带符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static long ToInt64(this long value)
        {
            return value;
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 64 位带符号整数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 64 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int64.MaxValue" /> 或小于 <see cref="F:System.Int64.MinValue" />。
        /// </exception>

        public static long ToInt64(this float value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 64 位带符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 64 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int64.MaxValue" /> 或小于 <see cref="F:System.Int64.MinValue" />。
        /// </exception>

        public static long ToInt64(this double value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将指定的十进制数的值转换为等效的 64 位带符号整数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 64 位带符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Int64.MaxValue" /> 或小于 <see cref="F:System.Int64.MinValue" />。
        /// </exception>

        public static long ToInt64(this decimal value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 64 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 64 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" /> 的数字。
        /// </exception>

        public static long ToInt64(this string value)
        {
            if (value == null)
                return 0;
            return long.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 64 位带符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 64 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" /> 的数字。
        /// </exception>

        public static long ToInt64(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0;
            return long.Parse(value, NumberStyles.Integer, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static long ToInt64(this DateTime value)
        {
            return ((IConvertible)value).ToInt64(null);
        }

        /// <summary>将指定对象的值转换为 64 位无符号整数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" /> 的数字。
        /// </exception>

        public static ulong ToUInt64(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToUInt64(null);
            return 0;
        }

        /// <summary>使用指定的区域性特定格式信息，将指定对象的值转换为 64 位无符号整数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" /> 的数字。
        /// </exception>

        public static ulong ToUInt64(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToUInt64(provider);
            return 0;
        }

        /// <summary>将指定的布尔值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static ulong ToUInt64(this bool value)
        {
            return !value ? 0UL : 1UL;
        }

        /// <summary>将指定 Unicode 字符的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数。
        /// </returns>

        public static ulong ToUInt64(this char value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的 8 位有符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static ulong ToUInt64(this sbyte value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位带符号整数。
        /// </returns>

        public static ulong ToUInt64(this byte value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的 16 位有符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static ulong ToUInt64(this short value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数。
        /// </returns>

        public static ulong ToUInt64(this ushort value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的 32 位有符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static ulong ToUInt64(this int value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数。
        /// </returns>

        public static ulong ToUInt64(this uint value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的 64 位有符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 64 位无符号整数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零。
        /// </exception>

        public static ulong ToUInt64(this long value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>返回指定的 64 位无符号整数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的 64 位无符号整数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static ulong ToUInt64(this ulong value)
        {
            return value;
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 64 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt64.MaxValue" />。
        /// </exception>

        public static ulong ToUInt64(this float value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 64 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt64.MaxValue" />。
        /// </exception>

        public static ulong ToUInt64(this double value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将指定的十进制数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" />，舍入为最接近的 64 位无符号整数。
        ///    如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt64.MaxValue" />。
        /// </exception>

        public static ulong ToUInt64(this decimal value)
        {
            return Convert.ToUInt64(value);
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 64 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" /> 的数字。
        /// </exception>

        public static ulong ToUInt64(this string value)
        {
            if (value == null)
                return 0;
            return ulong.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 64 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不由一个可选符号后跟一系列数字 (0-9) 组成。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" /> 的数字。
        /// </exception>

        public static ulong ToUInt64(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0;
            return ulong.Parse(value, NumberStyles.Integer, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static ulong ToUInt64(this DateTime value)
        {
            return ((IConvertible)value).ToUInt64(null);
        }

        /// <summary>将指定对象的值转换为单精度浮点数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的单精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" /> 的数字。
        /// </exception>

        public static float ToSingle(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToSingle(null);
            return 0.0f;
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定对象的值转换为单精度浮点数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的单精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" />。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" /> 的数字。
        /// </exception>

        public static float ToSingle(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToSingle(provider);
            return 0.0f;
        }

        /// <summary>将指定的 8 位带符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>

        public static float ToSingle(this sbyte value)
        {
            return Convert.ToSingle(value);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>

        public static float ToSingle(this byte value)
        {
            return Convert.ToSingle(value);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static float ToSingle(this char value)
        {
            return ((IConvertible)value).ToSingle(null);
        }

        /// <summary>将指定的 16 位带符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>

        public static float ToSingle(this short value)
        {
            return value;
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>

        public static float ToSingle(this ushort value)
        {
            return value;
        }

        /// <summary>将指定的 32 位带符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>

        public static float ToSingle(this int value)
        {
            return value;
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>

        public static float ToSingle(this uint value)
        {
            return value;
        }

        /// <summary>将指定的 64 位带符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>

        public static float ToSingle(this long value)
        {
            return value;
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>

        public static float ToSingle(this ulong value)
        {
            return value;
        }

        /// <summary>返回指定的单精度浮点数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的单精度浮点数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static float ToSingle(this float value)
        {
            return value;
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        ///
        ///   使用“舍入为最接近的数字”规则对 <paramref name="value" /> 进行舍入。
        ///    例如，当舍入为两位小数时，值 2.345 变成 2.34，而值 2.355 变成 2.36。
        /// </returns>

        public static float ToSingle(this double value)
        {
            return (float)value;
        }

        /// <summary>将指定的十进制数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的单精度浮点数。
        ///
        ///   使用“舍入为最接近的数字”规则对 <paramref name="value" /> 进行舍入。
        ///    例如，当舍入为两位小数时，值 2.345 变成 2.34，而值 2.355 变成 2.36。
        /// </returns>

        public static float ToSingle(this decimal value)
        {
            return (float)value;
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的单精度浮点数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的单精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是一个具有有效格式的数字。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" /> 的数字。
        /// </exception>

        public static float ToSingle(this string value)
        {
            if (value == null)
                return 0.0f;
            return float.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的单精度浮点数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的单精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是一个具有有效格式的数字。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" /> 的数字。
        /// </exception>

        public static float ToSingle(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0.0f;
            return float.Parse(value, NumberStyles.Float | NumberStyles.AllowThousands, provider);
        }

        /// <summary>将指定的布尔值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static float ToSingle(this bool value)
        {
            return value ? 1f : 0.0f;
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static float ToSingle(this DateTime value)
        {
            return ((IConvertible)value).ToSingle(null);
        }

        /// <summary>将指定对象的值转换为双精度浮点数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的双精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   对于 <see cref="T:System.Double" /> 类型，<paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" /> 的数字。
        /// </exception>

        public static double ToDouble(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToDouble(null);
            return 0.0;
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定对象的值转换为双精度浮点数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的双精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为零。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   对于 <see cref="T:System.Double" /> 类型，<paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" /> 的数字。
        /// </exception>

        public static double ToDouble(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToDouble(provider);
            return 0.0;
        }

        /// <summary>将指定的 8 位带符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的 8 位带符号整数。
        /// </returns>

        public static double ToDouble(this sbyte value)
        {
            return value;
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的双精度浮点数。
        /// </returns>

        public static double ToDouble(this byte value)
        {
            return value;
        }

        /// <summary>将指定的 16 位带符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的双精度浮点数。
        /// </returns>

        public static double ToDouble(this short value)
        {
            return value;
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static double ToDouble(this char value)
        {
            return ((IConvertible)value).ToDouble(null);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的双精度浮点数。
        /// </returns>

        public static double ToDouble(this ushort value)
        {
            return value;
        }

        /// <summary>将指定的 32 位带符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的双精度浮点数。
        /// </returns>

        public static double ToDouble(this int value)
        {
            return value;
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的双精度浮点数。
        /// </returns>

        public static double ToDouble(this uint value)
        {
            return value;
        }

        /// <summary>将指定的 64 位带符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的双精度浮点数。
        /// </returns>

        public static double ToDouble(this long value)
        {
            return value;
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的双精度浮点数。
        /// </returns>

        public static double ToDouble(this ulong value)
        {
            return value;
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">单精度浮点数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的双精度浮点数。
        /// </returns>

        public static double ToDouble(this float value)
        {
            return value;
        }

        /// <summary>返回指定的双精度浮点数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的双精度浮点数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static double ToDouble(this double value)
        {
            return value;
        }

        /// <summary>将指定的十进制数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的双精度浮点数。
        /// </returns>

        public static double ToDouble(this decimal value)
        {
            return (double)value;
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的双精度浮点数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的双精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是一个具有有效格式的数字。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" /> 的数字。
        /// </exception>

        public static double ToDouble(this string value)
        {
            if (value == null)
                return 0.0;
            return double.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的双精度浮点数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的双精度浮点数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是一个具有有效格式的数字。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" /> 的数字。
        /// </exception>

        public static double ToDouble(this string value, IFormatProvider provider)
        {
            if (value == null)
                return 0.0;
            return double.Parse(value, NumberStyles.Float | NumberStyles.AllowThousands, provider);
        }

        /// <summary>将指定的布尔值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static double ToDouble(this bool value)
        {
            return value ? 1.0 : 0.0;
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static double ToDouble(this DateTime value)
        {
            return ((IConvertible)value).ToDouble(null);
        }

        /// <summary>将指定对象的值转换为等效的十进制数。</summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的十进制数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   对于 <see cref="T:System.Decimal" /> 类型，<paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" /> 的数字。
        /// </exception>

        public static decimal ToDecimal(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToDecimal(null);
            return decimal.Zero;
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定对象的值转换为等效的十进制数。</summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的十进制数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   对于 <see cref="T:System.Decimal" /> 类型，<paramref name="value" /> 的格式不正确。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" /> 的数字。
        /// </exception>

        public static decimal ToDecimal(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToDecimal(provider);
            return decimal.Zero;
        }

        /// <summary>将指定的 8 位带符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>

        public static decimal ToDecimal(this sbyte value)
        {
            return value;
        }

        /// <summary>将指定的 8 位无符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的十进制数。
        /// </returns>

        public static decimal ToDecimal(this byte value)
        {
            return value;
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static decimal ToDecimal(this char value)
        {
            return ((IConvertible)value).ToDecimal(null);
        }

        /// <summary>将指定的 16 位带符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>

        public static decimal ToDecimal(this short value)
        {
            return value;
        }

        /// <summary>将指定的 16 位无符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 等效的十进制数。
        /// </returns>

        public static decimal ToDecimal(this ushort value)
        {
            return value;
        }

        /// <summary>将指定的 32 位带符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>

        public static decimal ToDecimal(this int value)
        {
            return value;
        }

        /// <summary>将指定的 32 位无符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>

        public static decimal ToDecimal(this uint value)
        {
            return value;
        }

        /// <summary>将指定的 64 位带符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>

        public static decimal ToDecimal(this long value)
        {
            return value;
        }

        /// <summary>将指定的 64 位无符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>

        public static decimal ToDecimal(this ulong value)
        {
            return value;
        }

        /// <summary>将指定的单精度浮点数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Decimal.MaxValue" /> 或小于 <see cref="F:System.Decimal.MinValue" />。
        /// </exception>

        public static decimal ToDecimal(this float value)
        {
            return (decimal)value;
        }

        /// <summary>将指定的双精度浮点数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   一个等于 <paramref name="value" /> 的十进制数。
        /// </returns>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 大于 <see cref="F:System.Decimal.MaxValue" /> 或小于 <see cref="F:System.Decimal.MinValue" />。
        /// </exception>

        public static decimal ToDecimal(this double value)
        {
            return (decimal)value;
        }

        /// <summary>将数字的指定字符串表示形式转换为等效的十进制数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的十进制数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是一个具有有效格式的数字。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" /> 的数字。
        /// </exception>

        public static decimal ToDecimal(this string value)
        {
            if (value == null)
                return decimal.Zero;
            return decimal.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的十进制数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的十进制数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是一个具有有效格式的数字。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" /> 的数字。
        /// </exception>

        public static decimal ToDecimal(this string value, IFormatProvider provider)
        {
            if (value == null)
                return decimal.Zero;
            return decimal.Parse(value, NumberStyles.Number, provider);
        }

        /// <summary>返回指定的十进制数；不执行任何实际的转换。</summary>
        /// <param name="value">十进制数。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>

        public static decimal ToDecimal(this decimal value)
        {
            return value;
        }

        /// <summary>将指定的布尔值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   如果 <paramref name="value" /> 为 <see langword="true" />，则为数字 1；否则，为 0。
        /// </returns>

        public static decimal ToDecimal(this bool value)
        {
            return value ? 1 : 0;
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static decimal ToDecimal(this DateTime value)
        {
            return ((IConvertible)value).ToDecimal(null);
        }

        /// <summary>
        ///   返回指定的 <see cref="T:System.DateTime" /> 对象；不执行任何实际的转换。
        /// </summary>
        /// <param name="value">日期和时间值。</param>
        /// <returns>
        ///   不经更改即返回 <paramref name="value" />。
        /// </returns>
        public static DateTime ToDateTime(this DateTime value)
        {
            return value;
        }

        /// <summary>
        ///   将指定对象的值转换为 <see cref="T:System.DateTime" /> 对象。
        /// </summary>
        /// <param name="value">
        ///   用于实现 <see cref="T:System.IConvertible" /> 接口的对象，或为 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   <paramref name="value" /> 的值的日期和时间等效项，如果 <see cref="F:System.DateTime.MinValue" /> 为 <paramref name="value" />，则为 <see langword="null" /> 的日期和时间等效项。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 是无效的日期和时间值。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>

        public static DateTime ToDateTime(this object value)
        {
            if (value != null)
                return ((IConvertible)value).ToDateTime(null);
            return DateTime.MinValue;
        }

        /// <summary>
        ///   使用指定的区域性特定格式设置信息将指定对象的值转换为 <see cref="T:System.DateTime" /> 对象。
        /// </summary>
        /// <param name="value">
        ///   一个实现 <see cref="T:System.IConvertible" /> 接口的对象。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的值的日期和时间等效项，如果 <see cref="F:System.DateTime.MinValue" /> 为 <paramref name="value" />，则为 <see langword="null" /> 的日期和时间等效项。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 是无效的日期和时间值。
        /// </exception>
        /// <exception cref="T:System.InvalidCastException">
        ///   <paramref name="value" /> 不实现 <see cref="T:System.IConvertible" /> 接口。
        ///
        ///   - 或 -
        ///
        ///   不支持该转换。
        /// </exception>

        public static DateTime ToDateTime(this object value, IFormatProvider provider)
        {
            if (value != null)
                return ((IConvertible)value).ToDateTime(provider);
            return DateTime.MinValue;
        }

        /// <summary>将日期和时间的指定字符串表示形式转换为等效的日期和时间值。</summary>
        /// <param name="value">日期和时间的字符串表示形式。</param>
        /// <returns>
        ///   <paramref name="value" /> 的值的日期和时间等效项，如果 <see cref="F:System.DateTime.MinValue" /> 为 <paramref name="value" />，则为 <see langword="null" /> 的日期和时间等效项。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是格式正确的日期和时间字符串。
        /// </exception>

        public static DateTime ToDateTime(this string value)
        {
            if (value == null)
                return new DateTime(0L);
            return DateTime.Parse(value, CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将数字的指定字符串表示形式转换为等效的日期和时间。</summary>
        /// <param name="value">包含要转换的日期和时间的字符串。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的值的日期和时间等效项，如果 <see cref="F:System.DateTime.MinValue" /> 为 <paramref name="value" />，则为 <see langword="null" /> 的日期和时间等效项。
        /// </returns>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 不是格式正确的日期和时间字符串。
        /// </exception>

        public static DateTime ToDateTime(this string value, IFormatProvider provider)
        {
            if (value == null)
                return new DateTime(0L);
            return DateTime.Parse(value, provider);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static DateTime ToDateTime(this sbyte value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this byte value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this short value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static DateTime ToDateTime(this ushort value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this int value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static DateTime ToDateTime(this uint value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this long value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>

        public static DateTime ToDateTime(this ulong value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this bool value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this char value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的单精度浮点值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this float value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的双精度浮点值。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this double value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>
        ///   调用此方法始终引发 <see cref="T:System.InvalidCastException" />。
        /// </summary>
        /// <param name="value">要转换的数字。</param>
        /// <returns>
        ///   不支持此转换。
        ///    不返回任何值。
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        ///   不支持此转换。
        /// </exception>
        public static DateTime ToDateTime(this decimal value)
        {
            return ((IConvertible)value).ToDateTime(null);
        }

        /// <summary>将指定对象的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">
        ///   一个对象，用于提供要转换的值，或 <see langword="null" />。
        /// </param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表现形式；如果 <paramref name="value" /> 为 <see langword="null" />，则为 <see cref="F:System.String.Empty" />。
        /// </returns>

        public static string ToString(this object value)
        {
            return Convert.ToString(value, null);
        }

        /// <summary>使用指定的区域性特定格式设置信息将指定对象的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">
        ///   一个对象，用于提供要转换的值，或 <see langword="null" />。
        /// </param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式；如果 <see cref="F:System.String.Empty" /> 是一个值为 <paramref name="value" /> 的对象，则为 <see langword="null" />。
        ///    如果 <paramref name="value" /> 为 <see langword="null" />，则此方法返回 <see langword="null" />。
        /// </returns>

        public static string ToString(this object value, IFormatProvider provider)
        {
            IConvertible convertible = value as IConvertible;
            if (convertible != null)
                return convertible.ToString(provider);
            IFormattable formattable = value as IFormattable;
            if (formattable != null)
                return formattable.ToString(null, provider);
            if (value != null)
                return value.ToString();
            return string.Empty;
        }

        /// <summary>将指定的布尔值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this bool value)
        {
            return value.ToString();
        }

        /// <summary>将指定的布尔值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的布尔值。</param>
        /// <param name="provider">
        ///   一个对象的实例。
        ///    忽略此参数。
        /// </param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this bool value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 Unicode 字符的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this char value)
        {
            return char.ToString(value);
        }

        /// <summary>使用指定的区域性特定格式设置信息将指定的 Unicode 字符的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <param name="provider">
        ///   一个提供区域性特定的格式设置信息的对象。
        ///    忽略此参数。
        /// </param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this char value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 8 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this sbyte value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 8 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this sbyte value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 8 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this byte value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 8 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this byte value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 16 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this short value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 16 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this short value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 16 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this ushort value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 16 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this ushort value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 32 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this int value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 32 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this int value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 32 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this uint value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 32 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this uint value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 64 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this long value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 64 位带符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this long value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的 64 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this ulong value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的 64 位无符号整数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this ulong value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的单精度浮点数的值转换其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this float value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息，将指定的单精度浮点数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this float value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的双精度浮点数的值转换其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this double value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>将指定的双精度浮点数的值转换其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this double value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定的十进制数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this decimal value)
        {
            return value.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>使用指定的区域性特定格式设置信息将指定的十进制数的值转换为其等效的字符串表示形式。</summary>
        /// <param name="value">要转换的十进制数。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>

        public static string ToString(this decimal value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>
        ///   使用指定的区域性特定格式设置信息将指定的 <see cref="T:System.DateTime" /> 的值转换为其等效的字符串表示形式。
        /// </summary>
        /// <param name="value">要转换的日期和时间值。</param>
        /// <param name="provider">一个提供区域性特定的格式设置信息的对象。</param>
        /// <returns>
        ///   <paramref name="value" /> 的字符串表示形式。
        /// </returns>
        public static string ToString(this DateTime value, IFormatProvider provider)
        {
            return value.ToString(provider);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 8 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的 8 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示非 10 为基数的无符号数字）的前面带一个负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示 10 为基的无符号数字）的前面带一个负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" /> 的数字。
        /// </exception>
        public static byte ToByte(this string value, int fromBase)
        {
            return Convert.ToByte(value, fromBase);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 8 位有符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   与 <paramref name="value" /> 中数字等效的 8 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.SByte.MinValue" /> 或大于 <see cref="F:System.SByte.MaxValue" /> 的数字。
        /// </exception>
        public static sbyte ToSByte(this string value, int fromBase)
        {
            return Convert.ToSByte(value, fromBase);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 16 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" /> 的数字。
        /// </exception>
        public static short ToInt16(this string value, int fromBase)
        {
            return Convert.ToInt16(value, fromBase);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 16 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 16 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示非 10 为基数的无符号数字）的前面带一个负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示非 10 为基数的无符号数字）的前面带一个负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" /> 的数字。
        /// </exception>
        public static ushort ToUInt16(this string value, int fromBase)
        {
            return Convert.ToUInt16(value, fromBase);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 32 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int32.MinValue" /> 或大于 <see cref="F:System.Int32.MaxValue" /> 的数字。
        /// </exception>
        public static int ToInt32(this string value, int fromBase)
        {
            return Convert.ToInt32(value, fromBase);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 32 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 32 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示非 10 为基数的无符号数字）的前面带一个负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示非 10 为基数的无符号数字）的前面带一个负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt32.MinValue" /> 或大于 <see cref="F:System.UInt32.MaxValue" /> 的数字。
        /// </exception>
        public static uint ToUInt32(this string value, int fromBase)
        {
            return Convert.ToUInt32(value, fromBase);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 64 位带符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示基数不为 10 的符号数字）的前缀为负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" /> 的数字。
        /// </exception>
        public static long ToInt64(this string value, int fromBase)
        {
            return Convert.ToInt64(value, fromBase);
        }

        /// <summary>将指定基数的数字的字符串表示形式转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="fromBase">
        ///   <paramref name="value" /> 中数字的基数，它必须是 2、8、10 或 16。
        /// </param>
        /// <returns>
        ///   一个与 <paramref name="value" /> 中数字等效的 64 位无符号整数，如果 <paramref name="value" /> 为 <see langword="null" />，则为 0（零）。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="fromBase" /> 不是 2、8、10 或 16。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" />（表示非 10 为基数的无符号数字）的前面带一个负号。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="value" /> 为 <see cref="F:System.String.Empty" />。
        /// </exception>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="value" /> 包含一个字符，该字符不是由 <paramref name="fromBase" /> 指定的基数中的有效数字。
        ///    如果 <paramref name="value" /> 中的第一个字符无效，则该异常消息指示没有要转换的数字；否则，该消息指示 <paramref name="value" /> 包含无效的尾随字符。
        /// </exception>
        /// <exception cref="T:System.OverflowException">
        ///   <paramref name="value" />（表示非 10 为基数的无符号数字）的前面带一个负号。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="value" /> 表示一个小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" /> 的数字。
        /// </exception>
        public static ulong ToUInt64(this string value, int fromBase)
        {
            return Convert.ToUInt64(value, fromBase);
        }

        /// <summary>将 8 位无符号整数的值转换为其等效的指定基数的字符串表示形式。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <param name="toBase">返回值的基数，必须是 2、8、10 或 16。</param>
        /// <returns>
        ///   以 <paramref name="value" /> 为基数的 <paramref name="toBase" /> 的字符串表示形式。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="toBase" /> 不是 2、8、10 或 16。
        /// </exception>
        [SecuritySafeCritical]
        public static string ToString(this byte value, int toBase)
        {
            return Convert.ToString(value, toBase);
        }

        /// <summary>将 16 位带符号整数的值转换为其指定基的等效字符串表示形式。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <param name="toBase">返回值的基数，必须是 2、8、10 或 16。</param>
        /// <returns>
        ///   以 <paramref name="value" /> 为基数的 <paramref name="toBase" /> 的字符串表示形式。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="toBase" /> 不是 2、8、10 或 16。
        /// </exception>
        [SecuritySafeCritical]
        public static string ToString(this short value, int toBase)
        {
            return Convert.ToString(value, toBase);
        }

        /// <summary>将 32 位带符号整数的值转换为其指定基的等效字符串表示形式。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <param name="toBase">返回值的基数，必须是 2、8、10 或 16。</param>
        /// <returns>
        ///   以 <paramref name="value" /> 为基数的 <paramref name="toBase" /> 的字符串表示形式。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="toBase" /> 不是 2、8、10 或 16。
        /// </exception>
        [SecuritySafeCritical]
        public static string ToString(this int value, int toBase)
        {
            return Convert.ToString(value, toBase);
        }

        /// <summary>将 64 位带符号整数的值转换为其指定基的等效字符串表示形式。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <param name="toBase">返回值的基数，必须是 2、8、10 或 16。</param>
        /// <returns>
        ///   以 <paramref name="value" /> 为基数的 <paramref name="toBase" /> 的字符串表示形式。
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="toBase" /> 不是 2、8、10 或 16。
        /// </exception>
        [SecuritySafeCritical]
        public static string ToString(this long value, int toBase)
        {
            return Convert.ToString(value, toBase);
        }

        /// <summary>将 8 位无符号整数的数组转换为其用 Base64 数字编码的等效字符串表示形式。</summary>
        /// <param name="inArray">8 位无符号整数数组。</param>
        /// <returns>
        ///   <paramref name="inArray" /> 的内容的字符串表示形式，以 Base64 表示。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="inArray" /> 为 <see langword="null" />。
        /// </exception>
        public static string ToBase64String(this byte[] inArray)
        {
            if (inArray == null)
                throw new ArgumentNullException(nameof(inArray));
            return Convert.ToBase64String(inArray, 0, inArray.Length, Base64FormattingOptions.None);
        }

        /// <summary>
        ///   将 8 位无符号整数的数组转换为其用 Base64 数字编码的等效字符串表示形式。
        ///    参数指定是否在返回值中插入分行符。
        /// </summary>
        /// <param name="inArray">8 位无符号整数数组。</param>
        /// <param name="options">
        ///   如果每 76 个字符插入一个分行符，则使用 <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" />，如果不插入分行符，则使用 <see cref="F:System.Base64FormattingOptions.None" />。
        /// </param>
        /// <returns>
        ///   <paramref name="inArray" /> 中元素的字符串表示形式，以 Base64 表示。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="inArray" /> 为 <see langword="null" />。
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="options" /> 不是有效的 <see cref="T:System.Base64FormattingOptions" /> 值。
        /// </exception>
        [ComVisible(false)]
        public static string ToBase64String(this byte[] inArray, Base64FormattingOptions options)
        {
            if (inArray == null)
                throw new ArgumentNullException(nameof(inArray));
            return Convert.ToBase64String(inArray, 0, inArray.Length, options);
        }

        /// <summary>
        ///   将 8 位无符号整数数组的子集转换为其用 Base64 数字编码的等效字符串表示形式。
        ///    参数将子集指定为输入数组中的偏移量和数组中要转换的元素数。
        /// </summary>
        /// <param name="inArray">8 位无符号整数数组。</param>
        /// <param name="offset">
        ///   <paramref name="inArray" /> 中的偏移量。
        /// </param>
        /// <param name="length">
        ///   要转换的 <paramref name="inArray" /> 的元素数。
        /// </param>
        /// <returns>
        ///   <paramref name="length" /> 中从位置 <paramref name="inArray" /> 开始的 <paramref name="offset" /> 个元素的字符串表示形式，以 Base64 表示。
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="inArray" /> 为 <see langword="null" />。
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="offset" /> 或 <paramref name="length" /> 为负数。
        ///
        ///   - 或 -
        ///
        ///   <paramref name="offset" /> 加上 <paramref name="length" /> 大于 <paramref name="inArray" /> 的长度。
        /// </exception>
        public static string ToBase64String(this byte[] inArray, int offset, int length)
        {
            return Convert.ToBase64String(inArray, offset, length, Base64FormattingOptions.None);
        }
    }
}