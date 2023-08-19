namespace Task_4.Models
{
    public class CliensListcs
    {
       public List<Client> clients;

       public CliensListcs()
        {
            clients = new List<Client>()
            {

                new Client()
                {
                     Id = 100,
                     Login = "user1",
                    Email = "user1@example.com"
                },

                new Client()
                {
                    Id = 200,
                    Login = "user2",
                    Email = "user2@example.com"
                },

                new Client()
                 {
                    Id = 300,
                    Login = "user3",
                    Email = "user3@example.com"
                },
            };
        }

    }
}
