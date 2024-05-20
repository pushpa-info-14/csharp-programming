namespace CSharpProgramming.Study.DesignPatterns.Structural.Facade
{
    public class WithoutExample
    {
        public class Customer
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string MobileNumber { get; set; }
            public string Address { get; set; }
            // Any other Properties as per the Business Requirements
        }

        public class Validator
        {
            public bool ValidateCustomer(Customer customer)
            {
                // Need to Validate the Customer Object
                Console.WriteLine("Customer Validated...");
                Console.WriteLine($"Name:{customer.Name}");
                Console.WriteLine($"Email:{customer.Email}");
                Console.WriteLine($"Mobile:{customer.MobileNumber}");
                Console.WriteLine($"Address:{customer.Address}");
                return true;
            }
        }

        public class CustomerDataAccessLayer
        {
            public bool SaveCustomer(Customer customer)
            {
                // Save the Customer in the Database
                Console.WriteLine("\nCustomer Saved into the Database...");
                return true;
            }
        }

        public class Email
        {
            public bool SendRegistrationEmail(Customer customer)
            {
                //Send Registration Successful Email to Customer
                Console.WriteLine("\nRegistration Email Send to Customer...");
                return true;
            }
        }

        public void Test()
        {
            // Step1: Create an Instance of Customer Class
            var customer = new Customer()
            {
                Name = "Pranaya",
                Email = "info@dotnettutorials.net",
                MobileNumber = "1234567890",
                Address = "BBSR, Odisha, India"
            };

            // Step2: Validate the Customer
            Validator validator = new Validator();
            bool IsValid = validator.ValidateCustomer(customer);

            // Step3: Save the Customer Object into the database
            CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
            bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);

            // Step4: Send the Registration Email to the Customer
            var email = new Email();
            email.SendRegistrationEmail(customer);
        }
    }
}
