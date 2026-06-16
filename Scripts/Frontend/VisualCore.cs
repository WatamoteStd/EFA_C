using Godot;
using System;

public partial class VisualCore : Control
{
	[Export] private RichTextLabel _logDisplay;
	[Export] private LineEdit _logMsg;
	private MainController _mainController;

	public void Init(MainController controller)
	{
		_mainController = controller;

		// SUBS
		_logMsg.TextSubmitted += (text) =>
		{
			if (string.IsNullOrEmpty(text)) return;

			_logDisplay.Text += "> " + text + "\n";
			_logMsg.Clear();

			_mainController.SendText(text);

		};

	}

	public override void _Ready()
	{
		
		

	}

	public void VizualizeResponse(string text)
	{
		
		_logDisplay.Text += "EFA: " + text + "\n";

	}


}
