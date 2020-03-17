namespace TextCensoring {
    partial class FileCensoring {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.file_label = new System.Windows.Forms.Label();
            this.file_name = new System.Windows.Forms.Label();
            this.chose_file = new System.Windows.Forms.Button();
            this.file_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.censoring = new System.Windows.Forms.Button();
            this.open_catalog = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.wait_label = new System.Windows.Forms.Label();
            this.file_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.BackColor = System.Drawing.Color.SandyBrown;
            this.file_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_label.Location = new System.Drawing.Point(0, 2);
            this.file_label.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(61, 22);
            this.file_label.TabIndex = 0;
            this.file_label.Text = "Файл:";
            // 
            // file_name
            // 
            this.file_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_name.AutoSize = true;
            this.file_name.BackColor = System.Drawing.Color.White;
            this.file_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file_name.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_name.Location = new System.Drawing.Point(61, 2);
            this.file_name.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.file_name.MaximumSize = new System.Drawing.Size(317, 22);
            this.file_name.MinimumSize = new System.Drawing.Size(2, 22);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(143, 22);
            this.file_name.TabIndex = 1;
            this.file_name.Text = "Укажите файл…";
            // 
            // chose_file
            // 
            this.chose_file.AutoSize = true;
            this.chose_file.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chose_file.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chose_file.Location = new System.Drawing.Point(207, 0);
            this.chose_file.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.chose_file.Name = "chose_file";
            this.chose_file.Size = new System.Drawing.Size(75, 26);
            this.chose_file.TabIndex = 2;
            this.chose_file.Text = "Обзор…";
            this.chose_file.UseVisualStyleBackColor = true;
            this.chose_file.Click += new System.EventHandler(this.Chose_file_Click);
            // 
            // file_panel
            // 
            this.file_panel.Controls.Add(this.file_label);
            this.file_panel.Controls.Add(this.file_name);
            this.file_panel.Controls.Add(this.chose_file);
            this.file_panel.Location = new System.Drawing.Point(12, 12);
            this.file_panel.Name = "file_panel";
            this.file_panel.Size = new System.Drawing.Size(460, 26);
            this.file_panel.TabIndex = 3;
            // 
            // censoring
            // 
            this.censoring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.censoring.AutoSize = true;
            this.censoring.BackColor = System.Drawing.Color.YellowGreen;
            this.censoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.censoring.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.censoring.Location = new System.Drawing.Point(73, 58);
            this.censoring.Name = "censoring";
            this.censoring.Size = new System.Drawing.Size(344, 40);
            this.censoring.TabIndex = 4;
            this.censoring.Text = "Скрыть конфиденциальные данные";
            this.censoring.UseVisualStyleBackColor = false;
            this.censoring.Click += new System.EventHandler(this.Censoring_Click);
            // 
            // open_catalog
            // 
            this.open_catalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open_catalog.AutoSize = true;
            this.open_catalog.BackColor = System.Drawing.Color.PeachPuff;
            this.open_catalog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.open_catalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.open_catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_catalog.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_catalog.Location = new System.Drawing.Point(246, 121);
            this.open_catalog.Name = "open_catalog";
            this.open_catalog.Size = new System.Drawing.Size(142, 28);
            this.open_catalog.TabIndex = 5;
            this.open_catalog.Text = "Показать в папке";
            this.open_catalog.UseVisualStyleBackColor = false;
            this.open_catalog.Visible = false;
            this.open_catalog.Click += new System.EventHandler(this.Open_catalog_Click);
            // 
            // open_file
            // 
            this.open_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open_file.AutoSize = true;
            this.open_file.BackColor = System.Drawing.Color.LightBlue;
            this.open_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.open_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.open_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_file.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_file.Location = new System.Drawing.Point(394, 121);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(78, 28);
            this.open_file.TabIndex = 6;
            this.open_file.Text = "Открыть";
            this.open_file.UseVisualStyleBackColor = false;
            this.open_file.Visible = false;
            this.open_file.Click += new System.EventHandler(this.Open_file_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // wait_label
            // 
            this.wait_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wait_label.AutoSize = true;
            this.wait_label.BackColor = System.Drawing.Color.Transparent;
            this.wait_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wait_label.Location = new System.Drawing.Point(291, 123);
            this.wait_label.Name = "wait_label";
            this.wait_label.Size = new System.Drawing.Size(140, 24);
            this.wait_label.TabIndex = 7;
            this.wait_label.Text = "Подождите...";
            this.wait_label.Visible = false;
            // 
            // FileCensoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.wait_label);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.open_catalog);
            this.Controls.Add(this.censoring);
            this.Controls.Add(this.file_panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FileCensoring";
            this.ShowIcon = false;
            this.Text = "File Censoring";
            this.file_panel.ResumeLayout(false);
            this.file_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.Button chose_file;
        private System.Windows.Forms.FlowLayoutPanel file_panel;
        private System.Windows.Forms.Button censoring;
        private System.Windows.Forms.Button open_catalog;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label wait_label;
    }
}

