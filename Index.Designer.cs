
namespace Proyecto_MN_2._0
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btnError = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.btnInteracion = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.Teal;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnError.ForeColor = System.Drawing.Color.White;
            this.btnError.Location = new System.Drawing.Point(12, 228);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(99, 40);
            this.btnError.TabIndex = 68;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // Info
            // 
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.Black;
            this.Info.Location = new System.Drawing.Point(159, 110);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Info.Size = new System.Drawing.Size(228, 188);
            this.Info.TabIndex = 67;
            this.Info.Text = resources.GetString("Info.Text");
            this.Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInteracion
            // 
            this.btnInteracion.BackColor = System.Drawing.Color.Teal;
            this.btnInteracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteracion.ForeColor = System.Drawing.Color.White;
            this.btnInteracion.Location = new System.Drawing.Point(12, 146);
            this.btnInteracion.Name = "btnInteracion";
            this.btnInteracion.Size = new System.Drawing.Size(99, 40);
            this.btnInteracion.TabIndex = 66;
            this.btnInteracion.Text = "Iteración";
            this.btnInteracion.UseVisualStyleBackColor = false;
            this.btnInteracion.Click += new System.EventHandler(this.btnInteracion_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Titulo.Location = new System.Drawing.Point(92, 31);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(210, 34);
            this.Titulo.TabIndex = 65;
            this.Titulo.Text = "Metodo de Punto Fijo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(312, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Eliam Jesus Vazquez Parra #19211748";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.btnInteracion);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnSalir);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Puntp Fijo";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Button btnInteracion;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

