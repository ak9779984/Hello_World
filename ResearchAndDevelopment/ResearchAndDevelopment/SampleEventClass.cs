﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndDevelopment
{
    public class SampleEventClass
    {
        public delegate void StringValueChangeDelegate();

        public event StringValueChangeDelegate StringValueChanged;

        string _strValue;

        public string StrValue
        {
            get
            {
                return _strValue;
            }
            set
            {
                
                if (StringValueChanged != null && this._strValue != value)
                {
                    StringValueChanged();
                }
                _strValue = value;
                //Console.WriteLine(this._strValue);

            }
        }


    }
}
