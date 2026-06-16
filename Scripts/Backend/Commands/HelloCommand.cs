using System;
using System.Diagnostics;

public partial class HelloCommand : ICommandable
{
    
    public string Execute(string args)
    {
        
        string response = "Привет, я готова к работе. Узнать список команд: 'ифа помоги'";
        return response;

    }

}