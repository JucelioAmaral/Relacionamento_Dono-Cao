
using System;

namespace ProvaEdesoft
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRacaCao = new System.Windows.Forms.TextBox();
            this.txtNomeCao = new System.Windows.Forms.TextBox();
            this.txtNomeDono = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblRacaDoCao = new System.Windows.Forms.Label();
            this.lblNomeCao = new System.Windows.Forms.Label();
            this.lblNomeDoDono = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGerarRelatório = new System.Windows.Forms.Button();
            this.txtInformeRacaCao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRacaCao);
            this.groupBox1.Controls.Add(this.txtNomeCao);
            this.groupBox1.Controls.Add(this.txtNomeDono);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblRacaDoCao);
            this.groupBox1.Controls.Add(this.lblNomeCao);
            this.groupBox1.Controls.Add(this.lblNomeDoDono);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controle do dono e cão";
            // 
            // txtRacaCao
            // 
            this.txtRacaCao.Location = new System.Drawing.Point(117, 96);
            this.txtRacaCao.Name = "txtRacaCao";
            this.txtRacaCao.Size = new System.Drawing.Size(471, 20);
            this.txtRacaCao.TabIndex = 9;
            // 
            // txtNomeCao
            // 
            this.txtNomeCao.Location = new System.Drawing.Point(117, 57);
            this.txtNomeCao.Name = "txtNomeCao";
            this.txtNomeCao.Size = new System.Drawing.Size(471, 20);
            this.txtNomeCao.TabIndex = 8;
            // 
            // txtNomeDono
            // 
            this.txtNomeDono.Location = new System.Drawing.Point(117, 29);
            this.txtNomeDono.Name = "txtNomeDono";
            this.txtNomeDono.Size = new System.Drawing.Size(471, 20);
            this.txtNomeDono.TabIndex = 7;
            this.txtNomeDono.TextChanged += new System.EventHandler(this.txtNomeDono_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(418, 141);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(337, 141);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(256, 141);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblRacaDoCao
            // 
            this.lblRacaDoCao.AutoSize = true;
            this.lblRacaDoCao.Location = new System.Drawing.Point(21, 99);
            this.lblRacaDoCao.Name = "lblRacaDoCao";
            this.lblRacaDoCao.Size = new System.Drawing.Size(70, 13);
            this.lblRacaDoCao.TabIndex = 2;
            this.lblRacaDoCao.Text = "Raça do Cão";
            this.lblRacaDoCao.Click += new System.EventHandler(this.lblRacaDoCao_Click);
            // 
            // lblNomeCao
            // 
            this.lblNomeCao.AutoSize = true;
            this.lblNomeCao.Location = new System.Drawing.Point(19, 60);
            this.lblNomeCao.Name = "lblNomeCao";
            this.lblNomeCao.Size = new System.Drawing.Size(72, 13);
            this.lblNomeCao.TabIndex = 1;
            this.lblNomeCao.Text = "Nome do Cão";
            // 
            // lblNomeDoDono
            // 
            this.lblNomeDoDono.AutoSize = true;
            this.lblNomeDoDono.Location = new System.Drawing.Point(19, 32);
            this.lblNomeDoDono.Name = "lblNomeDoDono";
            this.lblNomeDoDono.Size = new System.Drawing.Size(77, 13);
            this.lblNomeDoDono.TabIndex = 0;
            this.lblNomeDoDono.Text = "Nome do dono";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGerarRelatório);
            this.groupBox2.Controls.Add(this.txtInformeRacaCao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerar relatório";
            // 
            // btnGerarRelatório
            // 
            this.btnGerarRelatório.Location = new System.Drawing.Point(9, 60);
            this.btnGerarRelatório.Name = "btnGerarRelatório";
            this.btnGerarRelatório.Size = new System.Drawing.Size(108, 23);
            this.btnGerarRelatório.TabIndex = 10;
            this.btnGerarRelatório.Text = "Gerar relatório";
            this.btnGerarRelatório.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerarRelatório.UseVisualStyleBackColor = true;
            this.btnGerarRelatório.Click += new System.EventHandler(this.btnGerarRelatório_Click);
            // 
            // txtInformeRacaCao
            // 
            this.txtInformeRacaCao.Location = new System.Drawing.Point(117, 19);
            this.txtInformeRacaCao.Name = "txtInformeRacaCao";
            this.txtInformeRacaCao.Size = new System.Drawing.Size(471, 20);
            this.txtInformeRacaCao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informe a raça do cão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cadastro de Dono e seu Cão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void lblRacaDoCao_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRacaCao;
        private System.Windows.Forms.TextBox txtNomeCao;
        private System.Windows.Forms.TextBox txtNomeDono;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblRacaDoCao;
        private System.Windows.Forms.Label lblNomeCao;
        private System.Windows.Forms.Label lblNomeDoDono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGerarRelatório;
        private System.Windows.Forms.TextBox txtInformeRacaCao;
        private System.Windows.Forms.Label label4;
    }
}

