using BlazorF.ApiFilm.Models;
using Fluxor;

namespace BlazorF.StateManager
{
    
   

    public static class UsersReducers
    {
        [ReducerMethod]
        public static UserState1 ReduceSetUserIdAction(UserState1 state, SetUsersIdAction action)
        {
            return new UserState1(action.User);
        }
    }


    public record SetUsersIdAction(User User);
}
