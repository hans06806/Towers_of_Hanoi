namespace Towers_of_Hanoi
{
    partial class MainForm
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
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblPeg1 = new System.Windows.Forms.Label();
            this.lblPeg2 = new System.Windows.Forms.Label();
            this.lblPeg3 = new System.Windows.Forms.Label();
            this.Disk4 = new System.Windows.Forms.Label();
            this.Disk3 = new System.Windows.Forms.Label();
            this.Disk2 = new System.Windows.Forms.Label();
            this.Disk1 = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBase.Location = new System.Drawing.Point(120, 240);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(584, 48);
            this.pnlBase.TabIndex = 0;
            // 
            // lblPeg1
            // 
            this.lblPeg1.AllowDrop = true;
            this.lblPeg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg1.Location = new System.Drawing.Point(216, 112);
            this.lblPeg1.Name = "lblPeg1";
            this.lblPeg1.Size = new System.Drawing.Size(24, 144);
            this.lblPeg1.TabIndex = 1;
            this.lblPeg1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragEnter);
            // 
            // lblPeg2
            // 
            this.lblPeg2.AllowDrop = true;
            this.lblPeg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg2.Location = new System.Drawing.Point(400, 112);
            this.lblPeg2.Name = "lblPeg2";
            this.lblPeg2.Size = new System.Drawing.Size(24, 144);
            this.lblPeg2.TabIndex = 2;
            this.lblPeg2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragEnter);
            // 
            // lblPeg3
            // 
            this.lblPeg3.AllowDrop = true;
            this.lblPeg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg3.Location = new System.Drawing.Point(576, 112);
            this.lblPeg3.Name = "lblPeg3";
            this.lblPeg3.Size = new System.Drawing.Size(24, 144);
            this.lblPeg3.TabIndex = 3;
            this.lblPeg3.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg3.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg2_DragEnter);
            // 
            // Disk4
            // 
            this.Disk4.BackColor = System.Drawing.Color.Lime;
            this.Disk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Disk4.Location = new System.Drawing.Point(157, 216);
            this.Disk4.Name = "Disk4";
            this.Disk4.Size = new System.Drawing.Size(144, 24);
            this.Disk4.TabIndex = 4;
            this.Disk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk3
            // 
            this.Disk3.BackColor = System.Drawing.Color.Lime;
            this.Disk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Disk3.Location = new System.Drawing.Point(173, 192);
            this.Disk3.Name = "Disk3";
            this.Disk3.Size = new System.Drawing.Size(112, 24);
            this.Disk3.TabIndex = 5;
            this.Disk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk2
            // 
            this.Disk2.BackColor = System.Drawing.Color.Lime;
            this.Disk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Disk2.Location = new System.Drawing.Point(189, 168);
            this.Disk2.Name = "Disk2";
            this.Disk2.Size = new System.Drawing.Size(80, 24);
            this.Disk2.TabIndex = 6;
            this.Disk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // Disk1
            // 
            this.Disk1.BackColor = System.Drawing.Color.Lime;
            this.Disk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Disk1.Location = new System.Drawing.Point(205, 144);
            this.Disk1.Name = "Disk1";
            this.Disk1.Size = new System.Drawing.Size(48, 24);
            this.Disk1.TabIndex = 7;
            this.Disk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk1_MouseDown);
            // 
            // txtMoves
            // 
            this.txtMoves.Enabled = false;
            this.txtMoves.Location = new System.Drawing.Point(762, 27);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.Size = new System.Drawing.Size(140, 261);
            this.txtMoves.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(38, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 52);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(453, 27);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(60, 40);
            this.txtCount.TabIndex = 10;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.Location = new System.Drawing.Point(360, 38);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(77, 25);
            this.lblMoves.TabIndex = 11;
            this.lblMoves.Text = "Moves:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 421);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.Disk1);
            this.Controls.Add(this.Disk2);
            this.Controls.Add(this.Disk3);
            this.Controls.Add(this.Disk4);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lblPeg1);
            this.Controls.Add(this.lblPeg2);
            this.Controls.Add(this.lblPeg3);
            this.Name = "MainForm";
            this.Text = "The Towers of Hanoi";
            this.Load += new System.EventHandler(this.Board_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblPeg1;
        private System.Windows.Forms.Label lblPeg2;
        private System.Windows.Forms.Label lblPeg3;
        private System.Windows.Forms.Label Disk4;
        private System.Windows.Forms.Label Disk3;
        private System.Windows.Forms.Label Disk2;
        private System.Windows.Forms.Label Disk1;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblMoves;
    }
}

