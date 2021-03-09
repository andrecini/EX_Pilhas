namespace ExerciciosSobrePilhas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEmpilhar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnDesempilhar = new System.Windows.Forms.Button();
            this.btnTamanho = new System.Windows.Forms.Button();
            this.btnTopo = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSomar);
            this.tabPage1.Controls.Add(this.btnListar);
            this.tabPage1.Controls.Add(this.btnTopo);
            this.tabPage1.Controls.Add(this.btnTamanho);
            this.tabPage1.Controls.Add(this.btnDesempilhar);
            this.tabPage1.Controls.Add(this.txtSalario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnEmpilhar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ex. 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ex 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEmpilhar
            // 
            this.btnEmpilhar.Location = new System.Drawing.Point(20, 106);
            this.btnEmpilhar.Name = "btnEmpilhar";
            this.btnEmpilhar.Size = new System.Drawing.Size(113, 32);
            this.btnEmpilhar.TabIndex = 0;
            this.btnEmpilhar.Text = "Empilhar";
            this.btnEmpilhar.UseVisualStyleBackColor = true;
            this.btnEmpilhar.Click += new System.EventHandler(this.btnEmpilhar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 22);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salário (R$):";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(112, 61);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(141, 22);
            this.txtSalario.TabIndex = 4;
            // 
            // btnDesempilhar
            // 
            this.btnDesempilhar.Location = new System.Drawing.Point(149, 106);
            this.btnDesempilhar.Name = "btnDesempilhar";
            this.btnDesempilhar.Size = new System.Drawing.Size(113, 32);
            this.btnDesempilhar.TabIndex = 5;
            this.btnDesempilhar.Text = "Desempilhar";
            this.btnDesempilhar.UseVisualStyleBackColor = true;
            this.btnDesempilhar.Click += new System.EventHandler(this.btnDesempilhar_Click);
            // 
            // btnTamanho
            // 
            this.btnTamanho.Location = new System.Drawing.Point(20, 159);
            this.btnTamanho.Name = "btnTamanho";
            this.btnTamanho.Size = new System.Drawing.Size(113, 32);
            this.btnTamanho.TabIndex = 6;
            this.btnTamanho.Text = "Tamanho";
            this.btnTamanho.UseVisualStyleBackColor = true;
            this.btnTamanho.Click += new System.EventHandler(this.btnTamanho_Click);
            // 
            // btnTopo
            // 
            this.btnTopo.Location = new System.Drawing.Point(149, 159);
            this.btnTopo.Name = "btnTopo";
            this.btnTopo.Size = new System.Drawing.Size(113, 32);
            this.btnTopo.TabIndex = 7;
            this.btnTopo.Text = "Topo";
            this.btnTopo.UseVisualStyleBackColor = true;
            this.btnTopo.Click += new System.EventHandler(this.btnTopo_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(20, 209);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(113, 32);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar Dados";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(149, 209);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(113, 32);
            this.btnSomar.TabIndex = 9;
            this.btnSomar.Text = "Somar salários";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remover Base";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 312);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Pilhas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnTopo;
        private System.Windows.Forms.Button btnTamanho;
        private System.Windows.Forms.Button btnDesempilhar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpilhar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}

