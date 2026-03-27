namespace FastFirewallSolution
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
            this.HelpLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DenyCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HelpLabel
            // 
            this.HelpLabel.Location = new System.Drawing.Point(12, 9);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(512, 23);
            this.HelpLabel.TabIndex = 0;
            this.HelpLabel.Text = "Place this EXE in a folder containing the executables of the games/applications y" + "ou want to allow or deny.";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 33);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Rules";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(218, 33);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(200, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove Rules";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DenyCheckbox
            // 
            this.DenyCheckbox.Location = new System.Drawing.Point(438, 32);
            this.DenyCheckbox.Name = "DenyCheckbox";
            this.DenyCheckbox.Size = new System.Drawing.Size(81, 24);
            this.DenyCheckbox.TabIndex = 3;
            this.DenyCheckbox.Text = "Deny Mode";
            this.DenyCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 68);
            this.Controls.Add(this.DenyCheckbox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HelpLabel);
            this.Name = "Form1";
            this.Text = "bushtail\'s Fast Firewall Solution";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.CheckBox DenyCheckbox;

        private System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.Label HelpLabel;

        #endregion
    }
}