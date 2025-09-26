namespace TelaCadastroCliente
{
    partial class TelaCadastro
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
            this.button1 = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_procurar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.masked_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_razao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_fantasia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_inscricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_endereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.masked_cep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_cidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_uf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_pais = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.masked_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.masked_celular = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(273, 12);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 37);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(192, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 37);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(111, 11);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 38);
            this.Salvar.TabIndex = 3;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(354, 11);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 38);
            this.Excluir.TabIndex = 4;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Procurar";
            // 
            // text_procurar
            // 
            this.text_procurar.Location = new System.Drawing.Point(66, 69);
            this.text_procurar.Name = "text_procurar";
            this.text_procurar.Size = new System.Drawing.Size(327, 20);
            this.text_procurar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CNPJ";
            // 
            // masked_cnpj
            // 
            this.masked_cnpj.Location = new System.Drawing.Point(16, 119);
            this.masked_cnpj.Mask = "99.999.999/9999-99";
            this.masked_cnpj.Name = "masked_cnpj";
            this.masked_cnpj.Size = new System.Drawing.Size(112, 20);
            this.masked_cnpj.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Razão Social";
            // 
            // text_razao
            // 
            this.text_razao.Location = new System.Drawing.Point(154, 118);
            this.text_razao.Name = "text_razao";
            this.text_razao.Size = new System.Drawing.Size(297, 20);
            this.text_razao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome Fantasia";
            // 
            // text_fantasia
            // 
            this.text_fantasia.Location = new System.Drawing.Point(16, 171);
            this.text_fantasia.Name = "text_fantasia";
            this.text_fantasia.Size = new System.Drawing.Size(205, 20);
            this.text_fantasia.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inscrição Estadual";
            // 
            // text_inscricao
            // 
            this.text_inscricao.Location = new System.Drawing.Point(238, 171);
            this.text_inscricao.Name = "text_inscricao";
            this.text_inscricao.Size = new System.Drawing.Size(213, 20);
            this.text_inscricao.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Endereço";
            // 
            // text_endereco
            // 
            this.text_endereco.Location = new System.Drawing.Point(16, 215);
            this.text_endereco.Name = "text_endereco";
            this.text_endereco.Size = new System.Drawing.Size(205, 20);
            this.text_endereco.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bairro";
            // 
            // text_bairro
            // 
            this.text_bairro.Location = new System.Drawing.Point(238, 214);
            this.text_bairro.Name = "text_bairro";
            this.text_bairro.Size = new System.Drawing.Size(213, 20);
            this.text_bairro.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "CEP";
            // 
            // masked_cep
            // 
            this.masked_cep.Location = new System.Drawing.Point(19, 265);
            this.masked_cep.Mask = "99.999-999";
            this.masked_cep.Name = "masked_cep";
            this.masked_cep.Size = new System.Drawing.Size(72, 20);
            this.masked_cep.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cidade";
            // 
            // text_cidade
            // 
            this.text_cidade.Location = new System.Drawing.Point(111, 264);
            this.text_cidade.Name = "text_cidade";
            this.text_cidade.Size = new System.Drawing.Size(100, 20);
            this.text_cidade.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "UF";
            // 
            // text_uf
            // 
            this.text_uf.Location = new System.Drawing.Point(238, 264);
            this.text_uf.Name = "text_uf";
            this.text_uf.Size = new System.Drawing.Size(34, 20);
            this.text_uf.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pais";
            // 
            // text_pais
            // 
            this.text_pais.Location = new System.Drawing.Point(297, 265);
            this.text_pais.Name = "text_pais";
            this.text_pais.Size = new System.Drawing.Size(154, 20);
            this.text_pais.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "E-mail";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(19, 319);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(432, 20);
            this.text_email.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Telefone";
            // 
            // masked_telefone
            // 
            this.masked_telefone.Location = new System.Drawing.Point(16, 363);
            this.masked_telefone.Mask = "(00) 00000-0000";
            this.masked_telefone.Name = "masked_telefone";
            this.masked_telefone.Size = new System.Drawing.Size(100, 20);
            this.masked_telefone.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Celular";
            // 
            // masked_celular
            // 
            this.masked_celular.Location = new System.Drawing.Point(157, 362);
            this.masked_celular.Mask = "(00) 00000-0000";
            this.masked_celular.Name = "masked_celular";
            this.masked_celular.Size = new System.Drawing.Size(100, 20);
            this.masked_celular.TabIndex = 32;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.masked_celular);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.masked_telefone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_pais);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_uf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_cidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.masked_cep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_bairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_endereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_inscricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_fantasia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_razao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.masked_cnpj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_procurar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.button1);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_procurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox masked_cnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_razao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_fantasia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_inscricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox masked_cep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_cidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_uf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_pais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox masked_telefone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox masked_celular;
    }
}