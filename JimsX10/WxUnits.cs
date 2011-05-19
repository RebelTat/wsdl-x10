//============================================================================
//Weather Station Data Logger  Copyright © 2008, Weber Anderson
// 
//
//This application is free software; you can redistribute it and/or
//modify it under the terms of the GNU Lesser General Public
//License as published by the Free Software Foundation; either
//version 3 of the License, or (at your option) any later version.
//
//This application is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//Lesser General Public License for more details.
//
//You should have received a copy of the GNU Lesser General Public
//License along with this library; if not, see <http://www.gnu.org/licenses/>
//
//=============================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace JimsX10
{

    public enum TemperatureUnit { degC, degF };
    public enum TemperatureRateUnit { degC_per_hr, degC_per_min, degF_per_hr, degF_per_min };
    public enum SpeedUnit
    {
        m_per_sec, km_per_hr, knot, mi_per_hr, ft_per_sec,
        mm_per_hr, mm_per_day, in_per_hr, in_per_day
    };
    public enum LengthUnit { m, km, cm, mm, ins, ft, mi, nm };
    public enum PressureUnit { mb, inHg, psi, hPa };
    public enum PressureRateUnit { mb_per_hr, inHg_per_hr, psi_per_hr, hPa_per_hr };
    public enum AngleFormat { DDdddd, DDMMSS, DDMMmm };
    public enum AngleKind { Latitude, Longitude };

    /// <summary>
    /// A group of units sufficient to describe all the weather display data.
    /// </summary>
    public struct WxUnits
    {
        public bool UseLocalTime;
        public int UtcOffset;
        public TemperatureUnit Temperature;
        public TemperatureRateUnit TemperatureRate;
        public PressureUnit Pressure;
        public SpeedUnit Wind;
        public LengthUnit Rain;
        public SpeedUnit RainRate;

        public static bool operator ==(WxUnits x, WxUnits y)
        {
            bool same = x.Pressure == y.Pressure && x.Rain == y.Rain && x.RainRate == y.RainRate &&
                x.Temperature == y.Temperature && x.TemperatureRate == y.TemperatureRate &&
                x.Wind == y.Wind && x.UseLocalTime == y.UseLocalTime;
            if (!x.UseLocalTime)
            {
                same = same && x.UtcOffset == y.UtcOffset;
            }
            return same;
        }
        public static bool operator !=(WxUnits x, WxUnits y)
        {
            bool different = x.Pressure != y.Pressure || x.Rain != y.Rain || x.RainRate != y.RainRate ||
                x.Temperature != y.Temperature || x.TemperatureRate != y.TemperatureRate ||
                x.Wind != y.Wind || x.UseLocalTime != y.UseLocalTime;
            if (!x.UseLocalTime)
            {
                different = different || x.UtcOffset != y.UtcOffset;
            }
            return different;
        }
        public override bool Equals(object obj)
        {
            return (WxUnits)obj == this;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static WxUnits Default
        {
            get
            {
                if (System.Globalization.CultureInfo.CurrentCulture.Name == "en-US")
                {
                    return English;
                }
                else
                {
                    return Metric;
                }
            }
        }

        public static WxUnits Metric
        {
            get
            {
                WxUnits u = new WxUnits();
                u.Temperature = TemperatureUnit.degC;
                u.TemperatureRate = TemperatureRateUnit.degC_per_hr;
                u.Pressure = PressureUnit.mb;
                u.Wind = SpeedUnit.m_per_sec;
                u.Rain = LengthUnit.mm;
                u.RainRate = SpeedUnit.mm_per_hr;
                u.UtcOffset = 0;
                u.UseLocalTime = true;
                return u;
            }
        }

        public static WxUnits English
        {
            get
            {
                WxUnits u = new WxUnits();
                u.Temperature = TemperatureUnit.degF;
                u.TemperatureRate = TemperatureRateUnit.degF_per_hr;
                u.Pressure = PressureUnit.inHg;
                u.Wind = SpeedUnit.mi_per_hr;
                u.Rain = LengthUnit.ins;
                u.RainRate = SpeedUnit.in_per_hr;
                u.UtcOffset = 0;
                u.UseLocalTime = true;
                return u;
            }
        }

        public static WxUnits Parse(string s, CultureInfo ci)
        {
            WxUnits u = Default;
            char[] csvDelims = ci.TextInfo.ListSeparator.ToCharArray(); 
            string[] fields = s.Split(csvDelims);
            if (fields.Length != 8) return u;

            try
            {                
                //
                // the first field is the time zone. For fixed UTC offsets, this field is numeric (integer).
                // for local time zones, the field is text and will not begin with a numeric character.
                // we do not attempt to discern which local time zone is in use -- only that one specified.
                //
                char c = fields[0][0];
                if (char.IsDigit(c) || c == '-' || c == '+')
                {
                    u.UtcOffset = int.Parse(fields[0],ci);
                    u.UseLocalTime = false;
                }
                else
                {
                    u.UtcOffset = 0;
                    u.UseLocalTime = true;
                }
                u.Temperature = (TemperatureUnit)Enum.Parse(typeof(TemperatureUnit), fields[1], true);
                u.TemperatureRate = (TemperatureRateUnit)Enum.Parse(typeof(TemperatureRateUnit), fields[2], true);
                u.Pressure = (PressureUnit)Enum.Parse(typeof(PressureUnit), fields[3], true);                
                u.Wind = (SpeedUnit)Enum.Parse(typeof(SpeedUnit), fields[4], true);                
                u.Rain = (LengthUnit)Enum.Parse(typeof(LengthUnit), fields[5], true);
                u.RainRate = (SpeedUnit)Enum.Parse(typeof(SpeedUnit), fields[6], true);
                // we don't parse UV units as of now...
            }
            catch { }

            return u;
        }

        public override string ToString()
        {
            return ToString(CultureInfo.InvariantCulture);
        }

        public string ToString(CultureInfo ci)
        {
            string tz;
            if (UseLocalTime)
            {
                tz = WxDateUnit.TimeZoneName(true, 0);
            }
            else
            {
                tz = UtcOffset.ToString(ci);
            }
            string sep = ci.TextInfo.ListSeparator;

            return string.Format(CultureInfo.InvariantCulture,
                "{0}{8}{1}{8}{2}{8}{3}{8}{4}{8}{5}{8}{6}{8}{7}",
                tz, Temperature.ToString(), 
                TemperatureRate.ToString(),
                Pressure.ToString(), Wind.ToString(), 
                Rain.ToString(), RainRate.ToString(),
                "", sep);
        }

    }

    // The following classes provide unit conversion and string formatting for the 
    // various units used in the weather display. Some units (such as speed) will
    // have more than one set of formatting routines. For example, speed is used for 
    // both rainfall rate and wind speed -- each of these has different formatting 
    // needs.

    //
    // ***** TEMPERATURE *****
    //

    public class WxTemperatureUnit
    {
        private static string[] mUnitStrings = { "\x00B0C", "\x00B0F" };

        // resolution for logging and display. separate arrays are suggested for different end uses
        // these are stored here to make it easier to add units w/o causing bugs
        #region Formating

        private static string[] mLogFmt = { "0.00", "0.00" };
        private static string[] mDspFmt = { "0.0", "0.0" };

        public static string LogString(double Value, TemperatureUnit Unit, CultureInfo Culture)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mLogFmt[(int)Unit], Culture);
        }
        public static string LogString(double Value, TemperatureUnit FromUnit, TemperatureUnit ToUnit, CultureInfo Culture)
        {
            return LogString(Convert(Value, FromUnit, ToUnit), ToUnit, Culture);
        }
        public static string DspString(double Value, TemperatureUnit Unit)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mDspFmt[(int)Unit], CultureInfo.CurrentCulture);
        }
        public static string DspString(double Value, TemperatureUnit FromUnit, TemperatureUnit ToUnit)
        {
            return DspString(Convert(Value, FromUnit, ToUnit), ToUnit);
        }

        #endregion

        public static string ToString(TemperatureUnit Unit)
        {
            return mUnitStrings[(int)Unit];
        }

        public static double Convert(double Value, TemperatureUnit FromUnit, TemperatureUnit ToUnit)
        {
            if (FromUnit == ToUnit || double.IsNaN(Value)) return Value;
            double result;
            switch (FromUnit)
            {
                case TemperatureUnit.degC:
                    result = Value * 1.8 + 32.0;
                    break;
                case TemperatureUnit.degF:
                    result = (Value - 32.0) / 1.8;
                    break;
                default:
                    throw new InvalidOperationException("Convert: Illegal Temperature Unit");
            }
            return result;
        }
    }

    //
    // ***** TEMPERATURE RATE *****
    //

    public class WxTemperatureRateUnit
    {
        private static string[] mUnitStrings = { "\x00B0C/hr", "\x00B0C/min", "\x00B0F/hr", "\x00B0F/min" };
        //
        // resolution for logging and display. separate arrays are suggested for different end uses
        // these are stored here to make it easier to add units w/o causing bugs
        //
        #region Formating for temperature rate

        private static string[] mLogFmt = { "0.00", "0.0000", "0.00", "0.0000" };
        private static string[] mDspFmt = { "0.0", "0.00", "0.0", "0.00" };

        public static string LogString(double Value, TemperatureRateUnit Unit, CultureInfo Culture)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mLogFmt[(int)Unit], Culture);
        }
        public static string LogString(double Value, TemperatureRateUnit FromUnit, TemperatureRateUnit ToUnit, CultureInfo Culture)
        {
            return LogString(Convert(Value, FromUnit, ToUnit), ToUnit, Culture);
        }
        public static string DspString(double Value, TemperatureRateUnit Unit)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mDspFmt[(int)Unit], CultureInfo.CurrentCulture);
        }
        public static string DspString(double Value, TemperatureRateUnit FromUnit, TemperatureRateUnit ToUnit)
        {
            return DspString(Convert(Value, FromUnit, ToUnit), ToUnit);
        }

        #endregion

        public static string ToString(TemperatureRateUnit Unit)
        {
            return mUnitStrings[(int)Unit];
        }

        // in order of units (C/hr, C/min, F/hr, F/min), these are the multipliers
        // required to convert 1 degC/hr into each of the four units.        
        private static double[] mRatios = { 1, 1.0 / 60.0, 1.8, 1.8 / 60.0 };

        public static double Convert(double Value, TemperatureRateUnit FromUnit, TemperatureRateUnit ToUnit)
        {
            // it would be faster to create a 4-by-4 table with each conversion constant,
            // but this is much easier. 
            if (FromUnit == ToUnit || double.IsNaN(Value)) return Value;
            // first, convert the unit to meters-per-sec
            double rate = Value / mRatios[(int)FromUnit];
            // now, convert to the desired unit
            return rate * mRatios[(int)ToUnit];
        }
    }

    //
    // ***** SPEED *****
    //

    // seems a bit odd perhaps, but units commonly used to measure both
    // wind speed and rain rate are all thrown in together here. 

    public class WxSpeedUnit
    {

        private static string[] mUnitStrings = { 
            "m/s", "km/h", "KT", "MPH", "ft/s", 
            "mm/h", "mm/day", "in/hr", "in/day" };

        // resolution for logging and display. separate arrays are suggested for different end uses
        // these are stored here to make it easier to add units w/o causing bugs
        //

        #region Formating for wind speed
        // some of these values are dont-care since they won't be used for wind speed.
        private static string[] mWindLogFmt = { "0.00", "0.00", "0.00", "0.00", "0.00", "0", "0", "0", "0" };
        private static string[] mWindDspFmt = { "0.0", "0.0", "0.0", "0.0", "0.0", "0", "0", "0", "0" };

        public static string WindLogString(double Value, SpeedUnit Unit, CultureInfo Culture)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mWindLogFmt[(int)Unit],Culture);
        }
        public static string WindLogString(double Value, SpeedUnit FromUnit, SpeedUnit ToUnit, CultureInfo Culture)
        {
            return WindLogString(Convert(Value, FromUnit, ToUnit), ToUnit, Culture);
        }
        public static string WindDspString(double Value, SpeedUnit Unit)
        {
            if (double.IsNaN(Value)) return "";
            string fmt = (Value >= 9.4999) ? "0" : "0.0";
            return Value.ToString(fmt,CultureInfo.CurrentCulture);
        }
        public static string WindDspString(double Value, SpeedUnit FromUnit, SpeedUnit ToUnit)
        {
            return WindDspString(Convert(Value, FromUnit, ToUnit), ToUnit);
        }
        #endregion

        #region Formating for rain rate

        // values for rain rates -- again some values are don't care
        private static string[] mRainLogFmt = { "0", "0", "0", "0", "0", "0.00", "0.0", "0.000", "0.00" };
        private static string[] mRainDspFmt = { "0", "0", "0", "0", "0", "0.0", "0", "0.00", "0.0" };

        public static string RainLogString(double Value, SpeedUnit Unit, CultureInfo Culture)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mRainLogFmt[(int)Unit],Culture);
        }
        public static string RainLogString(double Value, SpeedUnit FromUnit, SpeedUnit ToUnit, CultureInfo Culture)
        {
            return RainLogString(Convert(Value, FromUnit, ToUnit), ToUnit, Culture);
        }
        public static string RainDspString(double Value, SpeedUnit Unit)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mRainDspFmt[(int)Unit],CultureInfo.CurrentCulture);
        }
        public static string RainDspString(double Value, SpeedUnit FromUnit, SpeedUnit ToUnit)
        {
            return RainDspString(Convert(Value, FromUnit, ToUnit), ToUnit);
        }

        #endregion

        public static string ToString(SpeedUnit Unit)
        {
            return mUnitStrings[(int)Unit];
        }

        // in order of units 
        // (m/s, km/hr, nm/hr, mi/hr, ft/sec, mm_per_hr, mm_per_day, in_per_hr, in_per_day),
        // these are the multipliers
        // required to convert 1 m/s into each of the five units.
        private static double[] mRatios = { 
            1, 3.6, 1.94383916052, 2.23693181818, 3.28083333333,
            3.6e6, 24*3.6e6, 39.37*3600, 39.37*3600*24
        };

        public static double Convert(double Value, SpeedUnit FromUnit, SpeedUnit ToUnit)
        {
            // it would be faster to create a 5-by-5 table with each conversion constant,
            // but this is much easier. 
            if (FromUnit == ToUnit || double.IsNaN(Value)) return Value;
            // first, convert the unit to meters-per-sec
            double m_per_sec = Value / mRatios[(int)FromUnit];
            // now, convert to the desired unit
            return m_per_sec * mRatios[(int)ToUnit];
        }

    }

    //
    // ***** PRESSURE *****
    //


    public class WxPressureUnit
    {
        private static string[] mUnitStrings = { "mb", "inHg", "psi", "hPa" };

        // resolution for logging and display. separate arrays are suggested for different end uses
        // these are stored here to make it easier to add units w/o causing bugs
        //

        #region Formating for barometric pressure

        private static string[] mLogFmt = { "0.00", "0.000", "0.000", "0.00" };
        private static string[] mDspFmt = { "0.0", "0.00", "0.00", "0.0" };

        public static string LogString(double Value, PressureUnit Unit, CultureInfo Culture)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mLogFmt[(int)Unit],Culture);
        }
        public static string LogString(double Value, PressureUnit FromUnit, PressureUnit ToUnit, CultureInfo Culture)
        {
            return LogString(Convert(Value, FromUnit, ToUnit), ToUnit, Culture);
        }
        public static string DspString(double Value, PressureUnit Unit)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mDspFmt[(int)Unit],CultureInfo.CurrentCulture);
        }
        public static string DspString(double Value, PressureUnit FromUnit, PressureUnit ToUnit)
        {
            return DspString(Convert(Value, FromUnit, ToUnit), ToUnit);
        }

        #endregion

        public static string ToString(PressureUnit Unit)
        {
            return mUnitStrings[(int)Unit];
        }

        // in order of units (mb, inHg, psi), these are the multipliers
        // required to convert 1 mb into each of the three units.
        // calculated from 1 atm = 1013.25026 mb = 760 mmHg = 14.6959409 psi == 1013.25026hPa.
        private static double[] mRatios = { 1, 0.029529981, 0.014503763, 1.0 };

        public static double Convert(double Value, PressureUnit FromUnit, PressureUnit ToUnit)
        {
            // it would be faster to create a 5-by-5 table with each conversion constant,
            // but this is much easier. 
            if (FromUnit == ToUnit || double.IsNaN(Value)) return Value;
            // first, convert the unit to meters-per-sec
            double mb = Value / mRatios[(int)FromUnit];
            // now, convert to the desired unit
            return mb * mRatios[(int)ToUnit];
        }
    }

    public class WxPressureRateUnit
    {
        // WARNING: for now, it is expected these units are exactly equal to the WxPressureUnit
        // strings except for being divided by one hour. That way, it is easy to re-cast the
        // pressure unit into a pressure rate unit and vice versa.
        private static string[] mUnitStrings = { "mb/hr", "inHg/hr", "psi/hr", "hPa/hr" };

        // resolution for logging and display. separate arrays are suggested for different end uses
        // these are stored here to make it easier to add units w/o causing bugs
        //

        #region Formating for barometric pressure

        private static string[] mLogFmt = { "0.000", "0.0000", "0.0000", "0.000" };
        private static string[] mDspFmt = { "0.00", "0.000", "0.000", "0.00" };

        public static string LogString(double Value, PressureRateUnit Unit, CultureInfo Culture)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mLogFmt[(int)Unit], Culture);
        }
        public static string LogString(double Value, PressureRateUnit FromUnit, PressureRateUnit ToUnit, CultureInfo Culture)
        {
            return LogString(Convert(Value, FromUnit, ToUnit), ToUnit, Culture);
        }
        public static string DspString(double Value, PressureRateUnit Unit)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mDspFmt[(int)Unit],CultureInfo.CurrentCulture);
        }
        public static string DspString(double Value, PressureRateUnit FromUnit, PressureRateUnit ToUnit)
        {
            return DspString(Convert(Value, FromUnit, ToUnit), ToUnit);
        }

        #endregion

        public static string ToString(PressureRateUnit Unit)
        {
            return mUnitStrings[(int)Unit];
        }
        // same as for pressure units...
        // in order of units (mb, inHg, psi, hPa), these are the multipliers
        // required to convert 1 mb into each of the three units.
        // calculated from 1 atm = 1013.25026 mb = 760 mmHg = 14.6959409 psi == 1013.25026hPa.
        private static double[] mRatios = { 1.0, 0.029529981, 0.014503763, 1.0 };

        public static double Convert(double Value, PressureRateUnit FromUnit, PressureRateUnit ToUnit)
        {
            // it would be faster to create a 5-by-5 table with each conversion constant,
            // but this is much easier. 
            if (FromUnit == ToUnit || double.IsNaN(Value)) return Value;
            // first, convert the unit to meters-per-sec
            double mb = Value / mRatios[(int)FromUnit];
            // now, convert to the desired unit
            return mb * mRatios[(int)ToUnit];
        }
    }



    //
    // ***** LENGTH *****
    //

    public class WxLengthUnit
    {
        private static string[] mUnitStrings = { 
         "m", "km", "cm", "mm", "in", "ft", "mi", "nm" };

        // resolution for logging and display. separate arrays are suggested for different end uses
        // these are stored here to make it easier to add units w/o causing bugs

        #region Formating for rainfall measurements

        // for now, length is only used for rainfall so many units are don't care values
        // 
        private static string[] mRainLogFmt = { "0", "0", "0.00", "0.0", "0.000", "0.0000", "0" };
        private static string[] mRainDspFmt = { "0", "0", "0.0", "0", "0.00", "0.000", "0" };

        public static string RainLogString(double Value, LengthUnit Unit, CultureInfo Culture)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mRainLogFmt[(int)Unit], Culture);
        }
        public static string RainLogString(double Value, LengthUnit FromUnit, LengthUnit ToUnit, CultureInfo Culture)
        {
            return RainLogString(Convert(Value, FromUnit, ToUnit), ToUnit, Culture);
        }
        public static string RainDspString(double Value, LengthUnit Unit)
        {
            if (double.IsNaN(Value)) return "";
            return Value.ToString(mRainDspFmt[(int)Unit], CultureInfo.CurrentCulture);
        }
        public static string RainDspString(double Value, LengthUnit FromUnit, LengthUnit ToUnit)
        {
            return RainDspString(Convert(Value, FromUnit, ToUnit), ToUnit);
        }

        #endregion

        public static string ToString(LengthUnit Unit)
        {
            return mUnitStrings[(int)Unit];
        }

        // in order of units ( m, km, cm, mm, ins, ft, mi, nm), these are the multipliers
        // required to convert 1 m into each of these units.
        private static double[] mRatios = { 
            1, 0.001, 100, 1000, 39.37, 39.37/12, 39.37/(12*5280), 39.37/(12*6076.12) };

        public static double Convert(double Value, LengthUnit FromUnit, LengthUnit ToUnit)
        {
            // it would be faster to create a 5-by-5 table with each conversion constant,
            // but this is much easier. 
            if (FromUnit == ToUnit || double.IsNaN(Value)) return Value;
            // first, convert the unit to meters-per-sec
            double mb = Value / mRatios[(int)FromUnit];
            // now, convert to the desired unit
            return mb * mRatios[(int)ToUnit];
        }
    }

    //
    // ***** DATE/TIME *****
    //

    public class WxDateUnit
    {
        // this class provides no formating since that is extremely variable amongst clients.

        private static long oneDayOfTicks = 10000000L * 3600L * 24L;

        public static DateTime Convert(DateTime Value, bool FromIsLocal, int FromUtcOffset, bool ToIsLocal, int ToUtcOffset)
        {
            if (Value.Ticks < oneDayOfTicks) return Value;
            if (FromIsLocal && ToIsLocal) return Value;
            if (!FromIsLocal && !ToIsLocal && (FromUtcOffset == ToUtcOffset)) return Value;

            DateTime utc = FromIsLocal ? Value.ToUniversalTime() : Value - new TimeSpan(FromUtcOffset, 0, 0);

            return ToIsLocal ? utc.ToLocalTime() : utc + new TimeSpan(ToUtcOffset, 0, 0);
        }

        public static string TimeZoneName(bool UseLocalTime, int UtcOffset)
        {
            string s;
            if (UseLocalTime)
            {
                s = TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now) ?
                    TimeZone.CurrentTimeZone.DaylightName : TimeZone.CurrentTimeZone.StandardName;
            }
            else
            {
                s = "UTC";
                if (UtcOffset > 0)
                {
                    s += "+" + UtcOffset.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    if (UtcOffset < 0)
                    {
                        s += "-" + UtcOffset.ToString(CultureInfo.InvariantCulture);
                    }
                }
            }
            return s;
        }

        public static string ShortTimeZoneName(bool UseLocalTime, int UtcOffset)
        {
            string s = TimeZoneName(UseLocalTime, UtcOffset);
            if (UseLocalTime)
            {
                // remove all lower case letters and white space from the string.
                string t = "";
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (char.IsLower(c) || char.IsWhiteSpace(c)) continue;
                    t += c;
                }
                s = t;
            }
            return s;
        }

    }

    public class WxAngleUnit
    {
        const double oneSixtieth = 1.0 / 60.0;

        public static double From_ddmmss(int Degrees, int Minutes, double Seconds)
        {
            int sign = (Degrees < 0) ? -1 : 1;
            Degrees = Math.Abs(Degrees);
            return sign * (Degrees + (Minutes + oneSixtieth * Seconds) * oneSixtieth);
        }

        public static double From_ddmmhh(int Degrees, int Minutes, double Hundredths)
        {
            int sign = (Degrees < 0) ? -1 : 1;
            Degrees = Math.Abs(Degrees);
            return sign * (Degrees + oneSixtieth * (Minutes + 0.01 * Hundredths));
        }

        public static void To_ddmmss(double Angle, out int Degrees, out int Minutes, out int Seconds)
        {
            int sign = (Angle < 0.0) ? -1 : 1;
            double a = Math.Abs(Angle);
            Degrees = (int)Math.Floor(a);
            double rem = 60.0 * (a - Degrees);
            Minutes = (int)Math.Floor(rem);
            Seconds = (int)Math.Round(60.0 * (rem - Minutes));
            if (Seconds >= 60)
            {
                Seconds -= 60;
                if (++Minutes >= 60)
                {
                    Minutes -= 60;
                    Degrees++;
                }
            }
            Degrees *= sign;
        }

        public static void To_ddmmhh(double Angle, out int Degrees, out int Minutes, out int Hundredths)
        {
            int sign = (Angle < 0.0) ? -1 : 1;
            double a = Math.Abs(Angle);
            Degrees = (int)Math.Floor(a);
            double rem = 60.0 * (a - Degrees);
            Minutes = (int)Math.Floor(rem);
            Hundredths = (int)Math.Round(100.0 * (rem - Minutes));
            if (Hundredths >= 100)
            {
                Hundredths -= 100;
                if (++Minutes >= 60)
                {
                    Minutes -= 60;
                    Degrees++;
                }
            }
            Degrees *= sign;
        }

        public static string ToString(double Angle, AngleKind Kind, AngleFormat Format)
        {
            string degFmt;
            char sign;
            switch (Kind)
            {
                case AngleKind.Latitude:
                    degFmt = "00";
                    sign = (Angle < 0.0) ? 'S' : 'N';
                    break;
                case AngleKind.Longitude:
                default:
                    degFmt = "000";
                    sign = (Angle < 0.0) ? 'W' : 'E';
                    break;
            }
            string s = ToString(Math.Abs(Angle), Format, degFmt) + sign;
            return s;
        }

        public static string ToString(double Angle)
        {
            return ToString(Angle, AngleFormat.DDMMSS, "0");
        }

        public static string ToString(double Angle, AngleFormat Format, string DegreeFormat)
        {
            double absA = Math.Abs(Angle);
            int deg = (int)Math.Floor(absA);
            double rem = 60.0 * (absA - deg);
            int min = (int)Math.Floor(rem);
            rem -= min;
            int hhss;
            string s = (Angle < 0.0) ? "-" : "";

            switch (Format)
            {
                case AngleFormat.DDMMmm:
                    hhss = (int)Math.Round(100.0 * rem);
                    if (hhss >= 100)
                    {
                        hhss -= 100;
                        min++;
                    }
                    break;
                case AngleFormat.DDMMSS:
                default:
                    hhss = (int)Math.Round(60.0 * rem);
                    if (hhss >= 60)
                    {
                        hhss -= 60;
                        min++;
                    }
                    break;
            }
            if (min >= 60)
            {
                min -= 60;
                deg++;
            }

            s += deg.ToString(DegreeFormat,CultureInfo.CurrentCulture) + min.ToString("00",CultureInfo.CurrentCulture);
            if (Format == AngleFormat.DDMMmm)
            {
                s += ".";
            }
            s += hhss.ToString("00",CultureInfo.CurrentCulture);
            return s;
        }

    }
}
