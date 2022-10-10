namespace Apiwithentity.Model
{
    public interface IUserdetailsRepository
    {
        List<Userdetails> GetAllUserdetails();
        Userdetails AddUserdetials(Userdetails userdetails);
        void DeleteUserdetails(int id);
        Userdetails GetAllUserdetailsById(int id);
        Userdetails UpdateUserdetails(Userdetails userdetails, int id);

    }
}
