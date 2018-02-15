/*
 * Created by nxtSTUDIO.
 * User: Sandeep Patil
 * Date: 2/9/2018
 * Time: 2:29 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for DistributingStation.
	/// </summary>
	partial class DistributingStation
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Plant = new HMI.Main.Symbols.Model.sDefault();
			// 
			// Plant
			// 
			this.Plant.BeginInit();
			this.Plant.AngleIgnore = false;
			this.Plant.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 6D, 4D);
			this.Plant.Name = "Plant";
			this.Plant.SecurityToken = ((uint)(4294967295u));
			this.Plant.TagName = "C46748C6BAEBC78";
			this.Plant.EndInit();
			// 
			// DistributingStation
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(743D)), ((float)(275D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "DistributingStation";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Plant});
			this.Size = new System.Drawing.Size(743, 275);
		}
		private HMI.Main.Symbols.Model.sDefault Plant;
		#endregion
	}
}
