namespace ShopApp
{
    partial class ProductForm
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
            this.txtprdct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprdcprice = new System.Windows.Forms.TextBox();
            this.richtxtdescrpt = new System.Windows.Forms.RichTextBox();
            this.labeldes = new System.Windows.Forms.Label();
            this.btnAddproduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbboxCategory = new System.Windows.Forms.ComboBox();
            this.cmbboxSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prodoct name";
            // 
            // txtprdct
            // 
            this.txtprdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprdct.Location = new System.Drawing.Point(25, 45);
            this.txtprdct.Name = "txtprdct";
            this.txtprdct.Size = new System.Drawing.Size(173, 26);
            this.txtprdct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // txtprdcprice
            // 
            this.txtprdcprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprdcprice.Location = new System.Drawing.Point(24, 106);
            this.txtprdcprice.Name = "txtprdcprice";
            this.txtprdcprice.Size = new System.Drawing.Size(173, 26);
            this.txtprdcprice.TabIndex = 1;
            this.txtprdcprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // richtxtdescrpt
            // 
            this.richtxtdescrpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtdescrpt.Location = new System.Drawing.Point(26, 339);
            this.richtxtdescrpt.Name = "richtxtdescrpt";
            this.richtxtdescrpt.Size = new System.Drawing.Size(171, 30);
            this.richtxtdescrpt.TabIndex = 2;
            this.richtxtdescrpt.Text = "";
            // 
            // labeldes
            // 
            this.labeldes.AutoSize = true;
            this.labeldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldes.Location = new System.Drawing.Point(23, 314);
            this.labeldes.Name = "labeldes";
            this.labeldes.Size = new System.Drawing.Size(89, 20);
            this.labeldes.TabIndex = 0;
            this.labeldes.Text = "Description";
            // 
            // btnAddproduct
            // 
            this.btnAddproduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddproduct.FlatAppearance.BorderSize = 0;
            this.btnAddproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddproduct.Location = new System.Drawing.Point(253, 414);
            this.btnAddproduct.Name = "btnAddproduct";
            this.btnAddproduct.Size = new System.Drawing.Size(162, 49);
            this.btnAddproduct.TabIndex = 3;
            this.btnAddproduct.Text = "ADD";
            this.btnAddproduct.UseVisualStyleBackColor = false;
            this.btnAddproduct.Click += new System.EventHandler(this.btnAddproduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 324);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAddproduct_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(628, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAddproduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(22, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(25, 168);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(173, 26);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // cmbboxCategory
            // 
            this.cmbboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxCategory.FormattingEnabled = true;
            this.cmbboxCategory.Location = new System.Drawing.Point(24, 232);
            this.cmbboxCategory.Name = "cmbboxCategory";
            this.cmbboxCategory.Size = new System.Drawing.Size(173, 21);
            this.cmbboxCategory.TabIndex = 5;
            this.cmbboxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbboxCategory_SelectedIndexChanged);
            // 
            // cmbboxSize
            // 
            this.cmbboxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxSize.FormattingEnabled = true;
            this.cmbboxSize.Location = new System.Drawing.Point(25, 279);
            this.cmbboxSize.Name = "cmbboxSize";
            this.cmbboxSize.Size = new System.Drawing.Size(173, 21);
            this.cmbboxSize.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(22, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Size";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(802, 475);
            this.Controls.Add(this.cmbboxSize);
            this.Controls.Add(this.cmbboxCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddproduct);
            this.Controls.Add(this.richtxtdescrpt);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtprdcprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeldes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprdct);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprdct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprdcprice;
        private System.Windows.Forms.RichTextBox richtxtdescrpt;
        private System.Windows.Forms.Label labeldes;
        private System.Windows.Forms.Button btnAddproduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbboxCategory;
        private System.Windows.Forms.ComboBox cmbboxSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}