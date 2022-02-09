using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ThanksCardClient.Services;

namespace WpfApp2.Models
{
    public class User : BindableBase
    {
        #region IdProperty
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        #endregion

        #region NameProperty
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }
        #endregion

        #region PasswordProperty
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }
        #endregion

        #region IsAdminProperty
        private bool _IsAdmin;
        public bool IsAdmin
        {
            get { return _IsAdmin; }
            set { SetProperty(ref _IsAdmin, value); }
        }
        #endregion

        #region DepartmentIdProperty
        private long? _DepartmentId;
        public long? DepartmentId
        {
            get { return _DepartmentId; }
            set { SetProperty(ref _DepartmentId, value); }
        }
        #endregion

        #region DepartmentProperty
        private Department _Department;
        public Department Department
        {
            get { return _Department; }
            set { SetProperty(ref _Department, value); }
        }
        #endregion

        public async Task<User> LogonAsync()
        {
            /* TODO: RestServic
            IRestService rest = new RestService();
            User authorizedUser = await rest.LogonAsync(this);
            return authorizedUser;
            */
            return null;
        }

        public async Task<List<User>> GetDepartmentUsersAsync(long? DepartmentId)
        {
            /* TODO: RestServic
            IRestService rest = new RestService();
            List<User> users = await rest.GetDepartmentUsersAsync(DepartmentId);
            return users;
            */
            return null;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            /* TODO: RestServic
            IRestService rest = new RestService();
            List<User> users = await rest.GetUsersAsync();
            return users;
            */
            return null;
        }

        public async Task<User> PostUserAsync(User user)
        {
            /* TODO: RestServic
            IRestService rest = new RestService();
            User createdUser = await rest.PostUserAsync(user);
            return createdUser;
            */
            return null;
        }

        public async Task<User> PutUserAsync(User user)
        {
            /* TODO: RestServic
            IRestService rest = new RestService();
            User updatedUser = await rest.PutUserAsync(user);
            return updatedUser;
            */
            return user;
        }

        public async Task<User> DeleteUserAsync(long Id)
        {
            /* TODO: RestServic
            IRestService rest = new RestService();
            User deletedUser = await rest.DeleteUserAsync(Id);
            return deletedUser;
            */
            return null;
        }
    }
}
