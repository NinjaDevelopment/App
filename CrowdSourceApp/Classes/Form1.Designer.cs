namespace CrowdSourceApp
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
            this.pageTabControl = new System.Windows.Forms.TabControl();
            this.findGamesPg = new System.Windows.Forms.TabPage();
            this.selectedGamePg = new System.Windows.Forms.TabPage();
            this.myGamePg = new System.Windows.Forms.TabPage();
            this.pageTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTabControl
            // 
            this.pageTabControl.Controls.Add(this.findGamesPg);
            this.pageTabControl.Controls.Add(this.selectedGamePg);
            this.pageTabControl.Controls.Add(this.myGamePg);
            this.pageTabControl.Location = new System.Drawing.Point(97, 4);
            this.pageTabControl.Name = "pageTabControl";
            this.pageTabControl.SelectedIndex = 0;
            this.pageTabControl.Size = new System.Drawing.Size(691, 434);
            this.pageTabControl.TabIndex = 0;
            // 
            // findGamesPg
            // 
            this.findGamesPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.findGamesPg.Location = new System.Drawing.Point(4, 22);
            this.findGamesPg.Name = "findGamesPg";
            this.findGamesPg.Padding = new System.Windows.Forms.Padding(3);
            this.findGamesPg.Size = new System.Drawing.Size(683, 408);
            this.findGamesPg.TabIndex = 0;
            this.findGamesPg.Text = "Find Games";
            // 
            // selectedGamePg
            // 
            this.selectedGamePg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.selectedGamePg.Location = new System.Drawing.Point(4, 22);
            this.selectedGamePg.Name = "selectedGamePg";
            this.selectedGamePg.Padding = new System.Windows.Forms.Padding(3);
            this.selectedGamePg.Size = new System.Drawing.Size(683, 408);
            this.selectedGamePg.TabIndex = 1;
            this.selectedGamePg.Text = "Selected Game";
            // 
            // myGamePg
            // 
            this.myGamePg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.myGamePg.Location = new System.Drawing.Point(4, 22);
            this.myGamePg.Name = "myGamePg";
            this.myGamePg.Padding = new System.Windows.Forms.Padding(3);
            this.myGamePg.Size = new System.Drawing.Size(683, 408);
            this.myGamePg.TabIndex = 2;
            this.myGamePg.Text = "My Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pageTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pageTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageTabControl;
        private System.Windows.Forms.TabPage findGamesPg;
        private System.Windows.Forms.TabPage selectedGamePg;
        private System.Windows.Forms.TabPage myGamePg;
    }
}

