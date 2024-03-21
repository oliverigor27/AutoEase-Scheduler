using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;
using Autoease.Domain.ValueObjects;

public class CreateUser : ICreateUser
{
        private static List<User> users = new List<User>
        {
            new User(
                userCPF: "45698723651",
                username: "JohnDoe",
                email: "johndoe@gmail.com",
                password: "Abc@270598",
                name: "John",
                lastName: "Doe",
                address: new Address(
                    street: "123 Main Street",
                    houseNumber: 5,
                    city: "Anytown",
                    state: "ST",
                    coutry: "USA",
                    zipcode: "12345"
                )
            )
        };
    public List<User> GetAllUsers()
    {
        return users;
    }

    public User Create(User user)
    {
        users.Add(user);

        Console.WriteLine("Novo usuário adicionado:");

        return user;
    }
}