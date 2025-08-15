namespace StudyGuide
{
    partial class StudyForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.jsonFileTextBox = new System.Windows.Forms.TextBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(670, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(28, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(142, 48);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browse_Click);
            // 
            // jsonFileTextBox
            // 
            this.jsonFileTextBox.Location = new System.Drawing.Point(202, 25);
            this.jsonFileTextBox.Name = "jsonFileTextBox";
            this.jsonFileTextBox.Size = new System.Drawing.Size(85, 20);
            this.jsonFileTextBox.TabIndex = 2;
            this.jsonFileTextBox.Visible = false;
            this.jsonFileTextBox.TextChanged += new System.EventHandler(this.jsonFileTextBox_TextChanged);
            // 
            // button1
            // 
            this.readFileButton.Location = new System.Drawing.Point(28, 89);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(142, 50);
            this.readFileButton.TabIndex = 3;
            this.readFileButton.Text = "Read File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Visible = false;
            this.readFileButton.Click += new System.EventHandler(this.read_Click);
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.jsonFileTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.exitButton);
            this.Name = "StudyForm";
            this.Text = "Study Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox jsonFileTextBox;
        private System.Windows.Forms.Button readFileButton;
    }
}

