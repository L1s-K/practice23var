using System.Text;

namespace practice23var
{
    public partial class Main : Form
    {
        int rang = 0;
        bool matrixCreated = false;
        public Main()
        {
            InitializeComponent();
        }

        void buttonGenerateMatrix_Click(object sender, System.EventArgs e)
        {
            if (!int.TryParse(textBoxRang.Text, out rang))
            {
                

                MessageBox.Show("Введите корректное значение ранга матрицы!");
                return;
            }
            if (rang < 0)
            {
                MessageBox.Show("Введите положительное значение ранга матрицы!");
                return;
            }
            matrixCreated = true;
            Random rnd = new Random();
            dataGridViewMatrix.Rows.Clear();
            dataGridViewMatrix.Columns.Clear();
            dataGridViewMatrix.RowCount = rang;
            dataGridViewMatrix.ColumnCount = rang;
            for (int i = 0; i < rang; i++)
            {
                for (int j = 0; j < rang; j++)
                {
                    dataGridViewMatrix[j, i].Value = rnd.Next(0, 255);
                }
            }
        }

        private void buttonCalculateAVG_Click(object sender, EventArgs e)
        {
            if (matrixCreated)
            {
                StringBuilder sb = new StringBuilder();
                double[] results = new double[rang];
                for (int i = 0; i < rang; i++)
                {
                    int[] inputRow = new int[rang];
                    for (int j = 0; j < rang; j++)
                    {
                        inputRow[j] = (int)dataGridViewMatrix[j, i].Value;
                    }
                    results[i] = new avg1DMatrix(inputRow).Result;
                    sb.Append("Строка№ " + i + ": " + results[i] + "\n");
                }

                MessageBox.Show(sb.ToString());


            }
            else
            {
                MessageBox.Show("Сначала создайте матрицу!");
            }
        }
    }
}
