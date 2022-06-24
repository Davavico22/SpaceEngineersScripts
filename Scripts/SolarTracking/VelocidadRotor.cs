using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using VRage;
using VRage.Collections;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.GUI.TextPanel;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ModAPI.Ingame.Utilities;
using VRage.Game.ObjectBuilders.Definitions;
using VRageMath;

namespace IngameScript
{
	partial class Program : MyGridProgram
	{
		//INICIO
		IMyTextPanel lcd;
		IMyMotorStator rotor;
		public Program()
		{
			lcd = GridTerminalSystem.GetBlockWithName("p1") as IMyTextPanel;
			rotor = GridTerminalSystem.GetBlockWithName("Rotor") as IMyMotorStator;
		}

		public void Main(string argument, UpdateType updateSource)
		{
			lcd.ContentType = ContentType.TEXT_AND_IMAGE;

			float salida=rotor.TargetVelocityRPM;

			lcd.WriteText("La velocidad es:" +salida);

		}
		//FIN
	}
}
