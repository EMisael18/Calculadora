namespace Calculadora
{
    partial class frmBurbuja
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
            Column1 = new DataGridViewTextBoxColumn();
            dgvOrdenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            dgvDesordenado = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).BeginInit();
            SuspendLayout();
            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // dgvOrdenado
            // 
            dgvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvOrdenado.Location = new Point(567, 43);
            dgvOrdenado.Name = "dgvOrdenado";
            dgvOrdenado.RowHeadersWidth = 62;
            dgvOrdenado.Size = new Size(175, 383);
            dgvOrdenado.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ordenado";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(394, 212);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(112, 34);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // dgvDesordenado
            // 
            dgvDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesordenado.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            dgvDesordenado.Location = new Point(97, 77);
            dgvDesordenado.Name = "dgvDesordenado";
            dgvDesordenado.RowHeadersWidth = 62;
            dgvDesordenado.Size = new Size(215, 310);
            dgvDesordenado.TabIndex = 3;
            // 
            // Column2
            // 
            Column2.HeaderText = "Desordenado";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // frmBurbuja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(dgvDesordenado);
            Controls.Add(btnOrdenar);
            Controls.Add(dgvOrdenado);
            Name = "frmBurbuja";
            Text = "Ordenamiento Burbuja";
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvOrdenado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnOrdenar;
        private DataGridView dgvDesordenado;
        private DataGridViewTextBoxColumn Column2;
    }
}