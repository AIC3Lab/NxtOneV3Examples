/*
 * Created by nxtSTUDIO.
 * User: Sandeep Patil
 * Date: 2/9/2018
 * Time: 5:07 PM
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
	/// Summary description for RDS.
	/// </summary>
	partial class RefactoredDistributionStation
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PlantModel = new HMI.Main.Symbols.Model.sDefault();
			// 
			// PlantModel
			// 
			this.PlantModel.BeginInit();
			this.PlantModel.AngleIgnore = false;
			this.PlantModel.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 7D, 4D);
			this.PlantModel.Name = "PlantModel";
			this.PlantModel.SecurityToken = ((uint)(4294967295u));
			this.PlantModel.TagName = "AC508F037B32AC92";
			this.PlantModel.EndInit();
			// 
			// RDS
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(745D)), ((float)(275D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "RDS";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.PlantModel});
			this.Size = new System.Drawing.Size(745, 275);
		}
		private HMI.Main.Symbols.Model.sDefault PlantModel;
		#endregion
	}
}
