namespace Menu
{
    partial class Menu
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 245);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Меню выбора";
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(55, 123);
            button2.Name = "button2";
            button2.Size = new Size(146, 34);
            button2.TabIndex = 1;
            button2.Text = "Пирамида";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(55, 56);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 0;
            button1.Text = "Куб";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(55, 182);
            button3.Name = "button3";
            button3.Size = new Size(146, 57);
            button3.TabIndex = 2;
            button3.Text = "Кубическая карта";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 268);
            ControlBox = false;
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}