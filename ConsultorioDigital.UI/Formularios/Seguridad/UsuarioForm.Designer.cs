namespace ConsultorioDigital.UI.Formularios
{
  partial class UsuarioForm
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnCrear = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnActualizar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Buscar";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(15, 25);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(15, 51);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(443, 177);
      this.dataGridView1.TabIndex = 2;
      // 
      // btnCrear
      // 
      this.btnCrear.Location = new System.Drawing.Point(464, 51);
      this.btnCrear.Name = "btnCrear";
      this.btnCrear.Size = new System.Drawing.Size(75, 23);
      this.btnCrear.TabIndex = 3;
      this.btnCrear.Text = "Crear";
      this.btnCrear.UseVisualStyleBackColor = true;
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(464, 205);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 4;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(464, 80);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(75, 23);
      this.btnActualizar.TabIndex = 5;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      // 
      // UsuarioForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnCrear);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "UsuarioForm";
      this.Text = "UsuarioForm";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnActualizar;
  }
}