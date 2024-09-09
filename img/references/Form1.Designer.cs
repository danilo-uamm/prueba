namespace Ejercicio1
{
   partial class Form1
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
         this.label1 = new System.Windows.Forms.Label();
         this.tbNombre = new System.Windows.Forms.TextBox();
         this.cmbNombres = new System.Windows.Forms.ComboBox();
         this.button1 = new System.Windows.Forms.Button();
         this.btmNombres2 = new System.Windows.Forms.Button();
         this.cmbNombres2 = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(25, 55);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(84, 24);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nombre:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // tbNombre
         // 
         this.tbNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
         this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.tbNombre.Location = new System.Drawing.Point(115, 55);
         this.tbNombre.Name = "tbNombre";
         this.tbNombre.Size = new System.Drawing.Size(446, 26);
         this.tbNombre.TabIndex = 1;
         this.tbNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // cmbNombres
         // 
         this.cmbNombres.FormattingEnabled = true;
         this.cmbNombres.Location = new System.Drawing.Point(115, 129);
         this.cmbNombres.Name = "cmbNombres";
         this.cmbNombres.Size = new System.Drawing.Size(446, 21);
         this.cmbNombres.TabIndex = 3;
         // 
         // button1
         // 
         this.button1.Image = global::Ejercicio1.Properties.Resources.agregar_usuario;
         this.button1.Location = new System.Drawing.Point(577, 46);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(40, 46);
         this.button1.TabIndex = 2;
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // btmNombres2
         // 
         this.btmNombres2.Location = new System.Drawing.Point(122, 189);
         this.btmNombres2.Name = "btmNombres2";
         this.btmNombres2.Size = new System.Drawing.Size(438, 42);
         this.btmNombres2.TabIndex = 4;
         this.btmNombres2.Text = "Copiar";
         this.btmNombres2.UseVisualStyleBackColor = true;
         // 
         // cmbNombres2
         // 
         this.cmbNombres2.FormattingEnabled = true;
         this.cmbNombres2.Location = new System.Drawing.Point(125, 268);
         this.cmbNombres2.Name = "cmbNombres2";
         this.cmbNombres2.Size = new System.Drawing.Size(434, 21);
         this.cmbNombres2.TabIndex = 5;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.cmbNombres2);
         this.Controls.Add(this.btmNombres2);
         this.Controls.Add(this.cmbNombres);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.tbNombre);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbNombre;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.ComboBox cmbNombres;
      private System.Windows.Forms.Button btmNombres2;
      private System.Windows.Forms.ComboBox cmbNombres2;
   }
}