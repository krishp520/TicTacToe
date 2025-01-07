namespace tic_tac_toe
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtb7 = new System.Windows.Forms.TextBox();
            this.lbl6_winner = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.Btn_start = new System.Windows.Forms.Button();
            this.txtb5 = new System.Windows.Forms.TextBox();
            this.lbl5_nextturn = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb4_player2Symbol = new System.Windows.Forms.TextBox();
            this.txtb3_player1Symbol = new System.Windows.Forms.TextBox();
            this.lbl4_P2_symbol = new System.Windows.Forms.Label();
            this.lbl3_P1_symbol = new System.Windows.Forms.Label();
            this.txtb2_player2Name = new System.Windows.Forms.TextBox();
            this.lbl2_P2_name = new System.Windows.Forms.Label();
            this.txtb1_player1Name = new System.Windows.Forms.TextBox();
            this.lbl1_P1_name = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 545);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.txtb7);
            this.groupBox3.Controls.Add(this.lbl6_winner);
            this.groupBox3.Location = new System.Drawing.Point(495, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 352);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Stats";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 244);
            this.listBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBox1, "Game Stats");
            // 
            // txtb7
            // 
            this.txtb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb7.Location = new System.Drawing.Point(92, 315);
            this.txtb7.Name = "txtb7";
            this.txtb7.ReadOnly = true;
            this.txtb7.Size = new System.Drawing.Size(87, 22);
            this.txtb7.TabIndex = 0;
            // 
            // lbl6_winner
            // 
            this.lbl6_winner.AutoSize = true;
            this.lbl6_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6_winner.Location = new System.Drawing.Point(26, 315);
            this.lbl6_winner.Name = "lbl6_winner";
            this.lbl6_winner.Size = new System.Drawing.Size(59, 16);
            this.lbl6_winner.TabIndex = 0;
            this.lbl6_winner.Text = "Winner:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_continue);
            this.groupBox2.Controls.Add(this.Btn_reset);
            this.groupBox2.Controls.Add(this.Btn_start);
            this.groupBox2.Controls.Add(this.txtb5);
            this.groupBox2.Controls.Add(this.lbl5_nextturn);
            this.groupBox2.Controls.Add(this.btn9);
            this.groupBox2.Controls.Add(this.btn8);
            this.groupBox2.Controls.Add(this.btn7);
            this.groupBox2.Controls.Add(this.btn6);
            this.groupBox2.Controls.Add(this.btn5);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(38, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 352);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Area";
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(309, 124);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(91, 29);
            this.btn_continue.TabIndex = 8;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(309, 175);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(91, 29);
            this.Btn_reset.TabIndex = 7;
            this.Btn_reset.Text = "Reset";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn1_reset_Click);
            // 
            // Btn_start
            // 
            this.Btn_start.Location = new System.Drawing.Point(309, 78);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(91, 29);
            this.Btn_start.TabIndex = 5;
            this.Btn_start.Text = "Start";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // txtb5
            // 
            this.txtb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb5.Location = new System.Drawing.Point(150, 312);
            this.txtb5.Name = "txtb5";
            this.txtb5.ReadOnly = true;
            this.txtb5.Size = new System.Drawing.Size(153, 22);
            this.txtb5.TabIndex = 0;
            // 
            // lbl5_nextturn
            // 
            this.lbl5_nextturn.AutoSize = true;
            this.lbl5_nextturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5_nextturn.Location = new System.Drawing.Point(53, 315);
            this.lbl5_nextturn.Name = "lbl5_nextturn";
            this.lbl5_nextturn.Size = new System.Drawing.Size(77, 16);
            this.lbl5_nextturn.TabIndex = 0;
            this.lbl5_nextturn.Text = "Next Turn:";
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(190, 201);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 71);
            this.btn9.TabIndex = 0;
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(106, 201);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 71);
            this.btn8.TabIndex = 0;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(22, 201);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 71);
            this.btn7.TabIndex = 0;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(190, 124);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 71);
            this.btn6.TabIndex = 0;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(106, 124);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 71);
            this.btn5.TabIndex = 0;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(106, 47);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 71);
            this.btn2.TabIndex = 0;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(190, 47);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 71);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(22, 124);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 71);
            this.btn4.TabIndex = 0;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(22, 47);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 71);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb4_player2Symbol);
            this.groupBox1.Controls.Add(this.txtb3_player1Symbol);
            this.groupBox1.Controls.Add(this.lbl4_P2_symbol);
            this.groupBox1.Controls.Add(this.lbl3_P1_symbol);
            this.groupBox1.Controls.Add(this.txtb2_player2Name);
            this.groupBox1.Controls.Add(this.lbl2_P2_name);
            this.groupBox1.Controls.Add(this.txtb1_player1Name);
            this.groupBox1.Controls.Add(this.lbl1_P1_name);
            this.groupBox1.Location = new System.Drawing.Point(38, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Setup";
            // 
            // txtb4_player2Symbol
            // 
            this.txtb4_player2Symbol.Location = new System.Drawing.Point(548, 72);
            this.txtb4_player2Symbol.Name = "txtb4_player2Symbol";
            this.txtb4_player2Symbol.Size = new System.Drawing.Size(88, 22);
            this.txtb4_player2Symbol.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtb4_player2Symbol, "Player 2 Symbol");
            // 
            // txtb3_player1Symbol
            // 
            this.txtb3_player1Symbol.Location = new System.Drawing.Point(548, 33);
            this.txtb3_player1Symbol.Name = "txtb3_player1Symbol";
            this.txtb3_player1Symbol.Size = new System.Drawing.Size(88, 22);
            this.txtb3_player1Symbol.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtb3_player1Symbol, "Player 1 Symbol");
            // 
            // lbl4_P2_symbol
            // 
            this.lbl4_P2_symbol.AutoSize = true;
            this.lbl4_P2_symbol.Location = new System.Drawing.Point(434, 75);
            this.lbl4_P2_symbol.Name = "lbl4_P2_symbol";
            this.lbl4_P2_symbol.Size = new System.Drawing.Size(108, 16);
            this.lbl4_P2_symbol.TabIndex = 0;
            this.lbl4_P2_symbol.Text = "Player 2 Symbol:";
            // 
            // lbl3_P1_symbol
            // 
            this.lbl3_P1_symbol.AutoSize = true;
            this.lbl3_P1_symbol.Location = new System.Drawing.Point(434, 36);
            this.lbl3_P1_symbol.Name = "lbl3_P1_symbol";
            this.lbl3_P1_symbol.Size = new System.Drawing.Size(108, 16);
            this.lbl3_P1_symbol.TabIndex = 0;
            this.lbl3_P1_symbol.Text = "Player 1 Symbol:";
            // 
            // txtb2_player2Name
            // 
            this.txtb2_player2Name.Location = new System.Drawing.Point(124, 72);
            this.txtb2_player2Name.Name = "txtb2_player2Name";
            this.txtb2_player2Name.Size = new System.Drawing.Size(215, 22);
            this.txtb2_player2Name.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtb2_player2Name, "Player 2 Name");
            // 
            // lbl2_P2_name
            // 
            this.lbl2_P2_name.AutoSize = true;
            this.lbl2_P2_name.Location = new System.Drawing.Point(19, 75);
            this.lbl2_P2_name.Name = "lbl2_P2_name";
            this.lbl2_P2_name.Size = new System.Drawing.Size(99, 16);
            this.lbl2_P2_name.TabIndex = 0;
            this.lbl2_P2_name.Text = "Player 2 Name:";
            // 
            // txtb1_player1Name
            // 
            this.txtb1_player1Name.Location = new System.Drawing.Point(124, 34);
            this.txtb1_player1Name.Name = "txtb1_player1Name";
            this.txtb1_player1Name.Size = new System.Drawing.Size(215, 22);
            this.txtb1_player1Name.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtb1_player1Name, "Player 1 Name");
            // 
            // lbl1_P1_name
            // 
            this.lbl1_P1_name.AutoSize = true;
            this.lbl1_P1_name.Location = new System.Drawing.Point(19, 37);
            this.lbl1_P1_name.Name = "lbl1_P1_name";
            this.lbl1_P1_name.Size = new System.Drawing.Size(99, 16);
            this.lbl1_P1_name.TabIndex = 0;
            this.lbl1_P1_name.Text = "Player 1 Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 545);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1_P1_name;
        private System.Windows.Forms.TextBox txtb1_player1Name;
        private System.Windows.Forms.Label lbl3_P1_symbol;
        private System.Windows.Forms.TextBox txtb2_player2Name;
        private System.Windows.Forms.Label lbl2_P2_name;
        private System.Windows.Forms.TextBox txtb4_player2Symbol;
        private System.Windows.Forms.TextBox txtb3_player1Symbol;
        private System.Windows.Forms.Label lbl4_P2_symbol;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox txtb5;
        private System.Windows.Forms.Label lbl5_nextturn;
        private System.Windows.Forms.TextBox txtb7;
        private System.Windows.Forms.Label lbl6_winner;
        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_continue;
    }
}

