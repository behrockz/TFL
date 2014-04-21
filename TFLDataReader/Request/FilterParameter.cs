using System;
using System.Linq;
using TFLDataReader.Data;

namespace TFLDataReader.Request
{
    public class FilterParameter : IRequestParameter
    {
        private readonly ReturnList returnList;

        public FilterParameter(ReturnList returnList)
        {
            this.returnList = returnList;
        }

        public object Value
        {
            get
            {
                var list = Enumerable.Range(0, Enum.GetNames(typeof (ReturnList)).Length)
                                     .Select(p => (ReturnList) Math.Pow(2, p))
                                     .Where(e => (returnList & e) == e);

                return string.Join(",", list);
            }
        }

        public string Name { get { return "ReturnList"; } }
    }
}