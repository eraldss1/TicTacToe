/*
 * Created by SharpDevelop.
 * User: Erald
 * Date: 4/30/2020
 * Time: 7:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tic_Tac_Toe
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button C3;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.A1 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tic Tac Toe";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// A1
			// 
			this.A1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.A1.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.A1.FlatAppearance.BorderSize = 3;
			this.A1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.A1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A1.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A1.Location = new System.Drawing.Point(12, 50);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(75, 75);
			this.A1.TabIndex = 1;
			this.A1.UseVisualStyleBackColor = false;
			this.A1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// A2
			// 
			this.A2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.A2.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.A2.FlatAppearance.BorderSize = 3;
			this.A2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.A2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A2.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A2.Location = new System.Drawing.Point(93, 50);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(75, 75);
			this.A2.TabIndex = 2;
			this.A2.UseVisualStyleBackColor = false;
			this.A2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// A3
			// 
			this.A3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.A3.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.A3.FlatAppearance.BorderSize = 3;
			this.A3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.A3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.A3.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A3.Location = new System.Drawing.Point(174, 50);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(75, 75);
			this.A3.TabIndex = 3;
			this.A3.UseVisualStyleBackColor = false;
			this.A3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// B3
			// 
			this.B3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.B3.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.B3.FlatAppearance.BorderSize = 3;
			this.B3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.B3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B3.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3.Location = new System.Drawing.Point(174, 131);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(75, 75);
			this.B3.TabIndex = 6;
			this.B3.UseVisualStyleBackColor = false;
			this.B3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// B2
			// 
			this.B2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.B2.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.B2.FlatAppearance.BorderSize = 3;
			this.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B2.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2.Location = new System.Drawing.Point(93, 131);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(75, 75);
			this.B2.TabIndex = 5;
			this.B2.UseVisualStyleBackColor = false;
			this.B2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// B1
			// 
			this.B1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.B1.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.B1.FlatAppearance.BorderSize = 3;
			this.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B1.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1.Location = new System.Drawing.Point(12, 131);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(75, 75);
			this.B1.TabIndex = 4;
			this.B1.UseVisualStyleBackColor = false;
			this.B1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// C3
			// 
			this.C3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.C3.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.C3.FlatAppearance.BorderSize = 3;
			this.C3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.C3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C3.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C3.Location = new System.Drawing.Point(174, 212);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(75, 75);
			this.C3.TabIndex = 9;
			this.C3.UseVisualStyleBackColor = false;
			this.C3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// C2
			// 
			this.C2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.C2.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.C2.FlatAppearance.BorderSize = 3;
			this.C2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.C2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C2.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C2.Location = new System.Drawing.Point(93, 212);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(75, 75);
			this.C2.TabIndex = 8;
			this.C2.UseVisualStyleBackColor = false;
			this.C2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// C1
			// 
			this.C1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.C1.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
			this.C1.FlatAppearance.BorderSize = 3;
			this.C1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
			this.C1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
			this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.C1.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1.Location = new System.Drawing.Point(12, 212);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(75, 75);
			this.C1.TabIndex = 7;
			this.C1.UseVisualStyleBackColor = false;
			this.C1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newGameToolStripMenuItem,
			this.aboutToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 302);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(262, 33);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 29);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(262, 335);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
