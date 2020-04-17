namespace EJ_GUIA_L3._3
{
    partial class Form1
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
            this.contlbl = new System.Windows.Forms.Label();
            this.desconect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.conect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pal = new System.Windows.Forms.RadioButton();
            this.mayu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.altura_1 = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contlbl
            // 
            this.contlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contlbl.Location = new System.Drawing.Point(473, 222);
            this.contlbl.Name = "contlbl";
            this.contlbl.Size = new System.Drawing.Size(181, 72);
            this.contlbl.TabIndex = 20;
            // 
            // desconect
            // 
            this.desconect.Location = new System.Drawing.Point(44, 426);
            this.desconect.Name = "desconect";
            this.desconect.Size = new System.Drawing.Size(110, 38);
            this.desconect.TabIndex = 18;
            this.desconect.Text = "DESCONECTAR";
            this.desconect.UseVisualStyleBackColor = true;
            this.desconect.Click += new System.EventHandler(this.desconect_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 77);
            this.button1.TabIndex = 19;
            this.button1.Text = "¿Cuantos servicios?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conect
            // 
            this.conect.Location = new System.Drawing.Point(44, 38);
            this.conect.Name = "conect";
            this.conect.Size = new System.Drawing.Size(110, 38);
            this.conect.TabIndex = 17;
            this.conect.Text = "CONECTAR";
            this.conect.UseVisualStyleBackColor = true;
            this.conect.Click += new System.EventHandler(this.conect_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.pal);
            this.groupBox1.Controls.Add(this.mayu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.altura_1);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(44, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 282);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // pal
            // 
            this.pal.AutoSize = true;
            this.pal.Location = new System.Drawing.Point(116, 162);
            this.pal.Name = "pal";
            this.pal.Size = new System.Drawing.Size(180, 17);
            this.pal.TabIndex = 13;
            this.pal.TabStop = true;
            this.pal.Text = "Dime si mi nombre es palíndromo";
            this.pal.UseVisualStyleBackColor = true;
            // 
            // mayu
            // 
            this.mayu.AutoSize = true;
            this.mayu.Location = new System.Drawing.Point(116, 185);
            this.mayu.Name = "mayu";
            this.mayu.Size = new System.Drawing.Size(209, 17);
            this.mayu.TabIndex = 12;
            this.mayu.TabStop = true;
            this.mayu.Text = "Devuélveme mi nombre en mayúsculas";
            this.mayu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Altura";
            // 
            // altura_1
            // 
            this.altura_1.Location = new System.Drawing.Point(116, 57);
            this.altura_1.Name = "altura_1";
            this.altura_1.Size = new System.Drawing.Size(164, 20);
            this.altura_1.TabIndex = 10;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(116, 139);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(98, 17);
            this.altura.TabIndex = 9;
            this.altura.TabStop = true;
            this.altura.Text = "Dime si soy alto";
            this.altura.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(116, 116);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(166, 17);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(116, 93);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(156, 17);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(116, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.contlbl);
            this.Controls.Add(this.desconect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label contlbl;
        private System.Windows.Forms.Button desconect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button conect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pal;
        private System.Windows.Forms.RadioButton mayu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altura_1;
        private System.Windows.Forms.RadioButton altura;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nombre;
    }
}

