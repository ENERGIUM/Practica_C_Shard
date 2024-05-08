namespace PracticaForm
{
    partial class Registro
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
            this.gbDetalleDeUsuario = new System.Windows.Forms.GroupBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.laNombre = new System.Windows.Forms.Label();
            this.laDirección = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBDirección = new System.Windows.Forms.TextBox();
            this.laEdad = new System.Windows.Forms.Label();
            this.rBMasculino = new System.Windows.Forms.RadioButton();
            this.rBFemenino = new System.Windows.Forms.RadioButton();
            this.rBIndefinido = new System.Windows.Forms.RadioButton();
            this.cBCshard = new System.Windows.Forms.CheckBox();
            this.cBCmasmas = new System.Windows.Forms.CheckBox();
            this.cBJavascript = new System.Windows.Forms.CheckBox();
            this.lBPais = new System.Windows.Forms.ListBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.laPaís = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.gbDetalleDeUsuario.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.gbCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalleDeUsuario
            // 
            this.gbDetalleDeUsuario.Controls.Add(this.numericUpDownEdad);
            this.gbDetalleDeUsuario.Controls.Add(this.laEdad);
            this.gbDetalleDeUsuario.Controls.Add(this.tBDirección);
            this.gbDetalleDeUsuario.Controls.Add(this.tBNombre);
            this.gbDetalleDeUsuario.Controls.Add(this.laDirección);
            this.gbDetalleDeUsuario.Controls.Add(this.laNombre);
            this.gbDetalleDeUsuario.Location = new System.Drawing.Point(119, 75);
            this.gbDetalleDeUsuario.Name = "gbDetalleDeUsuario";
            this.gbDetalleDeUsuario.Size = new System.Drawing.Size(207, 133);
            this.gbDetalleDeUsuario.TabIndex = 0;
            this.gbDetalleDeUsuario.TabStop = false;
            this.gbDetalleDeUsuario.Text = "Detalle del Usuario";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rBIndefinido);
            this.gbGenero.Controls.Add(this.rBFemenino);
            this.gbGenero.Controls.Add(this.rBMasculino);
            this.gbGenero.Location = new System.Drawing.Point(488, 75);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(135, 112);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.cBJavascript);
            this.gbCurso.Controls.Add(this.cBCmasmas);
            this.gbCurso.Controls.Add(this.cBCshard);
            this.gbCurso.Location = new System.Drawing.Point(488, 204);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(135, 103);
            this.gbCurso.TabIndex = 2;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Curso";
            // 
            // laNombre
            // 
            this.laNombre.AutoSize = true;
            this.laNombre.Location = new System.Drawing.Point(17, 31);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(44, 13);
            this.laNombre.TabIndex = 0;
            this.laNombre.Text = "Nombre";
            this.laNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // laDirección
            // 
            this.laDirección.AutoSize = true;
            this.laDirección.Location = new System.Drawing.Point(16, 58);
            this.laDirección.Name = "laDirección";
            this.laDirección.Size = new System.Drawing.Size(52, 13);
            this.laDirección.TabIndex = 1;
            this.laDirección.Text = "Dirección";
            this.laDirección.Click += new System.EventHandler(this.laApellido_Click);
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(80, 27);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(100, 20);
            this.tBNombre.TabIndex = 2;
            this.tBNombre.TextChanged += new System.EventHandler(this.tBNombre_TextChanged);
            // 
            // tBDirección
            // 
            this.tBDirección.Location = new System.Drawing.Point(80, 55);
            this.tBDirección.Name = "tBDirección";
            this.tBDirección.Size = new System.Drawing.Size(100, 20);
            this.tBDirección.TabIndex = 3;
            this.tBDirección.TextChanged += new System.EventHandler(this.tBDirección_TextChanged);
            // 
            // laEdad
            // 
            this.laEdad.AutoSize = true;
            this.laEdad.Location = new System.Drawing.Point(20, 92);
            this.laEdad.Name = "laEdad";
            this.laEdad.Size = new System.Drawing.Size(32, 13);
            this.laEdad.TabIndex = 4;
            this.laEdad.Text = "Edad";
            this.laEdad.Click += new System.EventHandler(this.label3_Click);
            // 
            // rBMasculino
            // 
            this.rBMasculino.AutoSize = true;
            this.rBMasculino.Location = new System.Drawing.Point(46, 28);
            this.rBMasculino.Name = "rBMasculino";
            this.rBMasculino.Size = new System.Drawing.Size(68, 17);
            this.rBMasculino.TabIndex = 0;
            this.rBMasculino.TabStop = true;
            this.rBMasculino.Text = "Maculino";
            this.rBMasculino.UseVisualStyleBackColor = true;
            this.rBMasculino.CheckedChanged += new System.EventHandler(this.rBMasculino_CheckedChanged);
            // 
            // rBFemenino
            // 
            this.rBFemenino.AutoSize = true;
            this.rBFemenino.Location = new System.Drawing.Point(46, 51);
            this.rBFemenino.Name = "rBFemenino";
            this.rBFemenino.Size = new System.Drawing.Size(71, 17);
            this.rBFemenino.TabIndex = 1;
            this.rBFemenino.TabStop = true;
            this.rBFemenino.Text = "Femenino";
            this.rBFemenino.UseVisualStyleBackColor = true;
            this.rBFemenino.CheckedChanged += new System.EventHandler(this.rBFemenino_CheckedChanged);
            // 
            // rBIndefinido
            // 
            this.rBIndefinido.AutoSize = true;
            this.rBIndefinido.Location = new System.Drawing.Point(46, 74);
            this.rBIndefinido.Name = "rBIndefinido";
            this.rBIndefinido.Size = new System.Drawing.Size(71, 17);
            this.rBIndefinido.TabIndex = 2;
            this.rBIndefinido.TabStop = true;
            this.rBIndefinido.Text = "Indefinido";
            this.rBIndefinido.UseVisualStyleBackColor = true;
            this.rBIndefinido.CheckedChanged += new System.EventHandler(this.rBIndefinido_CheckedChanged);
            // 
            // cBCshard
            // 
            this.cBCshard.AutoSize = true;
            this.cBCshard.Location = new System.Drawing.Point(46, 30);
            this.cBCshard.Name = "cBCshard";
            this.cBCshard.Size = new System.Drawing.Size(40, 17);
            this.cBCshard.TabIndex = 0;
            this.cBCshard.Text = "C#";
            this.cBCshard.UseVisualStyleBackColor = true;
            this.cBCshard.CheckedChanged += new System.EventHandler(this.cBCshard_CheckedChanged);
            // 
            // cBCmasmas
            // 
            this.cBCmasmas.AutoSize = true;
            this.cBCmasmas.Location = new System.Drawing.Point(46, 53);
            this.cBCmasmas.Name = "cBCmasmas";
            this.cBCmasmas.Size = new System.Drawing.Size(45, 17);
            this.cBCmasmas.TabIndex = 1;
            this.cBCmasmas.Text = "C++";
            this.cBCmasmas.UseVisualStyleBackColor = true;
            this.cBCmasmas.CheckedChanged += new System.EventHandler(this.cB2_CheckedChanged);
            // 
            // cBJavascript
            // 
            this.cBJavascript.AutoSize = true;
            this.cBJavascript.Location = new System.Drawing.Point(46, 76);
            this.cBJavascript.Name = "cBJavascript";
            this.cBJavascript.Size = new System.Drawing.Size(74, 17);
            this.cBJavascript.TabIndex = 2;
            this.cBJavascript.Text = "Javascript";
            this.cBJavascript.UseVisualStyleBackColor = true;
            this.cBJavascript.CheckedChanged += new System.EventHandler(this.cBJavascript_CheckedChanged);
            // 
            // lBPais
            // 
            this.lBPais.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lBPais.FormattingEnabled = true;
            this.lBPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lBPais.Location = new System.Drawing.Point(119, 271);
            this.lBPais.Name = "lBPais";
            this.lBPais.Size = new System.Drawing.Size(207, 108);
            this.lBPais.TabIndex = 0;
            this.lBPais.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(80, 90);
            this.numericUpDownEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownEdad.TabIndex = 5;
            this.numericUpDownEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownEdad.ValueChanged += new System.EventHandler(this.numericUpDownEdad_ValueChanged);
            // 
            // laPaís
            // 
            this.laPaís.AutoSize = true;
            this.laPaís.Location = new System.Drawing.Point(119, 252);
            this.laPaís.Name = "laPaís";
            this.laPaís.Size = new System.Drawing.Size(29, 13);
            this.laPaís.TabIndex = 3;
            this.laPaís.Text = "País";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(521, 349);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(81, 30);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.laPaís);
            this.Controls.Add(this.lBPais);
            this.Controls.Add(this.gbCurso);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDetalleDeUsuario);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.gbDetalleDeUsuario.ResumeLayout(false);
            this.gbDetalleDeUsuario.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalleDeUsuario;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.Label laEdad;
        private System.Windows.Forms.TextBox tBDirección;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.Label laDirección;
        private System.Windows.Forms.Label laNombre;
        private System.Windows.Forms.RadioButton rBIndefinido;
        private System.Windows.Forms.RadioButton rBFemenino;
        private System.Windows.Forms.RadioButton rBMasculino;
        private System.Windows.Forms.CheckBox cBJavascript;
        private System.Windows.Forms.CheckBox cBCmasmas;
        private System.Windows.Forms.CheckBox cBCshard;
        private System.Windows.Forms.ListBox lBPais;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.Label laPaís;
        private System.Windows.Forms.Button buttonIngresar;
    }
}

