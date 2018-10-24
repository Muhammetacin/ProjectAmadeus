namespace Amadeus
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
            this.KnopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KnopButton
            // 
            this.KnopButton.Location = new System.Drawing.Point(107, 87);
            this.KnopButton.Name = "KnopButton";
            this.KnopButton.Size = new System.Drawing.Size(116, 62);
            this.KnopButton.TabIndex = 0;
            this.KnopButton.Text = "Knop";
            this.KnopButton.UseVisualStyleBackColor = true;
            this.KnopButton.Click += new System.EventHandler(this.KnopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KnopButton);
            this.Name = "MainForm";
            this.Text = "Homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KnopButton;
    }
}

