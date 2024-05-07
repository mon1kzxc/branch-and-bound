using System;
using System.Linq;
using System.Windows.Forms;

namespace Черновик
{
    public partial class Form2 : Form
    {
        static int INF = int.MaxValue;
        static int[,] adjacencyMatrix;

        static int[] bestPath;
        static int bestDistance = INF;

        static int CalculateDistance(int[] path, int[,] adjacencyMatrix)
        {
            int distance = 0;
            for (int i = 0; i < path.Length - 1; i++)
            {
                int fromCity = path[i];
                int toCity = path[i + 1];
                distance += adjacencyMatrix[fromCity, toCity];
            }
            distance += adjacencyMatrix[path[path.Length - 1], path[0]];
            return distance;
        }

        static void BranchAndBound(int[] path, int level, int bound, int[,] adjacencyMatrix)
        {
            if (level == path.Length - 1)
            {
                int distance = CalculateDistance(path, adjacencyMatrix);
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                    Array.Copy(path, bestPath, path.Length);
                }
                return;
            }

            for (int i = level + 1; i < path.Length; i++)
            {
                if (adjacencyMatrix[path[level], path[i]] != 0 && bound < bestDistance)
                {
                    int newBound = bound + CalculateLowerBound(path, level, adjacencyMatrix);
                    if (newBound < bestDistance)
                    {
                        Swap(ref path[level + 1], ref path[i]);
                        BranchAndBound(path, level + 1, bound + adjacencyMatrix[path[level], path[level + 1]], adjacencyMatrix);
                        Swap(ref path[level + 1], ref path[i]);
                    }
                }
            }
        }

        static int CalculateLowerBound(int[] path, int level, int[,] adjacencyMatrix)
        {
            int lowerBound = 0;
            for (int i = level + 1; i < path.Length; i++)
            {
                lowerBound += GetClosestCityDistance(path[i], path, level, adjacencyMatrix);
            }
            return lowerBound;
        }

        static int GetClosestCityDistance(int city, int[] path, int level, int[,] adjacencyMatrix)
        {
            int minDistance = INF;
            for (int i = level; i < path.Length; i++)
            {
                if (adjacencyMatrix[city, path[i]] < minDistance)
                    minDistance = adjacencyMatrix[city, path[i]];
            }
            return minDistance;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Answer.Clear();

            TextBox[] matrixTextBoxes = { AB, AC, AD, AE, BA, BC, BD, BE, CA, CB, CD, CE, DA, Db, DC, DE, EA, EB, EC, ED };

            foreach (TextBox textBox in matrixTextBoxes)
            {
                textBox.Clear();
            }
        }

        private void Creat_Work_Click(object sender, EventArgs e)
        {
            TextBox[] matrixTextBoxes = { AB, AC, AD, AE, BA, BC, BD, BE, CA, CB, CD, CE, DA, Db, DC, DE, EA, EB, EC, ED };
            int numOfCities = 5;
            adjacencyMatrix = new int[numOfCities, numOfCities];

            foreach (TextBox textBox in matrixTextBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Заполните все поля матрицы перед созданием матрицы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прекращаем выполнение метода, если есть пустые поля
                }
            }

            for (int i = 0; i < matrixTextBoxes.Length; i++)
            {
                int row = i / numOfCities;
                int col = i % numOfCities;
                adjacencyMatrix[row, col] = Convert.ToInt32(matrixTextBoxes[i].Text);
            }
        }


        private void Way_button_Click(object sender, EventArgs e)
        {
            int numOfCities = 5;
            int[] path = Enumerable.Range(0, numOfCities).ToArray(); // начальный путь (0, 1, 2, 3, 4)
            bestPath = new int[numOfCities];

            TextBox[] matrixTextBoxes = { AB, AC, AD, AE, BA, BC, BD, BE, CA, CB, CD, CE, DA, Db, DC, DE, EA, EB, EC, ED };
            foreach (TextBox textBox in matrixTextBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Заполните все поля матрицы перед поиском кратчайшего пути.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            BranchAndBound(path, 0, 0, adjacencyMatrix);

            Answer.Text = bestDistance.ToString();

            // Answer.Text += Environment.NewLine + "Best Path: ";
            // foreach (var city in bestPath)
            // {
                // Answer.Text += city + " ";
            // }
        }
    }
}
