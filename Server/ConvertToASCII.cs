using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ConvertToASCII
    {
        public static string ConvertStringToASCII(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    result.Append(strFormD[i]);
                }
            }
            result = result.Replace('Đ', 'D');
            result = result.Replace('đ', 'd');
            result = result.Replace(" ", "");
            return (result.ToString().Normalize(NormalizationForm.FormD));
        }
    }
}
