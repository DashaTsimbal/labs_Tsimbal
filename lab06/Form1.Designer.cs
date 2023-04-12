namespace lab06
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
            this.plusButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.sumNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(305, 167);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(168, 65);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(44, 317);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(168, 65);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(560, 317);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 65);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(44, 39);
            this.firstNumberTextBox.Multiline = true;
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(684, 48);
            this.firstNumberTextBox.TabIndex = 3;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(44, 104);
            this.secondNumberTextBox.Multiline = true;
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(684, 48);
            this.secondNumberTextBox.TabIndex = 4;
            // 
            // sumNumberTextBox
            // 
            this.sumNumberTextBox.Location = new System.Drawing.Point(44, 248);
            this.sumNumberTextBox.Multiline = true;
            this.sumNumberTextBox.Name = "sumNumberTextBox";
            this.sumNumberTextBox.Size = new System.Drawing.Size(684, 48);
            this.sumNumberTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 573);
            this.Controls.Add(this.sumNumberTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.plusButton);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "lab06: Довга сума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox sumNumberTextBox;
    }
}

