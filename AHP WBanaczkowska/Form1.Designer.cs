﻿namespace AHP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Criterias_groupBox = new System.Windows.Forms.GroupBox();
            this.Criteria_textBox = new System.Windows.Forms.TextBox();
            this.CheckConsistency_button = new System.Windows.Forms.Button();
            this.CriteriasAdd_button = new System.Windows.Forms.Button();
            this.CriteriaWeight_label = new System.Windows.Forms.Label();
            this.CriteriaWeight_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NormalizedMatrix_dgv = new System.Windows.Forms.DataGridView();
            this.Update_button = new System.Windows.Forms.Button();
            this.CriteriaCPC_button = new System.Windows.Forms.Button();
            this.Criterias_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alt_table_label = new System.Windows.Forms.Label();
            this.FinalTab_button = new System.Windows.Forms.Button();
            this.AltPeriority_dgv = new System.Windows.Forms.DataGridView();
            this.ShowPeriorityMatrix_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AltWeight_label = new System.Windows.Forms.Label();
            this.AltNorm_label = new System.Windows.Forms.Label();
            this.Criterias_comboBox = new System.Windows.Forms.ComboBox();
            this.AltCheckConsistency_button = new System.Windows.Forms.Button();
            this.AlternativesWeight_dgv = new System.Windows.Forms.DataGridView();
            this.AlterNormalizedMatrix_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AlternativesCPC_button = new System.Windows.Forms.Button();
            this.Alternatives_dgv = new System.Windows.Forms.DataGridView();
            this.Alternatives_listBox = new System.Windows.Forms.ListBox();
            this.Alternatives_textBox = new System.Windows.Forms.TextBox();
            this.AddAlternative_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FRM_listBox = new System.Windows.Forms.ListBox();
            this.FRM_label = new System.Windows.Forms.Label();
            this.FinalRating_label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Criterias_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaWeight_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizedMatrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Criterias_dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltPeriority_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesWeight_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlterNormalizedMatrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alternatives_dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1670, 723);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.Criterias_groupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1662, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kryteria";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(18, 32);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(155, 282);
            this.treeView1.TabIndex = 6;
            // 
            // Criterias_groupBox
            // 
            this.Criterias_groupBox.Controls.Add(this.Criteria_textBox);
            this.Criterias_groupBox.Controls.Add(this.CheckConsistency_button);
            this.Criterias_groupBox.Controls.Add(this.CriteriasAdd_button);
            this.Criterias_groupBox.Controls.Add(this.CriteriaWeight_label);
            this.Criterias_groupBox.Controls.Add(this.CriteriaWeight_dgv);
            this.Criterias_groupBox.Controls.Add(this.label1);
            this.Criterias_groupBox.Controls.Add(this.NormalizedMatrix_dgv);
            this.Criterias_groupBox.Controls.Add(this.Update_button);
            this.Criterias_groupBox.Controls.Add(this.CriteriaCPC_button);
            this.Criterias_groupBox.Controls.Add(this.Criterias_dgv);
            this.Criterias_groupBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Criterias_groupBox.Location = new System.Drawing.Point(192, 7);
            this.Criterias_groupBox.Name = "Criterias_groupBox";
            this.Criterias_groupBox.Size = new System.Drawing.Size(1136, 549);
            this.Criterias_groupBox.TabIndex = 11;
            this.Criterias_groupBox.TabStop = false;
            this.Criterias_groupBox.Text = "Kryteria";
            // 
            // Criteria_textBox
            // 
            this.Criteria_textBox.Location = new System.Drawing.Point(22, 25);
            this.Criteria_textBox.Name = "Criteria_textBox";
            this.Criteria_textBox.Size = new System.Drawing.Size(170, 26);
            this.Criteria_textBox.TabIndex = 10;
            // 
            // CheckConsistency_button
            // 
            this.CheckConsistency_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckConsistency_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckConsistency_button.Location = new System.Drawing.Point(239, 444);
            this.CheckConsistency_button.Name = "CheckConsistency_button";
            this.CheckConsistency_button.Size = new System.Drawing.Size(136, 31);
            this.CheckConsistency_button.TabIndex = 13;
            this.CheckConsistency_button.Text = "Sprawdź spójność";
            this.CheckConsistency_button.UseVisualStyleBackColor = false;
            this.CheckConsistency_button.Click += new System.EventHandler(this.CheckConsistency_button_Click_1);
            // 
            // CriteriasAdd_button
            // 
            this.CriteriasAdd_button.BackColor = System.Drawing.Color.Gainsboro;
            this.CriteriasAdd_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CriteriasAdd_button.Location = new System.Drawing.Point(198, 25);
            this.CriteriasAdd_button.Name = "CriteriasAdd_button";
            this.CriteriasAdd_button.Size = new System.Drawing.Size(84, 24);
            this.CriteriasAdd_button.TabIndex = 9;
            this.CriteriasAdd_button.Text = "Dodaj";
            this.CriteriasAdd_button.UseVisualStyleBackColor = false;
            this.CriteriasAdd_button.Click += new System.EventHandler(this.CriteriasAdd_button_Click_1);
            // 
            // CriteriaWeight_label
            // 
            this.CriteriaWeight_label.AutoSize = true;
            this.CriteriaWeight_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CriteriaWeight_label.Location = new System.Drawing.Point(895, 116);
            this.CriteriaWeight_label.Name = "CriteriaWeight_label";
            this.CriteriaWeight_label.Size = new System.Drawing.Size(106, 19);
            this.CriteriaWeight_label.TabIndex = 12;
            this.CriteriaWeight_label.Text = "Wagi kryteriów";
            // 
            // CriteriaWeight_dgv
            // 
            this.CriteriaWeight_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CriteriaWeight_dgv.Location = new System.Drawing.Point(899, 159);
            this.CriteriaWeight_dgv.Name = "CriteriaWeight_dgv";
            this.CriteriaWeight_dgv.Size = new System.Drawing.Size(237, 256);
            this.CriteriaWeight_dgv.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(462, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Macierz znormalizowana";
            // 
            // NormalizedMatrix_dgv
            // 
            this.NormalizedMatrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NormalizedMatrix_dgv.Location = new System.Drawing.Point(466, 159);
            this.NormalizedMatrix_dgv.Name = "NormalizedMatrix_dgv";
            this.NormalizedMatrix_dgv.Size = new System.Drawing.Size(365, 256);
            this.NormalizedMatrix_dgv.TabIndex = 9;
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Update_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Update_button.Location = new System.Drawing.Point(996, 495);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(114, 36);
            this.Update_button.TabIndex = 8;
            this.Update_button.Text = "Dalej";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click_1);
            // 
            // CriteriaCPC_button
            // 
            this.CriteriaCPC_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CriteriaCPC_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CriteriaCPC_button.Location = new System.Drawing.Point(22, 90);
            this.CriteriaCPC_button.Name = "CriteriaCPC_button";
            this.CriteriaCPC_button.Size = new System.Drawing.Size(161, 36);
            this.CriteriaCPC_button.TabIndex = 7;
            this.CriteriaCPC_button.Text = "Porównanie parami";
            this.CriteriaCPC_button.UseVisualStyleBackColor = false;
            this.CriteriaCPC_button.Click += new System.EventHandler(this.CriteriaCPC_button_Click);
            // 
            // Criterias_dgv
            // 
            this.Criterias_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Criterias_dgv.Location = new System.Drawing.Point(22, 159);
            this.Criterias_dgv.Name = "Criterias_dgv";
            this.Criterias_dgv.Size = new System.Drawing.Size(377, 256);
            this.Criterias_dgv.TabIndex = 6;
            this.Criterias_dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Criterias_dgv_CellEndEdit);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.alt_table_label);
            this.tabPage2.Controls.Add(this.FinalTab_button);
            this.tabPage2.Controls.Add(this.AltPeriority_dgv);
            this.tabPage2.Controls.Add(this.ShowPeriorityMatrix_button);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.AltWeight_label);
            this.tabPage2.Controls.Add(this.AltNorm_label);
            this.tabPage2.Controls.Add(this.Criterias_comboBox);
            this.tabPage2.Controls.Add(this.AltCheckConsistency_button);
            this.tabPage2.Controls.Add(this.AlternativesWeight_dgv);
            this.tabPage2.Controls.Add(this.AlterNormalizedMatrix_dgv);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.AlternativesCPC_button);
            this.tabPage2.Controls.Add(this.Alternatives_dgv);
            this.tabPage2.Controls.Add(this.Alternatives_listBox);
            this.tabPage2.Controls.Add(this.Alternatives_textBox);
            this.tabPage2.Controls.Add(this.AddAlternative_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1662, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alternatywy";
            // 
            // alt_table_label
            // 
            this.alt_table_label.AutoSize = true;
            this.alt_table_label.Location = new System.Drawing.Point(148, 107);
            this.alt_table_label.Name = "alt_table_label";
            this.alt_table_label.Size = new System.Drawing.Size(0, 15);
            this.alt_table_label.TabIndex = 40;
            // 
            // FinalTab_button
            // 
            this.FinalTab_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FinalTab_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinalTab_button.Location = new System.Drawing.Point(1126, 498);
            this.FinalTab_button.Name = "FinalTab_button";
            this.FinalTab_button.Size = new System.Drawing.Size(181, 38);
            this.FinalTab_button.TabIndex = 38;
            this.FinalTab_button.Text = "Zestawienie wyników";
            this.FinalTab_button.UseVisualStyleBackColor = false;
            this.FinalTab_button.Click += new System.EventHandler(this.FinalTab_button_Click);
            // 
            // AltPeriority_dgv
            // 
            this.AltPeriority_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AltPeriority_dgv.Location = new System.Drawing.Point(981, 163);
            this.AltPeriority_dgv.Name = "AltPeriority_dgv";
            this.AltPeriority_dgv.Size = new System.Drawing.Size(439, 195);
            this.AltPeriority_dgv.TabIndex = 1;
            // 
            // ShowPeriorityMatrix_button
            // 
            this.ShowPeriorityMatrix_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowPeriorityMatrix_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowPeriorityMatrix_button.Location = new System.Drawing.Point(981, 115);
            this.ShowPeriorityMatrix_button.Name = "ShowPeriorityMatrix_button";
            this.ShowPeriorityMatrix_button.Size = new System.Drawing.Size(189, 30);
            this.ShowPeriorityMatrix_button.TabIndex = 37;
            this.ShowPeriorityMatrix_button.Text = "Pokaż macierz priorytetów";
            this.ShowPeriorityMatrix_button.UseVisualStyleBackColor = false;
            this.ShowPeriorityMatrix_button.Click += new System.EventHandler(this.ShowPeriorityMatrix_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(154, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Wybierz kryterium";
            // 
            // AltWeight_label
            // 
            this.AltWeight_label.AutoSize = true;
            this.AltWeight_label.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AltWeight_label.Location = new System.Drawing.Point(795, 127);
            this.AltWeight_label.Name = "AltWeight_label";
            this.AltWeight_label.Size = new System.Drawing.Size(108, 18);
            this.AltWeight_label.TabIndex = 34;
            this.AltWeight_label.Text = "Wagi alternatyw";
            // 
            // AltNorm_label
            // 
            this.AltNorm_label.AutoSize = true;
            this.AltNorm_label.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AltNorm_label.Location = new System.Drawing.Point(472, 127);
            this.AltNorm_label.Name = "AltNorm_label";
            this.AltNorm_label.Size = new System.Drawing.Size(160, 18);
            this.AltNorm_label.TabIndex = 33;
            this.AltNorm_label.Text = "Macierz znormalizowana";
            // 
            // Criterias_comboBox
            // 
            this.Criterias_comboBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Criterias_comboBox.FormattingEnabled = true;
            this.Criterias_comboBox.Location = new System.Drawing.Point(310, 115);
            this.Criterias_comboBox.Name = "Criterias_comboBox";
            this.Criterias_comboBox.Size = new System.Drawing.Size(121, 31);
            this.Criterias_comboBox.TabIndex = 32;
            // 
            // AltCheckConsistency_button
            // 
            this.AltCheckConsistency_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AltCheckConsistency_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AltCheckConsistency_button.Location = new System.Drawing.Point(609, 388);
            this.AltCheckConsistency_button.Name = "AltCheckConsistency_button";
            this.AltCheckConsistency_button.Size = new System.Drawing.Size(143, 31);
            this.AltCheckConsistency_button.TabIndex = 31;
            this.AltCheckConsistency_button.Text = "Sprawdź spójność";
            this.AltCheckConsistency_button.UseVisualStyleBackColor = false;
            this.AltCheckConsistency_button.Click += new System.EventHandler(this.AltCheckConsistency_button_Click);
            // 
            // AlternativesWeight_dgv
            // 
            this.AlternativesWeight_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativesWeight_dgv.Location = new System.Drawing.Point(798, 163);
            this.AlternativesWeight_dgv.Name = "AlternativesWeight_dgv";
            this.AlternativesWeight_dgv.Size = new System.Drawing.Size(145, 195);
            this.AlternativesWeight_dgv.TabIndex = 30;
            // 
            // AlterNormalizedMatrix_dgv
            // 
            this.AlterNormalizedMatrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlterNormalizedMatrix_dgv.Location = new System.Drawing.Point(475, 163);
            this.AlterNormalizedMatrix_dgv.Name = "AlterNormalizedMatrix_dgv";
            this.AlterNormalizedMatrix_dgv.Size = new System.Drawing.Size(286, 195);
            this.AlterNormalizedMatrix_dgv.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(276, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 28;
            this.button1.Text = "Następne kryterium";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AlternativesCPC_button
            // 
            this.AlternativesCPC_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AlternativesCPC_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AlternativesCPC_button.Location = new System.Drawing.Point(463, 24);
            this.AlternativesCPC_button.Name = "AlternativesCPC_button";
            this.AlternativesCPC_button.Size = new System.Drawing.Size(169, 32);
            this.AlternativesCPC_button.TabIndex = 27;
            this.AlternativesCPC_button.Text = "Porównanie parami";
            this.AlternativesCPC_button.UseVisualStyleBackColor = false;
            this.AlternativesCPC_button.Click += new System.EventHandler(this.AlternativesCPC_button_Click);
            // 
            // Alternatives_dgv
            // 
            this.Alternatives_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alternatives_dgv.Location = new System.Drawing.Point(158, 163);
            this.Alternatives_dgv.Name = "Alternatives_dgv";
            this.Alternatives_dgv.Size = new System.Drawing.Size(280, 195);
            this.Alternatives_dgv.TabIndex = 26;
            this.Alternatives_dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Alternatives_dgv_CellEndEdit);
            // 
            // Alternatives_listBox
            // 
            this.Alternatives_listBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Alternatives_listBox.FormattingEnabled = true;
            this.Alternatives_listBox.ItemHeight = 15;
            this.Alternatives_listBox.Location = new System.Drawing.Point(9, 9);
            this.Alternatives_listBox.Name = "Alternatives_listBox";
            this.Alternatives_listBox.Size = new System.Drawing.Size(120, 289);
            this.Alternatives_listBox.TabIndex = 25;
            // 
            // Alternatives_textBox
            // 
            this.Alternatives_textBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Alternatives_textBox.Location = new System.Drawing.Point(158, 30);
            this.Alternatives_textBox.Name = "Alternatives_textBox";
            this.Alternatives_textBox.Size = new System.Drawing.Size(168, 26);
            this.Alternatives_textBox.TabIndex = 24;
            // 
            // AddAlternative_button
            // 
            this.AddAlternative_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAlternative_button.Location = new System.Drawing.Point(332, 29);
            this.AddAlternative_button.Name = "AddAlternative_button";
            this.AddAlternative_button.Size = new System.Drawing.Size(75, 26);
            this.AddAlternative_button.TabIndex = 23;
            this.AddAlternative_button.Text = "Dodaj";
            this.AddAlternative_button.UseVisualStyleBackColor = true;
            this.AddAlternative_button.Click += new System.EventHandler(this.AddAlternative_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.FRM_listBox);
            this.tabPage3.Controls.Add(this.FRM_label);
            this.tabPage3.Controls.Add(this.FinalRating_label);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1662, 695);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ocena końcowa ";
            // 
            // FRM_listBox
            // 
            this.FRM_listBox.FormattingEnabled = true;
            this.FRM_listBox.ItemHeight = 15;
            this.FRM_listBox.Location = new System.Drawing.Point(11, 47);
            this.FRM_listBox.Name = "FRM_listBox";
            this.FRM_listBox.Size = new System.Drawing.Size(152, 289);
            this.FRM_listBox.TabIndex = 3;
            // 
            // FRM_label
            // 
            this.FRM_label.AutoSize = true;
            this.FRM_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRM_label.ForeColor = System.Drawing.Color.Red;
            this.FRM_label.Location = new System.Drawing.Point(163, 104);
            this.FRM_label.Name = "FRM_label";
            this.FRM_label.Size = new System.Drawing.Size(0, 25);
            this.FRM_label.TabIndex = 2;
            // 
            // FinalRating_label
            // 
            this.FinalRating_label.AutoSize = true;
            this.FinalRating_label.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinalRating_label.Location = new System.Drawing.Point(8, 26);
            this.FinalRating_label.Name = "FinalRating_label";
            this.FinalRating_label.Size = new System.Drawing.Size(146, 18);
            this.FinalRating_label.TabIndex = 1;
            this.FinalRating_label.Text = "Zestawienie wyników:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 723);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Przykłady zastosowań procedur AHP do podejmowania decyzji ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Criterias_groupBox.ResumeLayout(false);
            this.Criterias_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaWeight_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizedMatrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Criterias_dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltPeriority_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesWeight_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlterNormalizedMatrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alternatives_dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Criteria_textBox;
        private System.Windows.Forms.Button CriteriasAdd_button;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Criterias_groupBox;
        private System.Windows.Forms.Button CheckConsistency_button;
        private System.Windows.Forms.Label CriteriaWeight_label;
        private System.Windows.Forms.DataGridView CriteriaWeight_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView NormalizedMatrix_dgv;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button CriteriaCPC_button;
        internal System.Windows.Forms.DataGridView Criterias_dgv;
        private System.Windows.Forms.Label AltWeight_label;
        private System.Windows.Forms.Label AltNorm_label;
        private System.Windows.Forms.ComboBox Criterias_comboBox;
        private System.Windows.Forms.Button AltCheckConsistency_button;
        private System.Windows.Forms.DataGridView AlternativesWeight_dgv;
        private System.Windows.Forms.DataGridView AlterNormalizedMatrix_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AlternativesCPC_button;
        internal System.Windows.Forms.DataGridView Alternatives_dgv;
        private System.Windows.Forms.ListBox Alternatives_listBox;
        private System.Windows.Forms.TextBox Alternatives_textBox;
        private System.Windows.Forms.Button AddAlternative_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label FinalRating_label;
        private System.Windows.Forms.Button FinalTab_button;
        private System.Windows.Forms.Label FRM_label;
        private System.Windows.Forms.ListBox FRM_listBox;
        private System.Windows.Forms.Label alt_table_label;
        private System.Windows.Forms.DataGridView AltPeriority_dgv;
        private System.Windows.Forms.Button ShowPeriorityMatrix_button;
    }
}

