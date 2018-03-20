namespace SportsInformationsManager
{
	partial class GUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.Compétitions = new System.Windows.Forms.ListBox();
			this.Athlètes = new System.Windows.Forms.ListBox();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(50, 127);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 51);
			this.button1.TabIndex = 0;
			this.button1.Text = "Afficher toutes les compétitions";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(388, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 50);
			this.button2.TabIndex = 2;
			this.button2.Text = "Afficher tous les athlètes";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(388, 242);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 50);
			this.button3.TabIndex = 3;
			this.button3.Text = "Afficher tous les athlètes de la compétition";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(50, 241);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(117, 51);
			this.button4.TabIndex = 4;
			this.button4.Text = "Ajouter une compétition";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// Compétitions
			// 
			this.Compétitions.FormattingEnabled = true;
			this.Compétitions.Location = new System.Drawing.Point(173, 38);
			this.Compétitions.Name = "Compétitions";
			this.Compétitions.Size = new System.Drawing.Size(179, 381);
			this.Compétitions.TabIndex = 5;
			// 
			// Athlètes
			// 
			this.Athlètes.FormattingEnabled = true;
			this.Athlètes.Location = new System.Drawing.Point(495, 38);
			this.Athlètes.Name = "Athlètes";
			this.Athlètes.Size = new System.Drawing.Size(179, 381);
			this.Athlètes.TabIndex = 6;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(50, 184);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(117, 51);
			this.button5.TabIndex = 7;
			this.button5.Text = "Afficher les résultats de la compétition";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Athlètes);
			this.Controls.Add(this.Compétitions);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "GUI";
			this.Text = "GUI";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox Compétitions;
		private System.Windows.Forms.ListBox Athlètes;
		private System.Windows.Forms.Button button5;
	}
}