namespace Calculadora.Formularios
{
    partial class frmContador
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
            components = new System.ComponentModel.Container();
            lblCuenta = new Label();
            btnIniciar = new Button();
            btnDetener = new Button();
            tcbVelocidad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tcbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(291, 45);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(166, 191);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(170, 307);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Inicio";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(449, 307);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(112, 34);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tcbVelocidad
            // 
            tcbVelocidad.Enabled = false;
            tcbVelocidad.Location = new Point(111, 232);
            tcbVelocidad.Maximum = 5;
            tcbVelocidad.Minimum = 1;
            tcbVelocidad.Name = "tcbVelocidad";
            tcbVelocidad.Size = new Size(578, 69);
            tcbVelocidad.TabIndex = 3;
            tcbVelocidad.Value = 1;
            tcbVelocidad.Scroll += tcbVelocidad_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcbVelocidad);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblCuenta);
            Name = "frmContador";
            Text = "frmContador";
            ((System.ComponentModel.ISupportInitialize)tcbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnIniciar;
        private Button button1;
        private Button btnDetener;
        private TrackBar tcbVelocidad;
        private System.Windows.Forms.Timer tmrContador;
    }
}