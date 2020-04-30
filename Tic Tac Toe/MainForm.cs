using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	public partial class MainForm : Form
	{
		//if true it's N turn, if false it's Y turn
		bool turn;
		
		//Count turn, if 9 then draw
		int turn_count;
		
		public MainForm()
		{
			InitializeComponent();
			initGame();
		}
		
		void NewGameToolStripMenuItemClick(object sender, EventArgs e)
		{
			initGame();
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Simple Tic Tac Toe By : \nMuhammad Erald Setyaki Siregar \n181401066 \nUniversitas Sumatera Utara \n", "Tic Tac Toe About");
		}
		
		void btnClick(object sender, MouseEventArgs e)
		{
			Button now = (Button) sender;
			
			if(turn){
				now.Text = "Ñ";
			}
			else{
				now.Text = "¥";
			}
			
			turn_count++;
			turn = !turn;
			now.Enabled = false;
			
			checkWinner();
		}
		
		private void checkWinner(){
			bool win = false;
			
			//Horizontal
			if((A1.Text == A2.Text)&&(A2.Text == A3.Text)&&(!A1.Enabled))
			{
				win = true;
			}
			else if((B1.Text == B2.Text)&&(B2.Text == B3.Text)&&(!B1.Enabled))
			{
				win = true;
			}
			else if((C1.Text == C2.Text)&&(C2.Text == C3.Text)&&(!C1.Enabled))
			{
				win = true;
			}
			
			//Vertikal
			if((A1.Text == B1.Text)&&(B1.Text == C1.Text)&&(!A1.Enabled))
			{
				win = true;
			}
			else if((A2.Text == B2.Text)&&(B2.Text == C2.Text)&&(!A2.Enabled))
			{
				win = true;
			}
			else if((A3.Text == B3.Text)&&(B3.Text == C3.Text)&&(!A3.Enabled))
			{
				win = true;
			}
			
			//Diagonal
			if((A1.Text == B2.Text)&&(B2.Text == C3.Text)&&(!A1.Enabled))
			{
				win = true;
			}
			else if((A3.Text == B2.Text)&&(B2.Text == C1.Text)&&(!A3.Enabled))
			{
				win = true;
			}
			
			if(win)
			{	
				stopGame();
				char winner;
				if(turn)
				{
					winner = '¥';
				}
				else
				{
					winner = 'Ñ';
				}
				MessageBox.Show("The winner is "+winner+" !", "Game Result");
			}
			else if(turn_count == 9)
			{
				MessageBox.Show("The game is Draw", "Game Result");
			}
			
		}
		
		private void stopGame()
		{
			foreach(Control widget in Controls)
			{
				if(widget is Button){
					widget.Enabled = false;
				}
			}
		}
		
		private void initGame()
		{
			foreach(Control widget in Controls)
			{
				if(widget is Button)
				{
					widget.Enabled = true;
					widget.Text = "";
				}
			}
			
			turn = true;
			turn_count = 0;
		}	
	}
}
