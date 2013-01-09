using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RPGGame
{
	/// <summary>
	/// Input controller - Handles the input of all devices into one controlling interface.
	/// </summary>
	public class InputController
	{

		//Active input functions
		private bool Pause;
		private bool Forward;
		private bool Backwards;
		private bool Left;
		private bool Right;

		//Constant states for all input devices
		private KeyboardState InputKeyboard;

		//TODO: Add state for xbox 360 controller

		/// <summary>
		/// Initializes a new instance of the <see cref="RPGGame.InputController"/> class.
		/// </summary>
		public InputController ()
		{
			InputKeyboard = Keyboard.GetState();

		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="RPGGame.InputController"/> is PAUS.
		/// </summary>
		/// <value>
		/// <c>true</c> if PAUS; otherwise, <c>false</c>.
		/// </value>
		public bool PAUSE { get { return Pause; } }

		/// <summary>
		/// Gets a value indicating whether this <see cref="RPGGame.InputController"/> is FORWAR.
		/// </summary>
		/// <value>
		/// <c>true</c> if FORWAR; otherwise, <c>false</c>.
		/// </value>
		public bool FORWARD { get { return Forward; } }

		/// <summary>
		/// Gets a value indicating whether this <see cref="RPGGame.InputController"/> is BACKWARD.
		/// </summary>
		/// <value>
		/// <c>true</c> if BACKWARD; otherwise, <c>false</c>.
		/// </value>
		public bool BACKWARDS { get { return Backwards; } }

		/// <summary>
		/// Gets a value indicating whether this <see cref="RPGGame.InputController"/> is LEF.
		/// </summary>
		/// <value>
		/// <c>true</c> if LEF; otherwise, <c>false</c>.
		/// </value>
		public bool LEFT { get { return Left; } }

		/// <summary>
		/// Gets a value indicating whether this <see cref="RPGGame.InputController"/> is RIGH.
		/// </summary>
		/// <value>
		/// <c>true</c> if RIGH; otherwise, <c>false</c>.
		/// </value>
		public bool RIGHT { get { return Right; } }
	}
}

