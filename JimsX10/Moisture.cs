//============================================================================
//Weather Station Data Logger  Copyright © 2008,2009 Weber Anderson, Jim Roal
//                             
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

namespace JimsX10
{    
    /// <summary>
    /// Provides for conversion between dew point and relative humidity.
    /// This is less than trivial. These algorithms are based on polynomial fits
    /// to published data (or fits to the log of published data).
    /// </summary>
    class Moisture
    {
        #region Member Variables
        // curve fit constants for the Buck fits.
        const double ew4a = 6.1121;
        const double ew4b = 18.729;
        const double ew4c = 257.87;
        const double ew4d = 227.3;
        const double ei3a = 6.1115;
        const double ei3b = 23.036;
        const double ei3c = 279.82;
        const double ei3d = 333.7;
        const double fw5a = 4.1e-4;
        const double fw5b = 3.48e-6;
        const double fw5c = 7.4e-10;
        const double fw5d = 30.6;
        const double fw5e = -3.8e-2;
        const double fi5a = 4.8e-4;
        const double fi5b = 3.47e-6;
        const double fi5c = 5.9e-10;
        const double fi5d = 23.8;
        const double fi5e = -3.1e-2;
        #endregion

        #region Public Methods

        public static double DewPoint(double DryBulbDegF, double RhPercent, double Pmb)
        {
            return DewPointBuck(DryBulbDegF, RhPercent, Pmb);
        }

        public static double RH(double DryBulbDegF, double DewPointDegF, double Pmb)
        {
            return RhBuck(DryBulbDegF, DewPointDegF, Pmb);
        }

        public static double rhoWaterSat(double TempDegF, double Pmb)
        {
            return rhoWaterSatBuck(TempDegF, Pmb);
        }

        public static double rhoIceSat(double TempDegF, double Pmb)
        {
            return rhoIceSatBuck(TempDegF, Pmb);
        }


        public static double HeatIndex(double DryBulbDegF, double RhPercent, double DewPF)
        {
            double T = DryBulbDegF;
            double Rh = RhPercent;
            // calculation from NOAA website http://www.crh.noaa.gov/jkl/?n=heat_index_calculator
            // error is +/- 1.3F
            // Valid entries are, air temperatures greater than 80 °F ( 27 °C ), 
            // dew point temperatures greater than 60 °F ( 16 °C ), and relative humidities higher than 40 percent.
            if (T > 75 && DewPF > 55 && Rh >= 40)
                T = -42.379 + 2.04901523 * T + 10.14333127 * Rh - 0.22475541 * T * Rh - 6.83783e-3 * Math.Pow(T, 2)
                - 5.481717e-2 * Math.Pow(Rh, 2.0) + 1.22874e-3 * Math.Pow(T, 2.0) * Rh + 8.5282e-4 * T * Math.Pow(Rh, 2.0)
                - 1.99e-6 * Math.Pow(T, 2.0) * Math.Pow(Rh, 2.0);
            return T;
        }

        public static double WindChill(double tempF, double windMPH)
        {
            // windchill calculation per NOAA
            //windchill=(35.74+0.6215*temp-35.75*Math.pow(wind,0.16)+0.4275*temp*Math.pow(wind,0.16));
            //windchillC= Math.round((windchill - 32) * .556) + " °C";
            //<!-- Wind Thresholds -->
            //windchill=((wind <= 3) || (wind >= 110 )) ? "Winds need to be above 3 MPH and below 110 MPH." : windchill;
            //<!-- Max Ambient Temperature Thresholds -->
            //windchill=((temp <= -50) || (temp >= 50)) ? "Temperatures need to be above -50 °F and below 50 °F": windchill;

            double windchill = tempF; // set to input temp in case parameters are outside ranges, then just echo the temp
            if ((tempF >= -50) && (tempF <= 50) && ((windMPH >= 3) && (windMPH <= 110)))
                windchill = (35.74 + 0.6215 * tempF - 35.75 * Math.Pow(windMPH, 0.16) + 0.4275 * tempF * Math.Pow(windMPH, 0.16));
            return windchill;
        }

        public static double AppTemp(double DryBulbDegC, double RhPercent, double WindSpeed)
        {
            double AT;
            double vp;
            double Ta = DryBulbDegC;
            double rh = RhPercent;
            double ws = WindSpeed;
            // calculates apparent temperature per http://www.bom.gov.au/info/thermal_stress/#wc
            // Ta = Dry bulb temperature (°C)
            // vp = Water vapour pressure (hPa) [humidity]
            // ws = Wind speed (m/s) at an elevation of 10 meters
            vp = (rh / 100) * 6.105 * Math.Exp(17.27 * Ta / (237.7 + Ta)); // vapor pressure
            AT = Ta + 0.33 * vp - 0.70 * ws - 4.0;

            return AT;
        }
        
        public static double AppTemp(double DryBulbDegC, double RhPercent, double WindSpeed, double Q)
        {
            double AT;
            double vp;
            double Ta = DryBulbDegC;
            double rh = RhPercent;
            double ws = WindSpeed;
            // calculates apparent temperature per http://www.bom.gov.au/info/thermal_stress/#wc
            // Version including the effects of temperature, humidity, wind, and radiation: 
            // Ta = Dry bulb temperature (°C)
            // vp = Water vapour pressure (hPa) [humidity]
            // ws = Wind speed (m/s) at an elevation of 10 meters
            // Q = Net radiation absorbed per unit area of body surface (w/m2) 
            vp = (rh / 100) * 6.105 * Math.Exp(17.27 * Ta / (237.7 + Ta)); // vapor pressure
            AT = Ta + 0.348 * vp - 0.70 * ws + 0.70 * Q / (ws + 10.0) - 4.25;

            return AT;
        }

#endregion

        #region Private Methods

        private static double DewPointSonntag(double DryBulbDegF, double RhPercent)
        {
            if (DryBulbDegF > 32.0)
            {
                double es = rhoWaterSatSonntag(DryBulbDegF) * 0.01 * RhPercent;
                double dp = tWaterSatSonntag(es);
                return dp;
            }
            else
            {
                double es = rhoIceSatSonntag(DryBulbDegF) * 0.01 * RhPercent;
                double fp = tIceSatSonntag(es);
                return fp;
            }
        }

        private static double RhSonntag(double DryBulbDegF, double DewPointDegF)
        {
            double psat, pdsat;
            if (DryBulbDegF > 32.0)
            {
                psat = rhoWaterSatSonntag(DryBulbDegF);
                pdsat = rhoWaterSatSonntag(DewPointDegF);
            }
            else
            {
                psat = rhoIceSatSonntag(DryBulbDegF);
                pdsat = rhoIceSatSonntag(DewPointDegF);
            }
            return 100.0 * (pdsat / psat);
        }

        private static double DewPointBuck(double DryBulbDegF, double RhPercent, double Pmb)
        {
            if (DryBulbDegF > 32.0)
            {
                double es = rhoWaterSatBuck(DryBulbDegF, Pmb) * 0.01 * RhPercent;
                double dp = tWaterSatBuck(es, Pmb);
                return dp;
            }
            else
            {
                double es = rhoIceSatBuck(DryBulbDegF, Pmb) * 0.01 * RhPercent;
                double fp = tIceSatBuck(es, Pmb);
                return fp;
            }
        }

        private static double RhBuck(double DryBulbDegF, double DewPointDegF, double Pmb)
        {
            double psat, pdsat;
            if (DryBulbDegF > 32.0)
            {
                psat = rhoWaterSatBuck(DryBulbDegF, Pmb);
                pdsat = rhoWaterSatBuck(DewPointDegF, Pmb);
            }
            else
            {
                psat = rhoIceSatBuck(DryBulbDegF, Pmb);
                pdsat = rhoIceSatBuck(DewPointDegF, Pmb);
            }
            return 100.0 * (pdsat / psat);
        }

        //
        // these were created by performing a polynomial fit on the inverse of the 
        // vapor pressure functions below in Matlab. For water, temperatures from 30 to 120
        // degF were used. For ice, temperatures from -60 to 35 degF were used. Return values
        // are in degF.
        //
        private static double tWaterSatSonntag(double rho_mb)
        {
            double[] C = { 0.00871569, -0.147721, 2.10294, 6.82125, -74.0727 };
            double x = Math.Log(100*rho_mb);
            double t = C[0];
            for (int i = 1; i < C.Length; i++)
            {
                t = t * x + C[i];
            }
            return t;
        }

        private static double tIceSatSonntag(double rho_mb)
        {
            double[] C = { 6.08428e-005, 0.000105638, 0.0181602, 0.447882, 13.2441, -77.03395 };
            double x = Math.Log(100*rho_mb);
            double t = C[0];
            for (int i = 1; i < C.Length; i++)
            {
                t = t * x + C[i];
            }
            return t;
        }

        // these formulas are from Sonntag, 1990 for computing saturation vapor pressure from temperature.
        // the return values are in units of mb.

        private static double rhoWaterSatSonntag(double TempDegF)
        {
            double[] C = { -6096.9385, 21.2409642, -2.711193e-2, 1.673952e-5 };
            double D = 2.433502;

            double K = (TempDegF - 32.0) / 1.8 + 273.15;
            double logRho = C[0] / K + C[1] + (C[2] + C[3] * K) * K + D * Math.Log(K);
            return 0.01 * Math.Exp(logRho);
        }

        private static double rhoIceSatSonntag(double TempDegF)
        {
            double[] C = { -6024.5282, 29.32707, 1.0613868e-2, -1.3198825e-5 };
            double D = -0.49382577;

            double K = (TempDegF - 32.0) / 1.8 + 273.15;
            double logRho = C[0] / K + C[1] + (C[2] + C[3] * K) * K + D * Math.Log(K);
            return 0.01 * Math.Exp(logRho);
        }

        //
        // This series of functions implement curve fits published by Arden L. Buck (NCAR)
        // in 1981. They are accurate over the normal range of usage to about 0.05%.
        //

        // returns pressure in mb
        private static double rhoWaterSatBuck(double TempDegF, double Pmb)
        {
            double degC = (TempDegF - 32) / 1.8;
            double f = Buck_fw_Eq5(degC, Pmb);
            return f * BuckEq4(degC, ew4a, ew4b, ew4c, ew4d);
        }
        // returns temperature in degF
        private static double tWaterSatBuck(double rho_mb, double Pmb)
        {
            // first get an estimate of the saturation temperature
            double that = BuckInvEq4(rho_mb, ew4a, ew4b, ew4c, ew4d);
            // use the estimate to get the enhancement factor
            double f = Buck_fw_Eq5(that, Pmb);
            // now get the temperature with enhancment factor applied.
            double degC = BuckInvEq4(rho_mb/f, ew4a, ew4b, ew4c, ew4d);
            return degC * 1.8 + 32.0;
        }
        // returns pressure in mb
        private static double rhoIceSatBuck(double TempDegF, double Pmb)
        {
            double degC = (TempDegF - 32) / 1.8;
            double f = Buck_fi_Eq5(degC, Pmb);
            return f * BuckEq4(degC, ei3a, ei3b, ei3c, ei3d);
        }
        // returns temperature in degF
        private static double tIceSatBuck(double rho_mb, double Pmb)
        {
            // first get an estimate of the saturation temperature
            double that = BuckInvEq4(rho_mb, ei3a, ei3b, ei3c, ei3d);
            // use the estimate to get the enhancement factor
            double f = Buck_fi_Eq5(that, Pmb);
            // now get the temperature with enhancment factor applied.
            double degC = BuckInvEq4(rho_mb / f, ei3a, ei3b, ei3c, ei3d);
            return degC * 1.8 + 32.0;
        }
        //
        // these formulas are curve fits from Buck and use units of degC and mb.
        //
        private static double BuckEq4(double t, double a, double b, double c, double d)
        {
            double exponent = (b - t / d) * t / (t + c);
            return a * Math.Exp(exponent);
        }
        //
        private static double BuckInvEq4(double rho, double a, double b, double c, double d)
        {
            double z = Math.Log(rho / a);
            double bmz = b - z;
            double sqrt = Math.Sqrt(bmz * bmz - 4.0 * c * z / d);
            double t = 0.5 * d * (bmz - sqrt);
            return t;
        }
        // t in degC, P is station pressure in mb
        private static double Buck_fw_Eq5(double t, double P)
        {
            return 1 + fw5a + P * (fw5b + fw5c * Math.Pow(t + fw5d + fw5e * P, 2.0));
        }
        //
        private static double Buck_fi_Eq5(double t, double P)
        {
            return 1 + fi5a + P * (fi5b + fi5c * Math.Pow(t + fi5d + fi5e * P, 2.0));
        }

        #endregion

    }
}
