using System;
using CryEngine;

namespace CryEngine.Game
{
	[EntityComponent(Guid="684bba77-fda7-a5d4-dabe-f42b81bacf5b")]
	public class BasicMusic : EntityComponent
	{
		/// <summary>
		/// Called at the start of the game.
		/// </summary>
		protected override void OnGameplayStart()
		{
            Audio.EnableAllSound(true);
            Audio.Play("new_trigger");
		}

		/// <summary>
		/// Called once every frame when the game is running.
		/// </summary>
		/// <param name="frameTime">The time difference between this and the previous frame.</param>
		protected override void OnUpdate(float frameTime)
		{
			
		}
	}
}