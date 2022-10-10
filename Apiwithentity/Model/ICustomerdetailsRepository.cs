namespace Apiwithentity.Model
{
    public interface ICustomerdetailsRepository
    {
        List<Customerdetails> GetAllCustomerdetails();
        Customerdetails AddCustomerdetials(Customerdetails customerdetails);
        void DeleteCustomerdetails(int id);
        Customerdetails GetAllCustomerdetailsById(int id);
        Customerdetails UpdateCustomerdetails(Customerdetails customerdetails, int id);
    }
}
