namespace Laba3._1
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
            //this.txtFigure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFigure
            // 
            //this.txtFigure.Dock = System.Windows.Forms.DockStyle.Bottom;
            //this.txtFigure.Location = new System.Drawing.Point(0, 533);
            //this.txtFigure.Name = "txtFigure";
            //this.txtFigure.ReadOnly = true;
            //this.txtFigure.Size = new System.Drawing.Size(1004, 20);
            //this.txtFigure.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 553);
            //this.Controls.Add(this.txtFigure);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //private System.Windows.Forms.TextBox txtFigure;

        #endregion
    }
}
