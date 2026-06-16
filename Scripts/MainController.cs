using Godot;
using System;

public partial class MainController : Node
{
	
	private BackCore _backCore;
	[Export] private VisualCore _visualCore;

	public override void _Ready()
	{
		
		_backCore = new BackCore();
		_backCore.Init(this);
		_visualCore.Init(this);

	}

	// VISUAL TO BACK COMMANDS ==============================================
	public void SendText(string text)
	{
		
		string response = _backCore.StartCommand(text);
		if (response != null) VizualizeAnswer(response);

	}

	// BACK TO VISUAL COMMANDS ===============================================
	public void VizualizeAnswer(string response)
	{
		
		_visualCore.VizualizeResponse(response);

	}

}
