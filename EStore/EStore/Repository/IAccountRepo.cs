using EStore.Model;

namespace EStore.Repository
{
    public interface IAccountRepo
    {
        public account CheckExist(account acc);
    }
}
