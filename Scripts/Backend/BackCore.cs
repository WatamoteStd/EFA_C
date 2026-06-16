using System;
using System.Collections.Generic;

public partial class BackCore 
{
	private MainController _mainController;
	private CommandCenter _commandCenter;

	public void Init(MainController controller)
	{
		_mainController = controller;
		_commandCenter = new CommandCenter();
	}

	public string StartCommand(string unparsedCommand)
	{
		
		string? parsedCommand = ParseCommand(unparsedCommand);
		if (parsedCommand != null)
		{
			
			string response = _commandCenter.ExecuteCommand(parsedCommand);
			return response;

		}
		return null;
		

	}

	private string? ParseCommand(string text)
	{
		
		string clearText = text.Trim().ToLower();
		if (clearText.StartsWith("efa") || clearText.StartsWith("ифа") || clearText.StartsWith("ifa"))
		{
			
			if (clearText.Length <= 3) return null;

			string command = clearText.Substring(3).Trim();
			return command;
			
		}
		else return null;

	}

}
