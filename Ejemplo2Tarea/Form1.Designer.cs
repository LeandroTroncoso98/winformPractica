
namespace Ejemplo2Tarea
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.cbxMonotributo = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lwDetalle = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(115, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(45, 117);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(98, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(115, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtOtro);
            this.gbxSexo.Controls.Add(this.rbtFemenino);
            this.gbxSexo.Controls.Add(this.rbtMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(48, 160);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(308, 51);
            this.gbxSexo.TabIndex = 5;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo: ";
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(214, 19);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(92, 17);
            this.rbtOtro.TabIndex = 2;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Hetero flexible";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(117, 19);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 1;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(21, 20);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(154, 235);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(36, 235);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(112, 13);
            this.lblFechaNac.TabIndex = 7;
            this.lblFechaNac.Text = "Fecha de nacimiento: ";
            // 
            // cbxMonotributo
            // 
            this.cbxMonotributo.AutoSize = true;
            this.cbxMonotributo.Location = new System.Drawing.Point(39, 260);
            this.cbxMonotributo.Name = "cbxMonotributo";
            this.cbxMonotributo.Size = new System.Drawing.Size(82, 17);
            this.cbxMonotributo.TabIndex = 8;
            this.cbxMonotributo.Text = "Monotributo";
            this.cbxMonotributo.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(39, 305);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(165, 43);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lwDetalle
            // 
            this.lwDetalle.HideSelection = false;
            this.lwDetalle.Location = new System.Drawing.Point(177, 354);
            this.lwDetalle.Name = "lwDetalle";
            this.lwDetalle.Size = new System.Drawing.Size(611, 84);
            this.lwDetalle.TabIndex = 10;
            this.lwDetalle.UseCompatibleStateImageBehavior = false;
            this.lwDetalle.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detalle del usuario : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwDetalle);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cbxMonotributo);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.CheckBox cbxMonotributo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListView lwDetalle;
        private System.Windows.Forms.Label label1;
    }
}

