using System;

public partial interface ICommandable
{
    public string Execute(string args);
}