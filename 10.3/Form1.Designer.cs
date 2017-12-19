namespace _10._3
{
    partial class Form1
    {
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
            if (disposing && (components != null))
            {
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.InputMatrix = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputMatrix = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveRowBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.Filt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(571, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.save});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(186, 22);
            this.open.Text = "открыть";
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(186, 22);
            this.save.Text = "сохранить результат";
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // InputMatrix
            // 
            this.InputMatrix.AllowUserToAddRows = false;
            this.InputMatrix.AllowUserToDeleteRows = false;
            this.InputMatrix.AllowUserToResizeColumns = false;
            this.InputMatrix.AllowUserToResizeRows = false;
            this.InputMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C});
            this.InputMatrix.Location = new System.Drawing.Point(40, 40);
            this.InputMatrix.Name = "InputMatrix";
            this.InputMatrix.RowHeadersVisible = false;
            this.InputMatrix.Size = new System.Drawing.Size(201, 256);
            this.InputMatrix.TabIndex = 1;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.Width = 66;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.Width = 66;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.Width = 66;
            // 
            // OutputMatrix
            // 
            this.OutputMatrix.AllowUserToAddRows = false;
            this.OutputMatrix.AllowUserToDeleteRows = false;
            this.OutputMatrix.AllowUserToResizeColumns = false;
            this.OutputMatrix.AllowUserToResizeRows = false;
            this.OutputMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.OutputMatrix.Location = new System.Drawing.Point(358, 40);
            this.OutputMatrix.Name = "OutputMatrix";
            this.OutputMatrix.ReadOnly = true;
            this.OutputMatrix.RowHeadersVisible = false;
            this.OutputMatrix.Size = new System.Drawing.Size(201, 256);
            this.OutputMatrix.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "A";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 66;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "B";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 66;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "C";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 66;
            // 
            // RemoveRowBtn
            // 
            this.RemoveRowBtn.Location = new System.Drawing.Point(12, 40);
            this.RemoveRowBtn.Name = "RemoveRowBtn";
            this.RemoveRowBtn.Size = new System.Drawing.Size(22, 22);
            this.RemoveRowBtn.TabIndex = 3;
            this.RemoveRowBtn.Text = "-";
            this.RemoveRowBtn.UseVisualStyleBackColor = true;
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Location = new System.Drawing.Point(12, 68);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(22, 22);
            this.AddRowBtn.TabIndex = 4;
            this.AddRowBtn.Text = "+";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            // 
            // Filt
            // 
            this.Filt.Location = new System.Drawing.Point(247, 154);
            this.Filt.Name = "Filt";
            this.Filt.Size = new System.Drawing.Size(105, 23);
            this.Filt.TabIndex = 5;
            this.Filt.Text = "отфильтровать";
            this.Filt.UseVisualStyleBackColor = true;
            this.Filt.Click += new System.EventHandler(this.Filt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "список линий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "отфильтрованный список линий";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filt);
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.RemoveRowBtn);
            this.Controls.Add(this.OutputMatrix);
            this.Controls.Add(this.InputMatrix);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "10.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridView InputMatrix;
        private System.Windows.Forms.DataGridView OutputMatrix;
        private System.Windows.Forms.Button RemoveRowBtn;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Button Filt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
    }
}

