using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ComboBoxEx3
{
    public class RoleConverter : IValueConverter
    {
        public ObservableCollection<UserRole> Options { get; set; }
        public string RoleEditText { get; set; }
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            
            if (value != null && value.GetType().Equals(typeof(UserRole)))
            {
                return value;

            }

            if(RoleEditText.Length > 0)
            {
                var newItem = new UserRole() { id = RoleEditText, name = RoleEditText };

                if (Options != null && !Options.Contains(newItem))
                {
                    var x = newItem;
                    Options.Add(newItem);
                }
                return newItem;
            }

            return value; 
          
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value as UserRole;
        }
    }
}
