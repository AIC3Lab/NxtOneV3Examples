/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/13/2016
 * Time: 3:06 PM
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
	/// Summary description for Canvas1.
	/// </summary>
	partial class DistributingStationWithHMI
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DistributionStation = new HMI.Main.Symbols.Model.sDefault();
			this.TestPanel = new HMI.Main.Symbols.Test.sDefault();
			this.PanelButtons = new HMI.Main.Symbols.ButtonsPanel.sDefault();
			// 
			// DistributionStation
			// 
			this.DistributionStation.BeginInit();
			this.DistributionStation.AngleIgnore = false;
			this.DistributionStation.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 34, 74);
			this.DistributionStation.Name = "DistributionStation";
			this.DistributionStation.SecurityToken = ((uint)(4294967295u));
			this.DistributionStation.TagName = "E5262BBCD9D0F786";
			this.DistributionStation.EndInit();
			// 
			// TestPanel
			// 
			this.TestPanel.BeginInit();
			this.TestPanel.AngleIgnore = false;
			this.TestPanel.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 112, 352);
			this.TestPanel.Name = "TestPanel";
			this.TestPanel.SecurityToken = ((uint)(4294967295u));
			this.TestPanel.TagName = "AC58F7FF4B484349";
			this.TestPanel.EndInit();
			// 
			// PanelButtons
			// 
			this.PanelButtons.BeginInit();
			this.PanelButtons.AngleIgnore = false;
			this.PanelButtons.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 187, 437);
			this.PanelButtons.Name = "PanelButtons";
			this.PanelButtons.SecurityToken = ((uint)(4294967295u));
			this.PanelButtons.TagName = "F6724B35FD591DEB";
			this.PanelButtons.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(800)), ((float)(600)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "DistributingStationWithHMI";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.DistributionStation,
									this.TestPanel,
									this.PanelButtons});
			this.Size = new System.Drawing.Size(800, 600);
		}
		private HMI.Main.Symbols.ButtonsPanel.sDefault PanelButtons;
		private HMI.Main.Symbols.Test.sDefault TestPanel;
		private HMI.Main.Symbols.Model.sDefault DistributionStation;
		#endregion
	}
}
