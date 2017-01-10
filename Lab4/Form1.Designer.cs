using System.Windows.Forms;

namespace Lab4
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
        
        private void InitializeComponent()
        {
            this.tasksOptions = new System.Windows.Forms.ComboBox();
            this.arrayString = new System.Windows.Forms.TextBox();
            this.randomGenButton = new System.Windows.Forms.Button();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.randomGenPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.choicePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.randomButton = new System.Windows.Forms.RadioButton();
            this.inputButton = new System.Windows.Forms.RadioButton();
            this.arrayDoneButton = new System.Windows.Forms.Button();
            this.taskBox = new System.Windows.Forms.TextBox();
            this.taskDoneButton = new System.Windows.Forms.Button();
            this.taskBox2 = new System.Windows.Forms.TextBox();
            this.indexLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.randomGenPanel.SuspendLayout();
            this.choicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksOptions
            // 
            this.tasksOptions.DropDownHeight = 110;
            this.tasksOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksOptions.DropDownWidth = 700;
            this.tasksOptions.Font = new System.Drawing.Font("Courier New", 12F);
            this.tasksOptions.FormattingEnabled = true;
            this.tasksOptions.IntegralHeight = false;
            this.tasksOptions.Location = new System.Drawing.Point(12, 63);
            this.tasksOptions.Name = "tasksOptions";
            this.tasksOptions.Size = new System.Drawing.Size(363, 26);
            this.tasksOptions.TabIndex = 4;
            this.tasksOptions.Visible = false;
            this.tasksOptions.SelectedIndexChanged += new System.EventHandler(this.tasksOptions_SelectedIndexChanged);
            // 
            // arrayString
            // 
            this.arrayString.Font = new System.Drawing.Font("Courier New", 12F);
            this.arrayString.Location = new System.Drawing.Point(12, 12);
            this.arrayString.Multiline = true;
            this.arrayString.Name = "arrayString";
            this.arrayString.ReadOnly = true;
            this.arrayString.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.arrayString.Size = new System.Drawing.Size(760, 45);
            this.arrayString.TabIndex = 0;
            this.arrayString.WordWrap = false;
            this.arrayString.KeyUp += new KeyEventHandler(this.arrayStringKeyUp);
            this.arrayString.TextChanged += new System.EventHandler(this.arrayString_TextChanged);
            // 
            // randomGenButton
            // 
            this.randomGenButton.Location = new System.Drawing.Point(3, 3);
            this.randomGenButton.Name = "randomGenButton";
            this.randomGenButton.Size = new System.Drawing.Size(182, 27);
            this.randomGenButton.TabIndex = 1;
            this.randomGenButton.Text = "Сгенерировать";
            this.randomGenButton.UseVisualStyleBackColor = true;
            this.randomGenButton.Click += new System.EventHandler(this.randomGenButton_Click);
            // 
            // lengthBox
            // 
            this.lengthBox.Font = new System.Drawing.Font("Courier New", 12F);
            this.lengthBox.Location = new System.Drawing.Point(3, 36);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(98, 26);
            this.lengthBox.TabIndex = 2;
            this.lengthBox.KeyUp += new KeyEventHandler(this.lengthBoxKeyUp);
            this.lengthBox.TextChanged += new System.EventHandler(this.lengthBox_TextChanged);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(107, 33);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(64, 20);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "Длина";
            // 
            // randomGenPanel
            // 
            this.randomGenPanel.Controls.Add(this.randomGenButton);
            this.randomGenPanel.Controls.Add(this.lengthBox);
            this.randomGenPanel.Controls.Add(this.labelLength);
            this.randomGenPanel.Enabled = false;
            this.randomGenPanel.Location = new System.Drawing.Point(381, 64);
            this.randomGenPanel.Name = "randomGenPanel";
            this.randomGenPanel.Size = new System.Drawing.Size(203, 65);
            this.randomGenPanel.TabIndex = 5;
            this.randomGenPanel.Visible = false;
            // 
            // choicePanel
            // 
            this.choicePanel.Controls.Add(this.randomButton);
            this.choicePanel.Controls.Add(this.inputButton);
            this.choicePanel.Location = new System.Drawing.Point(590, 63);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(182, 65);
            this.choicePanel.TabIndex = 6;
            // 
            // randomButton
            // 
            this.randomButton.AutoSize = true;
            this.randomButton.Location = new System.Drawing.Point(3, 3);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(170, 24);
            this.randomButton.TabIndex = 7;
            this.randomButton.TabStop = true;
            this.randomButton.Text = "Сгенерировать";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.CheckedChanged += new System.EventHandler(this.randomButton_CheckedChanged);
            // 
            // inputButton
            // 
            this.inputButton.AutoSize = true;
            this.inputButton.Location = new System.Drawing.Point(3, 33);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(93, 24);
            this.inputButton.TabIndex = 8;
            this.inputButton.TabStop = true;
            this.inputButton.Text = "Ввести";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.CheckedChanged += new System.EventHandler(this.inputButton_CheckedChanged);
            // 
            // arrayDoneButton
            // 
            this.arrayDoneButton.Enabled = false;
            this.arrayDoneButton.Location = new System.Drawing.Point(381, 63);
            this.arrayDoneButton.Name = "arrayDoneButton";
            this.arrayDoneButton.Size = new System.Drawing.Size(203, 27);
            this.arrayDoneButton.TabIndex = 7;
            this.arrayDoneButton.Text = "Готово";
            this.arrayDoneButton.UseVisualStyleBackColor = true;
            this.arrayDoneButton.Visible = false;
            this.arrayDoneButton.Click += new System.EventHandler(this.arrayDoneButton_Click);
            // 
            // taskBox
            // 
            this.taskBox.Font = new System.Drawing.Font("Courier New", 12F);
            this.taskBox.Location = new System.Drawing.Point(89, 95);
            this.taskBox.Name = "taskBox";
            this.taskBox.ReadOnly = true;
            this.taskBox.Size = new System.Drawing.Size(177, 26);
            this.taskBox.TabIndex = 8;
            this.taskBox.Visible = false;
            this.taskBox.WordWrap = false;
            this.taskBox.KeyUp += new KeyEventHandler(taskBoxKeyUp);
            this.taskBox.TextChanged += new System.EventHandler(this.taskBox_TextChanged);
            // 
            // taskDoneButton
            // 
            this.taskDoneButton.Font = new System.Drawing.Font("Courier New", 13F);
            this.taskDoneButton.Location = new System.Drawing.Point(272, 95);
            this.taskDoneButton.Name = "taskDoneButton";
            this.taskDoneButton.Size = new System.Drawing.Size(103, 26);
            this.taskDoneButton.TabIndex = 9;
            this.taskDoneButton.Text = "Готово";
            this.taskDoneButton.UseVisualStyleBackColor = true;
            this.taskDoneButton.Visible = false;
            this.taskDoneButton.Click += new System.EventHandler(this.taskDoneButton_Click);
            // 
            // taskBox2
            // 
            this.taskBox2.Font = new System.Drawing.Font("Courier New", 12F);
            this.taskBox2.Location = new System.Drawing.Point(111, 127);
            this.taskBox2.Name = "taskBox2";
            this.taskBox2.ReadOnly = true;
            this.taskBox2.Size = new System.Drawing.Size(155, 26);
            this.taskBox2.TabIndex = 10;
            this.taskBox2.Visible = false;
            this.taskBox2.WordWrap = false;
            this.taskBox2.KeyUp += new KeyEventHandler(taskBoxKeyUp);
            this.taskBox2.TextChanged += new System.EventHandler(this.taskBox2_TextChanged);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(8, 98);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(75, 20);
            this.indexLabel.TabIndex = 11;
            this.indexLabel.Text = "Индекс";
            this.indexLabel.Visible = false;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(8, 129);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(97, 20);
            this.valueLabel.TabIndex = 12;
            this.valueLabel.Text = "Значение";
            this.valueLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.taskBox2);
            this.Controls.Add(this.taskDoneButton);
            this.Controls.Add(this.randomGenPanel);
            this.Controls.Add(this.choicePanel);
            this.Controls.Add(this.tasksOptions);
            this.Controls.Add(this.arrayString);
            this.Controls.Add(this.arrayDoneButton);
            this.Controls.Add(this.taskBox);
            this.Font = new System.Drawing.Font("Courier New", 13F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабораторная работа №4";
            this.randomGenPanel.ResumeLayout(false);
            this.randomGenPanel.PerformLayout();
            this.choicePanel.ResumeLayout(false);
            this.choicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox arrayString;
        private System.Windows.Forms.Button randomGenButton;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.ComboBox tasksOptions;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.FlowLayoutPanel randomGenPanel;
        private System.Windows.Forms.FlowLayoutPanel choicePanel;
        private System.Windows.Forms.RadioButton randomButton;
        private System.Windows.Forms.RadioButton inputButton;
        private System.Windows.Forms.Button arrayDoneButton;
        private System.Windows.Forms.TextBox taskBox;
        private System.Windows.Forms.Button taskDoneButton;
        private System.Windows.Forms.TextBox taskBox2;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label valueLabel;
    }
}

