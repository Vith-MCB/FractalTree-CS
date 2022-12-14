namespace Fractal_Tree
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
            this.pcb = new System.Windows.Forms.PictureBox();
            this.tbAngle = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb
            // 
            this.pcb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb.BackColor = System.Drawing.Color.Black;
            this.pcb.Location = new System.Drawing.Point(12, 12);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(1038, 598);
            this.pcb.TabIndex = 0;
            this.pcb.TabStop = false;
            this.pcb.Paint += new System.Windows.Forms.PaintEventHandler(this.pcb_Paint);
            // 
            // tbAngle
            // 
            this.tbAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngle.Location = new System.Drawing.Point(12, 616);
            this.tbAngle.Maximum = 180;
            this.tbAngle.Minimum = 1;
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(1038, 45);
            this.tbAngle.TabIndex = 1;
            this.tbAngle.Value = 1;
            this.tbAngle.ValueChanged += new System.EventHandler(this.tbAngle_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 638);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.pcb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pcb;
        private TrackBar tbAngle;

        #endregion

    }
}