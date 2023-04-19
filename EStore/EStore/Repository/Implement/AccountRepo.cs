using EStore.Data;
using EStore.Model;

namespace EStore.Repository.Implement
{
    public class AccountRepo : IAccountRepo
    {
        private readonly DBConnect _dBConnect;

        public AccountRepo(DBConnect dBConnect)
        {
            _dBConnect  = dBConnect;
        }
        public account CheckExist(account acc)
        {
            var rs = _dBConnect.account.FirstOrDefault(
                x=>x.username == acc.username
                && x.password == acc.password
                && x.isAdmin == true
                );
            return rs;
        }
    }
}
