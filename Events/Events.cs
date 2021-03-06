using Godot;
using System;
using System.Collections.Generic;


public class Events : Node
{
	public enum TYPE {LOCAL_PLAYER_MOVE, LOCAL_PLAYER_ROT, REMOTE_PLAYER_MOVE, REMOTE_PLAYER_ROT, PLACE_REQUEST, PLACE};
	public enum INVOKER {CLIENT, SERVER};

	private static Events Self;
	Events()
	{
		Self = this;
	}


	public static void Run(EventObject EventArg)
	{
		switch(EventArg.Type)
		{
			case(TYPE.LOCAL_PLAYER_MOVE):{
				Game.PossessedPlayer.SetTranslation( (Vector3)(EventArg.Args[0]) );
				return;
			}


			case(TYPE.LOCAL_PLAYER_ROT):{
				Game.PossessedPlayer.SetRotationDegrees(new Vector3(0, (float)EventArg.Args[0], 0));
				return;
			}


			case(TYPE.REMOTE_PLAYER_MOVE):{
				Game.PlayerList[(int)EventArg.Args[0]].SetTranslation( (Vector3)(EventArg.Args[1]) );
				return;
			}


			case(TYPE.REMOTE_PLAYER_ROT):{
				Game.PlayerList[(int)EventArg.Args[0]].SetRotationDegrees(new Vector3(0, (float)EventArg.Args[1], 0));
				return;
			}


			case(TYPE.PLACE_REQUEST):{
				Message.NetPlaceRequest((int)EventArg.Args[0], (Items.TYPE)EventArg.Args[1], (Vector3)EventArg.Args[2], (Vector3)EventArg.Args[3]);
				return;
			}


			case(TYPE.PLACE):{
				Building.Place((Items.TYPE)EventArg.Args[1], (Vector3)EventArg.Args[2], (Vector3)EventArg.Args[3], (int)EventArg.Args[0]);
				return;
			}

			default:
				throw new System.ArgumentException("Invalid event type '" + EventArg.Type.ToString() + "'");
		}
	}
}
