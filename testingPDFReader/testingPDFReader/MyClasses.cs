using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testingPDFReader
{
    public class MyClasses
    {
        public static string GetCompleteName(char _char, string _text)
        {
            string name = "";
            int position = 0;
            int _comma = 44;
            char comma = (char)_comma;
            for (int i = 0; i < _text.Length; i++)
            {
                if (i == 900)
                {
                    var a = i;
                }
                if (_text[i] == _char)
                {
                    position = i;

                    if((_text[i-1] == 'I') && (_text[i - 2] == 'N'))
                    {
                        position += 3;
                        while (_text[position] != comma)
                        {
                            name += _text[position];
                            position++;
                        }
                        return name;
                    }
                }
            }

            return name;
        }

        public static string FindString(int _from, int _to, string _searching, List<string> _list)
        {
            string _search = "";
            for (int i = _from; i <= _to; i++)
            {
                int x = 0;                
            }

            return _search;
        }

        public static string Search(string _searching, string _fullText)
        {
            string _search = "";
            var regex = new Regex(".*" + _searching + "(.*)");
            if (regex.IsMatch(_fullText.ToString()))
            {
                var myCapturedText = regex.Match(_fullText).Groups[1].Value;
                return _search = myCapturedText;
                //Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("Text {0} was not found",_searching);
            }
            return _search;
        }

        
        public static List<string> SearchAll(string _searching, string _fullText)
        {
            List<string> _searches = new List<string>();
            var regex = new Regex(".*" + _searching + "(.*)");
            if (regex.IsMatch(_fullText.ToString()))
            {
                MatchCollection myCapturedText = regex.Matches(_fullText);
               
                var matches = new string[myCapturedText.Count];
                for (int i = 0; i < matches.Length; i++)
                {
                    //matches[i] = myCapturedText[i].ToString();
                    _searches.Add(myCapturedText[i].ToString());
                }
                return _searches;
            }
            else
            {
                Console.WriteLine("Text was not found");
            }
            return _searches;


        }

        public static string GetMonth( string _fullText)
        {
            {
                String sourcestring = _fullText;
                Regex re = new Regex(@"MES(?:\r\n| )DE(?:\r\n| )(?:ENERO|FEBRERO|MARZO|ABRIL|MAYO|JUNIO|JULIO|AGOSTO|SEPTIEMBRE|OCTUBRE|NOVIEMBRE|DICIEMBRE)(?:\r\n| )20(\d{2}).(?:\r\n)");
                MatchCollection mc = re.Matches(sourcestring);
                int mIdx = 0;
                foreach (Match m in mc)
                {
                    for (int gIdx = 0; gIdx < m.Groups.Count; gIdx++)
                    {
                        Console.WriteLine("[{0}][{1}] = {2}", mIdx, re.GetGroupNames()[gIdx], m.Groups[gIdx].Value);
                        return m.Groups[gIdx].Value.ToString();
                    }
                    mIdx++;
                }
                return "";
            }



            //    var regex = new Regex(@"MES DE (?:ENERO|FEBRERO|MARZO|ABRIL|MAYO|JUNIO|JULIO|AGOSTO|SEPTIEMBRE|OCTUBRE|NOVIEMBRE|DICIEMBRE).* *.(\d{4})\.");
            //    if (regex.IsMatch(_fullText))
            //    {
            //        var myCapturedText = regex.Match(_fullText).Groups[1].Value;
            //        return myCapturedText.ToString();
            //        //Console.ReadLine(); 
            //    }
            //    else
            //    {
            //        Console.WriteLine("Text {0} was not found");
            //    }
            //    return "";
        }

        

        public static decimal GetImport(string _fullText)
        {
            List<string> _searches = new List<string>();
            var regex = new Regex("[0-9]{3,5},[0-9]{2}");
            if (regex.IsMatch(_fullText))
            {
                MatchCollection myCapturedText = regex.Matches(_fullText);

                var matches = new string[myCapturedText.Count];
                for (int i = 0; i < matches.Length; i++)
                {
                    matches[i] = myCapturedText[i].ToString();
                    _searches.Add(myCapturedText[i].ToString()); //.Replace((char)44, (char)46)
                }
                List<decimal> _results = new List<decimal>();
                foreach (string item in _searches)
                {
                    _results.Add(decimal.Parse(item, System.Globalization.NumberStyles.AllowDecimalPoint));
                }
                var a = Convert.ToString(_results.Max());
                return _results.Max();
            }
            return 0;
        }

        public static string GetOnlyMonth(string _month)
        {
            var x = 0;
            var month = "";
            while((_month[x] != (char)13)&&(_month[x] != (char)32))
            {
                month += _month[x];
                x++;
            }
            return month;
        }

        public static string GetOS(string _os, List<ObraSocial> ObrasSociales)
        {
            string os = "";

            foreach (var x in ObrasSociales)
            {
                if (x.strText == _os)
                {
                    return os = x.sigla;
                }
            }
            return os;
        }
        public class ObraSocial
        {
            public string strText { get; set; }
            public string sigla { get; set; }

            public ObraSocial(string _strText, string _sigla)
            {
                this.strText = _strText;
                this.sigla = _sigla;
            }
        }


        public static void formatSrt(List<string> _list)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Count() > 0)
                {
                    if (_list[i][_list[i].Count() - 1] == (char)13)
                    {
                        _list[i] = _list[i].Remove(_list[i].Count() - 1);
                    }
                    if (_list[i][0] == (char)10)
                    {
                        _list[i] = _list[i].Remove(0, 1);
                    }
                }
            }
        }


    }
}
