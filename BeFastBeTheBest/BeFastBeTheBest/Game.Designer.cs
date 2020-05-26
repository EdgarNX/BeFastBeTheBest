namespace BeFastBeTheBest
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dataGridViewScores = new System.Windows.Forms.DataGridView();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.textBoxQ1 = new System.Windows.Forms.TextBox();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.textBoxQ3 = new System.Windows.Forms.TextBox();
            this.textBoxQ4 = new System.Windows.Forms.TextBox();
            this.textBoxQ5 = new System.Windows.Forms.TextBox();
            this.textBoxQ6 = new System.Windows.Forms.TextBox();
            this.textBoxQ7 = new System.Windows.Forms.TextBox();
            this.textBoxQ8 = new System.Windows.Forms.TextBox();
            this.textBoxQ9 = new System.Windows.Forms.TextBox();
            this.textBoxQ10 = new System.Windows.Forms.TextBox();
            this.labelQ1 = new System.Windows.Forms.Label();
            this.labelQ2 = new System.Windows.Forms.Label();
            this.labelQ3 = new System.Windows.Forms.Label();
            this.labelQ4 = new System.Windows.Forms.Label();
            this.labelQ5 = new System.Windows.Forms.Label();
            this.labelQ6 = new System.Windows.Forms.Label();
            this.labelQ7 = new System.Windows.Forms.Label();
            this.labelQ8 = new System.Windows.Forms.Label();
            this.labelQ9 = new System.Windows.Forms.Label();
            this.labelQ10 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timeGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Cursor = System.Windows.Forms.Cursors.No;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(1017, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(70, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "default";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Location = new System.Drawing.Point(332, 255);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(535, 193);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(939, 90);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(234, 32);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete Account";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(939, 51);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(234, 33);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // dataGridViewScores
            // 
            this.dataGridViewScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScores.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewScores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewScores.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewScores.Location = new System.Drawing.Point(939, 140);
            this.dataGridViewScores.Name = "dataGridViewScores";
            this.dataGridViewScores.ReadOnly = true;
            this.dataGridViewScores.RowHeadersWidth = 51;
            this.dataGridViewScores.RowTemplate.Height = 24;
            this.dataGridViewScores.Size = new System.Drawing.Size(234, 700);
            this.dataGridViewScores.TabIndex = 5;
            this.dataGridViewScores.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewScores_RowPostPaint);
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.textBoxHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHelp.Location = new System.Drawing.Point(12, 140);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.ReadOnly = true;
            this.textBoxHelp.Size = new System.Drawing.Size(246, 401);
            this.textBoxHelp.TabIndex = 6;
            this.textBoxHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQ1
            // 
            this.textBoxQ1.Location = new System.Drawing.Point(435, 74);
            this.textBoxQ1.Name = "textBoxQ1";
            this.textBoxQ1.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ1.TabIndex = 7;
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Location = new System.Drawing.Point(435, 146);
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ2.TabIndex = 8;
            // 
            // textBoxQ3
            // 
            this.textBoxQ3.Location = new System.Drawing.Point(435, 208);
            this.textBoxQ3.Name = "textBoxQ3";
            this.textBoxQ3.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ3.TabIndex = 9;
            // 
            // textBoxQ4
            // 
            this.textBoxQ4.Location = new System.Drawing.Point(435, 270);
            this.textBoxQ4.Name = "textBoxQ4";
            this.textBoxQ4.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ4.TabIndex = 10;
            // 
            // textBoxQ5
            // 
            this.textBoxQ5.Location = new System.Drawing.Point(435, 332);
            this.textBoxQ5.Name = "textBoxQ5";
            this.textBoxQ5.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ5.TabIndex = 11;
            // 
            // textBoxQ6
            // 
            this.textBoxQ6.Location = new System.Drawing.Point(435, 394);
            this.textBoxQ6.Name = "textBoxQ6";
            this.textBoxQ6.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ6.TabIndex = 12;
            // 
            // textBoxQ7
            // 
            this.textBoxQ7.Location = new System.Drawing.Point(435, 456);
            this.textBoxQ7.Name = "textBoxQ7";
            this.textBoxQ7.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ7.TabIndex = 13;
            // 
            // textBoxQ8
            // 
            this.textBoxQ8.Location = new System.Drawing.Point(435, 518);
            this.textBoxQ8.Name = "textBoxQ8";
            this.textBoxQ8.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ8.TabIndex = 14;
            // 
            // textBoxQ9
            // 
            this.textBoxQ9.Location = new System.Drawing.Point(435, 580);
            this.textBoxQ9.Name = "textBoxQ9";
            this.textBoxQ9.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ9.TabIndex = 15;
            // 
            // textBoxQ10
            // 
            this.textBoxQ10.Location = new System.Drawing.Point(435, 639);
            this.textBoxQ10.Name = "textBoxQ10";
            this.textBoxQ10.Size = new System.Drawing.Size(306, 22);
            this.textBoxQ10.TabIndex = 16;
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ1.Location = new System.Drawing.Point(452, 46);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(64, 25);
            this.labelQ1.TabIndex = 17;
            this.labelQ1.Text = "label1";
            // 
            // labelQ2
            // 
            this.labelQ2.AutoSize = true;
            this.labelQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ2.Location = new System.Drawing.Point(454, 118);
            this.labelQ2.Name = "labelQ2";
            this.labelQ2.Size = new System.Drawing.Size(64, 25);
            this.labelQ2.TabIndex = 18;
            this.labelQ2.Text = "label2";
            // 
            // labelQ3
            // 
            this.labelQ3.AutoSize = true;
            this.labelQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ3.Location = new System.Drawing.Point(454, 180);
            this.labelQ3.Name = "labelQ3";
            this.labelQ3.Size = new System.Drawing.Size(64, 25);
            this.labelQ3.TabIndex = 19;
            this.labelQ3.Text = "label3";
            // 
            // labelQ4
            // 
            this.labelQ4.AutoSize = true;
            this.labelQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ4.Location = new System.Drawing.Point(452, 242);
            this.labelQ4.Name = "labelQ4";
            this.labelQ4.Size = new System.Drawing.Size(64, 25);
            this.labelQ4.TabIndex = 20;
            this.labelQ4.Text = "label4";
            // 
            // labelQ5
            // 
            this.labelQ5.AutoSize = true;
            this.labelQ5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ5.Location = new System.Drawing.Point(452, 304);
            this.labelQ5.Name = "labelQ5";
            this.labelQ5.Size = new System.Drawing.Size(64, 25);
            this.labelQ5.TabIndex = 21;
            this.labelQ5.Text = "label5";
            // 
            // labelQ6
            // 
            this.labelQ6.AutoSize = true;
            this.labelQ6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ6.Location = new System.Drawing.Point(454, 374);
            this.labelQ6.Name = "labelQ6";
            this.labelQ6.Size = new System.Drawing.Size(64, 25);
            this.labelQ6.TabIndex = 22;
            this.labelQ6.Text = "label6";
            // 
            // labelQ7
            // 
            this.labelQ7.AutoSize = true;
            this.labelQ7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ7.Location = new System.Drawing.Point(452, 428);
            this.labelQ7.Name = "labelQ7";
            this.labelQ7.Size = new System.Drawing.Size(64, 25);
            this.labelQ7.TabIndex = 23;
            this.labelQ7.Text = "label7";
            // 
            // labelQ8
            // 
            this.labelQ8.AutoSize = true;
            this.labelQ8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ8.Location = new System.Drawing.Point(452, 490);
            this.labelQ8.Name = "labelQ8";
            this.labelQ8.Size = new System.Drawing.Size(64, 25);
            this.labelQ8.TabIndex = 24;
            this.labelQ8.Text = "label8";
            // 
            // labelQ9
            // 
            this.labelQ9.AutoSize = true;
            this.labelQ9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ9.Location = new System.Drawing.Point(452, 552);
            this.labelQ9.Name = "labelQ9";
            this.labelQ9.Size = new System.Drawing.Size(64, 25);
            this.labelQ9.TabIndex = 25;
            this.labelQ9.Text = "label9";
            // 
            // labelQ10
            // 
            this.labelQ10.AutoSize = true;
            this.labelQ10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ10.Location = new System.Drawing.Point(452, 611);
            this.labelQ10.Name = "labelQ10";
            this.labelQ10.Size = new System.Drawing.Size(75, 25);
            this.labelQ10.TabIndex = 26;
            this.labelQ10.Text = "label10";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Lime;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Location = new System.Drawing.Point(435, 696);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(306, 117);
            this.buttonSubmit.TabIndex = 27;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(29, 34);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(211, 69);
            this.labelTimer.TabIndex = 28;
            this.labelTimer.Text = "60 : 00";
            // 
            // timeGame
            // 
            this.timeGame.Interval = 1000;
            this.timeGame.Tick += new System.EventHandler(this.timeGame_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 852);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelQ10);
            this.Controls.Add(this.labelQ9);
            this.Controls.Add(this.labelQ8);
            this.Controls.Add(this.labelQ7);
            this.Controls.Add(this.labelQ6);
            this.Controls.Add(this.labelQ5);
            this.Controls.Add(this.labelQ4);
            this.Controls.Add(this.labelQ3);
            this.Controls.Add(this.labelQ2);
            this.Controls.Add(this.labelQ1);
            this.Controls.Add(this.textBoxQ10);
            this.Controls.Add(this.textBoxQ9);
            this.Controls.Add(this.textBoxQ8);
            this.Controls.Add(this.textBoxQ7);
            this.Controls.Add(this.textBoxQ6);
            this.Controls.Add(this.textBoxQ5);
            this.Controls.Add(this.textBoxQ4);
            this.Controls.Add(this.textBoxQ3);
            this.Controls.Add(this.textBoxQ2);
            this.Controls.Add(this.textBoxQ1);
            this.Controls.Add(this.textBoxHelp);
            this.Controls.Add(this.dataGridViewScores);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelUserName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1199, 899);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1199, 899);
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridView dataGridViewScores;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.TextBox textBoxQ1;
        private System.Windows.Forms.TextBox textBoxQ2;
        private System.Windows.Forms.TextBox textBoxQ3;
        private System.Windows.Forms.TextBox textBoxQ4;
        private System.Windows.Forms.TextBox textBoxQ5;
        private System.Windows.Forms.TextBox textBoxQ6;
        private System.Windows.Forms.TextBox textBoxQ7;
        private System.Windows.Forms.TextBox textBoxQ8;
        private System.Windows.Forms.TextBox textBoxQ9;
        private System.Windows.Forms.TextBox textBoxQ10;
        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.Label labelQ2;
        private System.Windows.Forms.Label labelQ3;
        private System.Windows.Forms.Label labelQ4;
        private System.Windows.Forms.Label labelQ5;
        private System.Windows.Forms.Label labelQ6;
        private System.Windows.Forms.Label labelQ7;
        private System.Windows.Forms.Label labelQ8;
        private System.Windows.Forms.Label labelQ9;
        private System.Windows.Forms.Label labelQ10;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timeGame;
    }
}