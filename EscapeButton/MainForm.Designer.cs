namespace EscapeButton
{
    partial class MainForm
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
            QuestionLabel = new Label();
            YesButton = new Button();
            NoButton = new Button();
            SuspendLayout();
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Font = new Font("Segoe UI", 20F);
            QuestionLabel.Location = new Point(9, 8);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(600, 54);
            QuestionLabel.TabIndex = 0;
            QuestionLabel.Text = "Вы довольны своей зарплатой?";
            QuestionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // YesButton
            // 
            YesButton.Location = new Point(92, 225);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(120, 60);
            YesButton.TabIndex = 1;
            YesButton.TabStop = false;
            YesButton.Text = "Да, очень!!";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // NoButton
            // 
            NoButton.Location = new Point(383, 225);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(120, 60);
            NoButton.TabIndex = 2;
            NoButton.TabStop = false;
            NoButton.Text = "Нет :(";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 424);
            Controls.Add(NoButton);
            Controls.Add(YesButton);
            Controls.Add(QuestionLabel);
            Name = "MainForm";
            Text = "Вы довольны своей зарплатой?";
            MouseMove += MainForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionLabel;
        private Button YesButton;
        private Button NoButton;
    }
}
