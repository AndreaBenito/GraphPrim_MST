namespace Ejercicio3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvNodos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPrim = new System.Windows.Forms.DataGridView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearNodo = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnCrearAristaDirigida = new System.Windows.Forms.Button();
            this.btnAplicarPrim = new System.Windows.Forms.Button();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.btnMostrarGrafo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(568, 226);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvNodos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GRAFO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvNodos
            // 
            this.dgvNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvNodos.Location = new System.Drawing.Point(3, 9);
            this.dgvNodos.Name = "dgvNodos";
            this.dgvNodos.RowHeadersWidth = 51;
            this.dgvNodos.Size = new System.Drawing.Size(580, 241);
            this.dgvNodos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "VERTICES";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ADYACENTES";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMatriz);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MATRIZ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(6, 6);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.Size = new System.Drawing.Size(590, 241);
            this.dgvMatriz.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvPrim);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(449, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PRIM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvPrim
            // 
            this.dgvPrim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrim.Location = new System.Drawing.Point(7, 7);
            this.dgvPrim.Name = "dgvPrim";
            this.dgvPrim.RowHeadersWidth = 51;
            this.dgvPrim.Size = new System.Drawing.Size(590, 240);
            this.dgvPrim.TabIndex = 0;
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(703, 47);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(70, 20);
            this.txtNodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "VERTICE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "PESO:";
            // 
            // btnCrearNodo
            // 
            this.btnCrearNodo.Location = new System.Drawing.Point(647, 160);
            this.btnCrearNodo.Name = "btnCrearNodo";
            this.btnCrearNodo.Size = new System.Drawing.Size(126, 44);
            this.btnCrearNodo.TabIndex = 10;
            this.btnCrearNodo.Text = "Insertar Vertice ";
            this.btnCrearNodo.UseVisualStyleBackColor = true;
            this.btnCrearNodo.Click += new System.EventHandler(this.btnCrearNodo_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(869, 104);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(70, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DESTINO:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(869, 71);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(70, 20);
            this.txtDestino.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ORIGEN:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(869, 43);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(70, 20);
            this.txtOrigen.TabIndex = 13;
            // 
            // btnCrearAristaDirigida
            // 
            this.btnCrearAristaDirigida.Location = new System.Drawing.Point(813, 160);
            this.btnCrearAristaDirigida.Name = "btnCrearAristaDirigida";
            this.btnCrearAristaDirigida.Size = new System.Drawing.Size(126, 44);
            this.btnCrearAristaDirigida.TabIndex = 15;
            this.btnCrearAristaDirigida.Text = "Crear Arista ";
            this.btnCrearAristaDirigida.UseVisualStyleBackColor = true;
            this.btnCrearAristaDirigida.Click += new System.EventHandler(this.btnCrearAristaDirigida_Click);
            // 
            // btnAplicarPrim
            // 
            this.btnAplicarPrim.Location = new System.Drawing.Point(319, 19);
            this.btnAplicarPrim.Name = "btnAplicarPrim";
            this.btnAplicarPrim.Size = new System.Drawing.Size(126, 44);
            this.btnAplicarPrim.TabIndex = 16;
            this.btnAplicarPrim.Text = "Aplicar Prim (visual)";
            this.btnAplicarPrim.UseVisualStyleBackColor = true;
            this.btnAplicarPrim.Click += new System.EventHandler(this.btnAplicarPrim_Click);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Location = new System.Drawing.Point(20, 89);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(530, 416);
            this.panelCanvas.TabIndex = 17;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            // 
            // btnMostrarGrafo
            // 
            this.btnMostrarGrafo.Location = new System.Drawing.Point(124, 19);
            this.btnMostrarGrafo.Name = "btnMostrarGrafo";
            this.btnMostrarGrafo.Size = new System.Drawing.Size(126, 44);
            this.btnMostrarGrafo.TabIndex = 18;
            this.btnMostrarGrafo.Text = "Mostrar Grafo (visual)";
            this.btnMostrarGrafo.UseVisualStyleBackColor = true;
            this.btnMostrarGrafo.Click += new System.EventHandler(this.btnMostrarGrafo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(542, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Las aristas en verde forman el Árbol de Expansión Mínima, que conecta todos los n" +
    "odos con el menor costo total.";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1040, 518);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMostrarGrafo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.btnAplicarPrim);
            this.Controls.Add(this.btnCrearAristaDirigida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCrearNodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Visualizador Prim - Ejercicio3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvNodos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearNodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnCrearAristaDirigida;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPrim;
        private System.Windows.Forms.Button btnAplicarPrim;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Button btnMostrarGrafo;
        private System.Windows.Forms.Label label5;
    }
}