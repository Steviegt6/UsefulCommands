using Terraria;
using Terraria.ModLoader;

namespace GameModeCmd
{
	public class GameModeCmd : Mod
	{
		public GameModeCmd()
		{
		}
	}

	public class NWorldName : ModCommand
	{
		public override CommandType Type => CommandType.Chat | CommandType.World;
		public override string Command => "gamemode";
		public override string Usage => "/gamemode expert or normal (under 20 characters)";
		public override string Description => "Changes your gamemode";

		public override void Action(CommandCaller caller, string input, string[] args)
		{
			if (args.Length > 0)
			{
				string name = string.Join(" ", args);
				if (name == "expert")
				{
					Main.expertMode = true;
				}
				else if (name == "normal")
				{
					Main.expertMode = false;
				}
				else
				{
					Main.NewText("ERROR: You need to use either normal or expert for the command arguments");
				}
			}
			else
			{
				Main.NewText("ERROR: You have not specified a game mode.");
			}
		}
	}
}