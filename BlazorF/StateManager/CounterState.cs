using BlazorF.ApiFilm.Models;
using Fluxor;

namespace BlazorF.StateManager
{
    

  

    [FeatureState]
    public class UserState1
    {
        public User User { get; set; }

        // Параметрless конструктор
        public UserState1()
        {
            User = new User(); // Значение по умолчанию
        }

        // Конструктор с параметрами
        public UserState1(User user)
        {
            User = user;
        }
    }
}
