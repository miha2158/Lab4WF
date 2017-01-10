using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void randomButton_CheckedChanged(object sender, EventArgs e)
        {
            //Если я хочу генерировать массив

            #region закрытие всех textBox'ов

            taskBox.Clear();
            taskBox2.Clear();
            tasksOptions.Items.Clear();
            tasksOptions.Visible = false;
            taskDoneButton.Visible = false;
            indexLabel.Visible = false;
            valueLabel.Visible = false;
            taskBox.Visible = false;
            taskBox2.Visible = false;
            taskBox2.ReadOnly = true;
            taskBox.ReadOnly = true;

            #endregion

            if (randomButton.Checked)
            {
                arrayString.Clear();
                lengthBox.Focus();
                randomGenPanel.Visible = true;
                randomGenPanel.Enabled = true;
            }
            else
            {
                randomGenPanel.Visible = false;
                randomGenPanel.Enabled = false;
            }
        }

        private void inputButton_CheckedChanged(object sender, EventArgs e)
        {
            //Если я хочу вводить массив

            #region закрытие всех textBox'ов

            taskBox.Clear();
            taskBox2.Clear();
            tasksOptions.Items.Clear();
            tasksOptions.Visible = false;
            taskDoneButton.Visible = false;
            indexLabel.Visible = false;
            valueLabel.Visible = false;
            taskBox.Visible = false;
            taskBox2.Visible = false;
            taskBox2.ReadOnly = true;
            taskBox.ReadOnly = true;

            #endregion

            if (inputButton.Checked)
            {
                arrayString.Clear();
                arrayString.Focus();
                arrayString.ReadOnly = false;
                arrayDoneButton.Visible = true;
                arrayDoneButton.Enabled = true;
            }
            else
            {
                arrayDoneButton.Visible = false;
                arrayDoneButton.Enabled = false;
                arrayString.ReadOnly = true;
            }
            arrayString.Text = " ";
            arrayString.SelectionStart = arrayString.TextLength;
        }

        private void arrayDoneButton_Click(object sender, EventArgs e)
        {
            //Когда закончил вводить массив
            Stuff.MainArray = Stuff.StringToIntArray(arrayString.Text);
            arrayString.Clear();

            //Не даю ничего делать с нулевым массивом
            if (Stuff.MainArray == null)
                return;

            inputButton.Checked = false;
            arrayDoneButton.Enabled = false;
            arrayDoneButton.Visible = false;
            arrayString.Text = Stuff.WriteArray(Stuff.MainArray);

            tasksOptions.Items.Clear();
            tasksOptions.Items.AddRange(Tasks.Items);
            if (!Stuff.IsSorted(Stuff.MainArray))
                tasksOptions.Items.RemoveAt(Tasks.Items.Length - 1);
            tasksOptions.Visible = true;
        }

        private void randomGenButton_Click(object sender, EventArgs e)
        {
            //Когда ввёл длину и хочу получить массив
            Stuff.MainArray = Stuff.GenerateIntArray(Stuff.ReadInteger(lengthBox.Text));
            lengthBox.Clear();

            //Не даю ничего делать с нулевым массивом
            if (Stuff.MainArray == null)
                return;

            randomButton.Checked = false;
            randomGenPanel.Enabled = false;
            randomGenPanel.Visible = false;
            arrayString.Text = Stuff.WriteArray(Stuff.MainArray);

            tasksOptions.Items.Clear();
            tasksOptions.Items.AddRange(Tasks.Items);
            if (!Stuff.IsSorted(Stuff.MainArray))
                tasksOptions.Items.RemoveAt(Tasks.Items.Length - 1);
            tasksOptions.Visible = true;
        }

        private void tasksOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tasksOptions.SelectedIndex)
            {

                case 0:

                    #region открытие всех textBox'ов

                    taskDoneButton.Visible = true;
                    taskBox.Visible = true;
                    indexLabel.Visible = true;
                    valueLabel.Visible = true;
                    taskBox2.Visible = true;
                    taskBox2.ReadOnly = false;
                    taskBox.ReadOnly = false;

                    #endregion

                    break;
                case 1:

                    #region закрытие textBox'ов

                    taskBox2.Clear();
                    valueLabel.Visible = false;
                    taskBox2.Visible = false;
                    taskBox2.ReadOnly = true;

                    #endregion

                    #region открытие textBox'ов

                    taskDoneButton.Visible = true;
                    indexLabel.Visible = true;
                    taskBox.Visible = true;
                    taskBox.ReadOnly = false;

                    #endregion

                    break;

                case 2:
                    Stuff.MainArray = Tasks.Third(Stuff.MainArray);
                    taskDoneButton_Click(sender, e);
                    break;

                case 3:
                {
                    double temp1;
                    int n;
                    if (!Tasks.Fourth(Stuff.MainArray, out temp1, out n))
                        MessageBox.Show("Такого элемента ( " + (float) temp1 + " ) нет", "OK?", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Элемент " + (n + 1) + " со значением " + temp1, "OK?", MessageBoxButtons.OK);
                    taskDoneButton_Click(sender, e);
                }
                    break;

                case 4:
                    Stuff.MainArray = Tasks.Fifth(Stuff.MainArray);
                    taskDoneButton_Click(sender, e);
                    break;

                case 5:

                    #region закрытие textBox'ов

                    taskBox.Clear();
                    taskBox2.Clear();
                    indexLabel.Visible = false;
                    taskBox.Visible = false;
                    taskBox.ReadOnly = true;

                    #endregion

                    #region открытие textBox'ов

                    taskDoneButton.Visible = true;
                    valueLabel.Visible = true;
                    taskBox2.Visible = true;
                    taskBox2.ReadOnly = false;

                    #endregion

                    break;
            }

            arrayString.Text = Stuff.WriteArray(Stuff.MainArray);
        }

        private void taskDoneButton_Click(object sender, EventArgs e)
        {
            int n;
            int b;

            switch (tasksOptions.SelectedIndex)
            {
                case 0:
                    do
                    {
                        n = Stuff.ReadInteger(taskBox.Text);
                        if (n < 0 || n > Stuff.MainArray.Length + 1)
                        {
                            MessageBox.Show(
                                "Нельзя добавить элемент " + (n+1) + " в массив из " + Stuff.MainArray.Length + " элементов",
                                "OK?", MessageBoxButtons.OK);
                            taskBox.Clear();
                        }
                        break;
                    } while (true);

                    b = Stuff.ReadInteger(taskBox2.Text);
                    Stuff.MainArray = Tasks.Second(Stuff.MainArray, n - 1, b);
                    break;

                case 1:
                    do
                    {
                        n = Stuff.ReadInteger(taskBox.Text);
                        if (n <= 0 || n > Stuff.MainArray.Length)
                        {
                            MessageBox.Show(
                                "Нельзя удалить элемент " + n + " в массиве из " + Stuff.MainArray.Length + " элементов",
                                "OK?", MessageBoxButtons.OK);
                            taskBox.Clear();
                        }
                        break;
                    } while (true);

                    Stuff.MainArray = Tasks.First(Stuff.MainArray, n - 1);
                    break;

                case 5:
                {
                    n = Stuff.ReadInteger(taskBox2.Text);
                    int temp1;
                    if (Tasks.BinarySearch(Stuff.MainArray, n, out b, out temp1))
                        MessageBox.Show("Найден элемент " + n + " с индексом " + (temp1 + 1) + " за " + b + " проверок",
                            "OK?",
                            MessageBoxButtons.OK);
                    else MessageBox.Show("Элемент " + n + " не найден", "OK?", MessageBoxButtons.OK);
                }
                    break;
            }

            #region закрытие всех textBox'ов

            taskBox.Clear();
            taskBox2.Clear();
            taskDoneButton.Visible = false;
            indexLabel.Visible = false;
            valueLabel.Visible = false;
            taskBox.Visible = false;
            taskBox2.Visible = false;
            taskBox2.ReadOnly = true;
            taskBox.ReadOnly = true;

            #endregion

            arrayString.Text = Stuff.WriteArray(Stuff.MainArray);

            if (Stuff.MainArray == null || Stuff.MainArray.Length <= 0)
            {
                tasksOptions.Items.Clear();
                tasksOptions.Items.AddRange(new string[] {Tasks.Items[0]});
            }
            else
            {
                tasksOptions.Items.Clear();
                tasksOptions.Items.AddRange(Tasks.Items);
                if (!Stuff.IsSorted(Stuff.MainArray))
                    tasksOptions.Items.RemoveAt(Tasks.Items.Length - 1);
            }
        }

        private void arrayString_TextChanged(object sender, EventArgs e)
        {
            if (arrayString.TextLength > 0)
            {
                char[] validChars = new char[] {' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
                for (int i = 0; i < arrayString.TextLength; i++)
                    if (!validChars.Contains(arrayString.Text[arrayString.TextLength - 1]))
                        arrayString.Text = arrayString.Text.Remove(arrayString.TextLength - 1);
                arrayString.SelectionStart = arrayString.TextLength;
            }
        }

        private void taskBox_TextChanged(object sender, EventArgs e)
        {
            if (taskBox.TextLength > 0)
            {
                char[] validChars = new char[] {' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-'};
                for (int i = 0; i < taskBox.TextLength; i++)
                    if (!validChars.Contains(taskBox.Text[taskBox.TextLength - 1]))
                        taskBox.Text = taskBox.Text.Remove(taskBox.TextLength - 1);
                taskBox.SelectionStart = taskBox.TextLength;
            }
        }

        private void taskBox2_TextChanged(object sender, EventArgs e)
        {
            if (taskBox2.TextLength > 0)
            {
                char[] validChars = new char[] {' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-'};
                for (int i = 0; i < taskBox2.TextLength; i++)
                    if (!validChars.Contains(taskBox2.Text[taskBox2.TextLength - 1]))
                        taskBox2.Text = taskBox2.Text.Remove(taskBox2.TextLength - 1);
                taskBox2.SelectionStart = taskBox2.TextLength;
            }
        }

        private void arrayStringKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                arrayDoneButton_Click(sender, e);
            if (arrayString.TextLength - arrayString.Text.LastIndexOf(" ") > 9)
                arrayString.Text = arrayString.Text.Remove(arrayString.Text.LastIndexOf(" ") + 9);
        }

        private void lengthBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                randomGenButton_Click(sender, e);
            if (lengthBox.TextLength > 3)
                lengthBox.Text = lengthBox.Text.Remove(3);
        }

        private void taskBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                taskDoneButton_Click(sender, e);
        }

        private void lengthBox_TextChanged(object sender, EventArgs e)
        {
            if (lengthBox.TextLength > 0)
            {
                char[] validChars = new char[] {' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
                for (int i = 0; i < lengthBox.TextLength; i++)
                    if (!validChars.Contains(lengthBox.Text[i]))
                        lengthBox.Text = lengthBox.Text.Remove(i, 1);
                lengthBox.SelectionStart = lengthBox.TextLength;
            }
        }
    }
}