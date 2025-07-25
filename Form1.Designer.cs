namespace Port_Forwarding_Tool
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fromIpInput = new TextBox();
            fromPortInput = new TextBox();
            toIpInput = new TextBox();
            toPortInput = new TextBox();
            addButton = new Button();
            removeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "From ip";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "From port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 9);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "To ip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 62);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "To port";
            // 
            // fromIpInput
            // 
            fromIpInput.Location = new Point(12, 27);
            fromIpInput.Name = "fromIpInput";
            fromIpInput.Size = new Size(100, 23);
            fromIpInput.TabIndex = 4;
            // 
            // fromPortInput
            // 
            fromPortInput.Location = new Point(12, 80);
            fromPortInput.Name = "fromPortInput";
            fromPortInput.Size = new Size(100, 23);
            fromPortInput.TabIndex = 5;
            // 
            // toIpInput
            // 
            toIpInput.Location = new Point(143, 27);
            toIpInput.Name = "toIpInput";
            toIpInput.Size = new Size(100, 23);
            toIpInput.TabIndex = 6;
            // 
            // toPortInput
            // 
            toPortInput.Location = new Point(143, 80);
            toPortInput.Name = "toPortInput";
            toPortInput.Size = new Size(100, 23);
            toPortInput.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 112);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(143, 112);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(100, 23);
            removeButton.TabIndex = 9;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 147);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(toPortInput);
            Controls.Add(toIpInput);
            Controls.Add(fromPortInput);
            Controls.Add(fromIpInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Port Forwarding Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox fromIpInput;
        private TextBox fromPortInput;
        private TextBox toIpInput;
        private TextBox toPortInput;
        private Button addButton;
        private Button removeButton;
    }
}
