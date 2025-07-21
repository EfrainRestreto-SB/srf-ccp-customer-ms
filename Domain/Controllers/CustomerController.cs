
namespace Controllers
{
    public class CustomerController
    {
        public class CreateCustomerOutDto
        {
            public Guid Id;
            public string FullName;
            public string Document;
            public string State;
        }
    }
}