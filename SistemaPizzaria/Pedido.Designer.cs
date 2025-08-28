﻿namespace SistemaPizzaria
{
    partial class Pedido
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.lblValorOpicionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpOpcionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(457, 430);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 45);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(20, 34);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(107, 17);
            this.chkBorda.TabIndex = 1;
            this.chkBorda.Text = "Borda Recheada";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(88, 52);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(215, 21);
            this.cmbTamanhoPizza.TabIndex = 2;
            this.cmbTamanhoPizza.Text = "TAMAMANHO DA PIZZA";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(427, 263);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(580, 150);
            this.dgvPedido.TabIndex = 3;
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.Location = new System.Drawing.Point(454, 60);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(95, 13);
            this.lblValorPizza.TabIndex = 4;
            this.lblValorPizza.Text = "VALOR DA PIZZA";
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkTempero);
            this.grpOpcionais.Controls.Add(this.chkCatupiry);
            this.grpOpcionais.Controls.Add(this.chkCebola);
            this.grpOpcionais.Controls.Add(this.chkBorda);
            this.grpOpcionais.Location = new System.Drawing.Point(88, 263);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(200, 201);
            this.grpOpcionais.TabIndex = 5;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(20, 103);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(103, 17);
            this.chkTempero.TabIndex = 4;
            this.chkTempero.Text = "Tempero do City";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(20, 80);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(102, 17);
            this.chkCatupiry.TabIndex = 3;
            this.chkCatupiry.Text = "Catupiry Original";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(20, 57);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(111, 17);
            this.chkCebola.TabIndex = 2;
            this.chkCebola.Text = "Cebola sem choro";
            this.chkCebola.UseVisualStyleBackColor = true;
            this.chkCebola.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(441, 91);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(127, 20);
            this.txtValorPizza.TabIndex = 6;
            // 
            // lblValorOpicionais
            // 
            this.lblValorOpicionais.AutoSize = true;
            this.lblValorOpicionais.Location = new System.Drawing.Point(619, 60);
            this.lblValorOpicionais.Name = "lblValorOpicionais";
            this.lblValorOpicionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpicionais.TabIndex = 7;
            this.lblValorOpicionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(813, 60);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 8;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(622, 91);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(127, 20);
            this.txtValorOpcionais.TabIndex = 9;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(800, 91);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(127, 20);
            this.txtValorPagar.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(599, 430);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 45);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(753, 430);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 45);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(892, 430);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 45);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 572);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpicionais);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.lblValorPizza);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.btnNovo);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label lblValorPizza;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.Label lblValorOpicionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}