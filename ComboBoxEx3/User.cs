using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxEx3
{
    public class User : INotifyPropertyChanged
    {
        public int id { get; set; }
        public string username { get; set; }
        public string fisrt_name { get; set; }
        public string last_name { get; set; }
        public string _user_text { get; set; }
        public string user_text
        {
            get
            {

                return _user_text;
            }
            set
            {
                if (_user_text != value)
                {
                    _user_text = value;
                    RaisePropertyChanged("user_text");
                }
            }
        }

        private UserRole _user_role;  
        public UserRole user_role
        {
            get
            {

                return _user_role;
            }
            set
            {
                if (_user_role != value)
                {
                    _user_role = value;
                    RaisePropertyChanged("user_role");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
    }

    public class UserRole
    {
        public string id  { get; set; }

        public string name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is UserRole item &&
                   id == item.id;
        }
    }

    public class UserRoleManager
    {
        public static void GetUserRoleList(ObservableCollection<UserRole> userRoles)
        {
            var allItems = getUserRoles();
            userRoles.Clear();
            allItems.ForEach(p => userRoles.Add(p));
        }

        public static List<UserRole> getUserRoles()
        {
            var items = new List<UserRole>();

            items.Add(new UserRole() { id = "1", name = "admin" });
            items.Add(new UserRole() { id = "2", name = "customer" });

            return items;
        }
    }

    public class UserManager
    {
        public static void GetUserList(ObservableCollection<User> users)
        {
            var allItems = getUsers();
            users.Clear();
            allItems.ForEach(p => users.Add(p));
        }

        public static List<User> getUsers()
        {
            var items = new List<User>();

            items.Add(new User() { id = 1, username = "mohitp", fisrt_name="Mohit", last_name="Pandey" });
            items.Add(new User() { id = 2, username = "rickyp", fisrt_name = "Ricky", last_name = "Ponting" });

            return items;
        }
    }
}
