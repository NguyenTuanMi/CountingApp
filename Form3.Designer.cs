﻿namespace WinFormsApp
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Rank = new DataGridViewTextBoxColumn();
            School = new DataGridViewTextBoxColumn();
            HighestScore = new DataGridViewTextBoxColumn();
            HighestCarbon = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Rank, School, HighestScore, HighestCarbon });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1443, 1037);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Rank
            // 
            Rank.HeaderText = "Rank";
            Rank.Name = "Rank";
            // 
            // School
            // 
            School.HeaderText = "School";
            School.Name = "School";
            // 
            // HighestScore
            // 
            HighestScore.HeaderText = "Highest Score";
            HighestScore.Name = "HighestScore";
            // 
            // HighestCarbon
            // 
            HighestCarbon.HeaderText = "Highest Carbon";
            HighestCarbon.Name = "HighestCarbon";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 1061);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Rank;
        private DataGridViewTextBoxColumn School;
        private DataGridViewTextBoxColumn HighestScore;
        private DataGridViewTextBoxColumn HighestCarbon;
    }
}