
namespace CategoriasProductos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngetnames = new System.Windows.Forms.Button();
            this.btngetdata = new System.Windows.Forms.Button();
            this.lstProductsNames = new System.Windows.Forms.ListBox();
            this.dgAllProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetnames
            // 
            this.btngetnames.BackColor = System.Drawing.Color.DodgerBlue;
            this.btngetnames.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btngetnames.Location = new System.Drawing.Point(79, 75);
            this.btngetnames.Name = "btngetnames";
            this.btngetnames.Size = new System.Drawing.Size(101, 30);
            this.btngetnames.TabIndex = 0;
            this.btngetnames.Text = "Ver Categorias";
            this.btngetnames.UseVisualStyleBackColor = false;
            this.btngetnames.Click += new System.EventHandler(this.btngetnames_Click);
            // 
            // btngetdata
            // 
            this.btngetdata.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btngetdata.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btngetdata.Location = new System.Drawing.Point(79, 194);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(101, 29);
            this.btngetdata.TabIndex = 1;
            this.btngetdata.Text = "Mostrar Productos ";
            this.btngetdata.UseVisualStyleBackColor = false;
            this.btngetdata.Click += new System.EventHandler(this.btngetdata_Click);
            // 
            // lstProductsNames
            // 
            this.lstProductsNames.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstProductsNames.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstProductsNames.FormattingEnabled = true;
            this.lstProductsNames.Location = new System.Drawing.Point(216, 75);
            this.lstProductsNames.Name = "lstProductsNames";
            this.lstProductsNames.Size = new System.Drawing.Size(250, 82);
            this.lstProductsNames.TabIndex = 2;
            // 
            // dgAllProducts
            // 
            this.dgAllProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllProducts.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgAllProducts.Location = new System.Drawing.Point(216, 194);
            this.dgAllProducts.Name = "dgAllProducts";
            this.dgAllProducts.Size = new System.Drawing.Size(545, 185);
            this.dgAllProducts.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgAllProducts);
            this.Controls.Add(this.lstProductsNames);
            this.Controls.Add(this.btngetdata);
            this.Controls.Add(this.btngetnames);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "BIENVENIDOS A TIENDA EL CARIBE";
            this.TransparencyKey = System.Drawing.Color.Blue;
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngetnames;
        private System.Windows.Forms.Button btngetdata;
        private System.Windows.Forms.ListBox lstProductsNames;
        private System.Windows.Forms.DataGridView dgAllProducts;
    }
}

