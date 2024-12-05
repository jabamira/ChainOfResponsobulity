using ChainOfResponsobulity;

class Program() 
{
    static void Main(string[] args) 
    {
        var loginHandler = new LoginHandler();
        var logoutHandler = new LogoutHandler();
        var defaultHandler = new DefaultHandler();

        loginHandler.SetNext(logoutHandler).SetNext(defaultHandler);
        var requests = new List<Request>
        {
            new Request("Login", "Пользователь вошел в систему."),
            new Request("Logout", "Пользователь вышел из системы."),
            new Request("Unknown", "Неизвестное событие.")
        };

        foreach (var request in requests)
        {
            loginHandler.HandleRequest(request);
        }

    }
}
