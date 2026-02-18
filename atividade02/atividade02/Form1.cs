using System.Collections.Generic;

namespace atividade02
{
    public partial class Form1 : Form
    {
        Queue<string> fila = new Queue<string>();
        Stack<string> pilha = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // PUSH - Adicionar na Pilha
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                pilha.Push(textBox1.Text);
                textBox1.Clear();
                AtualizarPilha();
            }
        }

        // POP - Remover da Pilha
        private void button2_Click(object sender, EventArgs e)
        {
            if (pilha.Count > 0)
            {
                pilha.Pop();
                AtualizarPilha();
            }
        }

        // ENQUEUE - Adicionar na Fila
        private void buttonAdicionarFila_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                fila.Enqueue(textBox2.Text);
              textBox2.Clear();
                AtualizarFila();
            }
        }

        // DEQUEUE - Remover da Fila
        private void button3_Click(object sender, EventArgs e)
        {
            if (fila.Count > 0)
            {
                fila.Dequeue();
                AtualizarFila();
            }
        }

        // Atualização visual da Pilha
        void AtualizarPilha()
        {
            Pilha.Items.Clear();

            foreach (string item in pilha)
            {
                Pilha.Items.Add(item);
            }
        }

        // Atualização visual da Fila
        void AtualizarFila()
        {
            Fila.Items.Clear();

            foreach (string item in fila)
            {
                Fila.Items.Add(item);
            }

        }
    }
}