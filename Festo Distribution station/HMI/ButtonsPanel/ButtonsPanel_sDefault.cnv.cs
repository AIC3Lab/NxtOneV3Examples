/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/13/2016
 * Time: 4:28 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ButtonsPanel
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			startLed.Visible = false;
			resetLed.Visible = false;
			ackLed.Visible = false;
			polygon1.Visible = false;
		}
		
		void Start_ledValueChanged(object sender, ValueChangedEventArgs e)
		{
		  startLed.Visible = (bool)e.Value;
		}
		
		void Reset_ledValueChanged(object sender, ValueChangedEventArgs e)
		{
		  resetLed.Visible = (bool)e.Value;
		}
		
		void Ack_ledValueChanged(object sender, ValueChangedEventArgs e)
		{
		  ackLed.Visible = (bool)e.Value;
		}
		
		void StartButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,false,true,true,true,true,true,true,true,true);
		}
		
		void StartButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(false,false,true,true,true,true,true,true,true,true);
		}
		
		void StartButtonMouseLeave(object sender, EventArgs e)
		{
			this.FireEvent_CNF(false,false,true,true,true,true,true,true,true,true);
		}
		
		void ResetButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,false,true,true,true,true,true,true);
		}
		
		void ResetButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,false,false,true,true,true,true,true,true);
		}
		
		void ResetButtonMouseLeave(object sender, EventArgs e)
		{
			this.FireEvent_CNF(true,true,false,false,true,true,true,true,true,true);
		}
		
		void AckButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,true,false,true,true,true,true);
		}
		
		void AckButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,false,false,true,true,true,true);
		}
		
		void AckButtonMouseLeave(object sender, EventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,false,false,true,true,true,true);
		}
		
		void StopButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,true,true,true,true,false,false);
		}
		
		void StopButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,true,true,true,true,true,false);
		}
		
		void StopButtonMouseLeave(object sender, EventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,true,true,true,true,true,false);
		}
		
		void ManualSwitchClick(object sender, EventArgs e)
		{
			bool temp1 = polygon1.Visible;
			bool temp2 = polygon2.Visible;
			polygon1.Visible = !temp1;
			polygon2.Visible = !temp2;
			this.FireEvent_CNF(true,true,true,true,true,true,temp2,false,true,true);
		}
	}
}
