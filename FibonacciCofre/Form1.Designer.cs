namespace FibonacciCofre
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
            this.components = new System.ComponentModel.Container();
            this.lbPista = new System.Windows.Forms.Label();
            this.tbPista = new System.Windows.Forms.TextBox();
            this.btConfirmarCodigo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNovaPista = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPista
            // 
            this.lbPista.AutoSize = true;
            this.lbPista.Location = new System.Drawing.Point(12, 18);
            this.lbPista.Name = "lbPista";
            this.lbPista.Size = new System.Drawing.Size(36, 13);
            this.lbPista.TabIndex = 0;
            this.lbPista.Text = "Pista: ";
            // 
            // tbPista
            // 
            this.tbPista.Location = new System.Drawing.Point(54, 15);
            this.tbPista.Name = "tbPista";
            this.tbPista.Size = new System.Drawing.Size(155, 20);
            this.tbPista.TabIndex = 1;
            this.tbPista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPista_KeyPress);
            // 
            // btConfirmarCodigo
            // 
            this.btConfirmarCodigo.Location = new System.Drawing.Point(54, 41);
            this.btConfirmarCodigo.Name = "btConfirmarCodigo";
            this.btConfirmarCodigo.Size = new System.Drawing.Size(155, 23);
            this.btConfirmarCodigo.TabIndex = 2;
            this.btConfirmarCodigo.Text = "Confirmar código";
            this.btConfirmarCodigo.UseVisualStyleBackColor = true;
            this.btConfirmarCodigo.Click += new System.EventHandler(this.btConfirmarCodigo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stripTempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 120);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(221, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Tempo: ";
            // 
            // stripTempo
            // 
            this.stripTempo.Name = "stripTempo";
            this.stripTempo.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nova Pista:";
            // 
            // lbNovaPista
            // 
            this.lbNovaPista.AutoSize = true;
            this.lbNovaPista.Location = new System.Drawing.Point(91, 74);
            this.lbNovaPista.Name = "lbNovaPista";
            this.lbNovaPista.Size = new System.Drawing.Size(0, 13);
            this.lbNovaPista.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código: ";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(72, 97);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(0, 13);
            this.lbCodigo.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 142);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNovaPista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btConfirmarCodigo);
            this.Controls.Add(this.tbPista);
            this.Controls.Add(this.lbPista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cofre Fibonacci";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPista;
        private System.Windows.Forms.TextBox tbPista;
        private System.Windows.Forms.Button btConfirmarCodigo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stripTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNovaPista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Timer timer1;
    }
}

