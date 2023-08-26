namespace menuOpcoes_LPV
{
    partial class FmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btAlertas = new System.Windows.Forms.Button();
            this.btExemploAlerta = new System.Windows.Forms.Button();
            this.btAlteracaoRotulo = new System.Windows.Forms.Button();
            this.btComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DE OPÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btAlertas
            // 
            this.btAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlertas.Location = new System.Drawing.Point(231, 93);
            this.btAlertas.Name = "btAlertas";
            this.btAlertas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAlertas.Size = new System.Drawing.Size(368, 38);
            this.btAlertas.TabIndex = 1;
            this.btAlertas.Text = "ALERTAS";
            this.btAlertas.UseVisualStyleBackColor = true;
            this.btAlertas.Click += new System.EventHandler(this.btAlertas_Click);
            // 
            // btExemploAlerta
            // 
            this.btExemploAlerta.BackColor = System.Drawing.Color.LightCoral;
            this.btExemploAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploAlerta.Location = new System.Drawing.Point(231, 165);
            this.btExemploAlerta.Name = "btExemploAlerta";
            this.btExemploAlerta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btExemploAlerta.Size = new System.Drawing.Size(368, 38);
            this.btExemploAlerta.TabIndex = 2;
            this.btExemploAlerta.Text = "EXEMPLO COM ALERTA";
            this.btExemploAlerta.UseVisualStyleBackColor = false;
            this.btExemploAlerta.Click += new System.EventHandler(this.btExemploAlerta_Click);
            // 
            // btAlteracaoRotulo
            // 
            this.btAlteracaoRotulo.BackColor = System.Drawing.Color.LightGreen;
            this.btAlteracaoRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlteracaoRotulo.Location = new System.Drawing.Point(231, 236);
            this.btAlteracaoRotulo.Name = "btAlteracaoRotulo";
            this.btAlteracaoRotulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAlteracaoRotulo.Size = new System.Drawing.Size(368, 38);
            this.btAlteracaoRotulo.TabIndex = 3;
            this.btAlteracaoRotulo.Text = "EXEMPLO ALTERAÇÃO DE RÓTULO";
            this.btAlteracaoRotulo.UseVisualStyleBackColor = false;
            this.btAlteracaoRotulo.Click += new System.EventHandler(this.btAlteracaoRotulo_Click);
            // 
            // btComboBox
            // 
            this.btComboBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComboBox.Location = new System.Drawing.Point(231, 311);
            this.btComboBox.Name = "btComboBox";
            this.btComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btComboBox.Size = new System.Drawing.Size(368, 38);
            this.btComboBox.TabIndex = 4;
            this.btComboBox.Text = "EXEMPLO COM COMBOBOX";
            this.btComboBox.UseVisualStyleBackColor = false;
            this.btComboBox.Click += new System.EventHandler(this.btComboBox_Click);
            // 
            // FmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btComboBox);
            this.Controls.Add(this.btAlteracaoRotulo);
            this.Controls.Add(this.btExemploAlerta);
            this.Controls.Add(this.btAlertas);
            this.Controls.Add(this.label1);
            this.Name = "FmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlertas;
        private System.Windows.Forms.Button btExemploAlerta;
        private System.Windows.Forms.Button btAlteracaoRotulo;
        private System.Windows.Forms.Button btComboBox;
    }
}

