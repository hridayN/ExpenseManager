using static ExpenseManager.API.Enums.Enum;

namespace ExpenseManager.API.Utilites
{
    public class FilterQuery
    {
        public string PropertyName
        {
            get;
            set;
        }

        public FilterType FilterType
        {
            get;
            set;
        }

        public object PropertyValue
        {
            get;
            set;
        }

        public OperatorType OperatorType
        {
            get;
            set;
        }
    }
}
