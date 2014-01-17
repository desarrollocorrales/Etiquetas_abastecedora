using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Utilitarias
{
    public static class EAN13
    {
        public static string getCheckDigit(string barcode)
        {
            // Cálculo del dígito de control EAN
            int iSum = 0;
            int iSumInpar = 0;
            int iDigit = 0;
            string EAN = barcode;

            EAN = EAN.PadLeft(13, '0');

            for (int i = EAN.Length; i >= 1; i--)
            {
                iDigit = Convert.ToInt32(EAN.Substring(i - 1, 1));
                if (i % 2 != 0)
                {
                    iSumInpar += iDigit;
                }
                else
                {
                    iSum += iDigit;
                }
            }

            iDigit = (iSumInpar * 3) + iSum;

            int iCheckSum = (10 - (iDigit % 10)) % 10;
            return iCheckSum.ToString();
        }
    }
}
