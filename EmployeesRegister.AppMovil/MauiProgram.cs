using EmployeesRegister.ClassLibrary.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.Extensions.Logging;

namespace EmployeesRegister.AppMovil
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            Register();
            return builder.Build();
        }
        public static void Register()
        {
            FirebaseClient client = new FirebaseClient("https://employeesregister-11284-default-rtdb.firebaseio.com/");

            var position = client.Child("Positions").OnceAsync<Position>();

            if (position.Result.Count == 0)
            {
                client.Child("Positions").PostAsync(new Position { Name = "Admin" });
                client.Child("Positions").PostAsync(new Position { Name = "User" });
                client.Child("Positions").PostAsync(new Position { Name = "Super" });
            }
        }
    }
}
