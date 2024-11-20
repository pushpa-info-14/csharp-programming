namespace CSharpProgramming.Study.DesignPatterns.Structural.Proxy
{
    public class ProtectionProxyFolderProxyProgram
    {
        public class Employee
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
            public Employee(string username, string password, string role)
            {
                Username = username;
                Password = password;
                Role = role;
            }
        }

        // The Subject interface declares common operations for both RealSubject and the Proxy. 
        // As long as the client works with RealSubject using this interface, 
        // you will be able to pass it a proxy instead of a real subject.
        public interface ISharedFolder
        {
            void PerformReadWriteOperations();
        }

        // The RealSubject contains some core business logic. 
        // Usually, RealSubjects are capable of doing some useful work which may be very slow or sensitive 
        // A Proxy can solve these issues without any changes to the RealSubject's code.
        public class SharedFolder : ISharedFolder
        {
            public void PerformReadWriteOperations()
            {
                Console.WriteLine("Performing Read Write operation on the Shared Folder");
            }
        }

        // The Proxy has an interface identical to the RealSubject.
        class SharedFolderProxy : ISharedFolder
        {
            private ISharedFolder _folder;
            private readonly Employee _employee;
            public SharedFolderProxy(Employee emp)
            {
                _employee = emp;
            }
            public void PerformReadWriteOperations()
            {
                if (_employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "MANAGER")
                {
                    _folder = new SharedFolder();
                    Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                    _folder.PerformReadWriteOperations();
                }
                else
                {
                    Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
                }
            }
        }

        public void Test()
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            var emp1 = new Employee("Anurag", "Anurag123", "Developer");
            var folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformReadWriteOperations();
            Console.WriteLine();

            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            var emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            var folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformReadWriteOperations();
        }
    }
}
