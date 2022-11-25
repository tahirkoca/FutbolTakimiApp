
namespace KD12_EtutOOP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.futbolcuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takımEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takimSahibiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asçıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idariPersonelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futbolcuEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.liisteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futbolcuListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.futbolcuEkleToolStripMenuItem,
            this.liisteleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // futbolcuEkleToolStripMenuItem
            // 
            this.futbolcuEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asçıEkleToolStripMenuItem,
            this.futbolcuEkleToolStripMenuItem1,
            this.idariPersonelEkleToolStripMenuItem,
            this.takimSahibiEkleToolStripMenuItem,
            this.takımEkleToolStripMenuItem});
            this.futbolcuEkleToolStripMenuItem.Name = "futbolcuEkleToolStripMenuItem";
            this.futbolcuEkleToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.futbolcuEkleToolStripMenuItem.Text = "Ekle";
            // 
            // takımEkleToolStripMenuItem
            // 
            this.takımEkleToolStripMenuItem.Name = "takımEkleToolStripMenuItem";
            this.takımEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.takımEkleToolStripMenuItem.Text = "Takım Ekle";
            // 
            // takimSahibiEkleToolStripMenuItem
            // 
            this.takimSahibiEkleToolStripMenuItem.Name = "takimSahibiEkleToolStripMenuItem";
            this.takimSahibiEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.takimSahibiEkleToolStripMenuItem.Text = "Takim Sahibi Ekle";
            // 
            // asçıEkleToolStripMenuItem
            // 
            this.asçıEkleToolStripMenuItem.Name = "asçıEkleToolStripMenuItem";
            this.asçıEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asçıEkleToolStripMenuItem.Text = "Asçı Ekle";
            // 
            // idariPersonelEkleToolStripMenuItem
            // 
            this.idariPersonelEkleToolStripMenuItem.Name = "idariPersonelEkleToolStripMenuItem";
            this.idariPersonelEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.idariPersonelEkleToolStripMenuItem.Text = "Idari Personel Ekle";
            // 
            // futbolcuEkleToolStripMenuItem1
            // 
            this.futbolcuEkleToolStripMenuItem1.Name = "futbolcuEkleToolStripMenuItem1";
            this.futbolcuEkleToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.futbolcuEkleToolStripMenuItem1.Text = "Futbolcu Ekle";
            this.futbolcuEkleToolStripMenuItem1.Click += new System.EventHandler(this.futbolcuEkleToolStripMenuItem1_Click);
            // 
            // liisteleToolStripMenuItem
            // 
            this.liisteleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.futbolcuListeleToolStripMenuItem});
            this.liisteleToolStripMenuItem.Name = "liisteleToolStripMenuItem";
            this.liisteleToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.liisteleToolStripMenuItem.Text = "Listele";
            // 
            // futbolcuListeleToolStripMenuItem
            // 
            this.futbolcuListeleToolStripMenuItem.Name = "futbolcuListeleToolStripMenuItem";
            this.futbolcuListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.futbolcuListeleToolStripMenuItem.Text = "Futbolcu Listele";
            this.futbolcuListeleToolStripMenuItem.Click += new System.EventHandler(this.futbolcuListeleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem futbolcuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asçıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futbolcuEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem idariPersonelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takimSahibiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takımEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liisteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futbolcuListeleToolStripMenuItem;
    }
}

