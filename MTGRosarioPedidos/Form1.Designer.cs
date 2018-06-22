namespace MTGRosarioPedidos
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
            this.Enviar = new System.Windows.Forms.Button();
            this.MTGMintcard = new System.Windows.Forms.LinkLabel();
            this.MTGRosario = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InserteLink = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Finalizar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expansion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioIndividual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Enviar
            // 
            this.Enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Enviar.Location = new System.Drawing.Point(642, 25);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 0;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MTGMintcard
            // 
            this.MTGMintcard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MTGMintcard.AutoSize = true;
            this.MTGMintcard.Location = new System.Drawing.Point(12, 428);
            this.MTGMintcard.Name = "MTGMintcard";
            this.MTGMintcard.Size = new System.Drawing.Size(72, 13);
            this.MTGMintcard.TabIndex = 1;
            this.MTGMintcard.TabStop = true;
            this.MTGMintcard.Text = "MTGMintcard";
            this.MTGMintcard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MTGMintcard_LinkClicked);
            // 
            // MTGRosario
            // 
            this.MTGRosario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MTGRosario.AutoSize = true;
            this.MTGRosario.Location = new System.Drawing.Point(114, 428);
            this.MTGRosario.Name = "MTGRosario";
            this.MTGRosario.Size = new System.Drawing.Size(70, 13);
            this.MTGRosario.TabIndex = 2;
            this.MTGRosario.TabStop = true;
            this.MTGRosario.Text = "MTG Rosario";
            this.MTGRosario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MTGRosario_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(94, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 20);
            this.textBox1.TabIndex = 3;
            // 
            // InserteLink
            // 
            this.InserteLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InserteLink.AutoSize = true;
            this.InserteLink.Location = new System.Drawing.Point(288, 9);
            this.InserteLink.Name = "InserteLink";
            this.InserteLink.Size = new System.Drawing.Size(116, 13);
            this.InserteLink.TabIndex = 4;
            this.InserteLink.Text = "Inserte Link de la Carta";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Expansion,
            this.PrecioIndividual});
            this.dataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGrid.Location = new System.Drawing.Point(12, 132);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.Size = new System.Drawing.Size(624, 283);
            this.dataGrid.TabIndex = 5;
            // 
            // Finalizar
            // 
            this.Finalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Finalizar.Location = new System.Drawing.Point(642, 415);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(75, 23);
            this.Finalizar.TabIndex = 8;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(15, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre y apellido:";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.ToolTipText = "Nombre de la carta";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Expansion
            // 
            this.Expansion.HeaderText = "Expansión";
            this.Expansion.Name = "Expansion";
            this.Expansion.ReadOnly = true;
            // 
            // PrecioIndividual
            // 
            this.PrecioIndividual.HeaderText = "Precio Individual";
            this.PrecioIndividual.Name = "PrecioIndividual";
            this.PrecioIndividual.ReadOnly = true;
            this.PrecioIndividual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.InserteLink);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MTGRosario);
            this.Controls.Add(this.MTGMintcard);
            this.Controls.Add(this.Enviar);
            this.Name = "Form1";
            this.Text = "MTGRosario Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.LinkLabel MTGMintcard;
        private System.Windows.Forms.LinkLabel MTGRosario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InserteLink;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expansion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioIndividual;
    }
}

