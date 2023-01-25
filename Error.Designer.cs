
namespace Proyecto_MN_2._0
{
    partial class Error
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
            this.DgvResultado = new System.Windows.Forms.DataGridView();
            this.Itera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.TbB = new System.Windows.Forms.TextBox();
            this.TbA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbC = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbXi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbLim = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvResultado
            // 
            this.DgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Itera,
            this.Xinicial,
            this.Gxi,
            this.Fxi,
            this.E});
            this.DgvResultado.Location = new System.Drawing.Point(442, 12);
            this.DgvResultado.Name = "DgvResultado";
            this.DgvResultado.Size = new System.Drawing.Size(530, 418);
            this.DgvResultado.TabIndex = 109;
            // 
            // Itera
            // 
            this.Itera.HeaderText = "Iteracion";
            this.Itera.Name = "Itera";
            this.Itera.ReadOnly = true;
            // 
            // Xinicial
            // 
            this.Xinicial.HeaderText = "Xi";
            this.Xinicial.Name = "Xinicial";
            this.Xinicial.ReadOnly = true;
            // 
            // Gxi
            // 
            this.Gxi.HeaderText = "g(xi)";
            this.Gxi.Name = "Gxi";
            this.Gxi.ReadOnly = true;
            // 
            // Fxi
            // 
            this.Fxi.HeaderText = "f(xi)";
            this.Fxi.Name = "Fxi";
            this.Fxi.ReadOnly = true;
            // 
            // E
            // 
            this.E.HeaderText = "ea";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(144, 330);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 40);
            this.btnLimpiar.TabIndex = 125;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // TbB
            // 
            this.TbB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbB.Location = new System.Drawing.Point(230, 183);
            this.TbB.Name = "TbB";
            this.TbB.Size = new System.Drawing.Size(34, 29);
            this.TbB.TabIndex = 121;
            this.TbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbB_KeyPress);
            // 
            // TbA
            // 
            this.TbA.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbA.Location = new System.Drawing.Point(144, 183);
            this.TbA.Name = "TbA";
            this.TbA.Size = new System.Drawing.Size(34, 29);
            this.TbA.TabIndex = 118;
            this.TbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 19);
            this.label3.TabIndex = 124;
            this.label3.Text = "Ingrese una ecuacion cuadratica";
            // 
            // TbC
            // 
            this.TbC.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbC.Location = new System.Drawing.Point(310, 183);
            this.TbC.Name = "TbC";
            this.TbC.Size = new System.Drawing.Size(34, 29);
            this.TbC.TabIndex = 123;
            this.TbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbC_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(270, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(34, 22);
            this.textBox7.TabIndex = 122;
            this.textBox7.Text = "x";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(211, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(13, 13);
            this.textBox5.TabIndex = 120;
            this.textBox5.Text = "2";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(184, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(34, 22);
            this.textBox4.TabIndex = 119;
            this.textBox4.Text = "x";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 117;
            this.label2.Text = "Ingrese f(x):";
            // 
            // TbXi
            // 
            this.TbXi.Location = new System.Drawing.Point(211, 79);
            this.TbXi.Name = "TbXi";
            this.TbXi.Size = new System.Drawing.Size(75, 20);
            this.TbXi.TabIndex = 116;
            this.TbXi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbXi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 115;
            this.label1.Text = "Ingrese Xi:";
            // 
            // TbLim
            // 
            this.TbLim.Location = new System.Drawing.Point(211, 30);
            this.TbLim.Name = "TbLim";
            this.TbLim.Size = new System.Drawing.Size(75, 20);
            this.TbLim.TabIndex = 114;
            this.TbLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLim_KeyPress);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(1, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(204, 25);
            this.lblA.TabIndex = 113;
            this.lblA.Text = "Porcentaje de Error:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 409);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 29);
            this.btnRegresar.TabIndex = 112;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Teal;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(144, 256);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 40);
            this.btnCalcular.TabIndex = 111;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(310, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 110;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(283, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 126;
            this.label4.Text = "%";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.ControlBox = false;
            this.Controls.Add(this.TbLim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.TbB);
            this.Controls.Add(this.TbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbC);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbXi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.DgvResultado);
            this.Name = "Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xinicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox TbB;
        private System.Windows.Forms.TextBox TbA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbC;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbXi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbLim;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
    }
}