namespace Exercicio_11
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            bngnToolStripMenuItem = new ToolStripMenuItem();
            mudarCorELetraToolStripMenuItem = new ToolStripMenuItem();
            letraToolStripMenuItem = new ToolStripMenuItem();
            corToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 119);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "SISI CASMURRA";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bngnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1260, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // bngnToolStripMenuItem
            // 
            bngnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mudarCorELetraToolStripMenuItem });
            bngnToolStripMenuItem.Name = "bngnToolStripMenuItem";
            bngnToolStripMenuItem.Size = new Size(163, 29);
            bngnToolStripMenuItem.Text = "mudar cor e letra";
            bngnToolStripMenuItem.Click += bngnToolStripMenuItem_Click;
            // 
            // mudarCorELetraToolStripMenuItem
            // 
            mudarCorELetraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { letraToolStripMenuItem, corToolStripMenuItem });
            mudarCorELetraToolStripMenuItem.Name = "mudarCorELetraToolStripMenuItem";
            mudarCorELetraToolStripMenuItem.Size = new Size(249, 34);
            mudarCorELetraToolStripMenuItem.Text = "mudar cor e letra";
            // 
            // letraToolStripMenuItem
            // 
            letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            letraToolStripMenuItem.Size = new Size(148, 34);
            letraToolStripMenuItem.Text = "letra";
            letraToolStripMenuItem.Click += letraToolStripMenuItem_Click;
            // 
            // corToolStripMenuItem
            // 
            corToolStripMenuItem.Name = "corToolStripMenuItem";
            corToolStripMenuItem.Size = new Size(148, 34);
            corToolStripMenuItem.Text = "cor";
            corToolStripMenuItem.Click += corToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1058, 191);
            button1.Name = "button1";
            button1.Size = new Size(176, 109);
            button1.TabIndex = 3;
            button1.Text = "pagina 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1260, 359);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bngnToolStripMenuItem;
        private ToolStripMenuItem mudarCorELetraToolStripMenuItem;
        private ToolStripMenuItem letraToolStripMenuItem;
        private ToolStripMenuItem corToolStripMenuItem;
        private Button button1;
    }
}