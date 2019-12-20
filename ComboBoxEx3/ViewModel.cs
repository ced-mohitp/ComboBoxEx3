using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxEx3
{
    public class ViewModel : ViewModelBase
    {
        public ObservableCollection<UserRole> _UserRoleList = GetUserRoleCollection();

        public string _EditText;

        public string EditText 
        {
            get
            {

                return _EditText;
            }
            set
            {
                if (_EditText != value)
                {
                    _EditText = value;
                    RaisePropertyChanged("EditText");
                }
            }
        }


        public ObservableCollection<UserRole> UserRoleList
        {
            get
            {   
                
                return _UserRoleList;
            }
            set
            {
                if (_UserRoleList != value)
                {
                    _UserRoleList = value;
                    RaisePropertyChanged("UserRoleList");
                }
            }
        }

        private static ObservableCollection<UserRole>  GetUserRoleCollection()
        {
            ObservableCollection<UserRole> roles = new ObservableCollection<UserRole>();
            roles.Add(new UserRole() { id = "1", name = "admin" });
            roles.Add(new UserRole() { id = "2", name = "customer" });
            return roles; 
        }
    }
}
