namespace Passwords_gui
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrInsideText = new System.Windows.Forms.TextBox();
            this.CrtFiltrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(190, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CreateFilter";
            // 
            // FiltrInsideText
            // 
            this.FiltrInsideText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FiltrInsideText.Location = new System.Drawing.Point(32, 112);
            this.FiltrInsideText.Name = "FiltrInsideText";
            this.FiltrInsideText.Size = new System.Drawing.Size(498, 29);
            this.FiltrInsideText.TabIndex = 1;
            // 
            // CrtFiltrButton
            // 
            this.CrtFiltrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CrtFiltrButton.Location = new System.Drawing.Point(178, 171);
            this.CrtFiltrButton.Name = "CrtFiltrButton";
            this.CrtFiltrButton.Size = new System.Drawing.Size(170, 38);
            this.CrtFiltrButton.TabIndex = 2;
            this.CrtFiltrButton.Text = "Create FIlter";
            this.CrtFiltrButton.UseVisualStyleBackColor = true;
            this.CrtFiltrButton.Click += new System.EventHandler(this.CrtFiltrButton_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.CrtFiltrButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 257);
            this.Controls.Add(this.CrtFiltrButton);
            this.Controls.Add(this.FiltrInsideText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 296);
            this.MinimumSize = new System.Drawing.Size(573, 296);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiltrInsideText;
        private System.Windows.Forms.Button CrtFiltrButton;
    }
}