namespace Calculadora
{
    partial class frmCalculadora
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
            label1 = new Label();
            label2 = new Label();
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rbdSuma = new RadioButton();
            this.rbdResta = new RadioButton();
            this.rbdMultiplicacion = new RadioButton();

            this.rbdDivision = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Variable A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(545, 40);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "Variable  B";
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(254, 68);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(223, 31);
            txtVariableA.TabIndex = 2;
            txtVariableA.TextChanged += txtVariableA_TextChanged;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(532, 68);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(244, 31);
            txtVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(902, 73);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(911, 157);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(124, 52);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.rbdDivision);
            groupBox1.Controls.Add(this.rbdMultiplicacion);
            groupBox1.Controls.Add(this.rbdResta);
            groupBox1.Controls.Add(rbdSuma);
            groupBox1.Location = new Point(441, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 202);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbdSuma
            // 
            rbdSuma.AutoSize = true;
            rbdSuma.Location = new Point(20, 34);
            rbdSuma.Name = "rbdSuma";
            rbdSuma.Size = new Size(82, 29);
            rbdSuma.TabIndex = 0;
            rbdSuma.TabStop = true;
            rbdSuma.Text = "Suma";
            rbdSuma.UseVisualStyleBackColor = true;
            rbdSuma.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbdResta
            // 
            this.rbdResta.AutoSize = true;
            this.rbdResta.Location = new Point(19, 69);
            this.rbdResta.Name = "rbdResta";
            this.rbdResta.Size = new Size(79, 29);
            this.rbdResta.TabIndex = 1;
            this.rbdResta.TabStop = true;
            this.rbdResta.Text = "Resta";
            this.rbdResta.UseVisualStyleBackColor = true;
            this.rbdResta.CheckedChanged += this.radioButton2_CheckedChanged;
            // 
            // rbdMultiplicacion
            // 
            this.rbdMultiplicacion.AutoSize = true;
            this.rbdMultiplicacion.Location = new Point(21, 101);
            this.rbdMultiplicacion.Name = "rbdMultiplicacion";
            this.rbdMultiplicacion.Size = new Size(146, 29);
            this.rbdMultiplicacion.TabIndex = 2;
            this.rbdMultiplicacion.TabStop = true;
            this.rbdMultiplicacion.Text = "Multiplicacion";
            this.rbdMultiplicacion.UseVisualStyleBackColor = true;
            this.rbdMultiplicacion.CheckedChanged += this.radioButton6_CheckedChanged;
            // 
            // rbdDivision
            // 
            this.rbdDivision.AutoSize = true;
            this.rbdDivision.Location = new Point(19, 136);
            this.rbdDivision.Name = "rbdDivision";
            this.rbdDivision.Size = new Size(100, 29);
            this.rbdDivision.TabIndex = 3;
            this.rbdDivision.TabStop = true;
            this.rbdDivision.Text = "Division";
            this.rbdDivision.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
            Load += frmCalculadora_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton6;
        private RadioButton radioButton2;
        private RadioButton rbdSuma;
        private RadioButton rbdResta;
        private RadioButton rbdMultiplicacion;
        private RadioButton rbdDivision;
    }
}