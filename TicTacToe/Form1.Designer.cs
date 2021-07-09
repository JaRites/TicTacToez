
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTL = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnML = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnBM = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tryAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTL
            // 
            this.btnTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTL.Location = new System.Drawing.Point(28, 66);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(150, 150);
            this.btnTL.TabIndex = 0;
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.button_click);
            // 
            // btnTM
            // 
            this.btnTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTM.Location = new System.Drawing.Point(175, 66);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(150, 150);
            this.btnTM.TabIndex = 1;
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.button_click);
            // 
            // btnTR
            // 
            this.btnTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTR.Location = new System.Drawing.Point(322, 66);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(150, 150);
            this.btnTR.TabIndex = 2;
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.button_click);
            // 
            // btnML
            // 
            this.btnML.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnML.Location = new System.Drawing.Point(28, 212);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(150, 150);
            this.btnML.TabIndex = 3;
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Click += new System.EventHandler(this.button_click);
            // 
            // btnMM
            // 
            this.btnMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMM.Location = new System.Drawing.Point(175, 212);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(150, 150);
            this.btnMM.TabIndex = 4;
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.button_click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMR.Location = new System.Drawing.Point(322, 212);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(150, 150);
            this.btnMR.TabIndex = 5;
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.button_click);
            // 
            // btnBL
            // 
            this.btnBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBL.Location = new System.Drawing.Point(28, 359);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(150, 150);
            this.btnBL.TabIndex = 6;
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.button_click);
            // 
            // btnBM
            // 
            this.btnBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBM.Location = new System.Drawing.Point(175, 359);
            this.btnBM.Name = "btnBM";
            this.btnBM.Size = new System.Drawing.Size(150, 150);
            this.btnBM.TabIndex = 7;
            this.btnBM.UseVisualStyleBackColor = true;
            this.btnBM.Click += new System.EventHandler(this.button_click);
            // 
            // btnBR
            // 
            this.btnBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBR.Location = new System.Drawing.Point(322, 359);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(150, 150);
            this.btnBR.TabIndex = 8;
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.button_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tryAgainToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tryAgainToolStripMenuItem
            // 
            this.tryAgainToolStripMenuItem.Name = "tryAgainToolStripMenuItem";
            this.tryAgainToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.tryAgainToolStripMenuItem.Text = "Try Again";
            this.tryAgainToolStripMenuItem.Click += new System.EventHandler(this.tryAgainToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 586);
            this.Controls.Add(this.btnBR);
            this.Controls.Add(this.btnBM);
            this.Controls.Add(this.btnBL);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnML);
            this.Controls.Add(this.btnTR);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.btnTL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnBM;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tryAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
    }
}

