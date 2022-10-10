namespace Apiwithentity.Model
{
    public class CustomerdetailsSqlImpl : ICustomerdetailsRepository
    {

        private readonly ToplistDbContext _dbContext;
        public CustomerdetailsSqlImpl(ToplistDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Customerdetails AddCustomerdetials(Customerdetails customerdetails)
        {
            _dbContext.Customerdetails.Add(customerdetails);
            _dbContext.SaveChanges();
            return customerdetails;
        }

        public void DeleteCustomerdetails(int id)
        {
            Customerdetails customerdetails = GetAllCustomerdetailsById(id);
            _dbContext.Customerdetails.Remove(customerdetails);
            _dbContext.SaveChanges();
        }

        public List<Customerdetails> GetAllCustomerdetails()
        {
            return _dbContext.Customerdetails.ToList();
        }

        public Customerdetails GetAllCustomerdetailsById(int id)
        {
            return _dbContext.Customerdetails.FirstOrDefault(emp => emp.cid == id);
        }
        public Customerdetails UpdateCustomerdetails(Customerdetails customerdetails, int id)
        {
            Customerdetails saveBook = GetAllCustomerdetailsById(id);

            saveBook.Cname = customerdetails.Cname;
            saveBook.City = customerdetails.City;
            saveBook.Houseno = customerdetails.Houseno;
            saveBook.Pincode = customerdetails.Pincode;
            saveBook.Boktitle = customerdetails.Boktitle;
            saveBook.Price = customerdetails.Price;
            saveBook.Quantity = customerdetails.Quantity;
            saveBook.Totalprice = customerdetails.Totalprice;



            _dbContext.SaveChanges();
            return saveBook;
        }
    }
}
