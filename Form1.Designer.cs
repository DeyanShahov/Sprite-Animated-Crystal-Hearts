namespace Sprite_Animated_Crystal_Hearts
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
            components = new System.ComponentModel.Container();
            HeartTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // HeartTimer
            // 
            HeartTimer.Enabled = true;
            HeartTimer.Interval = 20;
            HeartTimer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Hearts Animated";
            Paint += FormPaintEvent;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer HeartTimer;
    }
}