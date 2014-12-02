using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemplateOne.Data;

namespace TemplateOne
{
    static class GlobalData
    {
        private static Data.Data _data;

        public static Data.Data data
        {
            get
            {
                if (_data == null)
                    _data = new Data.Data();

                return _data;
            }
            set
            {
                _data = value;
            }
        }
    }
}
