namespace atividade02
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
            Pilha = new ListBox();
            Fila = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // Pilha
            // 
            
            Pilha.FormattingEnabled = true;
            Pilha.Location = new Point(30, 78);
            Pilha.Name = "Pilha";
            Pilha.Size = new Size(284, 284);
            Pilha.TabIndex = 0;
            button4.Click += buttonAdicionarFila_Click;
            // 
            // Fila
            // 
            Fila.FormattingEnabled = true;
            Fila.Location = new Point(334, 78);
            Fila.Name = "Fila";
            Fila.Size = new Size(284, 284);
            Fila.TabIndex = 1;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 2;
            label1.Text = "Pilha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 37);
            label2.Name = "label2";
            label2.Size = new Size(55, 30);
            label2.TabIndex = 3;
            label2.Text = "Fila";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 396);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 37);
            textBox1.TabIndex = 4;
         
            // 
            // textBox2
            // 
            textBox2.Location = new Point(334, 396);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 37);
            textBox2.TabIndex = 5;
           
            // 
            // button1
            // 
            button1.Location = new Point(225, 396);
            button1.Name = "button1";
            button1.Size = new Size(37, 37);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 396);
            button2.Name = "button2";
            button2.Size = new Size(37, 37);
            button2.TabIndex = 7;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(581, 396);
            button3.Name = "button3";
            button3.Size = new Size(37, 37);
            button3.TabIndex = 8;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(529, 396);
            button4.Name = "button4";
            button4.Size = new Size(37, 37);
            button4.TabIndex = 9;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 510);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Fila);
            Controls.Add(Pilha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Pilha;
        private ListBox Fila;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
