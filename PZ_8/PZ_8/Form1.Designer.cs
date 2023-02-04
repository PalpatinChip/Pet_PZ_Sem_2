namespace PZ_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.txtBoxM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matrix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreate.Location = new System.Drawing.Point(12, 236);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(282, 46);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Сгенерировать";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClear.Location = new System.Drawing.Point(12, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(282, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProceed.Location = new System.Drawing.Point(12, 340);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(282, 46);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Расчитать";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите m:";
            // 
            // txtBoxN
            // 
            this.txtBoxN.Location = new System.Drawing.Point(131, 28);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(114, 27);
            this.txtBoxN.TabIndex = 7;
            // 
            // txtBoxM
            // 
            this.txtBoxM.Location = new System.Drawing.Point(131, 97);
            this.txtBoxM.Name = "txtBoxM";
            this.txtBoxM.Size = new System.Drawing.Size(114, 27);
            this.txtBoxM.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(881, 42);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.Size = new System.Drawing.Size(89, 27);
            this.txtBoxResult.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 60);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сумма максимальных\r\nэлементов каждой \r\nстроки:";
            // 
            // matrix
            // 
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.ColumnHeadersVisible = false;
            this.matrix.Location = new System.Drawing.Point(300, 25);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersVisible = false;
            this.matrix.RowHeadersWidth = 51;
            this.matrix.RowTemplate.Height = 29;
            this.matrix.Size = new System.Drawing.Size(400, 400);
            this.matrix.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxM);
            this.Controls.Add(this.txtBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "PZ_8";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCreate;
        private Button btnClear;
        private Button btnProceed;
        private Label label1;
        private Label label2;
        private TextBox txtBoxN;
        private TextBox txtBoxM;
        private Label label3;
        private TextBox txtBoxResult;
        private Label label4;
        private DataGridView matrix;
    }
}