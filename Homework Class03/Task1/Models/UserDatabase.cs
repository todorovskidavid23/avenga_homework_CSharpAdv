namespace Task1.Models
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(1, "Alice", 30),
            new User(2, "Bob", 25),
            new User(3, "Charlie", 35),
            new User(4, "Diana", 28),
            new User(5, "Eve", 22)
        };

        public static List<User> SearchById(int id)
        {
            List<User> result = Users
                .Where(x => x.Id == id)
                .ToList();

            return result;
        }

        public static List<User> SearchByName(string name)
        {
            List<User> result = Users
                .Where(x => x.Name == name)
                .ToList();

            return result;
        }

        public static List<User> SearchByAge(int age)
        {
            List<User> result = Users
                .Where(x => x.Age == age)
                .ToList();

            return result;
        }
    }
}
