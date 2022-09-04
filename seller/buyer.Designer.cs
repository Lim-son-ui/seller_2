
namespace seller
{
    partial class buyer
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
            this.picb_product = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.cmb_buy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picb_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_product
            // 
            this.picb_product.BackColor = System.Drawing.Color.MistyRose;
            this.picb_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_product.Location = new System.Drawing.Point(110, 295);
            this.picb_product.Name = "picb_product";
            this.picb_product.Size = new System.Drawing.Size(364, 158);
            this.picb_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_product.TabIndex = 34;
            this.picb_product.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "細看圖片";
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(30, 499);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(80, 37);
            this.btn_buy.TabIndex = 45;
            this.btn_buy.Text = "購買";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(28, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "商品概觀";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(450, 176);
            this.dataGridView2.TabIndex = 46;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(510, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "unitprice";
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_unitprice.Location = new System.Drawing.Point(514, 219);
            this.txt_unitprice.Multiline = true;
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(321, 36);
            this.txt_unitprice.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(510, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "剩餘數量";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_quantity.Location = new System.Drawing.Point(514, 374);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(190, 37);
            this.txt_quantity.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(510, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 24);
            this.label10.TabIndex = 49;
            this.label10.Text = "style(color)";
            // 
            // txt_style
            // 
            this.txt_style.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_style.Location = new System.Drawing.Point(514, 90);
            this.txt_style.Multiline = true;
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(321, 44);
            this.txt_style.TabIndex = 48;
            // 
            // cmb_buy
            // 
            this.cmb_buy.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_buy.FormattingEnabled = true;
            this.cmb_buy.Location = new System.Drawing.Point(514, 499);
            this.cmb_buy.Name = "cmb_buy";
            this.cmb_buy.Size = new System.Drawing.Size(190, 32);
            this.cmb_buy.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(510, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "購買數量";
            // 
            // buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_buy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_style);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.picb_product);
            this.Controls.Add(this.label4);
            this.Name = "buyer";
            this.Text = "buyer";
            this.Load += new System.EventHandler(this.buyer_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buyer_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picb_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picb_product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.ComboBox cmb_buy;
        private System.Windows.Forms.Label label1;
    }
}