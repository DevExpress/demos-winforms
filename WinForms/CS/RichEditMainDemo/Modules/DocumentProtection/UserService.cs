using System;
using System.Collections.Generic;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public class UserService : IUserListService {
        readonly List<string> _users = new List<string>();

        public List<string> Users { get { return _users; } }

        IList<string> IUserListService.GetUsers() {
            return Users;
        }
        public void Update(List<String> userList) {
            _users.Clear();
            _users.AddRange(userList);
        }
    }
}
