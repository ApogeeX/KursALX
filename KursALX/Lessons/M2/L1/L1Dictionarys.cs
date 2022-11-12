using KursALX.Lessons.M2.L1.ClassesAndEnums;

namespace KursALX.Lessons.M2.L1
{
    public class L1Dictionarys
    {
        public static void Run()
        {
            var fruitDictionary = new Dictionary<int, string>()
            {
                {1, "Banana"},
                {2, "Orange"},
                {3, "Apple"},
                {4, "Pear"},
                {5, "Plum"},
                {6, "Papaya"},
                {7, "Pineapple"},
                {8, "Grapes"},
                {9, "Melon"},
                {10, "Watermelon"},
                {11, "Passion friut"},
            };

            Console.WriteLine(fruitDictionary[1]);
            fruitDictionary.Add(12, "Raspberry");
        }

        public static void Run1()
        {
            UserDTO userDTO = new UserDTO
            {
                Name = "ab@somedomain.com",
                Role = "Data contractor"
            };

            var user = MapDTO(userDTO);
            Console.WriteLine($"User: \n\tName: {user.Name}\n\tRole: {user.Role}");
        }

        private static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;

            Dictionary<string, UserRoles> mapDictionary = new Dictionary<string, UserRoles>()
            {
                {"administrator", UserRoles.ADMINISTRATOR},
                {"user", UserRoles.USER},
                {"supervisor", UserRoles.SUPERVISOR},
                {"datacontractor", UserRoles.DATA_CONTRACTOR},
            };
            
            var roleFromDTO = userDTO.Role
                .ToLower()
                .Replace(" ","");            
            user.Role = mapDictionary[roleFromDTO];

            return user;
        }
    }
}
