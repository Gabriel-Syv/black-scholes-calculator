using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Black_Scholes_Calculator
{
    class Option
    {
        public double strike;
        public double assetPrice;
        public double optionPrice;
        public double volatility;
        public double timeToExpiry;
        public double riskFreeRate;

        public DateTime valuationDate;
        public DateTime expiryDate;

        double N(double x)
        {
            return 0.5 * (1.0 + SpecialFunction.erf(x / Math.Sqrt(2.0)));
        }

        public void price()
        {
            double da, db;
            da = Math.Log(assetPrice / strike) + riskFreeRate * timeToExpiry;
            da /= (volatility * Math.Sqrt(timeToExpiry));
            db = 0.5 * volatility * Math.Sqrt(timeToExpiry);
            optionPrice = assetPrice * N(da + db) - strike * Math.Exp(-riskFreeRate * timeToExpiry) * N(da - db);
            //System.Windows.Forms.MessageBox.Show("da = " + da + "\n" +
            //    "db = " + db + "\nPrice = " + optionPrice);
        }

        public void implicitVolatility()
        {
            double tol = 0.001, diff;
            double vol0, vol = 0.4;

            double da, db, n1, n2, num, den;
            double norm = 1.0 / Math.Sqrt(2.0 * Math.PI);

            do
            {
                vol0 = vol;
                da = Math.Log(assetPrice / strike) + riskFreeRate * timeToExpiry;
                da /= (vol0 * Math.Sqrt(timeToExpiry));
                db = 0.5 * vol0 * Math.Sqrt(timeToExpiry);
                num = assetPrice * N(da + db)
                    - strike * Math.Exp(-riskFreeRate * timeToExpiry) * N(da - db)
                    - optionPrice;

                n1 = norm * Math.Exp(-0.5 * (da + db) * (da + db));
                n2 = norm * Math.Exp(-0.5 * (da - db) * (da - db));
                den = assetPrice * n1 * (da - db)
                    - Math.Exp(-riskFreeRate * timeToExpiry) * strike * n2 * (da + db);
                den /= vol0;

                vol = vol0 + num / den;
                diff = vol - vol0;
            }
            while (Math.Abs(diff) > tol);

            volatility = vol;
        }


    }
}
