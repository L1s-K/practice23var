namespace practice23var
{
    partial class Main
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
            dataGridViewMatrix = new DataGridView();
            textBoxRang = new TextBox();
            labelRangCount = new Label();
            buttonGenerateMatrix = new Button();
            buttonCalculateAVG = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.AllowUserToDeleteRows = false;
            dataGridViewMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMatrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(31, 89);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(403, 334);
            dataGridViewMatrix.TabIndex = 0;
            // 
            // textBoxRang
            // 
            textBoxRang.Location = new Point(171, 17);
            textBoxRang.Name = "textBoxRang";
            textBoxRang.Size = new Size(100, 23);
            textBoxRang.TabIndex = 1;
            // 
            // labelRangCount
            // 
            labelRangCount.AutoSize = true;
            labelRangCount.Location = new Point(31, 20);
            labelRangCount.Name = "labelRangCount";
            labelRangCount.Size = new Size(134, 15);
            labelRangCount.TabIndex = 2;
            labelRangCount.Text = "Введите ранг матрицы:";
            // 
            // buttonGenerateMatrix
            // 
            buttonGenerateMatrix.Location = new Point(325, 16);
            buttonGenerateMatrix.Name = "buttonGenerateMatrix";
            buttonGenerateMatrix.Size = new Size(130, 23);
            buttonGenerateMatrix.TabIndex = 3;
            buttonGenerateMatrix.Text = "Создать матрицу";
            buttonGenerateMatrix.UseVisualStyleBackColor = true;
            buttonGenerateMatrix.Click += buttonGenerateMatrix_Click;
            // 
            // buttonCalculateAVG
            // 
            buttonCalculateAVG.Location = new Point(502, 400);
            buttonCalculateAVG.Name = "buttonCalculateAVG";
            buttonCalculateAVG.Size = new Size(275, 23);
            buttonCalculateAVG.TabIndex = 4;
            buttonCalculateAVG.Text = "Среднее арифметическое для каждой строки";
            buttonCalculateAVG.UseVisualStyleBackColor = true;
            buttonCalculateAVG.Click += buttonCalculateAVG_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalculateAVG);
            Controls.Add(buttonGenerateMatrix);
            Controls.Add(labelRangCount);
            Controls.Add(textBoxRang);
            Controls.Add(dataGridViewMatrix);
            Name = "Main";
            Text = "Среднее арифметическое";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMatrix;
        private TextBox textBoxRang;
        private Label labelRangCount;
        private Button buttonGenerateMatrix;
        private Button buttonCalculateAVG;
    }
}
