
namespace MC.Control
{
    partial class TestKomponent
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
            this.simpleLabelTextBox1 = new MC.Control.SimpleLabelTextBox();
            this.SuspendLayout();
            // 
            // simpleLabelTextBox1
            // 
      
            this.simpleLabelTextBox1.Location = new System.Drawing.Point(100, 34);
            this.simpleLabelTextBox1.Name = "simpleLabelTextBox1";
            this.simpleLabelTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.simpleLabelTextBox1.Size = new System.Drawing.Size(270, 31);
            this.simpleLabelTextBox1.TabIndex = 0;
            this.simpleLabelTextBox1.Title = "X:";
            this.simpleLabelTextBox1.TitleColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // TestKomponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpleLabelTextBox1);
            this.Name = "TestKomponent";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleLabelTextBox simpleLabelTextBox1;
    }
}