using System;
using System.Collections.Generic;
using System.Diagnostics;

public partial class CommandCenter
{
	private readonly Dictionary<string, ICommandable> CommandsDictionary = new Dictionary<string, ICommandable>()
	{
		{"привет", new HelloCommand()}
	};
	
	public string? ExecuteCommand(string command)
	{
		
		foreach (var pair in CommandsDictionary)
		{
			
			if (command.StartsWith(pair.Key))
			{
				if (pair.Key.Length == command.Length)
				{
					string response = pair.Value.Execute("");
					return response;
				}
				else
				{
					string arguments = command.Substring(pair.Key.Length).Trim();
					string response = pair.Value.Execute(arguments);
					return response;
					
				}

			}

		}
		return "Ошибка, я не знаю такой комманды(";

	}

}
