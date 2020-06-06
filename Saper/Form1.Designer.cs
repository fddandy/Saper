namespace Saper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sredniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trudnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prostaToolStripMenuItem,
            this.sredniaToolStripMenuItem,
            this.trudnaToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // prostaToolStripMenuItem
            // 
            this.prostaToolStripMenuItem.Name = "prostaToolStripMenuItem";
            this.prostaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.prostaToolStripMenuItem.Text = "Prosta";
            this.prostaToolStripMenuItem.Click += new System.EventHandler(this.prostaToolStripMenuItem_Click);
            // 
            // sredniaToolStripMenuItem
            // 
            this.sredniaToolStripMenuItem.Name = "sredniaToolStripMenuItem";
            this.sredniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sredniaToolStripMenuItem.Text = "Srednia";
            this.sredniaToolStripMenuItem.Click += new System.EventHandler(this.sredniaToolStripMenuItem_Click);
            // 
            // trudnaToolStripMenuItem
            // 
            this.trudnaToolStripMenuItem.Name = "trudnaToolStripMenuItem";
            this.trudnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trudnaToolStripMenuItem.Text = "Trudna";
            this.trudnaToolStripMenuItem.Click += new System.EventHandler(this.trudnaToolStripMenuItem_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 24);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(800, 426);
            this.panelButtons.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Saper v0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sredniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trudnaToolStripMenuItem;
        private System.Windows.Forms.Panel panelButtons;
    }
}

